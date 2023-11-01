namespace BirdCageManagement
{
    partial class CheckoutForm
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
            btnOrder = new Button();
            lblPhone = new Label();
            lblAddress = new Label();
            txtPhoneNumber = new TextBox();
            txtAddress = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // btnOrder
            // 
            btnOrder.Location = new Point(264, 220);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(112, 34);
            btnOrder.TabIndex = 0;
            btnOrder.Text = "Order";
            btnOrder.UseVisualStyleBackColor = true;
            btnOrder.Click += btnOrder_Click;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(40, 85);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(136, 25);
            lblPhone.TabIndex = 1;
            lblPhone.Text = "Phone Number:";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(40, 139);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(81, 25);
            lblAddress.TabIndex = 2;
            lblAddress.Text = "Address:";
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(182, 82);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(247, 31);
            txtPhoneNumber.TabIndex = 3;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(182, 136);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(247, 31);
            txtAddress.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(95, 220);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 5;
            button1.Text = "Cancel";
            button1.UseVisualStyleBackColor = true;
            // 
            // CheckoutForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(479, 315);
            Controls.Add(button1);
            Controls.Add(txtAddress);
            Controls.Add(txtPhoneNumber);
            Controls.Add(lblAddress);
            Controls.Add(lblPhone);
            Controls.Add(btnOrder);
            Name = "CheckoutForm";
            Text = "Checkout";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnOrder;
        private Label lblPhone;
        private Label lblAddress;
        private TextBox txtPhoneNumber;
        private TextBox txtAddress;
        private Button button1;
    }
}