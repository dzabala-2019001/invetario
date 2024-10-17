using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvetarioC
{
    public class BDGeneral
    {
        public static SqlConnection ObtnenerConexion()
        {
            SqlConnection conexion = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=INVETARIO;Data Source=PRACTICANTE1\\SQLEXPRESS\r\n");
            conexion.Open();

            return conexion;
        }

    }
}
