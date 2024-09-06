namespace Test
{
    partial class frm_producto
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txt_nombre = new TextBox();
            txt_precio = new TextBox();
            cmb_tipo_producto = new ComboBox();
            btn_aceptar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(392, 107);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 105);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 1;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 155);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 2;
            label3.Text = "Precio";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 56);
            label4.Name = "label4";
            label4.Size = new Size(98, 15);
            label4.TabIndex = 3;
            label4.Text = "Tipo de producto";
            // 
            // txt_nombre
            // 
            txt_nombre.Location = new Point(143, 104);
            txt_nombre.Name = "txt_nombre";
            txt_nombre.Size = new Size(121, 23);
            txt_nombre.TabIndex = 4;
            // 
            // txt_precio
            // 
            txt_precio.Location = new Point(143, 147);
            txt_precio.Name = "txt_precio";
            txt_precio.Size = new Size(121, 23);
            txt_precio.TabIndex = 5;
            // 
            // cmb_tipo_producto
            // 
            cmb_tipo_producto.FormattingEnabled = true;
            cmb_tipo_producto.Location = new Point(143, 53);
            cmb_tipo_producto.Name = "cmb_tipo_producto";
            cmb_tipo_producto.Size = new Size(121, 23);
            cmb_tipo_producto.TabIndex = 6;
            // 
            // btn_aceptar
            // 
            btn_aceptar.Location = new Point(106, 229);
            btn_aceptar.Name = "btn_aceptar";
            btn_aceptar.Size = new Size(75, 23);
            btn_aceptar.TabIndex = 7;
            btn_aceptar.Text = "Agregar";
            btn_aceptar.UseVisualStyleBackColor = true;
            btn_aceptar.Click += btn_aceptar_Click;
            // 
            // frm_producto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(310, 280);
            Controls.Add(btn_aceptar);
            Controls.Add(cmb_tipo_producto);
            Controls.Add(txt_precio);
            Controls.Add(txt_nombre);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frm_producto";
            Text = "Alta de Producto";
            Load += frm_producto_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txt_nombre;
        private TextBox txt_precio;
        private ComboBox cmb_tipo_producto;
        private Button btn_aceptar;
    }
}
