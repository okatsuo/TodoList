﻿using System;
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
            string todoName = textBoxAddNameTodo.Text;
            string todoDescription = textBoxAddDescriptionTodo.Text;
            MessageBox.Show("tarefa " + todoName.ToUpper() + " cadastrada com sucesso!");
            Close();
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
