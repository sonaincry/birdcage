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
            ((System.ComponentModel.ISupportInitialize)dgvProduct).BeginInit();
            SuspendLayout();
            // 
            // dgvProduct
            // 
            dgvProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProduct.Location = new Point(2, 2);
            dgvProduct.Name = "dgvProduct";
            dgvProduct.RowHeadersWidth = 51;
            dgvProduct.RowTemplate.Height = 29;
            dgvProduct.Size = new Size(796, 188);
            dgvProduct.TabIndex = 0;
            dgvProduct.CellClick += dgvProduct_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(2, 213);
            label1.Name = "label1";
            label1.Size = new Size(27, 20);
            label1.TabIndex = 1;
            label1.Text = "ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(328, 272);
            label2.Name = "label2";
            label2.Size = new Size(52, 20);
            label2.TabIndex = 2;
            label2.Text = "Status:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(2, 279);
            label3.Name = "label3";
            label3.Size = new Size(52, 20);
            label3.TabIndex = 3;
            label3.Text = "Name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(328, 213);
            label4.Name = "label4";
            label4.Size = new Size(88, 20);
            label4.TabIndex = 4;
            label4.Text = "Description:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(2, 341);
            label5.Name = "label5";
            label5.Size = new Size(44, 20);
            label5.TabIndex = 5;
            label5.Text = "Price:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(328, 337);
            label6.Name = "label6";
            label6.Size = new Size(53, 20);
            label6.TabIndex = 6;
            label6.Text = "Spoke:";
            // 
            // txtProductId
            // 
            txtProductId.Location = new Point(78, 206);
            txtProductId.Name = "txtProductId";
            txtProductId.Size = new Size(190, 27);
            txtProductId.TabIndex = 7;
            // 
            // txtStatus
            // 
            txtStatus.Location = new Point(422, 265);
            txtStatus.Name = "txtStatus";
            txtStatus.Size = new Size(190, 27);
            txtStatus.TabIndex = 8;
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(78, 272);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(190, 27);
            txtProductName.TabIndex = 9;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(422, 206);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(190, 27);
            txtDescription.TabIndex = 10;
            txtDescription.TextChanged += textBox4_TextChanged;
            // 
            // txtProductPrice
            // 
            txtProductPrice.Location = new Point(78, 334);
            txtProductPrice.Name = "txtProductPrice";
            txtProductPrice.Size = new Size(190, 27);
            txtProductPrice.TabIndex = 11;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(682, 206);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(116, 29);
            btnAdd.TabIndex = 13;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(682, 249);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(116, 29);
            btnUpdate.TabIndex = 14;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(682, 292);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(116, 29);
            btnDelete.TabIndex = 15;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(682, 341);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(116, 29);
            btnClose.TabIndex = 16;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(2, 390);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(610, 27);
            txtSearch.TabIndex = 17;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(682, 390);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(116, 29);
            btnSearch.TabIndex = 18;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSpoke
            // 
            txtSpoke.Location = new Point(422, 330);
            txtSpoke.Name = "txtSpoke";
            txtSpoke.Size = new Size(190, 27);
            txtSpoke.TabIndex = 19;
            // 
            // BirdCageManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}