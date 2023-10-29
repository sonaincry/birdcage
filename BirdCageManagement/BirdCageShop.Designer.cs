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
        linkLabel2 = new LinkLabel();
        ((System.ComponentModel.ISupportInitialize)dgvProduct).BeginInit();
        SuspendLayout();
        // 
        // dgvProduct
        // 
        dgvProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvProduct.Location = new Point(130, 1);
        dgvProduct.Margin = new Padding(3, 2, 3, 2);
        dgvProduct.Name = "dgvProduct";
        dgvProduct.RowHeadersWidth = 51;
        dgvProduct.RowTemplate.Height = 29;
        dgvProduct.Size = new Size(466, 159);
        dgvProduct.TabIndex = 0;
        dgvProduct.CellClick += dgvProduct_CellClick;
        dgvProduct.CellContentClick += dgvProduct_CellContentClick;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(130, 186);
        label1.Name = "label1";
        label1.Size = new Size(42, 15);
        label1.TabIndex = 1;
        label1.Text = "Name:";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(130, 226);
        label2.Name = "label2";
        label2.Size = new Size(36, 15);
        label2.TabIndex = 2;
        label2.Text = "Price:";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(130, 266);
        label3.Name = "label3";
        label3.Size = new Size(70, 15);
        label3.TabIndex = 3;
        label3.Text = "Description:";
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Location = new Point(130, 304);
        label4.Name = "label4";
        label4.Size = new Size(42, 15);
        label4.TabIndex = 4;
        label4.Text = "Spoke:";
        // 
        // txtName
        // 
        txtName.Location = new Point(216, 178);
        txtName.Margin = new Padding(3, 2, 3, 2);
        txtName.Name = "txtName";
        txtName.Size = new Size(210, 23);
        txtName.TabIndex = 5;
        // 
        // txtPrice
        // 
        txtPrice.Location = new Point(216, 218);
        txtPrice.Margin = new Padding(3, 2, 3, 2);
        txtPrice.Name = "txtPrice";
        txtPrice.Size = new Size(210, 23);
        txtPrice.TabIndex = 6;
        // 
        // txtDescription
        // 
        txtDescription.Location = new Point(216, 258);
        txtDescription.Margin = new Padding(3, 2, 3, 2);
        txtDescription.Name = "txtDescription";
        txtDescription.Size = new Size(210, 23);
        txtDescription.TabIndex = 7;
        // 
        // txtSpoke
        // 
        txtSpoke.Location = new Point(216, 296);
        txtSpoke.Margin = new Padding(3, 2, 3, 2);
        txtSpoke.Name = "txtSpoke";
        txtSpoke.Size = new Size(210, 23);
        txtSpoke.TabIndex = 8;
        // 
        // btnCompare
        // 
        btnCompare.Location = new Point(514, 177);
        btnCompare.Margin = new Padding(3, 2, 3, 2);
        btnCompare.Name = "btnCompare";
        btnCompare.Size = new Size(82, 22);
        btnCompare.TabIndex = 9;
        btnCompare.Text = "Compare";
        btnCompare.UseVisualStyleBackColor = true;
        btnCompare.Click += btnCompare_Click;
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Location = new Point(467, 304);
        label5.Name = "label5";
        label5.Size = new Size(147, 15);
        label5.TabIndex = 10;
        label5.Text = "Order your own bird cage?";
        // 
        // linkLabel1
        // 
        linkLabel1.AutoSize = true;
        linkLabel1.Location = new Point(629, 304);
        linkLabel1.Name = "linkLabel1";
        linkLabel1.Size = new Size(62, 15);
        linkLabel1.TabIndex = 11;
        linkLabel1.TabStop = true;
        linkLabel1.Text = "Click here!";
        linkLabel1.LinkClicked += linkLabel1_LinkClicked;
        // 
        // linkLabel2
        // 
        linkLabel2.AutoSize = true;
        linkLabel2.Location = new Point(629, 1);
        linkLabel2.Name = "linkLabel2";
        linkLabel2.Size = new Size(45, 15);
        linkLabel2.TabIndex = 12;
        linkLabel2.TabStop = true;
        linkLabel2.Text = "Logout";
        linkLabel2.LinkClicked += linkLabel2_LinkClicked;
        // 
        // BirdCageShop
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(700, 338);
        Controls.Add(linkLabel2);
        Controls.Add(linkLabel1);
        Controls.Add(label5);
        Controls.Add(btnCompare);
        Controls.Add(txtSpoke);
        Controls.Add(txtDescription);
        Controls.Add(txtPrice);
        Controls.Add(txtName);
        Controls.Add(label4);
        Controls.Add(label3);
        Controls.Add(label2);
        Controls.Add(label1);
        Controls.Add(dgvProduct);
        Margin = new Padding(3, 2, 3, 2);
        Name = "BirdCageShop";
        Text = "BirdCageShop";
        Load += BirdCageShop_Load;
        ((System.ComponentModel.ISupportInitialize)dgvProduct).EndInit();
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
    private Label label5;
    private LinkLabel linkLabel1;
    private LinkLabel linkLabel2;
}