using InvetarioC;
using System;
using System.Data.SqlClient;

namespace InventarioC
{
    public class ProductoDAL
    {
        public static int AgregarProducto(Producto producto)
        {
            int retorna = 0;
            

            using (SqlConnection conexion = BDGeneral.ObtnenerConexion())
            {
                // mira si el producto ya existe
                string checkQuery = "SELECT COUNT(*) FROM producto WHERE nombreProducto = @nombreProducto AND modelo = @modelo";
                SqlCommand checkCommand = new SqlCommand(checkQuery, conexion);
                checkCommand.Parameters.AddWithValue("@nombreProducto", producto.nombreProducto);
                checkCommand.Parameters.AddWithValue("@modelo", producto.modelo);

                int existe = (int)checkCommand.ExecuteScalar();

                if (existe > 0)
                {
                    // si existe solo aumenta a cantidad
                    string updateQuery = "UPDATE producto SET cantidad = cantidad + @cantidad WHERE nombreProducto = @nombreProducto AND modelo = @modelo";
                    SqlCommand updateCommand = new SqlCommand(updateQuery, conexion);
                    updateCommand.Parameters.AddWithValue("@cantidad", producto.cantidad);
                    updateCommand.Parameters.AddWithValue("@nombreProducto", producto.nombreProducto);
                    updateCommand.Parameters.AddWithValue("@modelo", producto.modelo);

                    retorna = updateCommand.ExecuteNonQuery();
                }
                else
                {
                    // Si no existe lo crea como nuevo 
                    string insertQuery = "INSERT INTO producto (nombreProducto, modelo, cantidad) VALUES (@nombreProducto, @modelo, @cantidad)";
                    SqlCommand insertCommand = new SqlCommand(insertQuery, conexion);
                    insertCommand.Parameters.AddWithValue("@nombreProducto", producto.nombreProducto);
                    insertCommand.Parameters.AddWithValue("@modelo", producto.modelo);
                    insertCommand.Parameters.AddWithValue("@cantidad", producto.cantidad);

                    retorna = insertCommand.ExecuteNonQuery();
                }
            }

            return retorna;
        }

        public static List<Producto> PresentarRegistro()
        {
            List<Producto> Lista = new List<Producto>();

            using (SqlConnection conexion = BDGeneral.ObtnenerConexion())
            {
                string query = "select * from producto";
                SqlCommand comando = new SqlCommand(query, conexion);

                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    Producto producto = new Producto();
                    producto.id = reader.GetInt32(0);
                    producto.nombreProducto = reader.GetString(1);
                    producto.modelo = reader.GetString(2);
                    producto.cantidad = reader.GetInt32(3);
                    Lista.Add(producto);
            }
                conexion.Close();
                return Lista;

            }
        }

        public static int modificarProducto(Producto producto)
        {
            int result = 0;
            using (SqlConnection conexion = BDGeneral.ObtnenerConexion())
            {
                
                string query = "UPDATE producto SET nombreProducto = @nombreProducto, modelo = @modelo, cantidad = @cantidad WHERE idproducto = @idproducto";
                SqlCommand comando = new SqlCommand(query, conexion);

                comando.Parameters.AddWithValue("@nombreProducto", producto.nombreProducto);
                comando.Parameters.AddWithValue("@modelo", producto.modelo);
                comando.Parameters.AddWithValue("@cantidad", producto.cantidad);
                comando.Parameters.AddWithValue("@idproducto", producto.id);
                
                result = comando.ExecuteNonQuery();
                conexion.Close() ;

            }
            return result;
        }


        public static int EliminarProducto(int id)
        {
            int retornar = 0;
            using (SqlConnection conexion = BDGeneral.ObtnenerConexion())
            {
                string query = "delete from producto where idproducto=" + id + " ";
                SqlCommand comando = new SqlCommand (query, conexion);

                retornar = comando.ExecuteNonQuery ();
            }
            return retornar;
        }
    }
}
