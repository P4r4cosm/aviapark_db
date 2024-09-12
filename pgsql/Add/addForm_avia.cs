using Microsoft.EntityFrameworkCore.Metadata.Internal;
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
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace pgsql
{
    public partial class addForm_avia : Form
    {
        private string conn;
        private Form1 _form1;
        static NpgsqlConnection sqlConnection = new NpgsqlConnection();
        public addForm_avia(string connection, Form1 form1)
        {
            InitializeComponent();
            conn = connection;
            sqlConnection = new NpgsqlConnection(conn);
            _form1 = form1;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (model.Text == string.Empty || tailNumber.Text == string.Empty
               || capacity.Text == string.Empty)
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
                    sqlCommand.CommandText = $@"SELECT add_aviapark ('{model.Text}', '{tailNumber.Text}',  {capacity.Text});";
                    NpgsqlDataReader dataReader = sqlCommand.ExecuteReader();
                    sqlConnection.Close();
                    _form1.LoadAirplaneData();
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
