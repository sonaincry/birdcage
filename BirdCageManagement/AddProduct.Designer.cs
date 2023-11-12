namespace BirdCageManagement;

partial class AddProduct
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
        label3 = new Label();
        label4 = new Label();
        label5 = new Label();
        txtName = new TextBox();
        txtPrice = new TextBox();
        txtDescription = new TextBox();
        txtSpoke = new TextBox();
        label2 = new Label();
        btnAdd = new Button();
        linkLabel1 = new LinkLabel();
        errorProvider1 = new ErrorProvider(components);
        linkLabel2 = new LinkLabel();
        ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
        SuspendLayout();
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(329, 45);
        label1.Name = "label1";
        label1.Size = new Size(101, 15);
        label1.TabIndex = 0;
        label1.Text = "Add New Product";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(140, 157);
        label3.Name = "label3";
        label3.Size = new Size(36, 15);
        label3.TabIndex = 2;
        label3.Text = "Price:";
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Location = new Point(140, 213);
        label4.Name = "label4";
        label4.Size = new Size(70, 15);
        label4.TabIndex = 3;
        label4.Text = "Description:";
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Location = new Point(140, 270);
        label5.Name = "label5";
        label5.Size = new Size(42, 15);
        label5.TabIndex = 4;
        label5.Text = "Spoke:";
        // 
        // txtName
        // 
        txtName.Location = new Point(236, 88);
        txtName.Name = "txtName";
        txtName.Size = new Size(302, 23);
        txtName.TabIndex = 5;
        // 
        // txtPrice
        // 
        txtPrice.Location = new Point(236, 157);
        txtPrice.Name = "txtPrice";
        txtPrice.Size = new Size(302, 23);
        txtPrice.TabIndex = 6;
        // 
        // txtDescription
        // 
        txtDescription.Location = new Point(236, 205);
        txtDescription.Name = "txtDescription";
        txtDescription.Size = new Size(302, 23);
        txtDescription.TabIndex = 7;
        // 
        // txtSpoke
        // 
        txtSpoke.Location = new Point(236, 262);
        txtSpoke.Name = "txtSpoke";
        txtSpoke.Size = new Size(302, 23);
        txtSpoke.TabIndex = 8;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(140, 96);
        label2.Name = "label2";
        label2.Size = new Size(42, 15);
        label2.TabIndex = 9;
        label2.Text = "Name:";
        // 
        // btnAdd
        // 
        btnAdd.Location = new Point(355, 324);
        btnAdd.Name = "btnAdd";
        btnAdd.Size = new Size(75, 23);
        btnAdd.TabIndex = 10;
        btnAdd.Text = "Add";
        btnAdd.UseVisualStyleBackColor = true;
        btnAdd.Click += btnAdd_Click;
        // 
        // linkLabel1
        // 
        linkLabel1.Location = new Point(0, 0);
        linkLabel1.Name = "linkLabel1";
        linkLabel1.Size = new Size(100, 23);
        linkLabel1.TabIndex = 0;
        // 
        // errorProvider1
        // 
        errorProvider1.ContainerControl = this;
        // 
        // linkLabel2
        // 
        linkLabel2.AutoSize = true;
        linkLabel2.Location = new Point(12, 9);
        linkLabel2.Name = "linkLabel2";
        linkLabel2.Size = new Size(32, 15);
        linkLabel2.TabIndex = 11;
        linkLabel2.TabStop = true;
        linkLabel2.Text = "Back";
        linkLabel2.LinkClicked += linkLabel2_LinkClicked;
        // 
        // AddProduct
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(linkLabel2);
        Controls.Add(btnAdd);
        Controls.Add(label2);
        Controls.Add(txtSpoke);
        Controls.Add(txtDescription);
        Controls.Add(txtPrice);
        Controls.Add(txtName);
        Controls.Add(label5);
        Controls.Add(label4);
        Controls.Add(label3);
        Controls.Add(label1);
        Name = "AddProduct";
        Text = "AddProduct";
        ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label label1;
    private Label label3;
    private Label label4;
    private Label label5;
    private TextBox txtName;
    private TextBox txtPrice;
    private TextBox txtDescription;
    private TextBox txtSpoke;
    private Label label2;
    private Button btnAdd;
    private LinkLabel linkLabel1;
    private ErrorProvider errorProvider1;
    private LinkLabel linkLabel2;
}