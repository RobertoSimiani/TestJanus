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
    public partial class frm_modificar : Form
    {
        public frm_modificar()
        {
            InitializeComponent();
        }

        SqlConnection conexion = new SqlConnection(DB_config.connectionString);
        Tipo_Productos tipo = new Tipo_Productos();

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txt_id.Text);

            string query = "SELECT * FROM Producto WHERE id=@id";
            SqlCommand command = new SqlCommand(query, conexion);
            command.Parameters.AddWithValue("@Id", id);

            conexion.Open();

            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                pnl_modificar.Visible = true;

                cmb_tipo_producto.SelectedValue = reader["idTipoProducto"];
                txt_nombre.Text = reader["nombre"].ToString();
                txt_precio.Text = reader["precio"].ToString();


            }
            else
            {
                MessageBox.Show("Producto no encontrado");
            }
            conexion.Close();
        }

        private void frm_modificar_Load(object sender, EventArgs e)
        {
            cmb_tipo_producto.DataSource = tipo.cargarCombo();
            cmb_tipo_producto.DisplayMember = "descripcion";
            cmb_tipo_producto.ValueMember = "id";
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txt_id.Text);
            int idTipoProducto = Convert.ToInt32(cmb_tipo_producto.SelectedValue);
            string nombre = txt_nombre.Text;
            int precio = Convert.ToInt32(txt_precio.Text);
            

            conexion.Open();

            SqlCommand command = new SqlCommand("SP_ModificarProducto", conexion);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@Id", id);

            command.Parameters.AddWithValue("@idTipoProducto", idTipoProducto);
            command.Parameters.AddWithValue("@nombre", nombre);
            command.Parameters.AddWithValue("@precio", precio);

            command.ExecuteNonQuery();
            conexion.Close();
            MessageBox.Show("Producto Modificado");
            pnl_modificar.Visible = false;
            txt_id.Text = "";
        }
    }
}
