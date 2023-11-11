namespace BirdCageManagement
{
    partial class OrderHistoryForm
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
            dgvOrders = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvOrders).BeginInit();
            SuspendLayout();
            // 
            // dgvOrders
            // 
            dgvOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrders.Location = new Point(12, 12);
            dgvOrders.Name = "dgvOrders";
            dgvOrders.RowHeadersWidth = 62;
            dgvOrders.RowTemplate.Height = 33;
            dgvOrders.Size = new Size(515, 458);
            dgvOrders.TabIndex = 0;
            // 
            // OrderHistoryForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(539, 477);
            Controls.Add(dgvOrders);
            Name = "OrderHistoryForm";
            Text = "History";
            Load += OrderHistoryForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvOrders).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvOrders;
    }
}