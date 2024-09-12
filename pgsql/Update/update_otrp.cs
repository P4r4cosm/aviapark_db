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

namespace pgsql.Update
{
    public partial class update_otrp : Form
    {
        private string conn;
        static NpgsqlConnection sqlConnection = new NpgsqlConnection();
        public update_otrp(string connection)
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
    ""Departure_time"" AS ""Время отправления"",
    ""Airline"" AS ""Авиакомпания"",
    ""Number"" AS ""Номер самолета"",
    ""Destination"" AS ""Пункт назначения""
FROM 
    ""Departing""
JOIN 
    ""Aviapark"" ON ""Departing"".id_airplane = ""Aviapark"".id;
";
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
                string time = selectedRow.Cells["Время отправления"].Value.ToString();
                string number = selectedRow.Cells["Номер самолета"].Value.ToString();
                string aviacompany = selectedRow.Cells["Авиакомпания"].Value.ToString();
                string place= selectedRow.Cells["Пункт назначения"].Value.ToString();
                update_otrp_place.Text = place;
                update_otrp_time.Text = time;
                update_otrp_num.Text = number;
                update_otrp_avia.Text = aviacompany;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentCell != null)
            {
                try
                {
                    int rowIndex = dataGridView1.CurrentCell.RowIndex;
                    DataGridViewRow selectedRow = dataGridView1.Rows[rowIndex];
                    string time = selectedRow.Cells["Время отправления"].Value.ToString();
                    string number = selectedRow.Cells["Номер самолета"].Value.ToString();
                    string aviacompany = selectedRow.Cells["Авиакомпания"].Value.ToString();
                    string place = selectedRow.Cells["Пункт назначения"].Value.ToString();
                    sqlConnection.Open();
                    NpgsqlCommand sqlCommand = new NpgsqlCommand();
                    sqlCommand.Connection = sqlConnection;
                    sqlCommand.CommandType = System.Data.CommandType.Text;
                    sqlCommand.CommandText = $@"SELECT edit_departing(
    (SELECT id FROM ""Departing""
     WHERE ""Departure_time"" = '{time}'
       AND ""Airline"" = '{aviacompany}'
       AND ""Destination"" = '{place}'
       AND ""id_airplane"" = (SELECT id FROM ""Aviapark""
                            WHERE ""Number"" = '{number}')),
    (SELECT id FROM ""Aviapark""
     WHERE ""Number"" = '{update_otrp_num.Text}'),
    '{update_otrp_time.Text}', 
    '{update_otrp_avia.Text}', 
    '{update_otrp_place.Text}'
)";
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
