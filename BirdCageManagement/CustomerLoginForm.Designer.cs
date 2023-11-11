namespace BirdCageManagement
{
    partial class CustomerLoginForm
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
            lblEmail = new Label();
            lblPassword = new Label();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            lblLogin = new Label();
            btnLogin = new Button();
            linkRegister = new LinkLabel();
            label4 = new Label();
            SuspendLayout();
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(75, 123);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(58, 25);
            lblEmail.TabIndex = 0;
            lblEmail.Text = "Email:";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(75, 173);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(91, 25);
            lblPassword.TabIndex = 1;
            lblPassword.Text = "Password:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(188, 120);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(239, 31);
            txtEmail.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(188, 170);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(239, 31);
            txtPassword.TabIndex = 3;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lblLogin.Location = new Point(210, 43);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(104, 45);
            lblLogin.TabIndex = 4;
            lblLogin.Text = "Login";
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(202, 236);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(112, 34);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // linkRegister
            // 
            linkRegister.AutoSize = true;
            linkRegister.Location = new Point(305, 300);
            linkRegister.Margin = new Padding(4, 0, 4, 0);
            linkRegister.Name = "linkRegister";
            linkRegister.Size = new Size(119, 25);
            linkRegister.TabIndex = 9;
            linkRegister.TabStop = true;
            linkRegister.Text = "Register here!";
            linkRegister.LinkClicked += linkRegister_LinkClicked;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(75, 300);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(218, 25);
            label4.TabIndex = 8;
            label4.Text = "If you don't have account.";
            // 
            // CustomerLoginForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(510, 378);
            Controls.Add(linkRegister);
            Controls.Add(label4);
            Controls.Add(btnLogin);
            Controls.Add(lblLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(lblPassword);
            Controls.Add(lblEmail);
            Name = "CustomerLoginForm";
            Text = "Customer Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblEmail;
        private Label lblPassword;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private Label lblLogin;
        private Button btnLogin;
        private LinkLabel linkRegister;
        private Label label4;
    }
}