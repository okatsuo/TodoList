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

                Banco banco = new Banco();
                banco.execMutation("delete to_do where id = " + id_to_delete);
                Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show("Error:" + error);
            }
        }
    }
}
