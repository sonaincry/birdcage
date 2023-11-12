namespace BirdCageManagement;

partial class UserManagement
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
        dgvUser = new DataGridView();
        linkLabel1 = new LinkLabel();
        label1 = new Label();
        label2 = new Label();
        label3 = new Label();
        label4 = new Label();
        label5 = new Label();
        label6 = new Label();
        label7 = new Label();
        btnAdd = new Button();
        btnUpdate = new Button();
        btnDelete = new Button();
        btnClose = new Button();
        btnSearch = new Button();
        txtUserID = new TextBox();
        txtFullname = new TextBox();
        txtEmail = new TextBox();
        txtAddress = new TextBox();
        textBox5 = new TextBox();
        txtPhone = new TextBox();
        txtRole = new TextBox();
        dtpDate = new DateTimePicker();
        errorProvider1 = new ErrorProvider(components);
        ((System.ComponentModel.ISupportInitialize)dgvUser).BeginInit();
        ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
        SuspendLayout();
        // 
        // dgvUser
        // 
        dgvUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvUser.Location = new Point(31, 1);
        dgvUser.Margin = new Padding(3, 2, 3, 2);
        dgvUser.Name = "dgvUser";
        dgvUser.RowHeadersWidth = 51;
        dgvUser.RowTemplate.Height = 29;
        dgvUser.Size = new Size(619, 141);
        dgvUser.TabIndex = 0;
        dgvUser.CellClick += dgvUser_CellClick;
        // 
        // linkLabel1
        // 
        linkLabel1.AutoSize = true;
        linkLabel1.Location = new Point(654, 1);
        linkLabel1.Name = "linkLabel1";
        linkLabel1.Size = new Size(45, 15);
        linkLabel1.TabIndex = 1;
        linkLabel1.TabStop = true;
        linkLabel1.Text = "Logout";
        linkLabel1.TextAlign = ContentAlignment.MiddleCenter;
        linkLabel1.LinkClicked += linkLabel1_LinkClicked;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(2, 175);
        label1.Name = "label1";
        label1.Size = new Size(44, 15);
        label1.TabIndex = 2;
        label1.Text = "UserID:";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(2, 215);
        label2.Name = "label2";
        label2.Size = new Size(59, 15);
        label2.TabIndex = 3;
        label2.Text = "Fullname:";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(2, 252);
        label3.Name = "label3";
        label3.Size = new Size(39, 15);
        label3.TabIndex = 4;
        label3.Text = "Email:";
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Location = new Point(2, 290);
        label4.Name = "label4";
        label4.Size = new Size(52, 15);
        label4.TabIndex = 5;
        label4.Text = "Address:";
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Location = new Point(316, 175);
        label5.Name = "label5";
        label5.Size = new Size(44, 15);
        label5.TabIndex = 6;
        label5.Text = "Phone:";
        // 
        // label6
        // 
        label6.AutoSize = true;
        label6.Location = new Point(316, 215);
        label6.Name = "label6";
        label6.Size = new Size(33, 15);
        label6.TabIndex = 7;
        label6.Text = "Role:";
        // 
        // label7
        // 
        label7.AutoSize = true;
        label7.Location = new Point(286, 252);
        label7.Name = "label7";
        label7.Size = new Size(78, 15);
        label7.TabIndex = 8;
        label7.Text = "Created Date:";
        // 
        // btnAdd
        // 
        btnAdd.Location = new Point(607, 168);
        btnAdd.Margin = new Padding(3, 2, 3, 2);
        btnAdd.Name = "btnAdd";
        btnAdd.Size = new Size(82, 22);
        btnAdd.TabIndex = 9;
        btnAdd.Text = "Add";
        btnAdd.UseVisualStyleBackColor = true;
        btnAdd.Click += btnAdd_Click;
        // 
        // btnUpdate
        // 
        btnUpdate.Location = new Point(607, 208);
        btnUpdate.Margin = new Padding(3, 2, 3, 2);
        btnUpdate.Name = "btnUpdate";
        btnUpdate.Size = new Size(82, 22);
        btnUpdate.TabIndex = 10;
        btnUpdate.Text = "Update";
        btnUpdate.UseVisualStyleBackColor = true;
        btnUpdate.Click += btnUpdate_Click;
        // 
        // btnDelete
        // 
        btnDelete.Location = new Point(607, 249);
        btnDelete.Margin = new Padding(3, 2, 3, 2);
        btnDelete.Name = "btnDelete";
        btnDelete.Size = new Size(82, 22);
        btnDelete.TabIndex = 11;
        btnDelete.Text = "Delete";
        btnDelete.UseVisualStyleBackColor = true;
        btnDelete.Click += btnDelete_Click;
        // 
        // btnClose
        // 
        btnClose.Location = new Point(607, 284);
        btnClose.Margin = new Padding(3, 2, 3, 2);
        btnClose.Name = "btnClose";
        btnClose.Size = new Size(82, 22);
        btnClose.TabIndex = 12;
        btnClose.Text = "Close";
        btnClose.UseVisualStyleBackColor = true;
        btnClose.Click += btnClose_Click;
        // 
        // btnSearch
        // 
        btnSearch.Location = new Point(607, 314);
        btnSearch.Margin = new Padding(3, 2, 3, 2);
        btnSearch.Name = "btnSearch";
        btnSearch.Size = new Size(82, 22);
        btnSearch.TabIndex = 13;
        btnSearch.Text = "Search";
        btnSearch.UseVisualStyleBackColor = true;
        // 
        // txtUserID
        // 
        txtUserID.Location = new Point(69, 168);
        txtUserID.Margin = new Padding(3, 2, 3, 2);
        txtUserID.Name = "txtUserID";
        txtUserID.Size = new Size(212, 23);
        txtUserID.TabIndex = 14;
        // 
        // txtFullname
        // 
        txtFullname.Location = new Point(69, 210);
        txtFullname.Margin = new Padding(3, 2, 3, 2);
        txtFullname.Name = "txtFullname";
        txtFullname.Size = new Size(212, 23);
        txtFullname.TabIndex = 15;
        // 
        // txtEmail
        // 
        txtEmail.Location = new Point(69, 247);
        txtEmail.Margin = new Padding(3, 2, 3, 2);
        txtEmail.Name = "txtEmail";
        txtEmail.Size = new Size(212, 23);
        txtEmail.TabIndex = 16;
        // 
        // txtAddress
        // 
        txtAddress.Location = new Point(69, 285);
        txtAddress.Margin = new Padding(3, 2, 3, 2);
        txtAddress.Name = "txtAddress";
        txtAddress.Size = new Size(212, 23);
        txtAddress.TabIndex = 17;
        // 
        // textBox5
        // 
        textBox5.Location = new Point(2, 314);
        textBox5.Margin = new Padding(3, 2, 3, 2);
        textBox5.Name = "textBox5";
        textBox5.Size = new Size(590, 23);
        textBox5.TabIndex = 18;
        // 
        // txtPhone
        // 
        txtPhone.Location = new Point(373, 170);
        txtPhone.Margin = new Padding(3, 2, 3, 2);
        txtPhone.Name = "txtPhone";
        txtPhone.Size = new Size(219, 23);
        txtPhone.TabIndex = 19;
        // 
        // txtRole
        // 
        txtRole.Location = new Point(373, 210);
        txtRole.Margin = new Padding(3, 2, 3, 2);
        txtRole.Name = "txtRole";
        txtRole.Size = new Size(219, 23);
        txtRole.TabIndex = 20;
        // 
        // dtpDate
        // 
        dtpDate.Location = new Point(373, 248);
        dtpDate.Margin = new Padding(3, 2, 3, 2);
        dtpDate.Name = "dtpDate";
        dtpDate.Size = new Size(219, 23);
        dtpDate.TabIndex = 21;
        // 
        // errorProvider1
        // 
        errorProvider1.ContainerControl = this;
        // 
        // UserManagement
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(700, 338);
        Controls.Add(dtpDate);
        Controls.Add(txtRole);
        Controls.Add(txtPhone);
        Controls.Add(textBox5);
        Controls.Add(txtAddress);
        Controls.Add(txtEmail);
        Controls.Add(txtFullname);
        Controls.Add(txtUserID);
        Controls.Add(btnSearch);
        Controls.Add(btnClose);
        Controls.Add(btnDelete);
        Controls.Add(btnUpdate);
        Controls.Add(btnAdd);
        Controls.Add(label7);
        Controls.Add(label6);
        Controls.Add(label5);
        Controls.Add(label4);
        Controls.Add(label3);
        Controls.Add(label2);
        Controls.Add(label1);
        Controls.Add(linkLabel1);
        Controls.Add(dgvUser);
        Margin = new Padding(3, 2, 3, 2);
        Name = "UserManagement";
        Text = "UserManagement";
        Load += UserManagement_Load;
        ((System.ComponentModel.ISupportInitialize)dgvUser).EndInit();
        ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private DataGridView dgvUser;
    private LinkLabel linkLabel1;
    private Label label1;
    private Label label2;
    private Label label3;
    private Label label4;
    private Label label5;
    private Label label6;
    private Label label7;
    private Button btnAdd;
    private Button btnUpdate;
    private Button btnDelete;
    private Button btnClose;
    private Button btnSearch;
    private TextBox txtUserID;
    private TextBox txtFullname;
    private TextBox txtEmail;
    private TextBox txtAddress;
    private TextBox textBox5;
    private TextBox txtPhone;
    private TextBox txtRole;
    private DateTimePicker dtpDate;
    private ErrorProvider errorProvider1;
}