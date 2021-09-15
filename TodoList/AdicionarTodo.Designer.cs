
namespace TodoList
{
    partial class AdicionarTodo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxAddNameTodo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxAddDescriptionTodo = new System.Windows.Forms.TextBox();
            this.ButtonSaveNewTodo = new System.Windows.Forms.Button();
            this.ButtonCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxAddNameTodo
            // 
            this.textBoxAddNameTodo.Location = new System.Drawing.Point(127, 38);
            this.textBoxAddNameTodo.Name = "textBoxAddNameTodo";
            this.textBoxAddNameTodo.Size = new System.Drawing.Size(164, 20);
            this.textBoxAddNameTodo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "nome da tarefa:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "descrição da tarefa:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBoxAddDescriptionTodo
            // 
            this.textBoxAddDescriptionTodo.Location = new System.Drawing.Point(127, 73);
            this.textBoxAddDescriptionTodo.Name = "textBoxAddDescriptionTodo";
            this.textBoxAddDescriptionTodo.Size = new System.Drawing.Size(164, 20);
            this.textBoxAddDescriptionTodo.TabIndex = 3;
            // 
            // ButtonSaveNewTodo
            // 
            this.ButtonSaveNewTodo.Location = new System.Drawing.Point(216, 111);
            this.ButtonSaveNewTodo.Name = "ButtonSaveNewTodo";
            this.ButtonSaveNewTodo.Size = new System.Drawing.Size(75, 23);
            this.ButtonSaveNewTodo.TabIndex = 4;
            this.ButtonSaveNewTodo.Text = "CRIAR";
            this.ButtonSaveNewTodo.UseVisualStyleBackColor = true;
            this.ButtonSaveNewTodo.Click += new System.EventHandler(this.ButtonSaveNewTodo_Click);
            // 
            // ButtonCancelar
            // 
            this.ButtonCancelar.Location = new System.Drawing.Point(127, 111);
            this.ButtonCancelar.Name = "ButtonCancelar";
            this.ButtonCancelar.Size = new System.Drawing.Size(75, 23);
            this.ButtonCancelar.TabIndex = 5;
            this.ButtonCancelar.Text = "CANCELAR";
            this.ButtonCancelar.UseVisualStyleBackColor = true;
            this.ButtonCancelar.Click += new System.EventHandler(this.ButtonCancelar_Click);
            // 
            // AdicionarTodo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 169);
            this.Controls.Add(this.ButtonCancelar);
            this.Controls.Add(this.ButtonSaveNewTodo);
            this.Controls.Add(this.textBoxAddDescriptionTodo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxAddNameTodo);
            this.Name = "AdicionarTodo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adicionar tarefa";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdicionarTodo_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxAddNameTodo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxAddDescriptionTodo;
        private System.Windows.Forms.Button ButtonSaveNewTodo;
        private System.Windows.Forms.Button ButtonCancelar;
    }
}