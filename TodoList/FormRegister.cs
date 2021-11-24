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
            try
            {
                string userName = textBoxUserRegister.Text;
                string userPassword = textBoxUserPassword.Text;
                string userPasswordConfirmation = textBoxUserPasswordConfirmation.Text;
                int isActive = 1; // 1 true, 0 false

                Banco banco = new Banco();
                banco.execMutation($"insert into users(email, password, status) values('{userName}', '{userPassword}', {isActive});");

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
            catch (SqlException error)
            {
                MessageBox.Show("Erro ao registrar.. \n\n Error: " + error.Message);
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
