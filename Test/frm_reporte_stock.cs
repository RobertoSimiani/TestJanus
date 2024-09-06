using Microsoft.Data.SqlClient;
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
    public partial class frm_reporte_stock : Form
    {
        public frm_reporte_stock()
        {
            InitializeComponent();
        }

        SqlConnection conexion = new SqlConnection(DB_config.connectionString);
        private void frm_reporte_stock_Load(object sender, EventArgs e)
        {
            string query = "SELECT * FROM VW_StockProducto";
            SqlCommand command = new SqlCommand(query, conexion);
            SqlDataAdapter da= new SqlDataAdapter(command);
            DataTable dt = new DataTable();

            da.Fill(dt);
            dgv_stock.DataSource = dt;
        }
    }
}
