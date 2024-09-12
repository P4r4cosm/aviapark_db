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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace pgsql.Update
{
    public partial class update_avia : Form
    {
        private string conn;
        static NpgsqlConnection sqlConnection = new NpgsqlConnection();
        public update_avia(string connection)
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
            sqlCommand.CommandText = "SELECT \"Model\", \"Number\", \"Capacity\" FROM \"Aviapark\"";
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
                string model = selectedRow.Cells["Model"].Value.ToString();
                string number = selectedRow.Cells["Number"].Value.ToString();
                string capacity = selectedRow.Cells["Capacity"].Value.ToString();
                update_avia_model.Text = model;
                update_avia_num.Text = number;
                update_avia_cap.Text = capacity;
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
                    string model = selectedRow.Cells["Model"].Value.ToString();
                    string number = selectedRow.Cells["Number"].Value.ToString();
                    string capacity = selectedRow.Cells["Capacity"].Value.ToString();
                    sqlConnection.Open();
                    NpgsqlCommand sqlCommand = new NpgsqlCommand();
                    sqlCommand.Connection = sqlConnection;
                    sqlCommand.CommandType = System.Data.CommandType.Text;
                    sqlCommand.CommandText = $@"SELECT edit_aviapark((SELECT ""id"" FROM ""Aviapark"" WHERE ""Model""='{model}'
                AND ""Number""='{number}'), '{update_avia_model.Text}', '{update_avia_num.Text}', {update_avia_cap.Text})";
                    NpgsqlDataReader dataReader = sqlCommand.ExecuteReader();
                    sqlConnection.Close();
                    // Обновить DataGridView после выполнения команды
                    View_table();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                sqlConnection.Close();
                MessageBox.Show("Пожалуйста, выберите строку.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }        
    }
}
