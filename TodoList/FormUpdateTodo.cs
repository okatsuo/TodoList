using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TodoList
{
    public partial class FormUpdateTodo : Form
    {
        public FormUpdateTodo()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void ButtonSaveNewTodo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Atualizado com sucesso!");
            Close();
        }

        private void ButtonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormUpdateTodo_Load(object sender, EventArgs e)
        {

        }
    }
}
