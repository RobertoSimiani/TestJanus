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
    public partial class frm_baja : Form
    {
        public frm_baja()
        {
            InitializeComponent();
        }

        SqlConnection conexion = new SqlConnection(DB_config.connectionString);

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            int id_producto = Convert.ToInt32(txt_id.Text);


            conexion.Open();

            SqlCommand command = new SqlCommand("SP_EliminarProducto", conexion);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@id", id_producto);

            command.ExecuteNonQuery();
            conexion.Close();

        }

        private void frm_baja_Load(object sender, EventArgs e)
        {

        }
    }
}
