namespace BirdCageManagement;

partial class BirdCageShop
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
        dgvProduct = new DataGridView();
        label1 = new Label();
        label2 = new Label();
        label3 = new Label();
        label4 = new Label();
        txtName = new TextBox();
        txtPrice = new TextBox();
        txtDescription = new TextBox();
        txtSpoke = new TextBox();
        btnCompare = new Button();
        label5 = new Label();
        linkLabel1 = new LinkLabel();
        detailsBox = new GroupBox();
        btnPurchase = new Button();
        btnCart = new Button();
        linkLabel3 = new LinkLabel();
        ((System.ComponentModel.ISupportInitialize)dgvProduct).BeginInit();
        detailsBox.SuspendLayout();
        SuspendLayout();
        // 
        // dgvProduct
        // 
        dgvProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvProduct.Location = new Point(9, 8);
        dgvProduct.Margin = new Padding(3, 2, 3, 2);
        dgvProduct.Name = "dgvProduct";
        dgvProduct.RowHeadersWidth = 51;
        dgvProduct.RowTemplate.Height = 29;
        dgvProduct.Size = new Size(445, 335);
        dgvProduct.TabIndex = 0;
        dgvProduct.CellClick += dgvProduct_CellClick;
        dgvProduct.CellContentClick += dgvProduct_CellContentClick;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(41, 32);
        label1.Name = "label1";
        label1.Size = new Size(42, 15);
        label1.TabIndex = 1;
        label1.Text = "Name:";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(41, 70);
        label2.Name = "label2";
        label2.Size = new Size(36, 15);
        label2.TabIndex = 2;
        label2.Text = "Price:";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(41, 107);
        label3.Name = "label3";
        label3.Size = new Size(70, 15);
        label3.TabIndex = 3;
        label3.Text = "Description:";
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Location = new Point(41, 146);
        label4.Name = "label4";
        label4.Size = new Size(42, 15);
        label4.TabIndex = 4;
        label4.Text = "Spoke:";
        label4.Click += label4_Click;
        // 
        // txtName
        // 
        txtName.Location = new Point(120, 31);
        txtName.Margin = new Padding(3, 2, 3, 2);
        txtName.Name = "txtName";
        txtName.ReadOnly = true;
        txtName.Size = new Size(210, 23);
        txtName.TabIndex = 5;
        // 
        // txtPrice
        // 
        txtPrice.Location = new Point(120, 68);
        txtPrice.Margin = new Padding(3, 2, 3, 2);
        txtPrice.Name = "txtPrice";
        txtPrice.ReadOnly = true;
        txtPrice.Size = new Size(210, 23);
        txtPrice.TabIndex = 6;
        // 
        // txtDescription
        // 
        txtDescription.Location = new Point(120, 106);
        txtDescription.Margin = new Padding(3, 2, 3, 2);
        txtDescription.Name = "txtDescription";
        txtDescription.ReadOnly = true;
        txtDescription.Size = new Size(210, 23);
        txtDescription.TabIndex = 7;
        // 
        // txtSpoke
        // 
        txtSpoke.Location = new Point(120, 144);
        txtSpoke.Margin = new Padding(3, 2, 3, 2);
        txtSpoke.Name = "txtSpoke";
        txtSpoke.ReadOnly = true;
        txtSpoke.Size = new Size(210, 23);
        txtSpoke.TabIndex = 8;
        // 
        // btnCompare
        // 
        btnCompare.Location = new Point(164, 187);
        btnCompare.Margin = new Padding(3, 2, 3, 2);
        btnCompare.Name = "btnCompare";
        btnCompare.Size = new Size(83, 22);
        btnCompare.TabIndex = 9;
        btnCompare.Text = "Compare";
        btnCompare.UseVisualStyleBackColor = true;
        btnCompare.Click += btnCompare_Click;
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Location = new Point(550, 253);
        label5.Margin = new Padding(2, 0, 2, 0);
        label5.Name = "label5";
        label5.Size = new Size(147, 15);
        label5.TabIndex = 10;
        label5.Text = "Order your own bird cage?";
        // 
        // linkLabel1
        // 
        linkLabel1.AutoSize = true;
        linkLabel1.Location = new Point(711, 253);
        linkLabel1.Margin = new Padding(2, 0, 2, 0);
        linkLabel1.Name = "linkLabel1";
        linkLabel1.Size = new Size(62, 15);
        linkLabel1.TabIndex = 11;
        linkLabel1.TabStop = true;
        linkLabel1.Text = "Click here!";
        linkLabel1.LinkClicked += linkLabel1_LinkClicked;
        // 
        // detailsBox
        // 
        detailsBox.Controls.Add(btnPurchase);
        detailsBox.Controls.Add(txtName);
        detailsBox.Controls.Add(label1);
        detailsBox.Controls.Add(label2);
        detailsBox.Controls.Add(btnCompare);
        detailsBox.Controls.Add(label3);
        detailsBox.Controls.Add(txtSpoke);
        detailsBox.Controls.Add(label4);
        detailsBox.Controls.Add(txtDescription);
        detailsBox.Controls.Add(txtPrice);
        detailsBox.Location = new Point(483, 8);
        detailsBox.Margin = new Padding(2, 2, 2, 2);
        detailsBox.Name = "detailsBox";
        detailsBox.Padding = new Padding(2, 2, 2, 2);
        detailsBox.Size = new Size(369, 224);
        detailsBox.TabIndex = 10;
        detailsBox.TabStop = false;
        detailsBox.Text = "Details";
        detailsBox.Enter += detailsBox_Enter;
        // 
        // btnPurchase
        // 
        btnPurchase.Location = new Point(265, 187);
        btnPurchase.Margin = new Padding(2, 2, 2, 2);
        btnPurchase.Name = "btnPurchase";
        btnPurchase.Size = new Size(78, 22);
        btnPurchase.TabIndex = 11;
        btnPurchase.Text = "Purchase";
        btnPurchase.UseVisualStyleBackColor = true;
        btnPurchase.Click += btnPurchase_Click;
        // 
        // btnCart
        // 
        btnCart.Location = new Point(774, 313);
        btnCart.Margin = new Padding(2, 2, 2, 2);
        btnCart.Name = "btnCart";
        btnCart.Size = new Size(78, 20);
        btnCart.TabIndex = 11;
        btnCart.Text = "Your Cart";
        btnCart.UseVisualStyleBackColor = true;
        btnCart.Click += btnCart_Click;
        // 
        // linkLabel3
        // 
        linkLabel3.AutoSize = true;
        linkLabel3.Location = new Point(857, 8);
        linkLabel3.Name = "linkLabel3";
        linkLabel3.Size = new Size(45, 15);
        linkLabel3.TabIndex = 12;
        linkLabel3.TabStop = true;
        linkLabel3.Text = "Logout";
        linkLabel3.LinkClicked += linkLabel3_LinkClicked;
        // 
        // BirdCageShop
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(900, 350);
        Controls.Add(linkLabel3);
        Controls.Add(btnCart);
        Controls.Add(detailsBox);
        Controls.Add(linkLabel1);
        Controls.Add(label5);
        Controls.Add(dgvProduct);
        Margin = new Padding(3, 2, 3, 2);
        Name = "BirdCageShop";
        Text = "BirdCageShop";
        Load += BirdCageShop_Load;
        ((System.ComponentModel.ISupportInitialize)dgvProduct).EndInit();
        detailsBox.ResumeLayout(false);
        detailsBox.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private DataGridView dgvProduct;
    private Label label1;
    private Label label2;
    private Label label3;
    private Label label4;
    private TextBox txtName;
    private TextBox txtPrice;
    private TextBox txtDescription;
    private TextBox txtSpoke;
    private Button btnCompare;
    private GroupBox detailsBox;
    private Button btnPurchase;
    private Button btnCart;
    private Label label5;
    private LinkLabel linkLabel1;
    private LinkLabel linkLabel3;
}