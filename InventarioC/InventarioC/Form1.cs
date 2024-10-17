using System;
using System.Windows.Forms;

namespace InventarioC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Producto producto = new Producto();

            // Validar entrada
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtModelo.Text) || string.IsNullOrWhiteSpace(txtCantidad.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }

            producto.nombreProducto = txtNombre.Text;
            producto.modelo = txtModelo.Text;

            int cantidad;
            if (!int.TryParse(txtCantidad.Text, out cantidad) || cantidad <= 0)
            {
                MessageBox.Show("La cantidad tiene que ser mayor que 0.");
                return;
            }

            producto.cantidad = cantidad;



            if (dataGridView1.SelectedRows.Count == 1)
            {
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id"].Value);
                producto.id = id;

                int result = ProductoDAL.modificarProducto(producto);
                if (result > 0)
                {
                    MessageBox.Show("Se modificó exitosamente.");
                }
                else
                {
                    MessageBox.Show("No se pudo modificar.");
                }
            }
            else
            {
                int result = ProductoDAL.AgregarProducto(producto);
                if (result > 0)
                {
                    MessageBox.Show("Éxito al guardar.");
                }
                else
                {
                    MessageBox.Show("No se pudo guardar.");
                }
            }

            refreshPantalla();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            refreshPantalla();
            txtId.Enabled = false; 
        }

        public void refreshPantalla()
        {
            dataGridView1.DataSource = ProductoDAL.PresentarRegistro();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                txtId.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["id"].Value);
                txtNombre.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["nombreProducto"].Value);
                txtModelo.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["modelo"].Value);
                txtCantidad.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["cantidad"].Value);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtId.Clear();
            txtNombre.Clear();
            txtModelo.Clear();
            txtCantidad.Clear();
            dataGridView1.CurrentCell = null;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells ["id"].Value);
                int resultado = ProductoDAL.EliminarProducto(id);
                    if(resultado > 0)
                {
                    MessageBox.Show("El producto se elimino con exito");
                }
                else
                {
                    MessageBox.Show("no se pudo borrar :(");
                }


            }
            refreshPantalla();

        }
    }
}
