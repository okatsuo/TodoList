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
    public partial class FormRegister : Form
    {
        public FormRegister()
        {
            InitializeComponent();
        }

        private void FormRegister_Load(object sender, EventArgs e)
        {

        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            string userName = textBoxUserRegister.Text;
            string userPassword = textBoxUserPassword.Text;
            string userPasswordConfirmation = textBoxUserPasswordConfirmation.Text;
            MessageBox.Show("você foi cadastrado com sucesso!");
            if (Application.OpenForms.Count == 0)
            {
                Application.Exit();
            }
            else
            {
                foreach (Form formAberto in Application.OpenForms)
                {
                    if (formAberto is FormLogin)
                    {
                        Close();
                        formAberto.Show();
                        break;
                    }
                }
            }
        }

        private void buttonLeave_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.Count == 0)
            {
                Application.Exit();
            }
            else
            {
                foreach (Form formAberto in Application.OpenForms)
                {
                    if (formAberto is FormLogin)
                    {
                        Close();
                        formAberto.Show();
                        break;
                    }
                }
            }
        }

        private void linkCreateNewAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (Application.OpenForms.Count == 0)
            {
                Application.Exit();
            }
            else
            {
                foreach (Form formAberto in Application.OpenForms)
                {
                    if (formAberto is FormLogin)
                    {
                        Close();
                        formAberto.Show();
                        break;
                    }
                }
            }
        }
    }
}
