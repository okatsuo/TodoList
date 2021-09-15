
namespace TodoList
{
    partial class FormRegister
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
            this.label3 = new System.Windows.Forms.Label();
            this.linkCreateNewAccount = new System.Windows.Forms.LinkLabel();
            this.buttonLeave = new System.Windows.Forms.Button();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.textBoxUserPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxUserRegister = new System.Windows.Forms.TextBox();
            this.textBoxUserPasswordConfirmation = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(174, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Já tem uma conta ?";
            // 
            // linkCreateNewAccount
            // 
            this.linkCreateNewAccount.AutoSize = true;
            this.linkCreateNewAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkCreateNewAccount.Location = new System.Drawing.Point(278, 235);
            this.linkCreateNewAccount.Name = "linkCreateNewAccount";
            this.linkCreateNewAccount.Size = new System.Drawing.Size(34, 13);
            this.linkCreateNewAccount.TabIndex = 14;
            this.linkCreateNewAccount.TabStop = true;
            this.linkCreateNewAccount.Text = "entrar";
            this.linkCreateNewAccount.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkCreateNewAccount_LinkClicked);
            // 
            // buttonLeave
            // 
            this.buttonLeave.Location = new System.Drawing.Point(177, 181);
            this.buttonLeave.Name = "buttonLeave";
            this.buttonLeave.Size = new System.Drawing.Size(73, 23);
            this.buttonLeave.TabIndex = 13;
            this.buttonLeave.Text = "CANCELAR";
            this.buttonLeave.UseVisualStyleBackColor = true;
            this.buttonLeave.Click += new System.EventHandler(this.buttonLeave_Click);
            // 
            // buttonRegister
            // 
            this.buttonRegister.Location = new System.Drawing.Point(256, 181);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(87, 23);
            this.buttonRegister.TabIndex = 12;
            this.buttonRegister.Text = "CADASTRAR";
            this.buttonRegister.UseVisualStyleBackColor = true;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // textBoxUserPassword
            // 
            this.textBoxUserPassword.Location = new System.Drawing.Point(177, 114);
            this.textBoxUserPassword.Name = "textBoxUserPassword";
            this.textBoxUserPassword.Size = new System.Drawing.Size(166, 20);
            this.textBoxUserPassword.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Senha";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Usuário";
            // 
            // textBoxUserRegister
            // 
            this.textBoxUserRegister.Location = new System.Drawing.Point(177, 71);
            this.textBoxUserRegister.Name = "textBoxUserRegister";
            this.textBoxUserRegister.Size = new System.Drawing.Size(166, 20);
            this.textBoxUserRegister.TabIndex = 8;
            // 
            // textBoxUserPasswordConfirmation
            // 
            this.textBoxUserPasswordConfirmation.Location = new System.Drawing.Point(177, 149);
            this.textBoxUserPasswordConfirmation.Name = "textBoxUserPasswordConfirmation";
            this.textBoxUserPasswordConfirmation.Size = new System.Drawing.Size(166, 20);
            this.textBoxUserPasswordConfirmation.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Confirmação da senha";
            // 
            // FormRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 313);
            this.Controls.Add(this.textBoxUserPasswordConfirmation);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.linkCreateNewAccount);
            this.Controls.Add(this.buttonLeave);
            this.Controls.Add(this.buttonRegister);
            this.Controls.Add(this.textBoxUserPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxUserRegister);
            this.Name = "FormRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Criar uma nova conta";
            this.Load += new System.EventHandler(this.FormRegister_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel linkCreateNewAccount;
        private System.Windows.Forms.Button buttonLeave;
        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.TextBox textBoxUserPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxUserRegister;
        private System.Windows.Forms.TextBox textBoxUserPasswordConfirmation;
        private System.Windows.Forms.Label label4;
    }
}