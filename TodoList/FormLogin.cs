using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace TodoList
{
    public partial class FormLogin : Form
    {
        private void Banco()
        {
            try
            {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                builder.DataSource = "<your_server>.database.windows.net";
                builder.UserID = "<your_username>";
                builder.Password = "<your_password>";
                builder.InitialCatalog = "<your_database>";

                using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                {
                    Console.WriteLine("\nQuery data example:");
                    Console.WriteLine("=========================================\n");

                    String sql = "SELECT name, collation_name FROM sys.databases";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Console.WriteLine("{0} {1}", reader.GetString(0), reader.GetString(1));
                            }
                        }
                    }
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.ToString());
            }
            Console.ReadLine();
        }
        public FormLogin()
        {
            Banco();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user_email = textBoxUserLogin.Text;
            string user_password = textBoxUserPassword.Text;

            if (user_email.Length == 0 && user_password.Length == 0)
            {
                MessageBox.Show("por favor digite suas credenciais");
                return;
            }

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            SqlDataReader sqlDataReader;

            //String de conexão
            SqlConnection sqlConnection = new SqlConnection();
            SqlCommand sqlCommand = new SqlCommand();

            sqlConnection.ConnectionString = "DATA SOURCE=.\\SQLSERVER; INITIAL CATALOG=todo; INTEGRATED SECURITY=TRUE";
            sqlConnection.Open();
            //Comando
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandType = CommandType.Text;

            sqlCommand.CommandText = $"select * from users where email='{user_email}'";
            sqlDataAdapter.SelectCommand = sqlCommand;

            // testando pegar valor pela variavel
            sqlDataReader = sqlCommand.ExecuteReader();
            sqlDataReader.Read();
            string db_user_id = sqlDataReader["id"].ToString();
            string db_user_password = sqlDataReader["password"].ToString();
            string db_user_email = sqlDataReader["email"].ToString();

            User.Id = db_user_id;
            User.Email = db_user_email;

            if (db_user_id == null || user_password != db_user_password)
            {
                MessageBox.Show("email ou senha inválida");
                return;
            }

            if (db_user_password == user_password)
            {
                TodoList formTodoList = new TodoList();
                formTodoList.Show();
                this.Hide();
            }
        }

        private void buttonLeave_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void linkCreateNewAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormRegister formRegister = new FormRegister();
            formRegister.Show();
            this.Hide();
        }
    }
}
