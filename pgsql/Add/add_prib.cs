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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace pgsql.Add
{
    public partial class add_prib : Form
    {
        private string conn;
        static NpgsqlConnection sqlConnection = new NpgsqlConnection();
        public add_prib(string connection)
        {
            InitializeComponent();
            conn = connection;
            sqlConnection = new NpgsqlConnection(conn);
        }
        private void add_prib_Load(object sender, EventArgs e)
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
                        comboBoxAirplane.Items.Add(new KeyValuePair<int, string>((int)reader["id"], reader["Number"].ToString()));
                    }

                    comboBoxAirplane.DisplayMember = "Value";
                    comboBoxAirplane.ValueMember = "Key";
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
            if (add_prib_avia.Text == string.Empty || add_prib_place.Text == string.Empty
                || Date.Text == string.Empty ||
                (comboBoxAirplane.SelectedItem == null))
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
                    sqlCommand.CommandText = $@"SELECT add_arriving('{Date.Text}',  '{add_prib_avia.Text}', '{((KeyValuePair<int, string>)comboBoxAirplane.SelectedItem).Key}','{add_prib_place.Text}');";
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
