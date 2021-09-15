
namespace TodoList
{
    partial class FormLogin
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
            this.textBoxUserLogin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxUserPassword = new System.Windows.Forms.TextBox();
            this.buttonSignin = new System.Windows.Forms.Button();
            this.buttonLeave = new System.Windows.Forms.Button();
            this.linkCreateNewAccount = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxUserLogin
            // 
            this.textBoxUserLogin.Location = new System.Drawing.Point(149, 93);
            this.textBoxUserLogin.Name = "textBoxUserLogin";
            this.textBoxUserLogin.Size = new System.Drawing.Size(154, 20);
            this.textBoxUserLogin.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Usuário";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Senha";
            // 
            // textBoxUserPassword
            // 
            this.textBoxUserPassword.Location = new System.Drawing.Point(149, 136);
            this.textBoxUserPassword.Name = "textBoxUserPassword";
            this.textBoxUserPassword.Size = new System.Drawing.Size(154, 20);
            this.textBoxUserPassword.TabIndex = 3;
            // 
            // buttonSignin
            // 
            this.buttonSignin.Location = new System.Drawing.Point(228, 180);
            this.buttonSignin.Name = "buttonSignin";
            this.buttonSignin.Size = new System.Drawing.Size(75, 23);
            this.buttonSignin.TabIndex = 4;
            this.buttonSignin.Text = "ENTRAR";
            this.buttonSignin.UseVisualStyleBackColor = true;
            this.buttonSignin.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonLeave
            // 
            this.buttonLeave.Location = new System.Drawing.Point(147, 180);
            this.buttonLeave.Name = "buttonLeave";
            this.buttonLeave.Size = new System.Drawing.Size(75, 23);
            this.buttonLeave.TabIndex = 5;
            this.buttonLeave.Text = "SAIR";
            this.buttonLeave.UseVisualStyleBackColor = true;
            this.buttonLeave.Click += new System.EventHandler(this.buttonLeave_Click);
            // 
            // linkCreateNewAccount
            // 
            this.linkCreateNewAccount.AutoSize = true;
            this.linkCreateNewAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkCreateNewAccount.Location = new System.Drawing.Point(259, 257);
            this.linkCreateNewAccount.Name = "linkCreateNewAccount";
            this.linkCreateNewAccount.Size = new System.Drawing.Size(44, 13);
            this.linkCreateNewAccount.TabIndex = 6;
            this.linkCreateNewAccount.TabStop = true;
            this.linkCreateNewAccount.Text = "registrar";
            this.linkCreateNewAccount.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkCreateNewAccount_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(116, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ainda não tem uma conta ?";
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 351);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.linkCreateNewAccount);
            this.Controls.Add(this.buttonLeave);
            this.Controls.Add(this.buttonSignin);
            this.Controls.Add(this.textBoxUserPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxUserLogin);
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TodoList";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxUserLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxUserPassword;
        private System.Windows.Forms.Button buttonSignin;
        private System.Windows.Forms.Button buttonLeave;
        private System.Windows.Forms.LinkLabel linkCreateNewAccount;
        private System.Windows.Forms.Label label3;
    }
}