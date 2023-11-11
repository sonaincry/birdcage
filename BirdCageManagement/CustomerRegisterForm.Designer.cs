namespace BirdCageManagement
{
    partial class CustomerRegisterForm
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
            lblFullName = new Label();
            lblAddress = new Label();
            txtPassword = new TextBox();
            txtFullName = new TextBox();
            txtAddress = new TextBox();
            txtPhoneNumber = new TextBox();
            lblRegistration = new Label();
            lblPhone = new Label();
            txtEmail = new TextBox();
            btnRegister = new Button();
            SuspendLayout();
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(91, 104);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(58, 25);
            lblEmail.TabIndex = 0;
            lblEmail.Text = "Email:";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(91, 156);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(91, 25);
            lblPassword.TabIndex = 1;
            lblPassword.Text = "Password:";
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Location = new Point(91, 213);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(95, 25);
            lblFullName.TabIndex = 2;
            lblFullName.Text = "Full Name:";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(91, 270);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(81, 25);
            lblAddress.TabIndex = 3;
            lblAddress.Text = "Address:";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(233, 150);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(239, 31);
            txtPassword.TabIndex = 4;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(233, 207);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(239, 31);
            txtFullName.TabIndex = 5;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(233, 264);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(239, 31);
            txtAddress.TabIndex = 6;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(233, 323);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(239, 31);
            txtPhoneNumber.TabIndex = 7;
            txtPhoneNumber.KeyPress += txtPhoneNumber_KeyPress;
            // 
            // lblRegistration
            // 
            lblRegistration.AutoSize = true;
            lblRegistration.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lblRegistration.Location = new Point(190, 18);
            lblRegistration.Name = "lblRegistration";
            lblRegistration.Size = new Size(202, 45);
            lblRegistration.TabIndex = 8;
            lblRegistration.Text = "Registration";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(91, 329);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(136, 25);
            lblPhone.TabIndex = 9;
            lblPhone.Text = "Phone Number:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(233, 98);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(239, 31);
            txtEmail.TabIndex = 10;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(233, 389);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(112, 34);
            btnRegister.TabIndex = 11;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // CustomerRegisterForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(579, 459);
            Controls.Add(btnRegister);
            Controls.Add(txtEmail);
            Controls.Add(lblPhone);
            Controls.Add(lblRegistration);
            Controls.Add(txtPhoneNumber);
            Controls.Add(txtAddress);
            Controls.Add(txtFullName);
            Controls.Add(txtPassword);
            Controls.Add(lblAddress);
            Controls.Add(lblFullName);
            Controls.Add(lblPassword);
            Controls.Add(lblEmail);
            Name = "CustomerRegisterForm";
            Text = "Customer Account Register";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblEmail;
        private Label lblPassword;
        private Label lblFullName;
        private Label lblAddress;
        private TextBox txtPassword;
        private TextBox txtFullName;
        private TextBox txtAddress;
        private TextBox txtPhoneNumber;
        private Label lblRegistration;
        private Label lblPhone;
        private TextBox txtEmail;
        private Button btnRegister;
    }
}