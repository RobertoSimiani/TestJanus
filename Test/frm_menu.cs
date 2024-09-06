using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class frm_menu : Form
    {
        public frm_menu()
        {
            InitializeComponent();
        }

        private void frm_menu_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_producto form_producto = new frm_producto();
            form_producto.Show();

        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            frm_modificar form_modificar = new frm_modificar();
            form_modificar.Show();
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            frm_baja form_baja = new frm_baja();
            form_baja.Show();
        }

        private void btn_reporte_Click(object sender, EventArgs e)
        {
            frm_reporte_stock form_repo = new frm_reporte_stock();
            form_repo.Show();
        }
    }
}
