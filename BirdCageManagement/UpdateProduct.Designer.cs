namespace BirdCageManagement
{
    partial class UpdateProduct
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
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtName = new TextBox();
            txtPrice = new TextBox();
            txtDescription = new TextBox();
            txtStatus = new TextBox();
            txtSpoke = new TextBox();
            btnUpdate = new Button();
            txtProductId = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(336, 39);
            label1.Name = "label1";
            label1.Size = new Size(90, 15);
            label1.TabIndex = 0;
            label1.Text = "Update product";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(197, 80);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 1;
            label2.Text = "Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(197, 131);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 2;
            label3.Text = "Price:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(197, 180);
            label4.Name = "label4";
            label4.Size = new Size(70, 15);
            label4.TabIndex = 3;
            label4.Text = "Description;";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(197, 233);
            label5.Name = "label5";
            label5.Size = new Size(42, 15);
            label5.TabIndex = 4;
            label5.Text = "Status:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(197, 289);
            label6.Name = "label6";
            label6.Size = new Size(42, 15);
            label6.TabIndex = 5;
            label6.Text = "Spoke:";
            // 
            // txtName
            // 
            txtName.Location = new Point(281, 72);
            txtName.Name = "txtName";
            txtName.Size = new Size(217, 23);
            txtName.TabIndex = 6;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(281, 123);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(217, 23);
            txtPrice.TabIndex = 7;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(281, 172);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(217, 23);
            txtDescription.TabIndex = 8;
            // 
            // txtStatus
            // 
            txtStatus.Location = new Point(281, 225);
            txtStatus.Name = "txtStatus";
            txtStatus.Size = new Size(217, 23);
            txtStatus.TabIndex = 9;
            // 
            // txtSpoke
            // 
            txtSpoke.Location = new Point(281, 281);
            txtSpoke.Name = "txtSpoke";
            txtSpoke.Size = new Size(217, 23);
            txtSpoke.TabIndex = 10;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(336, 342);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 11;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // txtProductId
            // 
            txtProductId.Location = new Point(575, 72);
            txtProductId.Name = "txtProductId";
            txtProductId.Size = new Size(100, 23);
            txtProductId.TabIndex = 12;
            // 
            // UpdateProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtProductId);
            Controls.Add(btnUpdate);
            Controls.Add(txtSpoke);
            Controls.Add(txtStatus);
            Controls.Add(txtDescription);
            Controls.Add(txtPrice);
            Controls.Add(txtName);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UpdateProduct";
            Text = "UpdateProduct";
            Load += UpdateProduct_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtName;
        private TextBox txtPrice;
        private TextBox txtDescription;
        private TextBox txtStatus;
        private TextBox txtSpoke;
        private Button btnUpdate;
        private TextBox txtProductId;
    }
}