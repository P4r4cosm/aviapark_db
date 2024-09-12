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

namespace pgsql.Delete
{
    public partial class del_prib : Form
    {
        private string conn;
        static NpgsqlConnection sqlConnection = new NpgsqlConnection();
        public del_prib(string connection)
        {
            InitializeComponent();
            conn = connection;
            sqlConnection = new NpgsqlConnection(conn);
        }
        private void del_otpr_Load(object sender, EventArgs e)
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
            if (del_prib_date.Text == string.Empty || del_prib_place.Text == string.Empty
               || (comboBox1.SelectedItem == null))
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
                    sqlCommand.CommandText = $@"
            SELECT delete_arriving((SELECT id FROM ""Arriving""
            WHERE ""id_airplane"" = (
            SELECT id
            FROM ""Aviapark""
             WHERE ""Number"" = '{((KeyValuePair<int, string>)comboBox1.SelectedItem).Value}'
                AND ""Point_of_departure""='{del_prib_place.Text}'
                AND ""Arrival_time"" = '{del_prib_date.Text}')));";
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

