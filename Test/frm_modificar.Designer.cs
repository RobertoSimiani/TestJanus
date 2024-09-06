namespace Test
{
    partial class frm_modificar
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
            txt_id = new TextBox();
            btn_buscar = new Button();
            pnl_modificar = new Panel();
            btn_aceptar = new Button();
            cmb_tipo_producto = new ComboBox();
            txt_precio = new TextBox();
            txt_nombre = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            pnl_modificar.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(68, 31);
            label1.Name = "label1";
            label1.Size = new Size(88, 15);
            label1.TabIndex = 0;
            label1.Text = "Id del producto";
            // 
            // txt_id
            // 
            txt_id.Location = new Point(186, 28);
            txt_id.Name = "txt_id";
            txt_id.Size = new Size(121, 23);
            txt_id.TabIndex = 1;
            // 
            // btn_buscar
            // 
            btn_buscar.Location = new Point(150, 79);
            btn_buscar.Name = "btn_buscar";
            btn_buscar.Size = new Size(75, 23);
            btn_buscar.TabIndex = 2;
            btn_buscar.Text = "Buscar";
            btn_buscar.UseVisualStyleBackColor = true;
            btn_buscar.Click += btn_buscar_Click;
            // 
            // pnl_modificar
            // 
            pnl_modificar.Controls.Add(btn_aceptar);
            pnl_modificar.Controls.Add(cmb_tipo_producto);
            pnl_modificar.Controls.Add(txt_precio);
            pnl_modificar.Controls.Add(txt_nombre);
            pnl_modificar.Controls.Add(label4);
            pnl_modificar.Controls.Add(label3);
            pnl_modificar.Controls.Add(label2);
            pnl_modificar.Location = new Point(12, 124);
            pnl_modificar.Name = "pnl_modificar";
            pnl_modificar.Size = new Size(352, 299);
            pnl_modificar.TabIndex = 14;
            pnl_modificar.Visible = false;
            // 
            // btn_aceptar
            // 
            btn_aceptar.Location = new Point(138, 219);
            btn_aceptar.Name = "btn_aceptar";
            btn_aceptar.Size = new Size(75, 23);
            btn_aceptar.TabIndex = 20;
            btn_aceptar.Text = "Aceptar";
            btn_aceptar.UseVisualStyleBackColor = true;
            btn_aceptar.Click += btn_aceptar_Click;
            // 
            // cmb_tipo_producto
            // 
            cmb_tipo_producto.FormattingEnabled = true;
            cmb_tipo_producto.Location = new Point(174, 68);
            cmb_tipo_producto.Name = "cmb_tipo_producto";
            cmb_tipo_producto.Size = new Size(121, 23);
            cmb_tipo_producto.TabIndex = 19;
            // 
            // txt_precio
            // 
            txt_precio.Location = new Point(174, 162);
            txt_precio.Name = "txt_precio";
            txt_precio.Size = new Size(121, 23);
            txt_precio.TabIndex = 18;
            // 
            // txt_nombre
            // 
            txt_nombre.Location = new Point(174, 119);
            txt_nombre.Name = "txt_nombre";
            txt_nombre.Size = new Size(121, 23);
            txt_nombre.TabIndex = 17;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(56, 71);
            label4.Name = "label4";
            label4.Size = new Size(98, 15);
            label4.TabIndex = 16;
            label4.Text = "Tipo de producto";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(56, 170);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 15;
            label3.Text = "Precio";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(56, 120);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 14;
            label2.Text = "Nombre";
            // 
            // frm_modificar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(383, 437);
            Controls.Add(pnl_modificar);
            Controls.Add(btn_buscar);
            Controls.Add(txt_id);
            Controls.Add(label1);
            Name = "frm_modificar";
            Text = "Modificar Producto";
            Load += frm_modificar_Load;
            pnl_modificar.ResumeLayout(false);
            pnl_modificar.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txt_id;
        private Button btn_buscar;
        private Panel pnl_modificar;
        private Button btn_aceptar;
        private ComboBox cmb_tipo_producto;
        private TextBox txt_precio;
        private TextBox txt_nombre;
        private Label label4;
        private Label label3;
        private Label label2;
    }
}