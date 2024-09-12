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
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace pgsql.Add
{

    public partial class add_otrp : Form
    {
        private string conn;
        static NpgsqlConnection sqlConnection = new NpgsqlConnection();
        public add_otrp(string connection)
        {
            InitializeComponent();
            conn = connection;
            sqlConnection = new NpgsqlConnection(conn);
        }
        private void add_otrp_Load(object sender, EventArgs e)
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
           
            if (add_otrp_avia.Text == string.Empty || add_otrp_place.Text == string.Empty
                || add_otrp_time.Text == string.Empty ||
                (comboBox1.SelectedItem==null))
            {
                MessageBox.Show("Вы не ввели значение в текстовое поле");
            }
            else
            {
                try
                {
                    sqlConnection.Open();
                    NpgsqlCommand sqlCommand = new NpgsqlCommand();
                    sqlCommand.Connection = sqlConnection;
                    sqlCommand.CommandType = System.Data.CommandType.Text;
                    sqlCommand.CommandText = $@"SELECT add_departing ('{((KeyValuePair<int, string>)comboBox1.SelectedItem).Key}','{add_otrp_time.Text}',  '{add_otrp_avia.Text}', '{add_otrp_place.Text}');";
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
