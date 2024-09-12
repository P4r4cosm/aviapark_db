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

namespace pgsql.Delete
{
    public partial class Del_avia : Form
    {
        private string conn;
        static NpgsqlConnection sqlConnection = new NpgsqlConnection();
        public Del_avia(string connection)
        {
            InitializeComponent();
            conn = connection;
            sqlConnection = new NpgsqlConnection(conn);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (del_avia_cap.Text == string.Empty || del_avia_model.Text == string.Empty
               || del_avia_num.Text == string.Empty)
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
                    sqlCommand.CommandText = $@"SELECT delete_aviapark((SELECT id FROM ""Aviapark""
                WHERE ""Model"" = '{del_avia_model.Text}'
                AND ""Number"" = '{del_avia_num.Text}'
                AND ""Capacity"" ={del_avia_cap.Text}))";
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
