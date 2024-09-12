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

namespace pgsql.Update
{
    public partial class update_prib : Form
    {

        private string conn;
        static NpgsqlConnection sqlConnection = new NpgsqlConnection();
        public update_prib(string connection)
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
    ""Arrival_time"" AS ""Время прибытия"",
    ""Airline"" AS ""Авиакомпания"",
    ""Number"" AS ""Номер самолёта"",
    ""Point_of_departure"" AS ""Пункт отправления""
FROM 
    ""Arriving""
JOIN 
    ""Aviapark"" ON ""Arriving"".id_airplane = ""Aviapark"".id;
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
                string time = selectedRow.Cells["Время прибытия"].Value.ToString();
                string number = selectedRow.Cells["Номер самолёта"].Value.ToString();
                string aviacompany = selectedRow.Cells["Авиакомпания"].Value.ToString();
                string place = selectedRow.Cells["Пункт отправления"].Value.ToString();
                update_prib_place.Text = place;
                update_prib_time.Text = time;
                update_prib_num.Text = number;
                update_prib_avia.Text = aviacompany;
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
                    string time = selectedRow.Cells["Время прибытия"].Value.ToString();
                    string number = selectedRow.Cells["Номер самолёта"].Value.ToString();
                    string aviacompany = selectedRow.Cells["Авиакомпания"].Value.ToString();
                    string place = selectedRow.Cells["Пункт отправления"].Value.ToString();
                    sqlConnection.Open();
                    NpgsqlCommand sqlCommand = new NpgsqlCommand();
                    sqlCommand.Connection = sqlConnection;
                    sqlCommand.CommandType = System.Data.CommandType.Text;
                    sqlCommand.CommandText = $@"SELECT edit_arriving(
    (SELECT id FROM ""Arriving""
     WHERE ""Arrival_time"" = '{time}'
       AND ""Airline"" = '{aviacompany}'
       AND ""Point_of_departure"" = '{place}'
       AND ""id_airplane"" = (SELECT id FROM ""Aviapark""
                            WHERE ""Number"" = '{number}')),
    '{update_prib_time.Text}', 
    '{update_prib_avia.Text}', 
(SELECT id FROM ""Aviapark""
     WHERE ""Number"" = '{update_prib_num.Text}'),
    '{update_prib_place.Text}'
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
