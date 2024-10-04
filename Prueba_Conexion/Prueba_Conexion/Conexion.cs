using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;
using System.Net;


namespace Prueba_Conexion
{
    class Conexion
    {
        SqlConnection SqlCon;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;

        public void Open()
        {
            string nombre_servidor = Dns.GetHostName();
            SqlCon = new SqlConnection("Data Source= "+nombre_servidor+"\\LOCAL;Initial Catalog=PREUBA1;Integrated Security=True;Encrypt=False");

            SqlCon.Open();


        }

        public void Close()
        { 
            SqlCon.Close();
        }

        public string Cadena()
        {
            return SqlCon.ConnectionString;
        }

    }
}
