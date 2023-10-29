namespace BirdCageManagement
{
    partial class AddToCartForm
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
            txtSelectedSpoke = new TextBox();
            label2 = new Label();
            txtSelectedDescription = new TextBox();
            label3 = new Label();
            txtSelectedPrice = new TextBox();
            label4 = new Label();
            txtSelectedName = new TextBox();
            btnAddToCart = new Button();
            button2 = new Button();
            txtQuantity = new TextBox();
            label5 = new Label();
            btnIncrease = new Button();
            btnDecrease = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 53);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(63, 25);
            label1.TabIndex = 17;
            label1.Text = "Name:";
            // 
            // txtSelectedSpoke
            // 
            txtSelectedSpoke.Location = new Point(155, 239);
            txtSelectedSpoke.Margin = new Padding(4);
            txtSelectedSpoke.Name = "txtSelectedSpoke";
            txtSelectedSpoke.ReadOnly = true;
            txtSelectedSpoke.Size = new Size(298, 31);
            txtSelectedSpoke.TabIndex = 24;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 115);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(53, 25);
            label2.TabIndex = 18;
            label2.Text = "Price:";
            // 
            // txtSelectedDescription
            // 
            txtSelectedDescription.Location = new Point(155, 175);
            txtSelectedDescription.Margin = new Padding(4);
            txtSelectedDescription.Name = "txtSelectedDescription";
            txtSelectedDescription.ReadOnly = true;
            txtSelectedDescription.Size = new Size(298, 31);
            txtSelectedDescription.TabIndex = 23;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(41, 178);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(106, 25);
            label3.TabIndex = 19;
            label3.Text = "Description:";
            // 
            // txtSelectedPrice
            // 
            txtSelectedPrice.Location = new Point(155, 112);
            txtSelectedPrice.Margin = new Padding(4);
            txtSelectedPrice.Name = "txtSelectedPrice";
            txtSelectedPrice.ReadOnly = true;
            txtSelectedPrice.Size = new Size(298, 31);
            txtSelectedPrice.TabIndex = 22;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(41, 242);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(66, 25);
            label4.TabIndex = 20;
            label4.Text = "Spoke:";
            // 
            // txtSelectedName
            // 
            txtSelectedName.Location = new Point(155, 50);
            txtSelectedName.Margin = new Padding(4);
            txtSelectedName.Name = "txtSelectedName";
            txtSelectedName.ReadOnly = true;
            txtSelectedName.Size = new Size(298, 31);
            txtSelectedName.TabIndex = 21;
            // 
            // btnAddToCart
            // 
            btnAddToCart.Location = new Point(275, 371);
            btnAddToCart.Name = "btnAddToCart";
            btnAddToCart.Size = new Size(132, 34);
            btnAddToCart.TabIndex = 25;
            btnAddToCart.Text = "Add To Cart";
            btnAddToCart.UseVisualStyleBackColor = true;
            btnAddToCart.Click += btnAddToCart_Click;
            // 
            // button2
            // 
            button2.Location = new Point(112, 371);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 26;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = true;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(226, 296);
            txtQuantity.Margin = new Padding(4);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(66, 31);
            txtQuantity.TabIndex = 28;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(41, 299);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(80, 25);
            label5.TabIndex = 27;
            label5.Text = "Quantity";
            // 
            // btnIncrease
            // 
            btnIncrease.Location = new Point(308, 296);
            btnIncrease.Name = "btnIncrease";
            btnIncrease.Size = new Size(31, 31);
            btnIncrease.TabIndex = 29;
            btnIncrease.Text = "+";
            btnIncrease.UseVisualStyleBackColor = true;
            btnIncrease.Click += btnIncrease_Click;
            // 
            // btnDecrease
            // 
            btnDecrease.Location = new Point(179, 296);
            btnDecrease.Name = "btnDecrease";
            btnDecrease.Size = new Size(31, 31);
            btnDecrease.TabIndex = 30;
            btnDecrease.Text = "-";
            btnDecrease.UseVisualStyleBackColor = true;
            btnDecrease.Click += btnDecrease_Click;
            // 
            // AddToCartForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(505, 436);
            Controls.Add(btnDecrease);
            Controls.Add(btnIncrease);
            Controls.Add(txtQuantity);
            Controls.Add(label5);
            Controls.Add(button2);
            Controls.Add(btnAddToCart);
            Controls.Add(label1);
            Controls.Add(txtSelectedSpoke);
            Controls.Add(label2);
            Controls.Add(txtSelectedDescription);
            Controls.Add(label3);
            Controls.Add(txtSelectedPrice);
            Controls.Add(label4);
            Controls.Add(txtSelectedName);
            Name = "AddToCartForm";
            Text = "Add To Cart";
            Load += AddToCartForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtSelectedSpoke;
        private Label label2;
        private TextBox txtSelectedDescription;
        private Label label3;
        private TextBox txtSelectedPrice;
        private Label label4;
        private TextBox txtSelectedName;
        private Button btnAddToCart;
        private Button button2;
        private TextBox txtQuantity;
        private Label label5;
        private Button btnIncrease;
        private Button btnDecrease;
    }
}