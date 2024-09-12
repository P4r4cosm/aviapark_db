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
using static System.Windows.Forms.DataFormats;

namespace pgsql
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (login_address.Text==string.Empty || login_port.Text == string.Empty 
                || login_base.Text == string.Empty || login_name.Text == string.Empty
                || login_password.Text == string.Empty || login_port.Text == string.Empty)
            { 
                MessageBox.Show("Вы не заполнили поля");
            }
            else {
                string address = login_address.Text;
                string port = login_port.Text;
                string db = login_base.Text;
                string login = login_name.Text;
                string password = login_password.Text;
                string connection = $"Server={address};Port={port};Database={db};Username={login};Password={password};";
                NpgsqlConnection sqlConnection = new NpgsqlConnection(connection);
                try
                {

                    sqlConnection.Open();
                    NpgsqlCommand sqlCommand = new NpgsqlCommand();
                    sqlCommand.Connection = sqlConnection;

                    sqlConnection.Close();
                    Form1 newForm_1 = new Form1(connection);
                    newForm_1.Show();
                    this.Hide();
                    
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
