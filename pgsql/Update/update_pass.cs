using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace pgsql.Update
{
    public partial class update_pass : Form
    {
        private string conn;
        static NpgsqlConnection sqlConnection = new NpgsqlConnection();
        public update_pass(string connection)
        {
            InitializeComponent();
            conn = connection;
            sqlConnection = new NpgsqlConnection(conn);
            View_table();
        }
        public void View_table()
        {
            sqlConnection.Open();
            NpgsqlCommand sqlCommand = new NpgsqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandType = System.Data.CommandType.Text;
            sqlCommand.CommandText = $@"SELECT 
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
    ""Aviapark"" ON ""Passenger_traffic"".""id_airplane"" = ""Aviapark"".id;";
            NpgsqlDataReader dataReader = sqlCommand.ExecuteReader();
            if (dataReader.HasRows)
            {
                DataTable data = new DataTable();
                data.Load(dataReader);
                dataGridView1.DataSource = data;
            }
            sqlConnection.Close();
        } //отображаем таблицу
        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentCell != null)
            {
                int rowIndex = dataGridView1.CurrentCell.RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[rowIndex];
                string type = selectedRow.Cells["Тип рейса"].Value.ToString();
                string count = selectedRow.Cells["Количество пассажиров"].Value.ToString();
                string time = selectedRow.Cells["Время"].Value.ToString();
                string number = selectedRow.Cells["Номер самолёта"].Value.ToString();
                string aviacompany = selectedRow.Cells["Авиакомпания"].Value.ToString();
                string place = selectedRow.Cells["Пункт"].Value.ToString();
                update_pass_type.Text = type;
                update_pass_count.Text = count;
                update_pass_time.Text = time;
                update_pass_num.Text = number;
                update_pass_avia.Text = aviacompany;
                update_pass_place.Text = place;
                
            }
        }
        public string DoQuery(string query)
        {
            sqlConnection.Open();
            NpgsqlCommand sqlCommand = new NpgsqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandType = System.Data.CommandType.Text;
            sqlCommand.CommandText = query;
            NpgsqlDataReader dataReader = sqlCommand.ExecuteReader();
            
                dataReader.Read();
                var columnName = "id";
                var columnIndex = dataReader.GetOrdinal(columnName); // Получаем индекс столбца по имени
                var value = dataReader.GetValue(columnIndex); // Получаем значение по индексу столбца
            sqlConnection.Close();
            return value.ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentCell != null)
            {
                try
                {
                    int rowIndex = dataGridView1.CurrentCell.RowIndex;
                    DataGridViewRow selectedRow = dataGridView1.Rows[rowIndex];
                    string type = selectedRow.Cells["Тип рейса"].Value.ToString();
                    string count = selectedRow.Cells["Количество пассажиров"].Value.ToString();
                    string time = selectedRow.Cells["Время"].Value.ToString();
                    string number = selectedRow.Cells["Номер самолёта"].Value.ToString();
                    string aviacompany = selectedRow.Cells["Авиакомпания"].Value.ToString();
                    string place = selectedRow.Cells["Пункт"].Value.ToString();
                    string id_Arriving_flight = "NULL";
                    string id_Departing = "NULL";
                    string id_aviapark = "NULL";
                    id_aviapark = DoQuery($@" SELECT id
            FROM ""Aviapark""
            WHERE ""Number"" = '{number}'");
                    string id = string.Empty;
                    if (type == "прибывающий")
                    {
                        id_Arriving_flight = DoQuery($@"SELECT ""Passenger_traffic"".""id_Arriving_flight"" AS ""id""
                        FROM 
    ""Passenger_traffic""
LEFT JOIN 
    ""Arriving"" ON ""Passenger_traffic"".""id_Arriving_flight"" = ""Arriving"".id
JOIN 
    ""Aviapark"" ON ""Passenger_traffic"".""id_airplane"" = ""Aviapark"".id
WHERE ""Arriving"".""Arrival_time"" = TO_TIMESTAMP('{time}', 'MM/DD/YYYY HH12:MI:SS AM') AND ""Arriving"".""Point_of_departure"" = '{place}'
AND ""Aviapark"".""Number"" = '{number}';");
                        id = DoQuery($@"SELECT ""id"" FROM ""Passenger_traffic""
                WHERE ""Passenger_traffic"".""id_Arriving_flight""={id_Arriving_flight}
                AND ""Passenger_traffic"".""id_Departing"" is NULL
                AND ""Passenger_traffic"".""id_airplane""={id_aviapark}");
                    }
                    else
                    {
                        id_Departing = DoQuery($@"SELECT ""Passenger_traffic"".""id_Departing"" AS ""id""
                        FROM 
    ""Passenger_traffic""
LEFT JOIN 
    ""Departing"" ON ""Passenger_traffic"".""id_Departing"" = ""Departing"".id
JOIN 
    ""Aviapark"" ON ""Passenger_traffic"".""id_airplane"" = ""Aviapark"".id
WHERE ""Departing"".""Departure_time"" = TO_TIMESTAMP('{time}', 'MM/DD/YYYY HH12:MI:SS AM') AND ""Departing"".""Destination"" = '{place}'
AND ""Aviapark"".""Number"" = '{number}';");
                        id = DoQuery($@"SELECT ""id"" FROM ""Passenger_traffic""
                WHERE ""Passenger_traffic"".""id_Arriving_flight"" is NULL
                AND ""Passenger_traffic"".""id_Departing"" ={id_Departing}
                AND ""Passenger_traffic"".""id_airplane""={id_aviapark}");
                    }
                    sqlConnection.Open();
                    NpgsqlCommand sqlCommand = new NpgsqlCommand();
                    sqlCommand.Connection = sqlConnection;
                    sqlCommand.CommandType = System.Data.CommandType.Text;
                    sqlCommand.CommandText = $@"SELECT edit_passenger_traffic({id},'{type}',{id_Arriving_flight},
                {id_Departing},{id_aviapark},{update_pass_count.Text})";
                    NpgsqlDataReader dataReader = sqlCommand.ExecuteReader();
                    sqlConnection.Close();

                    // Обновить DataGridView после выполнения команды

                    View_table();
                }
                catch (Exception ex)
                {
                    sqlConnection.Close();
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите строку.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

