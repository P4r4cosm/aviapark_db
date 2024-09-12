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
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace pgsql.Add
{
    public partial class add_pass : Form
    {
        private string conn;
        static NpgsqlConnection sqlConnection = new NpgsqlConnection();
        public add_pass(string connection)
        {
            InitializeComponent();
            comboBox1.Items.AddRange(new string[] { "прибывающий" , "отправляющийся"});
            conn = connection;
            sqlConnection = new NpgsqlConnection(conn);
        }
        private void add_pass_Load(object sender, EventArgs e)
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
                        comboBox2.Items.Add(new KeyValuePair<int, string>((int)reader["id"], reader["Number"].ToString()));
                    }

                    comboBox2.DisplayMember = "Value";
                    comboBox2.ValueMember = "Key";
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
            if (add_pass_count.Text == string.Empty || add_pass_place.Text == string.Empty
               || add_pass_time.Text == string.Empty ||
               (comboBox1.SelectedItem == null)||comboBox2.SelectedIndex==null)
            {
                MessageBox.Show("Вы не ввели значение в текстовое поле");
            }
            else
            {
                try
                {
                    sqlConnection.Open();
                    string type = comboBox1.SelectedItem.ToString();
                    int airplane = ((KeyValuePair<int, string>)comboBox2.SelectedItem).Key;

                    NpgsqlCommand sqlCommand = new NpgsqlCommand();
                    sqlCommand.Connection = sqlConnection;
                    sqlCommand.CommandType = System.Data.CommandType.Text;
                    sqlCommand.CommandText = $@"
          SELECT add_passenger_traffic ('{type}', 
        CASE WHEN '{type}' = 'прибывающий' THEN (SELECT id FROM ""Arriving"" WHERE ""Arrival_time"" = '{add_pass_time.Text}' AND id_airplane = {airplane} AND ""Point_of_departure"" = '{add_pass_place.Text}') 
             ELSE NULL END,
        CASE WHEN '{type}' = 'отправляющийся' THEN (SELECT id FROM ""Departing"" WHERE ""Departure_time"" = '{add_pass_time.Text}' AND id_airplane = {airplane} AND ""Destination"" = '{add_pass_place.Text}') 
             ELSE NULL END,
        {airplane}, 
        {add_pass_count.Text})";
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
