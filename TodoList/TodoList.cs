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

        SqlDataReader sqlDataReader;
        DataSet dataSet = new DataSet();

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
            // unico botão de excluir existente agora
            FormDeleteTodo formDeleteTodo = new FormDeleteTodo();
            formDeleteTodo.ShowDialog();
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
            try
            {
                Banco banco = new Banco();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();

                sqlDataAdapter.SelectCommand = banco.execQuery($"select * from to_do where userId = {User.Id};");

                sqlDataAdapter.Fill(dataSet);
                dataGridViewUsers.DataSource = dataSet.Tables[0];
            }
            catch (SqlException error)
            {
                MessageBox.Show("Error:" + error);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewUsers_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            int linha = Convert.ToInt32(dataGridViewUsers.CurrentRow.Index);
            int idCliente = Convert.ToInt32(dataGridViewUsers.Rows[linha].Cells[0].Value.ToString());

            try
            {
                Banco banco = new Banco();
                sqlDataReader = banco.execConsultReturn($"select * from to_do where id={idCliente}");

                if (sqlDataReader.Read())
                {
                    FormUpdateTodo FormTodoUpdate = new FormUpdateTodo();

                    FormTodoUpdate.propriedadeIdTodo = sqlDataReader["id"].ToString();
                    FormTodoUpdate.propriedadeNameTodo = sqlDataReader["name"].ToString();
                    FormTodoUpdate.propriedadeDescricaoTodo = sqlDataReader["description"].ToString();

                    FormTodoUpdate.ShowDialog();
                }
            }
            catch (SqlException error)
            {
                MessageBox.Show("Error" + error);
            }
        }

        private void buttonRefreshTodo_Click(object sender, EventArgs e)
        {
            try
            {
                Banco banco = new Banco();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();

                sqlDataAdapter.SelectCommand = banco.execQuery($"select * from to_do where userId={User.Id}");

                dataSet.Clear();
                sqlDataAdapter.Fill(dataSet);
                dataGridViewUsers.DataSource = dataSet.Tables[0];
            }
            catch (SqlException error)
            {
                MessageBox.Show("Error:" + error);
            }
        }
    }
}
