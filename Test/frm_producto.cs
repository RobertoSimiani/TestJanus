using Microsoft.Data.SqlClient;
using System.Data;

namespace Test
{
    public partial class frm_producto : Form
    {
        public frm_producto()
        {
            InitializeComponent();
        }

        SqlConnection conexion = new SqlConnection(DB_config.connectionString);
        Tipo_Productos tipo = new Tipo_Productos();

        private void frm_producto_Load(object sender, EventArgs e)
        {
            cmb_tipo_producto.DataSource = tipo.cargarCombo();
            cmb_tipo_producto.DisplayMember = "descripcion";
            cmb_tipo_producto.ValueMember = "id";
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            int idTipoProducto = Convert.ToInt32(cmb_tipo_producto.SelectedValue);
            string nombre = txt_nombre.Text;
            int precio = Convert.ToInt32(txt_precio.Text);

           
            conexion.Open();

            SqlCommand command = new SqlCommand("SP_InsertarProducto", conexion);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@idTipoProducto", idTipoProducto);
            command.Parameters.AddWithValue("@nombre", nombre);
            command.Parameters.AddWithValue("@precio", precio);

            command.ExecuteNonQuery();
            conexion.Close();

            txt_nombre.Text = "";
            txt_precio.Text = "";
            

        }
    }
}
