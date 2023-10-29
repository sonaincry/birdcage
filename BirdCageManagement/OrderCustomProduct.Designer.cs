namespace BirdCageManagement;

partial class OrderCustomProduct
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
        label1 = new Label();
        label2 = new Label();
        txtSpoke = new TextBox();
        clMaterial = new CheckedListBox();
        clAccessories = new CheckedListBox();
        label3 = new Label();
        txtName = new TextBox();
        btnOrder = new Button();
        linklabel1 = new LinkLabel();
        SuspendLayout();
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Showcard Gothic", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point);
        label1.ForeColor = Color.Firebrick;
        label1.Location = new Point(56, 47);
        label1.Name = "label1";
        label1.Size = new Size(732, 54);
        label1.TabIndex = 0;
        label1.Text = "Customize Your Product Here";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(204, 187);
        label2.Name = "label2";
        label2.Size = new Size(53, 20);
        label2.TabIndex = 1;
        label2.Text = "Spoke:";
        // 
        // txtSpoke
        // 
        txtSpoke.Location = new Point(307, 180);
        txtSpoke.Name = "txtSpoke";
        txtSpoke.Size = new Size(213, 27);
        txtSpoke.TabIndex = 2;
        // 
        // clMaterial
        // 
        clMaterial.FormattingEnabled = true;
        clMaterial.Location = new Point(164, 251);
        clMaterial.Name = "clMaterial";
        clMaterial.Size = new Size(150, 114);
        clMaterial.TabIndex = 3;
        clMaterial.SelectedIndexChanged += clMaterial_SelectedIndexChanged;
        // 
        // clAccessories
        // 
        clAccessories.FormattingEnabled = true;
        clAccessories.Location = new Point(504, 251);
        clAccessories.Name = "clAccessories";
        clAccessories.Size = new Size(150, 114);
        clAccessories.TabIndex = 4;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(204, 139);
        label3.Name = "label3";
        label3.Size = new Size(52, 20);
        label3.TabIndex = 5;
        label3.Text = "Name:";
        // 
        // txtName
        // 
        txtName.Location = new Point(307, 132);
        txtName.Name = "txtName";
        txtName.Size = new Size(213, 27);
        txtName.TabIndex = 6;
        // 
        // btnOrder
        // 
        btnOrder.Location = new Point(347, 397);
        btnOrder.Name = "btnOrder";
        btnOrder.Size = new Size(94, 29);
        btnOrder.TabIndex = 7;
        btnOrder.Text = "Order";
        btnOrder.UseVisualStyleBackColor = true;
        btnOrder.Click += btnOrder_Click;
        // 
        // linklabel1
        // 
        linklabel1.AutoSize = true;
        linklabel1.Location = new Point(12, 9);
        linklabel1.Name = "linklabel1";
        linklabel1.Size = new Size(40, 20);
        linklabel1.TabIndex = 8;
        linklabel1.TabStop = true;
        linklabel1.Text = "Back";
        linklabel1.LinkClicked += linklabel1_LinkClicked;
        // 
        // OrderCustomProduct
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(linklabel1);
        Controls.Add(btnOrder);
        Controls.Add(txtName);
        Controls.Add(label3);
        Controls.Add(clAccessories);
        Controls.Add(clMaterial);
        Controls.Add(txtSpoke);
        Controls.Add(label2);
        Controls.Add(label1);
        Name = "OrderCustomProduct";
        Text = "OrderCustomProduct";
        Load += OrderCustomProduct_Load;
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label label1;
    private Label label2;
    private TextBox txtSpoke;
    private CheckedListBox clMaterial;
    private CheckedListBox clAccessories;
    private Label label3;
    private TextBox txtName;
    private Button btnOrder;
    private LinkLabel linklabel1;
}