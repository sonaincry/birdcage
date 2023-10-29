namespace BirdCageManagement
{
    partial class CartForm
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
            dgvCart = new DataGridView();
            detailsBox = new GroupBox();
            btnDecrease = new Button();
            btnIncrease = new Button();
            txtName = new TextBox();
            txtQuantity = new TextBox();
            label1 = new Label();
            btnRemove = new Button();
            txtSumPrice = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txtPrice = new TextBox();
            label4 = new Label();
            btnCheckout = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCart).BeginInit();
            detailsBox.SuspendLayout();
            SuspendLayout();
            // 
            // dgvCart
            // 
            dgvCart.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCart.Location = new Point(12, 12);
            dgvCart.Name = "dgvCart";
            dgvCart.RowHeadersWidth = 62;
            dgvCart.RowTemplate.Height = 33;
            dgvCart.Size = new Size(559, 447);
            dgvCart.TabIndex = 0;
            dgvCart.CellClick += dgvCart_CellClick;
            // 
            // detailsBox
            // 
            detailsBox.Controls.Add(btnDecrease);
            detailsBox.Controls.Add(btnIncrease);
            detailsBox.Controls.Add(txtName);
            detailsBox.Controls.Add(txtQuantity);
            detailsBox.Controls.Add(label1);
            detailsBox.Controls.Add(btnRemove);
            detailsBox.Controls.Add(txtSumPrice);
            detailsBox.Controls.Add(label2);
            detailsBox.Controls.Add(label3);
            detailsBox.Controls.Add(txtPrice);
            detailsBox.Controls.Add(label4);
            detailsBox.Location = new Point(608, 12);
            detailsBox.Name = "detailsBox";
            detailsBox.Size = new Size(527, 373);
            detailsBox.TabIndex = 11;
            detailsBox.TabStop = false;
            detailsBox.Text = "Details";
            // 
            // btnDecrease
            // 
            btnDecrease.Location = new Point(185, 178);
            btnDecrease.Name = "btnDecrease";
            btnDecrease.Size = new Size(31, 31);
            btnDecrease.TabIndex = 33;
            btnDecrease.Text = "-";
            btnDecrease.UseVisualStyleBackColor = true;
            btnDecrease.Click += btnDecrease_Click;
            // 
            // btnIncrease
            // 
            btnIncrease.Location = new Point(314, 178);
            btnIncrease.Name = "btnIncrease";
            btnIncrease.Size = new Size(31, 31);
            btnIncrease.TabIndex = 32;
            btnIncrease.Text = "+";
            btnIncrease.UseVisualStyleBackColor = true;
            btnIncrease.Click += btnIncrease_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(169, 50);
            txtName.Margin = new Padding(4);
            txtName.Name = "txtName";
            txtName.ReadOnly = true;
            txtName.Size = new Size(298, 31);
            txtName.TabIndex = 5;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(232, 178);
            txtQuantity.Margin = new Padding(4);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(66, 31);
            txtQuantity.TabIndex = 31;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(55, 53);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(63, 25);
            label1.TabIndex = 1;
            label1.Text = "Name:";
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(385, 308);
            btnRemove.Margin = new Padding(4);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(118, 36);
            btnRemove.TabIndex = 9;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // txtSumPrice
            // 
            txtSumPrice.Location = new Point(169, 239);
            txtSumPrice.Margin = new Padding(4);
            txtSumPrice.Name = "txtSumPrice";
            txtSumPrice.ReadOnly = true;
            txtSumPrice.Size = new Size(298, 31);
            txtSumPrice.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(55, 115);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(53, 25);
            label2.TabIndex = 2;
            label2.Text = "Price:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(55, 178);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(84, 25);
            label3.TabIndex = 3;
            label3.Text = "Quantity:";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(169, 112);
            txtPrice.Margin = new Padding(4);
            txtPrice.Name = "txtPrice";
            txtPrice.ReadOnly = true;
            txtPrice.Size = new Size(298, 31);
            txtPrice.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(55, 242);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(94, 25);
            label4.TabIndex = 4;
            label4.Text = "Sum Price:";
            // 
            // btnCheckout
            // 
            btnCheckout.Location = new Point(993, 412);
            btnCheckout.Name = "btnCheckout";
            btnCheckout.Size = new Size(118, 36);
            btnCheckout.TabIndex = 11;
            btnCheckout.Text = "Checkout";
            btnCheckout.UseVisualStyleBackColor = true;
            // 
            // CartForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1147, 471);
            Controls.Add(detailsBox);
            Controls.Add(btnCheckout);
            Controls.Add(dgvCart);
            Name = "CartForm";
            Text = "Your Cart";
            Load += CartForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCart).EndInit();
            detailsBox.ResumeLayout(false);
            detailsBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvCart;
        private GroupBox detailsBox;
        private Button btnCheckout;
        private TextBox txtName;
        private Label label1;
        private Button btnRemove;
        private TextBox txtSumPrice;
        private Label label2;
        private Label label3;
        private TextBox txtPrice;
        private Label label4;
        private Button btnDecrease;
        private Button btnIncrease;
        private TextBox txtQuantity;
    }
}