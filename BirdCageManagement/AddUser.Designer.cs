namespace BirdCageManagement;

partial class AddUser
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
        label6 = new Label();
        btnAdd = new Button();
        txtFullname = new TextBox();
        txtAddress = new TextBox();
        txtPhone = new TextBox();
        txtPassword = new TextBox();
        txtEmail = new TextBox();
        label7 = new Label();
        txtRole = new TextBox();
        errorProvider1 = new ErrorProvider(components);
        ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
        SuspendLayout();
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(335, 21);
        label1.Name = "label1";
        label1.Size = new Size(99, 20);
        label1.TabIndex = 0;
        label1.Text = "Add new user";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(154, 85);
        label2.Name = "label2";
        label2.Size = new Size(72, 20);
        label2.TabIndex = 1;
        label2.Text = "Fullname:";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(154, 131);
        label3.Name = "label3";
        label3.Size = new Size(49, 20);
        label3.TabIndex = 2;
        label3.Text = "Email:";
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Location = new Point(153, 185);
        label4.Name = "label4";
        label4.Size = new Size(73, 20);
        label4.TabIndex = 3;
        label4.Text = "Password:";
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Location = new Point(154, 243);
        label5.Name = "label5";
        label5.Size = new Size(65, 20);
        label5.TabIndex = 4;
        label5.Text = "Address:";
        // 
        // label6
        // 
        label6.AutoSize = true;
        label6.Location = new Point(154, 296);
        label6.Name = "label6";
        label6.Size = new Size(53, 20);
        label6.TabIndex = 5;
        label6.Text = "Phone:";
        // 
        // btnAdd
        // 
        btnAdd.Location = new Point(341, 400);
        btnAdd.Name = "btnAdd";
        btnAdd.Size = new Size(94, 29);
        btnAdd.TabIndex = 6;
        btnAdd.Text = "Add";
        btnAdd.UseVisualStyleBackColor = true;
        btnAdd.Click += button1_Click;
        // 
        // txtFullname
        // 
        txtFullname.Location = new Point(254, 77);
        txtFullname.Name = "txtFullname";
        txtFullname.Size = new Size(267, 27);
        txtFullname.TabIndex = 7;
        // 
        // txtAddress
        // 
        txtAddress.Location = new Point(254, 236);
        txtAddress.Name = "txtAddress";
        txtAddress.Size = new Size(267, 27);
        txtAddress.TabIndex = 8;
        // 
        // txtPhone
        // 
        txtPhone.Location = new Point(254, 289);
        txtPhone.Name = "txtPhone";
        txtPhone.Size = new Size(267, 27);
        txtPhone.TabIndex = 9;
        // 
        // txtPassword
        // 
        txtPassword.Location = new Point(254, 179);
        txtPassword.Name = "txtPassword";
        txtPassword.PasswordChar = '*';
        txtPassword.Size = new Size(267, 27);
        txtPassword.TabIndex = 10;
        txtPassword.UseSystemPasswordChar = true;
        // 
        // txtEmail
        // 
        txtEmail.Location = new Point(254, 124);
        txtEmail.Name = "txtEmail";
        txtEmail.Size = new Size(267, 27);
        txtEmail.TabIndex = 11;
        // 
        // label7
        // 
        label7.AutoSize = true;
        label7.Location = new Point(154, 349);
        label7.Name = "label7";
        label7.Size = new Size(42, 20);
        label7.TabIndex = 12;
        label7.Text = "Role:";
        // 
        // txtRole
        // 
        txtRole.Location = new Point(254, 341);
        txtRole.Name = "txtRole";
        txtRole.Size = new Size(267, 27);
        txtRole.TabIndex = 13;
        // 
        // errorProvider1
        // 
        errorProvider1.ContainerControl = this;
        // 
        // AddUser
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 451);
        Controls.Add(txtRole);
        Controls.Add(label7);
        Controls.Add(txtEmail);
        Controls.Add(txtPassword);
        Controls.Add(txtPhone);
        Controls.Add(txtAddress);
        Controls.Add(txtFullname);
        Controls.Add(btnAdd);
        Controls.Add(label6);
        Controls.Add(label5);
        Controls.Add(label4);
        Controls.Add(label3);
        Controls.Add(label2);
        Controls.Add(label1);
        Name = "AddUser";
        Text = "AddUser";
        Load += AddUser_Load;
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
    private Label label6;
    private Button btnAdd;
    private TextBox txtFullname;
    private TextBox txtAddress;
    private TextBox txtPhone;
    private TextBox txtPassword;
    private TextBox txtEmail;
    private Label label7;
    private TextBox txtRole;
    private ErrorProvider errorProvider1;
}