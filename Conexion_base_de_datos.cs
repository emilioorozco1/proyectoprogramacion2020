using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.IO;
using System.Net.NetworkInformation;
using System.Windows.Forms;
using System.Configuration;

namespace Taller_Mecánico
{
    public class Conexion_base_de_datos
    {
        private string conexion = string.Empty;
        private SqlConnection conectar;
        private SqlCommand comando;
        private SqlDataAdapter datad;
        private DataTable tablad;
        private DataSet setd;

        public static SqlConnection Conectar_BD()
        {
            SqlConnection Conectado = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=Taller mecánico; Integrated Security=True");
            Conectado.Open();
            return Conectado;
        }
    }
}
