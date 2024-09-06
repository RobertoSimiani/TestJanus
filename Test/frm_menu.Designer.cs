namespace Test
{
    partial class frm_menu
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
            btn_agregar = new Button();
            btn_modificar = new Button();
            btn_eliminar = new Button();
            btn_reporte = new Button();
            SuspendLayout();
            // 
            // btn_agregar
            // 
            btn_agregar.Location = new Point(96, 54);
            btn_agregar.Name = "btn_agregar";
            btn_agregar.Size = new Size(135, 31);
            btn_agregar.TabIndex = 0;
            btn_agregar.Text = "Agregar Producto";
            btn_agregar.UseVisualStyleBackColor = true;
            btn_agregar.Click += button1_Click;
            // 
            // btn_modificar
            // 
            btn_modificar.Location = new Point(96, 113);
            btn_modificar.Name = "btn_modificar";
            btn_modificar.Size = new Size(135, 31);
            btn_modificar.TabIndex = 1;
            btn_modificar.Text = "Modificar Producto";
            btn_modificar.UseVisualStyleBackColor = true;
            btn_modificar.Click += btn_modificar_Click;
            // 
            // btn_eliminar
            // 
            btn_eliminar.Location = new Point(96, 172);
            btn_eliminar.Name = "btn_eliminar";
            btn_eliminar.Size = new Size(135, 31);
            btn_eliminar.TabIndex = 2;
            btn_eliminar.Text = "Eliminar Producto";
            btn_eliminar.UseVisualStyleBackColor = true;
            btn_eliminar.Click += btn_eliminar_Click;
            // 
            // btn_reporte
            // 
            btn_reporte.Location = new Point(96, 227);
            btn_reporte.Name = "btn_reporte";
            btn_reporte.Size = new Size(135, 31);
            btn_reporte.TabIndex = 3;
            btn_reporte.Text = "Reporte Stock";
            btn_reporte.UseVisualStyleBackColor = true;
            btn_reporte.Click += btn_reporte_Click;
            // 
            // frm_menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(326, 333);
            Controls.Add(btn_reporte);
            Controls.Add(btn_eliminar);
            Controls.Add(btn_modificar);
            Controls.Add(btn_agregar);
            Name = "frm_menu";
            Text = "Menu";
            Load += frm_menu_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btn_agregar;
        private Button btn_modificar;
        private Button btn_eliminar;
        private Button btn_reporte;
    }
}