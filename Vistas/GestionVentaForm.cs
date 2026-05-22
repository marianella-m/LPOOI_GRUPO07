using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClasesBase;
using ClasesBase.services;

namespace Vistas
{
    public partial class GestionVentaForm : Form
    {
        public GestionVentaForm()
        {
            InitializeComponent();
        }

        private void GestionVentaForm_Load(object sender, EventArgs e)
        {

            listViewProductos.Items.Clear();

            /*
            listViewProductos.View = View.Details;
            listViewProductos.FullRowSelect = true;
            listViewProductos.GridLines = true;

            listViewProductos.Columns.Add("Código", 70);
            listViewProductos.Columns.Add("Descripción", 220);
            listViewProductos.Columns.Add("Precio", 90);    
            */
            DataTable tableClientes = ClienteService.findAllClientes();

            tableClientes.Columns.Add("ClienteTexto", typeof(string), "NOMBRE + ' ' + APELLIDO + ' - ' + DNI");

            cmbBoxClientes.DataSource = tableClientes;

            cmbBoxClientes.DisplayMember = "ClienteTexto";
            cmbBoxClientes.ValueMember = "DNI"; 

            DataTable tableProductos = ProductoService.list_productos();

            foreach(DataRow productoRow in tableProductos.Rows)
            {
                ListViewItem listItem = new ListViewItem(productoRow["Código"].ToString());
                listItem.SubItems.Add(productoRow["Descripción"].ToString());
                listItem.SubItems.Add(productoRow["Precio"].ToString());
                listViewProductos.Items.Add(listItem);
            }

        }

        private void dataGridViewDetallesVenta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5 && e.RowIndex >= 0)
            {
                DialogResult respuesta = MessageBox.Show("¿Quitar este producto?", "Confirmar",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (respuesta == DialogResult.Yes)
                {
                    dataGridViewDetallesVenta.Rows.RemoveAt(e.RowIndex);
                }
            }

            if (e.ColumnIndex == 2 && e.RowIndex >= 0)
            {
                DialogResult respuesta = MessageBox.Show("¿Quitar este producto?", "Confirmar",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (respuesta == DialogResult.Yes)
                {
                    dataGridViewDetallesVenta.Rows.RemoveAt(e.RowIndex);
                }
            }
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            if (listViewProductos.SelectedItems.Count > 0)
            {
                ListViewItem itemSeleccionado = listViewProductos.SelectedItems[0];

                string idProducto = itemSeleccionado.Text;

                string nombreProducto = itemSeleccionado.SubItems[1].Text;
                string precioProducto = itemSeleccionado.SubItems[2].Text;

                float cantidadInicial = 1.0f;

                dataGridViewDetallesVenta.Rows.Add(idProducto, nombreProducto, precioProducto, cantidadInicial, float.Parse(precioProducto) * cantidadInicial);
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un producto de la lista primero.",
                                "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dataGridViewDetallesVenta_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3 && e.RowIndex >= 0)
            {
                DataGridViewRow fila = dataGridViewDetallesVenta.Rows[e.RowIndex];

                float precio = Convert.ToSingle(fila.Cells[2].Value);
                float cantidad = Convert.ToSingle(fila.Cells[3].Value);

                float subtotal = precio * cantidad;

                fila.Cells[4].Value = subtotal;

                //ActualizarTotalGeneral();
            }
        }

        private void btnRegistrarVenta_Click(object sender, EventArgs e)
        {
            Venta venta = new Venta();

            if (cmbBoxClientes.SelectedValue != null)
            {
                string dniCliente = cmbBoxClientes.SelectedValue.ToString();
                venta.Cliente = new Cliente(dniCliente);

            }
            else
            {
                MessageBox.Show("Por favor, seleccione un cliente para la venta.", "Aviso");
            }


            venta.Fecha = dtTmPickerVenta.Value ;

            List<VentaDetalle> ventaDetalles = new List<VentaDetalle>();

            foreach (DataGridViewRow rowDetalle in dataGridViewDetallesVenta.Rows)
            {
                VentaDetalle ventaDetalle = new VentaDetalle();

                string codigoProducto = Convert.ToString(rowDetalle.Cells[0].Value);
                ventaDetalle.Producto = new Producto(codigoProducto);

                ventaDetalle.Cantidad = Convert.ToDecimal(rowDetalle.Cells[3].Value);
                ventaDetalle.Total = Convert.ToDecimal(rowDetalle.Cells[4].Value);


                ventaDetalles.Add(ventaDetalle);
            }

            venta.detalles = ventaDetalles;

            VentaService.InsertVenta(venta);
        }




    }
}
