using Microsoft.EntityFrameworkCore;
using Npgsql.EntityFrameworkCore.PostgreSQL;
using Npgsql;
using System.Xml;
using System.Data;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using pgsql.Add;
using pgsql.Delete;
using pgsql.Update;
namespace pgsql
{

    public partial class Form1 : Form
    {
        private string conn;
        static NpgsqlConnection sqlConnection = new NpgsqlConnection();
        public Form1(string connection)
        {
            InitializeComponent();
            conn = connection;
            sqlConnection = new NpgsqlConnection(conn);
            comboBox1.Items.AddRange(new string[] { "Вывести таблицу авиапарка", "Вывести таблицу прибывающих рейсов",
                "Вывести таблицу вылетов рейсов", "Вывести таблицу пассажиропотока" });
            comboBox2.Items.AddRange(new string[] { "Авиапарк", "Прибывающие",
                "Отправляющиеся", "Пассажиропоток" });
            comboBox3.Items.AddRange(new string[] { "Авиапарк", "Прибывающие",
                "Отправляющиеся", "Пассажиропоток" });
            comboBox4.Items.AddRange(new string[] { "Авиапарк", "Прибывающие",
                "Отправляющиеся", "Пассажиропоток" });
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
        }

        public void DoQuery(string query)
        {
            try
            {
                sqlConnection.Open();
                NpgsqlCommand sqlCommand = new NpgsqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandType = System.Data.CommandType.Text;
                sqlCommand.CommandText = query;
                NpgsqlDataReader dataReader = sqlCommand.ExecuteReader();
                if (dataReader.HasRows)
                {
                    DataTable data = new DataTable();
                    data.Load(dataReader);
                    dataGridView1.DataSource = data;
                }
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                sqlConnection.Close();
                MessageBox.Show(ex.Message);
            }
        }
        public void LoadAirplaneData()
        {
            using (NpgsqlConnection Connection = new NpgsqlConnection(conn))
            {
                string query = $@"SELECT id, ""Number"" FROM ""Aviapark"";";
                NpgsqlCommand command = new NpgsqlCommand(query, Connection);
                try
                {
                    Connection.Open();
                    NpgsqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        airplaneBox.Items.Add(new KeyValuePair<int, string>((int)reader["id"], reader["Number"].ToString()));
                    }

                    airplaneBox.DisplayMember = "Value";
                    airplaneBox.ValueMember = "Key";
                    Connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadAirplaneData();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            DoQuery(@$"SELECT
    p.""Flight_type"",
    p.""Number_of_passengers"",
    a.""Model"" AS ""Airline Model"",
    CASE
        WHEN a.""Capacity"" <= 20 THEN 'Малая авиация'
        WHEN a.""Capacity"" <= 150 THEN 'Среднемагистральная авиация'
        ELSE 'Дальнемагистральная авиация'
    END AS ""Aircraft_class"",
    a.""Number"" AS ""Airline_number"",
    coalesce(o.""Airline"", arr.""Airline"") AS ""Airplane_airline"",
    coalesce(o.""Departure_time"", arr.""Arrival_time"") AS ""Time"",
    coalesce(o.""Destination"", arr.""Point_of_departure"") AS ""Place""
FROM
    ""Passenger_traffic"" p
    LEFT JOIN ""Aviapark"" a ON p.""id_airplane"" = a.id
    LEFT JOIN ""Departing"" o ON p.""id_Departing"" = o.id
    LEFT JOIN ""Arriving"" arr ON p.""id_Arriving_flight"" = arr.id;
");
        } //case

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedState = comboBox1.SelectedItem.ToString();
            switch (selectedState)
            {
                case "Вывести таблицу авиапарка":
                    DoQuery(@$"SELECT ""Model"", ""Number"", ""Capacity"" FROM ""Aviapark"";");
                    break;
                case "Вывести таблицу прибывающих рейсов":
                    DoQuery($@"SELECT 
    ""Arrival_time"" AS ""Время прибытия"",
    ""Airline"" AS ""Авиакомпания"",
    ""Number"" AS ""Номер самолёта"",
    ""Point_of_departure"" AS ""Пункт отправления""
FROM 
    ""Arriving""
JOIN 
    ""Aviapark"" ON ""Arriving"".id_airplane = ""Aviapark"".id;
");
                    break;
                case "Вывести таблицу вылетов рейсов":
                    DoQuery($@"SELECT 
    ""Departure_time"" AS ""Время отправления"",
    ""Airline"" AS ""Авиакомпания"",
    ""Number"" AS ""Номер самолета"",
    ""Destination"" AS ""Пункт назначения""
FROM 
    ""Departing""
JOIN 
    ""Aviapark"" ON ""Departing"".id_airplane = ""Aviapark"".id;
");
                    break;
                case "Вывести таблицу пассажиропотока":
                    DoQuery($@"SELECT 
    ""Passenger_traffic"".""Flight_type"" AS ""Тип рейса"",
    CASE 
        WHEN ""Passenger_traffic"".""Flight_type"" = 'прибывающий' THEN ""Arriving"".""Arrival_time""
        ELSE ""Departing"".""Departure_time""
    END AS ""Время"",
    CASE 
        WHEN ""Passenger_traffic"".""Flight_type"" = 'прибывающий' THEN ""Arriving"".""Airline""
        ELSE ""Departing"".""Airline""
    END AS ""Авиакомпания"",
    CASE 
        WHEN ""Passenger_traffic"".""Flight_type"" = 'прибывающий' THEN ""Arriving"".""Point_of_departure""
        ELSE ""Departing"".""Destination""
    END AS ""Пункт"",
    ""Aviapark"".""Number"" AS ""Номер самолёта"",
    ""Passenger_traffic"".""Number_of_passengers"" AS ""Количество пассажиров""
FROM 
    ""Passenger_traffic""
LEFT JOIN 
    ""Arriving"" ON ""Passenger_traffic"".""id_Arriving_flight"" = ""Arriving"".id
LEFT JOIN 
    ""Departing"" ON ""Passenger_traffic"".""id_Departing"" = ""Departing"".id
JOIN 
    ""Aviapark"" ON ""Passenger_traffic"".""id_airplane"" = ""Aviapark"".id;");
                    break;
            }
        }//вывод таблиц
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedState = comboBox2.SelectedItem.ToString();
            switch (selectedState)
            {
                case "Авиапарк":
                    addForm_avia newForm_1 = new addForm_avia(conn, this);
                    newForm_1.Show();
                    break;
                case "Прибывающие":
                    add_prib newForm_2 = new add_prib(conn);
                    newForm_2.Show();
                    break;
                case "Отправляющиеся":
                    add_otrp newForm_3 = new add_otrp(conn);
                    newForm_3.Show();
                    break;
                case "Пассажиропоток":
                    add_pass newForm_4 = new add_pass(conn);
                    newForm_4.Show();
                    break;


            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedState = comboBox3.SelectedItem.ToString();
            switch (selectedState)
            {
                case "Авиапарк":
                    Del_avia newForm_5 = new Del_avia(conn);
                    newForm_5.Show();
                    break;
                case "Прибывающие":
                    del_prib newForm_6 = new del_prib(conn);
                    newForm_6.Show();
                    break;
                case "Отправляющиеся":
                    del_otpr newForm_7 = new del_otpr(conn);
                    newForm_7.Show();
                    break;
                case "Пассажиропоток":
                    del_pass newForm_8 = new del_pass(conn);
                    newForm_8.Show();
                    break;
            }
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedState = comboBox4.SelectedItem.ToString();
            switch (selectedState)
            {
                case "Авиапарк":
                    update_avia newForm_9 = new update_avia(conn);
                    newForm_9.Show();
                    break;
                case "Прибывающие":
                    update_prib newForm_10 = new update_prib(conn);
                    newForm_10.Show();
                    break;
                case "Отправляющиеся":
                    update_otrp newForm_11 = new update_otrp(conn);
                    newForm_11.Show();
                    break;
                case "Пассажиропоток":
                    update_pass newForm_12 = new update_pass(conn);
                    newForm_12.Show();
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e) //АнализЗагруженностиРейсов
        {
            DoQuery(@$"SELECT 
    ""Flight_Load_Analysis"".""Flight_type"",
    ""Aviapark"".""Number"" AS ""Airplane_number"",
    ""Flight_Load_Analysis"".""Airplane model"",
    ""Flight_Load_Analysis"".""Time"",
    ""Flight_Load_Analysis"".""Airline"",
    ""Flight_Load_Analysis"".""Place"",
    ""Flight_Load_Analysis"".""Number_of_passengers"",
    ""Flight_Load_Analysis"".""Capacity"",
    ""Flight_Load_Analysis"".""Load_(%)""
FROM 
    ""Flight_Load_Analysis"" 
JOIN 
    ""Aviapark"" ON ""Flight_Load_Analysis"".""id_airplane"" = ""Aviapark"".""id"";
");
        }

        private void button2_Click(object sender, EventArgs e) //СуммарныйПассажиропотокПоАвиакомпании
        {
            DoQuery(@$"REFRESH MATERIALIZED VIEW public.""Total_Passenger_Flow"";
                SELECT * FROM ""Total_Passenger_Flow""");
        }

        private void button3_Click(object sender, EventArgs e) //среднее кол-во пассажиров (задание d подзапрос в SELECT)
        {
            DoQuery(@$"SELECT
    ""Airline"",
    (SELECT AVG(""Number_of_passengers"") 
     FROM ""Flight_Load_Analysis"" 
     WHERE ""Airline"" = a.""Airline"") AS ""Average_passengers_per_flight"",
    (SELECT AVG(""Number_of_passengers"") 
     FROM ""Flight_Load_Analysis"") AS ""Average_passengers_across_all_flights""
FROM
    (SELECT DISTINCT ""Airline"" 
     FROM ""Flight_Load_Analysis"") AS a;
");
        }

        private void button5_Click(object sender, EventArgs e)//кол-во рейсов у каждой авиакомпании(задание d подзапрос в FROM)
        {
            DoQuery($@"SELECT 
    a.""Airline"",
    COUNT(*) AS ""Number_of_flights""
FROM 
    (SELECT DISTINCT ""Airline"" 
     FROM ""Flight_Load_Analysis"") AS a 
JOIN
    ""Flight_Load_Analysis"" AS b 
ON 
    a.""Airline"" = b.""Airline"" 
JOIN 
    ""Aviapark"" AS c 
ON 
    b.""id_airplane"" = c.""id""
GROUP BY 
    a.""Airline"";");
        }

        private void airplaneBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            DoQuery($@"
            SELECT
             b.""Flight_type"",
             b.""Number_of_passengers"",
            c.""Number"",
            b.""Airplane model"",
            b.""Capacity"",
            b.""Load_(%)"",
            b.""Airline"",
            b.""Time"",
            b.""Place""
            
            FROM
            ""Flight_Load_Analysis"" AS b
            JOIN
                ""Aviapark"" AS c ON b.""id_airplane"" = c.""id""
            WHERE
            c.""Number"" = '{((KeyValuePair<int, string>)airplaneBox.SelectedItem).Value}';
                ");
        }//выводим рейсы конкретного самолёта

        private void button6_Click(object sender, EventArgs e)//вывод рейсов с кол-вом пассажиров больше/=введённого(задание d подзапрос в WHERE) 
        {
            if (textBox1.Text == string.Empty)
            {
                MessageBox.Show("Вы не ввели значение в текстовое поле");
            }
            else
            {
                DoQuery($@"SELECT
    a.""Number"",
    o.""Time"",
    o.""Airline"",
    o.""Place"",
    o.""Flight_type"",
    o.""Airplane model"",
    o.""Capacity"",
    o.""Load_(%)"",
    o.""Number_of_passengers""
FROM
    ""Flight_Load_Analysis"" AS o
JOIN
    ""Aviapark"" AS a ON o.""id_airplane"" = a.id
WHERE
    o.""Airline"" IN (
        SELECT DISTINCT
            o_sub.""Airline""
        FROM
            public.""Flight_Load_Analysis"" AS o_sub
        JOIN
            public.""Passenger_traffic"" AS p ON o_sub.""id_passenger_traffic"" = p.id
        WHERE
            p.""Number_of_passengers"" >= {textBox1.Text});
");
            }
        }

        private void button7_Click(object sender, EventArgs e)//Выбор рейсов с информацией о средней загрузке самолёта (задание e)
        {
            DoQuery($@"SELECT
    ar.""Airline"",
    ar.""Airplane model"",
    a.""Number"",
    ar.""Number_of_passengers"",
    ar.""Load_(%)"",
    ar.""Place"",
    (SELECT AVG(ar_sub.""Load_(%)"")
     FROM public.""Flight_Load_Analysis"" ar_sub
     WHERE ar_sub.""id_airplane"" = ar.""id_airplane""
     GROUP BY ar_sub.""id_airplane"") AS ""Average_load_(%)""
FROM
    public.""Flight_Load_Analysis"" ar
JOIN
    public.""Aviapark"" a ON ar.""id_airplane"" = a.id
ORDER BY
    ar.""Airline"", ar.""Airplane model"" LIMIT 100;");
        }

        private void button8_Click(object sender, EventArgs e)//Загрузка самолётов выше средней (задание e)
        {
            DoQuery($@"SELECT
    ar.""Airline"",
    ar.""Airplane model"",
    a.""Number"" AS ""Airplane_number"",
    ar.""Number_of_passengers"",
    ar.""Load_(%)"",
    ar.""Place"",
    (SELECT AVG(ar_sub.""Load_(%)"")
     FROM public.""Flight_Load_Analysis"" ar_sub) AS ""Average_load_across_all_airplanes""
FROM
    public.""Flight_Load_Analysis"" ar
JOIN
    public.""Aviapark"" a ON ar.""id_airplane"" = a.id
WHERE
    ar.""Load_(%)"" > 
    (SELECT AVG(ar_sub.""Load_(%)"")
     FROM public.""Flight_Load_Analysis"" ar_sub)
ORDER BY
    ar.""Airline"", ar.""Airplane model"";");
        }

        private void button9_Click(object sender, EventArgs e)// среднее количество пассажиров на рейс в каждый день недели (задание e)
        {
            DoQuery(@$"SELECT 
    to_char(""Arrival_time"", 'D') AS day_of_week,
    AVG(""Number_of_passengers"") AS avg_passengers_per_flight
FROM 
    public.""Passenger_traffic"" pt
JOIN 
    public.""Arriving"" a ON pt.""id_Arriving_flight"" = a.id
GROUP BY 
    day_of_week
ORDER BY 
    day_of_week;");
        }

        private void button10_Click(object sender, EventArgs e)//Вывести компании у которых кол-во рейсов не меньше значения (задания f)
        {
            if (textBox2.Text == string.Empty)
            {
                MessageBox.Show("Вы не ввели значение в текстовое поле");
            }
            else
            {
                DoQuery($@"SELECT
    ""Airline"",
    COUNT(""id_passenger_traffic"") AS ""Total_flights"",
    string_agg(DISTINCT ""Number"", ', ') AS ""Airplane_numbers"",
    string_agg(DISTINCT ""Model"", ', ') AS ""Airplane_models""
FROM
    ""Flight_Load_Analysis""
LEFT JOIN
    ""Aviapark"" ON ""Flight_Load_Analysis"".""id_airplane"" = ""Aviapark"".""id""
GROUP BY
    ""Airline""
HAVING
    COUNT(""id_passenger_traffic"") > '{textBox2.Text}';

");
            }
        }

        private void button11_Click(object sender, EventArgs e)//Рейсы, для которых количество пассажиров больше, чем для любого рейса авиакомпании ANY 
        {
            if (textBox3.Text == string.Empty)
            {
                MessageBox.Show("Вы не ввели значение в текстовое поле");
            }
            else
            {
                DoQuery(@$"SELECT
    ""Flight_type"",
    ""Number_of_passengers"",
    ""Airplane model"",
    ""Number"" AS ""Airplane_number"",
    ""Flight_Load_Analysis"".""Capacity"",
    ""Load_(%)"",
    ""Airline"",
    ""Time"",
    ""Place""
FROM
    ""Flight_Load_Analysis""
JOIN
    ""Aviapark"" ON ""Flight_Load_Analysis"".""id_airplane"" = ""Aviapark"".id
WHERE
    ""Number_of_passengers"" > ANY (
        SELECT ""Number_of_passengers""
        FROM ""Flight_Load_Analysis""
        WHERE ""Airline"" = '{textBox3.Text}'
    );
");
            }
        }

        private void button12_Click(object sender, EventArgs e)//Рейсы, у которых количество пассажиров меньше, чем для всех рейсов авиакомпании ALL
        {
            if (textBox4.Text == string.Empty)
            {
                MessageBox.Show("Вы не ввели значение в текстовое поле");
            }
            else
            {
                DoQuery(@$"SELECT
    ""Flight_type"",
    ""Number_of_passengers"",
    ""Airplane model"",
    ""Number"" AS ""Airplane_number"",
    ""Flight_Load_Analysis"".""Capacity"",
    ""Load_(%)"",
    ""Airline"",
    ""Time"",
    ""Place""
FROM
    ""Flight_Load_Analysis""
JOIN
    ""Aviapark"" ON ""Flight_Load_Analysis"".""id_airplane"" = ""Aviapark"".id
WHERE
    ""Number_of_passengers"" < ALL (
        SELECT ""Number_of_passengers""
        FROM ""Flight_Load_Analysis""
        WHERE ""Airline"" = '{textBox4.Text}'
    );
");
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (textBox5.Text == string.Empty)
            {
                MessageBox.Show("Вы не ввели значение в текстовое поле");
            }
            else
            {
                DoQuery(@$"SELECT 
    ""Flight_type"",
    ""Number_of_passengers"",
    a.""Number"" AS ""Airplane_number"",
    a.""Model"" AS ""Airplane_model"",
    ar.""Capacity"",
    ""Load_(%)"",
    ""Airline"",
    ""Time"",
    ""Place""
FROM 
    public.""Flight_Load_Analysis"" ar
JOIN 
    public.""Aviapark"" a ON ar.""id_airplane"" = a.id
WHERE 
    DATE(""Time"") = '{textBox5.Text}';");

            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (textBox6.Text == string.Empty)
            {
                MessageBox.Show("Вы не ввели значение в текстовое поле");
            }
            else
            {
                DoQuery(@$"SELECT 
    ""Flight_type"",
    ""Number_of_passengers"",
    a.""Number"" AS ""Airplane_number"",
    a.""Model"" AS ""Airplane_model"",
    ar.""Capacity"",
    ""Load_(%)"",
    ""Airline"",
    ""Time"",
    ""Place""
FROM 
    public.""Flight_Load_Analysis"" ar
JOIN 
    public.""Aviapark"" a ON ar.""id_airplane"" = a.id
WHERE 
    ""Flight_type"" = 'прибывающий' 
    AND ""Place"" = '{textBox6.Text}';
");

            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (textBox7.Text == string.Empty)
            {
                MessageBox.Show("Вы не ввели значение в текстовое поле");
            }
            else
            {
                DoQuery(@$"SELECT 
    ""Flight_type"",
    ""Number_of_passengers"",
    a.""Number"" AS ""Airplane_number"",
    a.""Model"" AS ""Airplane_model"",
    ar.""Capacity"",
    ""Load_(%)"",
    ""Airline"",
    ""Time"",
    ""Place""
FROM 
    public.""Flight_Load_Analysis"" ar
JOIN 
    public.""Aviapark"" a ON ar.""id_airplane"" = a.id
WHERE 
    ""Flight_type"" = 'отправляющийся' 
    AND ""Place"" = '{textBox7.Text}'; -- Замените 'Ваш город' на нужный вам город");

            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }

}



