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
        ((System.ComponentModel.ISupportInitialize)dgvProduct).BeginInit();
        detailsBox.SuspendLayout();
        SuspendLayout();
        // 
        // dgvProduct
        // 
        dgvProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvProduct.Location = new Point(13, 13);
        dgvProduct.Margin = new Padding(4);
        dgvProduct.Name = "dgvProduct";
        dgvProduct.RowHeadersWidth = 51;
        dgvProduct.RowTemplate.Height = 29;
        dgvProduct.Size = new Size(636, 558);
        dgvProduct.TabIndex = 0;
        dgvProduct.CellClick += dgvProduct_CellClick;
        dgvProduct.CellContentClick += dgvProduct_CellContentClick;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(58, 54);
        label1.Margin = new Padding(4, 0, 4, 0);
        label1.Name = "label1";
        label1.Size = new Size(63, 25);
        label1.TabIndex = 1;
        label1.Text = "Name:";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(58, 116);
        label2.Margin = new Padding(4, 0, 4, 0);
        label2.Name = "label2";
        label2.Size = new Size(53, 25);
        label2.TabIndex = 2;
        label2.Text = "Price:";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(58, 179);
        label3.Margin = new Padding(4, 0, 4, 0);
        label3.Name = "label3";
        label3.Size = new Size(106, 25);
        label3.TabIndex = 3;
        label3.Text = "Description:";
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Location = new Point(58, 243);
        label4.Margin = new Padding(4, 0, 4, 0);
        label4.Name = "label4";
        label4.Size = new Size(66, 25);
        label4.TabIndex = 4;
        label4.Text = "Spoke:";
        label4.Click += label4_Click;
        // 
        // txtName
        // 
        txtName.Location = new Point(172, 51);
        txtName.Margin = new Padding(4);
        txtName.Name = "txtName";
        txtName.ReadOnly = true;
        txtName.Size = new Size(298, 31);
        txtName.TabIndex = 5;
        // 
        // txtPrice
        // 
        txtPrice.Location = new Point(172, 113);
        txtPrice.Margin = new Padding(4);
        txtPrice.Name = "txtPrice";
        txtPrice.ReadOnly = true;
        txtPrice.Size = new Size(298, 31);
        txtPrice.TabIndex = 6;
        // 
        // txtDescription
        // 
        txtDescription.Location = new Point(172, 176);
        txtDescription.Margin = new Padding(4);
        txtDescription.Name = "txtDescription";
        txtDescription.ReadOnly = true;
        txtDescription.Size = new Size(298, 31);
        txtDescription.TabIndex = 7;
        // 
        // txtSpoke
        // 
        txtSpoke.Location = new Point(172, 240);
        txtSpoke.Margin = new Padding(4);
        txtSpoke.Name = "txtSpoke";
        txtSpoke.ReadOnly = true;
        txtSpoke.Size = new Size(298, 31);
        txtSpoke.TabIndex = 8;
        // 
        // btnCompare
        // 
        btnCompare.Location = new Point(235, 312);
        btnCompare.Margin = new Padding(4);
        btnCompare.Name = "btnCompare";
        btnCompare.Size = new Size(118, 36);
        btnCompare.TabIndex = 9;
        btnCompare.Text = "Compare";
        btnCompare.UseVisualStyleBackColor = true;
        btnCompare.Click += btnCompare_Click;
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Location = new Point(785, 421);
        label5.Name = "label5";
        label5.Size = new Size(225, 25);
        label5.TabIndex = 10;
        label5.Text = "Order your own bird cage?";
        // 
        // linkLabel1
        // 
        linkLabel1.AutoSize = true;
        linkLabel1.Location = new Point(1016, 421);
        linkLabel1.Name = "linkLabel1";
        linkLabel1.Size = new Size(92, 25);
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
        detailsBox.Location = new Point(690, 13);
        detailsBox.Name = "detailsBox";
        detailsBox.Size = new Size(527, 373);
        detailsBox.TabIndex = 10;
        detailsBox.TabStop = false;
        detailsBox.Text = "Details";
        // 
        // btnPurchase
        // 
        btnPurchase.Location = new Point(378, 311);
        btnPurchase.Name = "btnPurchase";
        btnPurchase.Size = new Size(112, 36);
        btnPurchase.TabIndex = 11;
        btnPurchase.Text = "Purchase";
        btnPurchase.UseVisualStyleBackColor = true;
        btnPurchase.Click += btnPurchase_Click;
        // 
        // btnCart
        // 
        btnCart.Location = new Point(1105, 521);
        btnCart.Name = "btnCart";
        btnCart.Size = new Size(112, 34);
        btnCart.TabIndex = 11;
        btnCart.Text = "Your Cart";
        btnCart.UseVisualStyleBackColor = true;
        btnCart.Click += btnCart_Click;
        // 
        // BirdCageShop
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1286, 584);
        Controls.Add(btnCart);
        Controls.Add(detailsBox);
        Controls.Add(linkLabel1);
        Controls.Add(label5);
        Controls.Add(dgvProduct);
        Margin = new Padding(4);
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
}