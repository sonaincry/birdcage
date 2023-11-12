namespace BirdCageManagement;

partial class RegistrationForm
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
        components = new System.ComponentModel.Container();
        label1 = new Label();
        label2 = new Label();
        label3 = new Label();
        label4 = new Label();
        label5 = new Label();
        txtEmail = new TextBox();
        txtPassword = new TextBox();
        txtRepassword = new TextBox();
        txtFullname = new TextBox();
        btnRegister = new Button();
        label6 = new Label();
        linkLabel1 = new LinkLabel();
        errorProvider1 = new ErrorProvider(components);
        label7 = new Label();
        label8 = new Label();
        txtPhone = new TextBox();
        txtAddress = new TextBox();
        ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
        SuspendLayout();
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(346, 21);
        label1.Name = "label1";
        label1.Size = new Size(127, 20);
        label1.TabIndex = 0;
        label1.Text = "Registration Form";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(215, 69);
        label2.Name = "label2";
        label2.Size = new Size(49, 20);
        label2.TabIndex = 1;
        label2.Text = "Email:";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(215, 168);
        label3.Name = "label3";
        label3.Size = new Size(73, 20);
        label3.TabIndex = 2;
        label3.Text = "Password:";
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Location = new Point(215, 221);
        label4.Name = "label4";
        label4.Size = new Size(98, 20);
        label4.TabIndex = 3;
        label4.Text = "Re-password:";
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Location = new Point(215, 118);
        label5.Name = "label5";
        label5.Size = new Size(72, 20);
        label5.TabIndex = 4;
        label5.Text = "Fullname:";
        // 
        // txtEmail
        // 
        txtEmail.Location = new Point(323, 62);
        txtEmail.Name = "txtEmail";
        txtEmail.Size = new Size(198, 27);
        txtEmail.TabIndex = 6;
        // 
        // txtPassword
        // 
        txtPassword.Location = new Point(323, 161);
        txtPassword.Name = "txtPassword";
        txtPassword.PasswordChar = '*';
        txtPassword.Size = new Size(198, 27);
        txtPassword.TabIndex = 7;
        txtPassword.UseSystemPasswordChar = true;
        // 
        // txtRepassword
        // 
        txtRepassword.Location = new Point(323, 214);
        txtRepassword.Name = "txtRepassword";
        txtRepassword.PasswordChar = '*';
        txtRepassword.Size = new Size(198, 27);
        txtRepassword.TabIndex = 8;
        txtRepassword.UseSystemPasswordChar = true;
        // 
        // txtFullname
        // 
        txtFullname.Location = new Point(323, 111);
        txtFullname.Name = "txtFullname";
        txtFullname.Size = new Size(198, 27);
        txtFullname.TabIndex = 9;
        txtFullname.TextChanged += txtPhone_TextChanged;
        // 
        // btnRegister
        // 
        btnRegister.Location = new Point(379, 339);
        btnRegister.Name = "btnRegister";
        btnRegister.RightToLeft = RightToLeft.Yes;
        btnRegister.Size = new Size(94, 29);
        btnRegister.TabIndex = 10;
        btnRegister.Text = "Register";
        btnRegister.UseVisualStyleBackColor = true;
        btnRegister.Click += btnRegister_Click;
        // 
        // label6
        // 
        label6.AutoSize = true;
        label6.Location = new Point(234, 381);
        label6.Name = "label6";
        label6.Size = new Size(178, 20);
        label6.TabIndex = 11;
        label6.Text = "Already have an account?";
        // 
        // linkLabel1
        // 
        linkLabel1.AutoSize = true;
        linkLabel1.Location = new Point(418, 381);
        linkLabel1.Name = "linkLabel1";
        linkLabel1.Size = new Size(91, 20);
        linkLabel1.TabIndex = 12;
        linkLabel1.TabStop = true;
        linkLabel1.Text = "Sign in here!";
        linkLabel1.LinkClicked += linkLabel1_LinkClicked;
        // 
        // errorProvider1
        // 
        errorProvider1.ContainerControl = this;
        // 
        // label7
        // 
        label7.AutoSize = true;
        label7.Location = new Point(215, 266);
        label7.Name = "label7";
        label7.Size = new Size(53, 20);
        label7.TabIndex = 15;
        label7.Text = "Phone:";
        label7.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // label8
        // 
        label8.AutoSize = true;
        label8.Location = new Point(215, 313);
        label8.Name = "label8";
        label8.Size = new Size(65, 20);
        label8.TabIndex = 16;
        label8.Text = "Address:";
        label8.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // txtPhone
        // 
        txtPhone.Location = new Point(323, 259);
        txtPhone.Name = "txtPhone";
        txtPhone.Size = new Size(198, 27);
        txtPhone.TabIndex = 17;
        // 
        // txtAddress
        // 
        txtAddress.Location = new Point(323, 306);
        txtAddress.Name = "txtAddress";
        txtAddress.Size = new Size(198, 27);
        txtAddress.TabIndex = 18;
        // 
        // RegistrationForm
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(txtAddress);
        Controls.Add(txtPhone);
        Controls.Add(label8);
        Controls.Add(label7);
        Controls.Add(linkLabel1);
        Controls.Add(label6);
        Controls.Add(btnRegister);
        Controls.Add(txtFullname);
        Controls.Add(txtRepassword);
        Controls.Add(txtPassword);
        Controls.Add(txtEmail);
        Controls.Add(label5);
        Controls.Add(label4);
        Controls.Add(label3);
        Controls.Add(label2);
        Controls.Add(label1);
        Name = "RegistrationForm";
        Text = "RegistrationForm";
        Load += RegistrationForm_Load;
        ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label label1;
    private Label label2;
    private Label label3;
    private Label label4;
    private Label label5;
    private TextBox txtEmail;
    private TextBox txtPassword;
    private TextBox txtRepassword;
    private TextBox txtFullname;
    private Button btnRegister;
    private Label label6;
    private LinkLabel linkLabel1;
    private ErrorProvider errorProvider1;
    private TextBox txtAddress;
    private TextBox txtPhone;
    private Label label8;
    private Label label7;
}