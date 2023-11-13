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
        lblCustomCage = new Label();
        linkCustomOrder = new LinkLabel();
        detailsBox = new GroupBox();
        btnPurchase = new Button();
        btnCart = new Button();
        btnLogin = new Button();
        btnHistory = new Button();
        lblWelcome = new Label();
        ((System.ComponentModel.ISupportInitialize)dgvProduct).BeginInit();
        detailsBox.SuspendLayout();
        SuspendLayout();
        // 
        // dgvProduct
        // 
        dgvProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvProduct.Location = new Point(10, 10);
        dgvProduct.Name = "dgvProduct";
        dgvProduct.RowHeadersWidth = 51;
        dgvProduct.RowTemplate.Height = 29;
        dgvProduct.Size = new Size(509, 446);
        dgvProduct.TabIndex = 0;
        dgvProduct.CellClick += dgvProduct_CellClick;
        dgvProduct.CellContentClick += dgvProduct_CellContentClick;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(46, 43);
        label1.Name = "label1";
        label1.Size = new Size(52, 20);
        label1.TabIndex = 1;
        label1.Text = "Name:";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(46, 93);
        label2.Name = "label2";
        label2.Size = new Size(44, 20);
        label2.TabIndex = 2;
        label2.Text = "Price:";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(46, 143);
        label3.Name = "label3";
        label3.Size = new Size(88, 20);
        label3.TabIndex = 3;
        label3.Text = "Description:";
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Location = new Point(46, 194);
        label4.Name = "label4";
        label4.Size = new Size(53, 20);
        label4.TabIndex = 4;
        label4.Text = "Spoke:";
        label4.Click += label4_Click;
        // 
        // txtName
        // 
        txtName.Location = new Point(138, 41);
        txtName.Name = "txtName";
        txtName.ReadOnly = true;
        txtName.Size = new Size(304, 27);
        txtName.TabIndex = 5;
        // 
        // txtPrice
        // 
        txtPrice.Location = new Point(138, 90);
        txtPrice.Name = "txtPrice";
        txtPrice.ReadOnly = true;
        txtPrice.Size = new Size(304, 27);
        txtPrice.TabIndex = 6;
        // 
        // txtDescription
        // 
        txtDescription.Location = new Point(138, 141);
        txtDescription.Name = "txtDescription";
        txtDescription.ReadOnly = true;
        txtDescription.Size = new Size(304, 27);
        txtDescription.TabIndex = 7;
        // 
        // txtSpoke
        // 
        txtSpoke.Location = new Point(138, 192);
        txtSpoke.Name = "txtSpoke";
        txtSpoke.ReadOnly = true;
        txtSpoke.Size = new Size(304, 27);
        txtSpoke.TabIndex = 8;
        // 
        // btnCompare
        // 
        btnCompare.Location = new Point(248, 259);
        btnCompare.Name = "btnCompare";
        btnCompare.Size = new Size(105, 34);
        btnCompare.TabIndex = 9;
        btnCompare.Text = "Compare";
        btnCompare.UseVisualStyleBackColor = true;
        btnCompare.Click += btnCompare_Click;
        // 
        // lblCustomCage
        // 
        lblCustomCage.AutoSize = true;
        lblCustomCage.Location = new Point(675, 339);
        lblCustomCage.Margin = new Padding(2, 0, 2, 0);
        lblCustomCage.Name = "lblCustomCage";
        lblCustomCage.Size = new Size(186, 20);
        lblCustomCage.TabIndex = 10;
        lblCustomCage.Text = "Order your own bird cage?";
        // 
        // linkCustomOrder
        // 
        linkCustomOrder.AutoSize = true;
        linkCustomOrder.Location = new Point(860, 339);
        linkCustomOrder.Margin = new Padding(2, 0, 2, 0);
        linkCustomOrder.Name = "linkCustomOrder";
        linkCustomOrder.Size = new Size(77, 20);
        linkCustomOrder.TabIndex = 11;
        linkCustomOrder.TabStop = true;
        linkCustomOrder.Text = "Click here!";
        linkCustomOrder.LinkClicked += linkCustomOrder_LinkClicked;
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
        detailsBox.Location = new Point(537, 11);
        detailsBox.Margin = new Padding(2);
        detailsBox.Name = "detailsBox";
        detailsBox.Padding = new Padding(2);
        detailsBox.Size = new Size(481, 306);
        detailsBox.TabIndex = 10;
        detailsBox.TabStop = false;
        detailsBox.Text = "Details";
        detailsBox.Enter += detailsBox_Enter;
        // 
        // btnPurchase
        // 
        btnPurchase.Location = new Point(368, 259);
        btnPurchase.Margin = new Padding(2);
        btnPurchase.Name = "btnPurchase";
        btnPurchase.Size = new Size(95, 34);
        btnPurchase.TabIndex = 11;
        btnPurchase.Text = "Purchase";
        btnPurchase.UseVisualStyleBackColor = true;
        btnPurchase.Click += btnPurchase_Click;
        // 
        // btnCart
        // 
        btnCart.Location = new Point(927, 417);
        btnCart.Margin = new Padding(2);
        btnCart.Name = "btnCart";
        btnCart.Size = new Size(91, 34);
        btnCart.TabIndex = 11;
        btnCart.Text = "Your Cart";
        btnCart.UseVisualStyleBackColor = true;
        btnCart.Click += btnCart_Click;
        // 
        // btnLogin
        // 
        btnLogin.Location = new Point(552, 417);
        btnLogin.Margin = new Padding(2, 2, 2, 2);
        btnLogin.Name = "btnLogin";
        btnLogin.Size = new Size(131, 34);
        btnLogin.TabIndex = 12;
        btnLogin.Text = "Customer Login";
        btnLogin.UseVisualStyleBackColor = true;
        btnLogin.Click += btnLogin_Click;
        // 
        // btnHistory
        // 
        btnHistory.Location = new Point(785, 417);
        btnHistory.Margin = new Padding(2, 2, 2, 2);
        btnHistory.Name = "btnHistory";
        btnHistory.Size = new Size(117, 34);
        btnHistory.TabIndex = 13;
        btnHistory.Text = "Order History";
        btnHistory.UseVisualStyleBackColor = true;
        btnHistory.Click += btnHistory_Click;
        // 
        // lblWelcome
        // 
        lblWelcome.AutoSize = true;
        lblWelcome.Location = new Point(552, 374);
        lblWelcome.Margin = new Padding(2, 0, 2, 0);
        lblWelcome.Name = "lblWelcome";
        lblWelcome.Size = new Size(71, 20);
        lblWelcome.TabIndex = 14;
        lblWelcome.Text = "Welcome";
        // 
        // BirdCageShop
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1029, 467);
        Controls.Add(lblWelcome);
        Controls.Add(btnHistory);
        Controls.Add(btnLogin);
        Controls.Add(btnCart);
        Controls.Add(detailsBox);
        Controls.Add(linkCustomOrder);
        Controls.Add(lblCustomCage);
        Controls.Add(dgvProduct);
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
    private Label lblCustomCage;
    private LinkLabel linkCustomOrder;
    private Button btnLogin;
    private Button btnHistory;
    private Label lblWelcome;

}