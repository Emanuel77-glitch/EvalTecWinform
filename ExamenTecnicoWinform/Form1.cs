using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
namespace ExamenTecnicoWinform
{
    public partial class Form1 : Form
    {
        private List<Producto> productos;
        private int nextId;
        public Form1()
        {
            InitializeComponent();
            productos = new List<Producto>();
            nextId = 1;


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtPrecio.Text) || string.IsNullOrEmpty(txtCategoria.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }

            var producto = new Producto
            {
                id = nextId++,
                nombre = txtNombre.Text,
                precio = decimal.Parse(txtPrecio.Text),
                categoria = txtCategoria.Text
            };

            productos.Add(producto);
            ActualizarDataGridView();
            LimpiarCampos();
            ActualizarPrecioPromedio();

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if(dataGridViewProductos.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridViewProductos.SelectedRows[0];
                var productoId = (int)selectedRow.Cells["id"].Value;
                var productoAEliminar = productos.FirstOrDefault(p => p.id == productoId);
                if(productoAEliminar != null)
                {
                    productos.Remove(productoAEliminar);
                    ActualizarDataGridView();
                    ActualizarPrecioPromedio();
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un producto para eliminar.");
            }
        }

        private void ActualizarDataGridView()
        {
            dataGridViewProductos.DataSource = null;
            dataGridViewProductos.DataSource = productos;
        }

        private void LimpiarCampos()
        {
            txtNombre.Text = "";
            txtPrecio.Text = "";
            txtCategoria.Text = "";
        }

        private void ActualizarPrecioPromedio()
        {
            if(productos.Count > 0)
            {
                var promedio = productos.Average(p => p.precio);
                lblPrecioPromedio.Text = $"Precio Promedio: {promedio:C}";
            }
            else
            {
                lblPrecioPromedio.Text = "Precio Promedio: $0.00";
            }
        }
    }
}
