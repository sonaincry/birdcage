namespace BirdCageManagement
{
    partial class CompareForm
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
            txtSelectedSpoke = new TextBox();
            txtSelectedDescription = new TextBox();
            txtSelectedPrice = new TextBox();
            txtSelectedName = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            detailsBox1 = new GroupBox();
            btnPurchaseSelected = new Button();
            detailsBox2 = new GroupBox();
            btnPurchaseCompared = new Button();
            btnSelect = new Button();
            label5 = new Label();
            txtComparedSpoke = new TextBox();
            label6 = new Label();
            txtComparedDescription = new TextBox();
            label7 = new Label();
            txtComparedPrice = new TextBox();
            label8 = new Label();
            txtComparedName = new TextBox();
            detailsBox1.SuspendLayout();
            detailsBox2.SuspendLayout();
            SuspendLayout();
            // 
            // txtSelectedSpoke
            // 
            txtSelectedSpoke.Location = new Point(155, 232);
            txtSelectedSpoke.Margin = new Padding(4);
            txtSelectedSpoke.Name = "txtSelectedSpoke";
            txtSelectedSpoke.ReadOnly = true;
            txtSelectedSpoke.Size = new Size(298, 31);
            txtSelectedSpoke.TabIndex = 16;
            // 
            // txtSelectedDescription
            // 
            txtSelectedDescription.Location = new Point(155, 168);
            txtSelectedDescription.Margin = new Padding(4);
            txtSelectedDescription.Name = "txtSelectedDescription";
            txtSelectedDescription.ReadOnly = true;
            txtSelectedDescription.Size = new Size(298, 31);
            txtSelectedDescription.TabIndex = 15;
            // 
            // txtSelectedPrice
            // 
            txtSelectedPrice.Location = new Point(155, 105);
            txtSelectedPrice.Margin = new Padding(4);
            txtSelectedPrice.Name = "txtSelectedPrice";
            txtSelectedPrice.ReadOnly = true;
            txtSelectedPrice.Size = new Size(298, 31);
            txtSelectedPrice.TabIndex = 14;
            // 
            // txtSelectedName
            // 
            txtSelectedName.Location = new Point(155, 43);
            txtSelectedName.Margin = new Padding(4);
            txtSelectedName.Name = "txtSelectedName";
            txtSelectedName.ReadOnly = true;
            txtSelectedName.Size = new Size(298, 31);
            txtSelectedName.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(41, 235);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(66, 25);
            label4.TabIndex = 12;
            label4.Text = "Spoke:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(41, 171);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(106, 25);
            label3.TabIndex = 11;
            label3.Text = "Description:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 108);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(53, 25);
            label2.TabIndex = 10;
            label2.Text = "Price:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 46);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(63, 25);
            label1.TabIndex = 9;
            label1.Text = "Name:";
            // 
            // detailsBox1
            // 
            detailsBox1.Controls.Add(btnPurchaseSelected);
            detailsBox1.Controls.Add(label1);
            detailsBox1.Controls.Add(txtSelectedSpoke);
            detailsBox1.Controls.Add(label2);
            detailsBox1.Controls.Add(txtSelectedDescription);
            detailsBox1.Controls.Add(label3);
            detailsBox1.Controls.Add(txtSelectedPrice);
            detailsBox1.Controls.Add(label4);
            detailsBox1.Controls.Add(txtSelectedName);
            detailsBox1.Location = new Point(12, 12);
            detailsBox1.Name = "detailsBox1";
            detailsBox1.Size = new Size(504, 411);
            detailsBox1.TabIndex = 17;
            detailsBox1.TabStop = false;
            detailsBox1.Text = "Selected Cage";
            // 
            // btnPurchaseSelected
            // 
            btnPurchaseSelected.Location = new Point(339, 356);
            btnPurchaseSelected.Name = "btnPurchaseSelected";
            btnPurchaseSelected.Size = new Size(141, 34);
            btnPurchaseSelected.TabIndex = 17;
            btnPurchaseSelected.Text = "Purchase";
            btnPurchaseSelected.UseVisualStyleBackColor = true;
            btnPurchaseSelected.Click += btnPurchaseSelected_Click;
            // 
            // detailsBox2
            // 
            detailsBox2.Controls.Add(btnPurchaseCompared);
            detailsBox2.Controls.Add(btnSelect);
            detailsBox2.Controls.Add(label5);
            detailsBox2.Controls.Add(txtComparedSpoke);
            detailsBox2.Controls.Add(label6);
            detailsBox2.Controls.Add(txtComparedDescription);
            detailsBox2.Controls.Add(label7);
            detailsBox2.Controls.Add(txtComparedPrice);
            detailsBox2.Controls.Add(label8);
            detailsBox2.Controls.Add(txtComparedName);
            detailsBox2.Location = new Point(522, 12);
            detailsBox2.Name = "detailsBox2";
            detailsBox2.Size = new Size(504, 411);
            detailsBox2.TabIndex = 18;
            detailsBox2.TabStop = false;
            detailsBox2.Text = "Compared With";
            // 
            // btnPurchaseCompared
            // 
            btnPurchaseCompared.Enabled = false;
            btnPurchaseCompared.Location = new Point(353, 356);
            btnPurchaseCompared.Name = "btnPurchaseCompared";
            btnPurchaseCompared.Size = new Size(125, 34);
            btnPurchaseCompared.TabIndex = 18;
            btnPurchaseCompared.Text = "Purchase";
            btnPurchaseCompared.UseVisualStyleBackColor = true;
            btnPurchaseCompared.Click += btnPurchaseCompared_Click;
            // 
            // btnSelect
            // 
            btnSelect.Location = new Point(41, 356);
            btnSelect.Name = "btnSelect";
            btnSelect.Size = new Size(115, 34);
            btnSelect.TabIndex = 17;
            btnSelect.Text = "Select Cage";
            btnSelect.UseVisualStyleBackColor = true;
            btnSelect.Click += btnSelect_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(41, 46);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(63, 25);
            label5.TabIndex = 9;
            label5.Text = "Name:";
            // 
            // txtComparedSpoke
            // 
            txtComparedSpoke.Location = new Point(155, 232);
            txtComparedSpoke.Margin = new Padding(4);
            txtComparedSpoke.Name = "txtComparedSpoke";
            txtComparedSpoke.ReadOnly = true;
            txtComparedSpoke.Size = new Size(298, 31);
            txtComparedSpoke.TabIndex = 16;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(41, 108);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(53, 25);
            label6.TabIndex = 10;
            label6.Text = "Price:";
            // 
            // txtComparedDescription
            // 
            txtComparedDescription.Location = new Point(155, 168);
            txtComparedDescription.Margin = new Padding(4);
            txtComparedDescription.Name = "txtComparedDescription";
            txtComparedDescription.ReadOnly = true;
            txtComparedDescription.Size = new Size(298, 31);
            txtComparedDescription.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(41, 171);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(106, 25);
            label7.TabIndex = 11;
            label7.Text = "Description:";
            // 
            // txtComparedPrice
            // 
            txtComparedPrice.Location = new Point(155, 105);
            txtComparedPrice.Margin = new Padding(4);
            txtComparedPrice.Name = "txtComparedPrice";
            txtComparedPrice.ReadOnly = true;
            txtComparedPrice.Size = new Size(298, 31);
            txtComparedPrice.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(41, 235);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(66, 25);
            label8.TabIndex = 12;
            label8.Text = "Spoke:";
            // 
            // txtComparedName
            // 
            txtComparedName.Location = new Point(155, 43);
            txtComparedName.Margin = new Padding(4);
            txtComparedName.Name = "txtComparedName";
            txtComparedName.ReadOnly = true;
            txtComparedName.Size = new Size(298, 31);
            txtComparedName.TabIndex = 13;
            // 
            // CompareForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1040, 453);
            Controls.Add(detailsBox2);
            Controls.Add(detailsBox1);
            Name = "CompareForm";
            Text = "Comparasion";
            Load += CompareForm_Load;
            detailsBox1.ResumeLayout(false);
            detailsBox1.PerformLayout();
            detailsBox2.ResumeLayout(false);
            detailsBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtSelectedSpoke;
        private TextBox txtSelectedDescription;
        private TextBox txtSelectedPrice;
        private TextBox txtSelectedName;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox detailsBox1;
        private GroupBox detailsBox2;
        private Button btnSelect;
        private Label label5;
        private TextBox txtComparedSpoke;
        private Label label6;
        private TextBox txtComparedDescription;
        private Label label7;
        private TextBox txtComparedPrice;
        private Label label8;
        private TextBox txtComparedName;
        private Button btnPurchaseSelected;
        private Button btnPurchaseCompared;
    }
}