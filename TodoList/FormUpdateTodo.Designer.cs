
namespace TodoList
{
    partial class FormUpdateTodo
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
            this.ButtonCancelar = new System.Windows.Forms.Button();
            this.ButtonSaveUpdatedTodo = new System.Windows.Forms.Button();
            this.textBoxUpdateDescriptionTodo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxUpdateNameTodo = new System.Windows.Forms.TextBox();
            this.labelUpdateTodoName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ButtonCancelar
            // 
            this.ButtonCancelar.Location = new System.Drawing.Point(156, 198);
            this.ButtonCancelar.Name = "ButtonCancelar";
            this.ButtonCancelar.Size = new System.Drawing.Size(75, 23);
            this.ButtonCancelar.TabIndex = 11;
            this.ButtonCancelar.Text = "CANCELAR";
            this.ButtonCancelar.UseVisualStyleBackColor = true;
            this.ButtonCancelar.Click += new System.EventHandler(this.ButtonCancelar_Click);
            // 
            // ButtonSaveUpdatedTodo
            // 
            this.ButtonSaveUpdatedTodo.Location = new System.Drawing.Point(245, 198);
            this.ButtonSaveUpdatedTodo.Name = "ButtonSaveUpdatedTodo";
            this.ButtonSaveUpdatedTodo.Size = new System.Drawing.Size(75, 23);
            this.ButtonSaveUpdatedTodo.TabIndex = 10;
            this.ButtonSaveUpdatedTodo.Text = "ATUALIZAR";
            this.ButtonSaveUpdatedTodo.UseVisualStyleBackColor = true;
            this.ButtonSaveUpdatedTodo.Click += new System.EventHandler(this.ButtonSaveNewTodo_Click);
            // 
            // textBoxUpdateDescriptionTodo
            // 
            this.textBoxUpdateDescriptionTodo.Location = new System.Drawing.Point(156, 160);
            this.textBoxUpdateDescriptionTodo.Name = "textBoxUpdateDescriptionTodo";
            this.textBoxUpdateDescriptionTodo.Size = new System.Drawing.Size(164, 20);
            this.textBoxUpdateDescriptionTodo.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "descrição da tarefa:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "nome da tarefa:";
            // 
            // textBoxUpdateNameTodo
            // 
            this.textBoxUpdateNameTodo.Location = new System.Drawing.Point(156, 125);
            this.textBoxUpdateNameTodo.Name = "textBoxUpdateNameTodo";
            this.textBoxUpdateNameTodo.Size = new System.Drawing.Size(164, 20);
            this.textBoxUpdateNameTodo.TabIndex = 6;
            // 
            // labelUpdateTodoName
            // 
            this.labelUpdateTodoName.AutoSize = true;
            this.labelUpdateTodoName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUpdateTodoName.Location = new System.Drawing.Point(75, 33);
            this.labelUpdateTodoName.Name = "labelUpdateTodoName";
            this.labelUpdateTodoName.Size = new System.Drawing.Size(245, 24);
            this.labelUpdateTodoName.TabIndex = 12;
            this.labelUpdateTodoName.Text = "Atualizando todo Examplo 1";
            this.labelUpdateTodoName.Click += new System.EventHandler(this.label3_Click);
            // 
            // FormUpdateTodo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 279);
            this.Controls.Add(this.labelUpdateTodoName);
            this.Controls.Add(this.ButtonCancelar);
            this.Controls.Add(this.ButtonSaveUpdatedTodo);
            this.Controls.Add(this.textBoxUpdateDescriptionTodo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxUpdateNameTodo);
            this.Name = "FormUpdateTodo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Atualizar tarefa";
            this.Load += new System.EventHandler(this.FormUpdateTodo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonCancelar;
        private System.Windows.Forms.Button ButtonSaveUpdatedTodo;
        private System.Windows.Forms.TextBox textBoxUpdateDescriptionTodo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxUpdateNameTodo;
        private System.Windows.Forms.Label labelUpdateTodoName;
    }
}