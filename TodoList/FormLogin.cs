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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TodoList formTodoList = new TodoList();
            formTodoList.Show();
            this.Hide();
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
