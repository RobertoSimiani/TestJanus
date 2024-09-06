namespace Test
{
    partial class frm_reporte_stock
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
            dgv_stock = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgv_stock).BeginInit();
            SuspendLayout();
            // 
            // dgv_stock
            // 
            dgv_stock.AllowUserToAddRows = false;
            dgv_stock.AllowUserToDeleteRows = false;
            dgv_stock.AllowUserToOrderColumns = true;
            dgv_stock.AllowUserToResizeColumns = false;
            dgv_stock.AllowUserToResizeRows = false;
            dgv_stock.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_stock.Location = new Point(12, 37);
            dgv_stock.Name = "dgv_stock";
            dgv_stock.ReadOnly = true;
            dgv_stock.Size = new Size(751, 233);
            dgv_stock.TabIndex = 0;
            // 
            // frm_reporte_stock
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgv_stock);
            Name = "frm_reporte_stock";
            Text = "Reporte Stock";
            Load += frm_reporte_stock_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_stock).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgv_stock;
    }
}