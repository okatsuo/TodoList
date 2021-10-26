
namespace TodoList
{
    partial class FormDeleteTodo
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
            this.btnDeleteTodo = new System.Windows.Forms.Button();
            this.textBoxDeleteTodoId = new System.Windows.Forms.TextBox();
            this.labelDeleteTodo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDeleteTodo
            // 
            this.btnDeleteTodo.Location = new System.Drawing.Point(116, 84);
            this.btnDeleteTodo.Name = "btnDeleteTodo";
            this.btnDeleteTodo.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteTodo.TabIndex = 0;
            this.btnDeleteTodo.Text = "Deletar tarefa";
            this.btnDeleteTodo.UseVisualStyleBackColor = true;
            this.btnDeleteTodo.Click += new System.EventHandler(this.btnDeleteTodo_Click);
            // 
            // textBoxDeleteTodoId
            // 
            this.textBoxDeleteTodoId.Location = new System.Drawing.Point(73, 47);
            this.textBoxDeleteTodoId.Name = "textBoxDeleteTodoId";
            this.textBoxDeleteTodoId.Size = new System.Drawing.Size(153, 20);
            this.textBoxDeleteTodoId.TabIndex = 1;
            // 
            // labelDeleteTodo
            // 
            this.labelDeleteTodo.AutoSize = true;
            this.labelDeleteTodo.Location = new System.Drawing.Point(73, 22);
            this.labelDeleteTodo.Name = "labelDeleteTodo";
            this.labelDeleteTodo.Size = new System.Drawing.Size(153, 13);
            this.labelDeleteTodo.TabIndex = 2;
            this.labelDeleteTodo.Text = "ID da tarefa que deseja deletar";
            this.labelDeleteTodo.Click += new System.EventHandler(this.label1_Click);
            // 
            // FormDeleteTodo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 133);
            this.Controls.Add(this.labelDeleteTodo);
            this.Controls.Add(this.textBoxDeleteTodoId);
            this.Controls.Add(this.btnDeleteTodo);
            this.Name = "FormDeleteTodo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Deletar tarefa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDeleteTodo;
        private System.Windows.Forms.TextBox textBoxDeleteTodoId;
        private System.Windows.Forms.Label labelDeleteTodo;
    }
}