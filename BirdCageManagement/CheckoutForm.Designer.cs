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
            components = new System.ComponentModel.Container();
            btnOrder = new Button();
            lblPhone = new Label();
            lblAddress = new Label();
            txtPhoneNumber = new TextBox();
            txtAddress = new TextBox();
            button1 = new Button();
            linkLogin = new LinkLabel();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // btnOrder
            // 
            btnOrder.Location = new Point(212, 167);
            btnOrder.Margin = new Padding(2, 2, 2, 2);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(90, 27);
            btnOrder.TabIndex = 0;
            btnOrder.Text = "Order";
            btnOrder.UseVisualStyleBackColor = true;
            btnOrder.Click += btnOrder_Click;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(32, 68);
            lblPhone.Margin = new Padding(2, 0, 2, 0);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(111, 20);
            lblPhone.TabIndex = 1;
            lblPhone.Text = "Phone Number:";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(32, 111);
            lblAddress.Margin = new Padding(2, 0, 2, 0);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(65, 20);
            lblAddress.TabIndex = 2;
            lblAddress.Text = "Address:";
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(146, 66);
            txtPhoneNumber.Margin = new Padding(2, 2, 2, 2);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(198, 27);
            txtPhoneNumber.TabIndex = 3;
            txtPhoneNumber.KeyPress += txtPhoneNumber_KeyPress;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(146, 109);
            txtAddress.Margin = new Padding(2, 2, 2, 2);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(198, 27);
            txtAddress.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(77, 167);
            button1.Margin = new Padding(2, 2, 2, 2);
            button1.Name = "button1";
            button1.Size = new Size(90, 27);
            button1.TabIndex = 5;
            button1.Text = "Cancel";
            button1.UseVisualStyleBackColor = true;
            // 
            // linkLogin
            // 
            linkLogin.AutoSize = true;
            linkLogin.Location = new Point(128, 23);
            linkLogin.Margin = new Padding(2, 0, 2, 0);
            linkLogin.Name = "linkLogin";
            linkLogin.Size = new Size(131, 20);
            linkLogin.TabIndex = 6;
            linkLogin.TabStop = true;
            linkLogin.Text = "Login as Customer";
            linkLogin.LinkClicked += linkLogin_LinkClicked;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // CheckoutForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(383, 230);
            Controls.Add(linkLogin);
            Controls.Add(button1);
            Controls.Add(txtAddress);
            Controls.Add(txtPhoneNumber);
            Controls.Add(lblAddress);
            Controls.Add(lblPhone);
            Controls.Add(btnOrder);
            Margin = new Padding(2, 2, 2, 2);
            Name = "CheckoutForm";
            Text = "Checkout";
            Load += CheckoutForm_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
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
        private LinkLabel linkLogin;
        private ErrorProvider errorProvider1;
    }
}