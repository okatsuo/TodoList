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
    public partial class AdicionarTodo : Form
    {
        public AdicionarTodo()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ButtonSaveNewTodo_Click(object sender, EventArgs e)
        {
            try
            {
                string todoName = textBoxAddNameTodo.Text;
                string todoDescription = textBoxAddDescriptionTodo.Text;
                int isActive = 1;

                Banco banco = new Banco();
                banco.execMutation($"insert into to_do(name, description, status, userId) values ('{todoName}', '{todoDescription}', '{isActive}', '{User.Id}');");
                MessageBox.Show($"tarefa {todoName.ToUpper()} cadastrada com sucesso!");
                Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show("Error ao cadastrar a tarefa.. \n\n Error:  " + error);
            }
        }

        private void ButtonCancelar_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void AdicionarTodo_FormClosed(object sender, FormClosedEventArgs e)
        {
        }
    }
}
