using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventarioC
{
    public class Producto
    {
        public int id {  get; set; }

        public string nombreProducto { get; set; }

        public string modelo { get; set; }

        public int cantidad { get; set; }

        public Producto() { }

        public Producto (int id, string nombreProducto, string modelo, int cantidad)
        {
            this.id = id;
            this.nombreProducto = nombreProducto;
            this.modelo = modelo;
            this.cantidad = cantidad;
        }
    }
}
