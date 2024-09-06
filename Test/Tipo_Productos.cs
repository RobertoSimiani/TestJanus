using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class Tipo_Productos
    {
        public DataTable cargarCombo ()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM TipoProducto",DB_config.connectionString);
            DataTable dt = new DataTable();

            da.Fill(dt);
            return dt;
        }
    }
}
