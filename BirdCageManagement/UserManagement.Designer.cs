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
        ((System.ComponentModel.ISupportInitialize)dgvUser).BeginInit();
        SuspendLayout();
        // 
        // dgvUser
        // 
        dgvUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvUser.Location = new Point(35, 1);
        dgvUser.Name = "dgvUser";
        dgvUser.RowHeadersWidth = 51;
        dgvUser.RowTemplate.Height = 29;
        dgvUser.Size = new Size(707, 188);
        dgvUser.TabIndex = 0;
        dgvUser.CellClick += dgvUser_CellClick;
        // 
        // linkLabel1
        // 
        linkLabel1.AutoSize = true;
        linkLabel1.Location = new Point(748, 1);
        linkLabel1.Name = "linkLabel1";
        linkLabel1.Size = new Size(40, 20);
        linkLabel1.TabIndex = 1;
        linkLabel1.TabStop = true;
        linkLabel1.Text = "Back";
        linkLabel1.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(2, 233);
        label1.Name = "label1";
        label1.Size = new Size(56, 20);
        label1.TabIndex = 2;
        label1.Text = "UserID:";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(2, 287);
        label2.Name = "label2";
        label2.Size = new Size(72, 20);
        label2.TabIndex = 3;
        label2.Text = "Fullname:";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(2, 336);
        label3.Name = "label3";
        label3.Size = new Size(49, 20);
        label3.TabIndex = 4;
        label3.Text = "Email:";
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Location = new Point(2, 387);
        label4.Name = "label4";
        label4.Size = new Size(65, 20);
        label4.TabIndex = 5;
        label4.Text = "Address:";
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Location = new Point(361, 233);
        label5.Name = "label5";
        label5.Size = new Size(53, 20);
        label5.TabIndex = 6;
        label5.Text = "Phone:";
        // 
        // label6
        // 
        label6.AutoSize = true;
        label6.Location = new Point(361, 287);
        label6.Name = "label6";
        label6.Size = new Size(42, 20);
        label6.TabIndex = 7;
        label6.Text = "Role:";
        // 
        // label7
        // 
        label7.AutoSize = true;
        label7.Location = new Point(327, 336);
        label7.Name = "label7";
        label7.Size = new Size(100, 20);
        label7.TabIndex = 8;
        label7.Text = "Created Date:";
        // 
        // btnAdd
        // 
        btnAdd.Location = new Point(694, 224);
        btnAdd.Name = "btnAdd";
        btnAdd.Size = new Size(94, 29);
        btnAdd.TabIndex = 9;
        btnAdd.Text = "Add";
        btnAdd.UseVisualStyleBackColor = true;
        btnAdd.Click += btnAdd_Click;
        // 
        // btnUpdate
        // 
        btnUpdate.Location = new Point(694, 278);
        btnUpdate.Name = "btnUpdate";
        btnUpdate.Size = new Size(94, 29);
        btnUpdate.TabIndex = 10;
        btnUpdate.Text = "Update";
        btnUpdate.UseVisualStyleBackColor = true;
        btnUpdate.Click += btnUpdate_Click;
        // 
        // btnDelete
        // 
        btnDelete.Location = new Point(694, 332);
        btnDelete.Name = "btnDelete";
        btnDelete.Size = new Size(94, 29);
        btnDelete.TabIndex = 11;
        btnDelete.Text = "Delete";
        btnDelete.UseVisualStyleBackColor = true;
        btnDelete.Click += btnDelete_Click;
        // 
        // btnClose
        // 
        btnClose.Location = new Point(694, 378);
        btnClose.Name = "btnClose";
        btnClose.Size = new Size(94, 29);
        btnClose.TabIndex = 12;
        btnClose.Text = "Close";
        btnClose.UseVisualStyleBackColor = true;
        btnClose.Click += btnClose_Click;
        // 
        // btnSearch
        // 
        btnSearch.Location = new Point(694, 418);
        btnSearch.Name = "btnSearch";
        btnSearch.Size = new Size(94, 29);
        btnSearch.TabIndex = 13;
        btnSearch.Text = "Search";
        btnSearch.UseVisualStyleBackColor = true;
        // 
        // txtUserID
        // 
        txtUserID.Location = new Point(79, 224);
        txtUserID.Name = "txtUserID";
        txtUserID.Size = new Size(242, 27);
        txtUserID.TabIndex = 14;
        // 
        // txtFullname
        // 
        txtFullname.Location = new Point(79, 280);
        txtFullname.Name = "txtFullname";
        txtFullname.Size = new Size(242, 27);
        txtFullname.TabIndex = 15;
        // 
        // txtEmail
        // 
        txtEmail.Location = new Point(79, 329);
        txtEmail.Name = "txtEmail";
        txtEmail.Size = new Size(242, 27);
        txtEmail.TabIndex = 16;
        // 
        // txtAddress
        // 
        txtAddress.Location = new Point(79, 380);
        txtAddress.Name = "txtAddress";
        txtAddress.Size = new Size(242, 27);
        txtAddress.TabIndex = 17;
        // 
        // textBox5
        // 
        textBox5.Location = new Point(2, 418);
        textBox5.Name = "textBox5";
        textBox5.Size = new Size(674, 27);
        textBox5.TabIndex = 18;
        // 
        // txtPhone
        // 
        txtPhone.Location = new Point(426, 226);
        txtPhone.Name = "txtPhone";
        txtPhone.Size = new Size(250, 27);
        txtPhone.TabIndex = 19;
        // 
        // txtRole
        // 
        txtRole.Location = new Point(426, 280);
        txtRole.Name = "txtRole";
        txtRole.Size = new Size(250, 27);
        txtRole.TabIndex = 20;
        // 
        // dtpDate
        // 
        dtpDate.Location = new Point(426, 331);
        dtpDate.Name = "dtpDate";
        dtpDate.Size = new Size(250, 27);
        dtpDate.TabIndex = 21;
        // 
        // UserManagement
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
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
        Name = "UserManagement";
        Text = "UserManagement";
        Load += UserManagement_Load;
        ((System.ComponentModel.ISupportInitialize)dgvUser).EndInit();
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
}