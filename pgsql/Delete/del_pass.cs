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
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.AxHost;

namespace pgsql.Delete
{
    public partial class del_pass : Form
    {
        private string conn;
        static NpgsqlConnection sqlConnection = new NpgsqlConnection();
        public del_pass(string connection)
        {
            InitializeComponent();
            conn = connection;
            sqlConnection = new NpgsqlConnection(conn);
            comboBox2.Items.AddRange(new string[] { "прибывающий", "отправляющийся" });
        }
        private void del_pass_Load(object sender, EventArgs e)
        {
            LoadAirplaneData();
        }
        private void LoadAirplaneData()
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
                        comboBox1.Items.Add(new KeyValuePair<int, string>((int)reader["id"], reader["Number"].ToString()));
                    }

                    comboBox1.DisplayMember = "Value";
                    comboBox1.ValueMember = "Key";
                    Connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (del_pass_date.Text == string.Empty || del_pass_place.Text == string.Empty
              || (comboBox1.SelectedItem == null) || (comboBox2.SelectedItem == null))
            {
                MessageBox.Show("Вы не ввели значение в текстовое поле");
            }
            else
            {
                try
                {
                    string type = comboBox2.SelectedItem.ToString();
                    string airplane = ((KeyValuePair<int, string>)comboBox1.SelectedItem).Value;
                    sqlConnection.Open();
                    NpgsqlCommand sqlCommand = new NpgsqlCommand();
                    sqlCommand.Connection = sqlConnection;
                    sqlCommand.CommandType = System.Data.CommandType.Text;
                    sqlCommand.Parameters.AddWithValue("@ТипРейса", type);
                    sqlCommand.Parameters.AddWithValue("@НомерСамолета", airplane);
                    sqlCommand.Parameters.AddWithValue("@Дата", del_pass_date.Text);
                    sqlCommand.Parameters.AddWithValue("@Место", del_pass_place.Text);
                    sqlCommand.CommandText = $@"SELECT delete_passenger_traffic(
    (SELECT id 
     FROM ""Passenger_traffic""
     WHERE ""Flight_type"" = 'прибывающий' 
       AND (""id_Arriving_flight"" = (
           SELECT id 
           FROM (
               SELECT id, ""Arrival_time"" AS ""Time"", ""Point_of_departure"" AS ""Place""
               FROM ""Arriving""
               UNION ALL
               SELECT id, ""Departure_time"" AS ""Time"", ""Destination"" AS ""Place""
               FROM ""Departing""
           ) AS subquery
           WHERE ""Time"" = TO_TIMESTAMP(@Дата, 'YYYY-MM-DD HH24:MI:SS')
             AND ""id_airplane"" = (
                 SELECT id 
                 FROM ""Aviapark""
                 WHERE ""Number"" = @НомерСамолета
             )
             AND ""Place"" = @Место)
       OR ""Flight_type"" = 'отправляющийся' 
       AND ""id_Departing"" = (
           SELECT id 
           FROM (
               SELECT id, ""Arrival_time"" AS ""Time"", ""Point_of_departure"" AS ""Place""
               FROM ""Arriving""
               UNION ALL
               SELECT id, ""Departure_time"" AS ""Time"", ""Destination"" AS ""Place""
               FROM ""Departing""
           ) AS subquery
           WHERE ""Time"" = TO_TIMESTAMP(@Дата, 'YYYY-MM-DD HH24:MI:SS')
             AND ""id_airplane"" = (
                 SELECT id 
                 FROM ""Aviapark""
                 WHERE ""Number"" = @НомерСамолета
             )
             AND ""Place"" = @Место)
       )
    )
);";
                    NpgsqlDataReader dataReader = sqlCommand.ExecuteReader();
                    sqlConnection.Close();
                }
                catch (Exception ex)
                {
                    sqlConnection.Close();
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
