namespace BirdCageManagement
{
    partial class BirdCageManagement
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
            label5 = new Label();
            label6 = new Label();
            txtProductId = new TextBox();
            txtStatus = new TextBox();
            txtProductName = new TextBox();
            txtDescription = new TextBox();
            txtProductPrice = new TextBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnClose = new Button();
            txtSearch = new TextBox();
            btnSearch = new Button();
            txtSpoke = new TextBox();
            linkLabel1 = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)dgvProduct).BeginInit();
            SuspendLayout();
            // 
            // dgvProduct
            // 
            dgvProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProduct.Location = new Point(3, 22);
            dgvProduct.Margin = new Padding(3, 2, 3, 2);
            dgvProduct.Name = "dgvProduct";
            dgvProduct.RowHeadersWidth = 51;
            dgvProduct.RowTemplate.Height = 29;
            dgvProduct.Size = new Size(696, 141);
            dgvProduct.TabIndex = 0;
            dgvProduct.CellClick += dgvProduct_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(2, 187);
            label1.Name = "label1";
            label1.Size = new Size(21, 15);
            label1.TabIndex = 1;
            label1.Text = "ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(287, 226);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 2;
            label2.Text = "Status:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(2, 228);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 3;
            label3.Text = "Name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(287, 187);
            label4.Name = "label4";
            label4.Size = new Size(70, 15);
            label4.TabIndex = 4;
            label4.Text = "Description:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(2, 274);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 5;
            label5.Text = "Price:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(287, 274);
            label6.Name = "label6";
            label6.Size = new Size(42, 15);
            label6.TabIndex = 6;
            label6.Text = "Spoke:";
            // 
            // txtProductId
            // 
            txtProductId.Location = new Point(68, 179);
            txtProductId.Margin = new Padding(3, 2, 3, 2);
            txtProductId.Name = "txtProductId";
            txtProductId.Size = new Size(167, 23);
            txtProductId.TabIndex = 7;
            // 
            // txtStatus
            // 
            txtStatus.Location = new Point(369, 223);
            txtStatus.Margin = new Padding(3, 2, 3, 2);
            txtStatus.Name = "txtStatus";
            txtStatus.Size = new Size(167, 23);
            txtStatus.TabIndex = 8;
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(68, 226);
            txtProductName.Margin = new Padding(3, 2, 3, 2);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(167, 23);
            txtProductName.TabIndex = 9;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(369, 179);
            txtDescription.Margin = new Padding(3, 2, 3, 2);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(167, 23);
            txtDescription.TabIndex = 10;
            txtDescription.TextChanged += textBox4_TextChanged;
            // 
            // txtProductPrice
            // 
            txtProductPrice.Location = new Point(68, 266);
            txtProductPrice.Margin = new Padding(3, 2, 3, 2);
            txtProductPrice.Name = "txtProductPrice";
            txtProductPrice.Size = new Size(167, 23);
            txtProductPrice.TabIndex = 11;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(597, 187);
            btnAdd.Margin = new Padding(3, 2, 3, 2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(102, 22);
            btnAdd.TabIndex = 13;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(597, 219);
            btnUpdate.Margin = new Padding(3, 2, 3, 2);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(102, 22);
            btnUpdate.TabIndex = 14;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(597, 248);
            btnDelete.Margin = new Padding(3, 2, 3, 2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(102, 22);
            btnDelete.TabIndex = 15;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(597, 274);
            btnClose.Margin = new Padding(3, 2, 3, 2);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(102, 22);
            btnClose.TabIndex = 16;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(2, 304);
            txtSearch.Margin = new Padding(3, 2, 3, 2);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(534, 23);
            txtSearch.TabIndex = 17;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(597, 305);
            btnSearch.Margin = new Padding(3, 2, 3, 2);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(102, 22);
            btnSearch.TabIndex = 18;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSpoke
            // 
            txtSpoke.Location = new Point(369, 266);
            txtSpoke.Margin = new Padding(3, 2, 3, 2);
            txtSpoke.Name = "txtSpoke";
            txtSpoke.Size = new Size(167, 23);
            txtSpoke.TabIndex = 19;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(639, 5);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(45, 15);
            linkLabel1.TabIndex = 20;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Logout";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // BirdCageManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(linkLabel1);
            Controls.Add(txtSpoke);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(btnClose);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(txtProductPrice);
            Controls.Add(txtDescription);
            Controls.Add(txtProductName);
            Controls.Add(txtStatus);
            Controls.Add(txtProductId);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvProduct);
            Margin = new Padding(3, 2, 3, 2);
            Name = "BirdCageManagement";
            Text = "Product Management";
            Load += BirdCageManagement_Load;
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
        private Label label5;
        private Label label6;
        private TextBox txtProductId;
        private TextBox txtStatus;
        private TextBox txtProductName;
        private TextBox txtDescription;
        private TextBox txtProductPrice;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnClose;
        private TextBox txtSearch;
        private Button btnSearch;
        private TextBox txtSpoke;
        private LinkLabel linkLabel1;
    }
}