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
    public partial class FormUpdateTodo : Form
    {
        public FormUpdateTodo()
        {
            InitializeComponent();
        }

        public string propriedadeIdTodo { get; set; }
        public string propriedadeNameTodo { get; set; }
        public string propriedadeDescricaoTodo { get; set; }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void ButtonSaveNewTodo_Click(object sender, EventArgs e)
        {
            try
            {
                string todo_name_to_update = textBoxUpdateNameTodo.Text;
                string todo_description_to_update = textBoxUpdateDescriptionTodo.Text;

                Banco banco = new Banco();
                banco.execMutation("update to_do set name = '" + todo_name_to_update + "', description = '" + todo_description_to_update + "' where id = " + this.propriedadeIdTodo);

                MessageBox.Show("Atualizado com sucesso!");
                Close();

            }
            catch (SqlException sqlError)
            {
                MessageBox.Show("Error:" + sqlError);
            }
        }

        private void ButtonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormUpdateTodo_Load(object sender, EventArgs e)
        {
            if (!this.propriedadeIdTodo.Equals(""))
            {
                labelUpdateTodoName.Text = this.propriedadeNameTodo;
                textBoxUpdateNameTodo.Text = this.propriedadeNameTodo;
                textBoxUpdateDescriptionTodo.Text = this.propriedadeDescricaoTodo;
            }
        }
    }
}
