using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace TodoList
{
    public partial class FormDeleteTodo : Form
    {
        public FormDeleteTodo()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteTodo_Click(object sender, EventArgs e)
        {
            try
            {
                string id_to_delete = textBoxDeleteTodoId.Text;

                SqlConnection sqlConnection = new SqlConnection();
                SqlCommand sqlCommand = new SqlCommand();
                sqlConnection.ConnectionString = "DATA SOURCE=.\\SQLSERVER; INITIAL CATALOG=todo; INTEGRATED SECURITY=TRUE";
                sqlConnection.Open();

                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandType = CommandType.Text;
                // update to_do set name = 'Estudar POO', description = 'dale' where id = 3;
                sqlCommand.CommandText = "delete to_do where id = " + id_to_delete;
                sqlCommand.ExecuteNonQuery();

                sqlConnection.Close();

                Close();
            }
            catch (SqlException sqlError)
            {
                MessageBox.Show("Error:" + sqlError);
            }
        }
    }
}
