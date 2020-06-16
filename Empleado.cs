using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Taller_Mecánico
{
    public class Empleado
    {
        public static int CuentaNueva(string usuario, string contrasena)
        {
            int res = 0;
            SqlConnection Conectar = Conexion_base_de_datos.Conectar_BD();
            SqlCommand Comando = new SqlCommand(string.Format("Insert Into Usuario (Nombre, Contraseña) values ('{0}', PwdEncrypt('{1}'))", usuario, contrasena), Conectar);
            res = Comando.ExecuteNonQuery();
            Conectar.Close();
            return res;
        }
        public static int Autentificacion(string usuario, string contrasena)
        {
            int res = -1;
            SqlConnection Conectar = Conexion_base_de_datos.Conectar_BD();
            SqlCommand Comando = new SqlCommand(string.Format("Select * From Usuario Where Nombre = '{0}' and PwdCompare('{1}', Contraseña) =1", usuario, contrasena), Conectar);
            SqlDataReader reader = Comando.ExecuteReader();

            while (reader.Read())
            {
                res = 50;
            }

            Conectar.Close();
            return res;
        }

    }
}
