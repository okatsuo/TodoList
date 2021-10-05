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
    public partial class TodoList : Form
    {
        public TodoList()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonNewTodo_Click(object sender, EventArgs e)
        {
            AdicionarTodo addTodoForm = new AdicionarTodo();
            addTodoForm.Show();
        }

        private void ajudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAjuda formAjuda = new FormAjuda();
            formAjuda.Show();
        }

        private void TodoList_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void documentaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDocumentation formDocumentation = new FormDocumentation();
            formDocumentation.Show();
        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSystemInformation formSystemInformation = new FormSystemInformation();
            formSystemInformation.Show();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("operação realizada com sucesso!");
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("operação realizada com sucesso!");
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("operação realizada com sucesso!");
        }

        private void buttonTodoEdit_Click(object sender, EventArgs e)
        {
            FormUpdateTodo formUpdateTodo = new FormUpdateTodo();
            formUpdateTodo.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormUpdateTodo formUpdateTodo = new FormUpdateTodo();
            formUpdateTodo.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormUpdateTodo formUpdateTodo = new FormUpdateTodo();
            formUpdateTodo.Show();
        }

        private void buttonTodoDelete_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Item excluido com sucesso!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Item excluido com sucesso!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Item excluido com sucesso!");
        }

        private void TodoList_Load(object sender, EventArgs e)
        {

        }
    }
}
