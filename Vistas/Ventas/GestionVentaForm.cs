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
using Vistas.Principal;

namespace Vistas
{
    public partial class GestionVentaForm : FormBase
    {
        public GestionVentaForm()
        {
            InitializeComponent();
        }

        Dictionary<String, DataGridViewRow> mapRowsItems;

        private void GestionVentaForm_Load(object sender, EventArgs e)
        {

            listViewProductos.Items.Clear();

            DataTable dtClientes = ClienteService.findAllClientes();

            dtClientes.Columns.Add("ClienteTexto", typeof(string),
                "IIF(DNI = '0', 'Seleccione...', NOMBRE + ' ' + APELLIDO + ' - ' + DNI)");

            DataRow defaultOptionRow = dtClientes.NewRow();
            defaultOptionRow["DNI"] = "0";
            dtClientes.Rows.InsertAt(defaultOptionRow, 0);

            cmbBoxClientes.DataSource = dtClientes;
            cmbBoxClientes.DisplayMember = "ClienteTexto";
            cmbBoxClientes.ValueMember = "DNI";

            DataTable tableProductos = ProductoService.list_productos();
            mapRowsItems = new Dictionary<String, DataGridViewRow>();

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
                    DataGridViewRow filaAEliminar = dataGridViewDetallesVenta.Rows[e.RowIndex];
                    string codigoProducto = filaAEliminar.Cells[0].Value.ToString();
                    dataGridViewDetallesVenta.Rows.RemoveAt(e.RowIndex);
                    mapRowsItems.Remove(codigoProducto);
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

                string codigoProducto = itemSeleccionado.Text;
                string nombreProducto = itemSeleccionado.SubItems[1].Text;
                string precioProducto = itemSeleccionado.SubItems[2].Text;

                float cantidadInicial = 1.0f;

                if (!mapRowsItems.ContainsKey(codigoProducto))
                {
                    // Agrega el producto a la grilla por primera vez
                    dataGridViewDetallesVenta.Rows.Add(codigoProducto, nombreProducto, precioProducto, cantidadInicial, float.Parse(precioProducto) * cantidadInicial);

                    // Guardamos la referencia de la fila recién creada en el mapa
                    DataGridViewRow lasRowDetalleVenta = dataGridViewDetallesVenta.Rows[dataGridViewDetallesVenta.RowCount - 1];
                    mapRowsItems.Add(codigoProducto, lasRowDetalleVenta);
                }
                else
                {
                    // El producto ya existe en el carrito, trabajamos directo sobre la fila guardada
                    DataGridViewRow rowProductoExistente = mapRowsItems[codigoProducto];

                    // 1. Sumamos 1 a la cantidad usando el índice de columna [3]
                    decimal cantidadActual = Convert.ToDecimal(rowProductoExistente.Cells[3].Value);
                    rowProductoExistente.Cells[3].Value = cantidadActual + 1;

                    // 2. Calculamos el nuevo subtotal usando los índices [2] (Precio) y [4] (Subtotal)
                    decimal productoPrecio = Convert.ToDecimal(rowProductoExistente.Cells[2].Value);
                    rowProductoExistente.Cells[4].Value = (cantidadActual + 1) * productoPrecio;

                    dataGridViewDetallesVenta.Refresh();
                }
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

        bool IsFormValid()
        {
            errorProviderVenta.Clear();

            int countErrors = 0;

            if (Convert.ToInt32(cmbBoxClientes.SelectedValue) == 0)
            {
                errorProviderVenta.SetError(cmbBoxClientes, "Por favor, seleccione un cliente para la venta.");
                countErrors++;
            }

            if (dataGridViewDetallesVenta.Rows.Count == 0)
            {
                errorProviderVenta.SetIconAlignment(dataGridViewDetallesVenta, ErrorIconAlignment.TopLeft);
                errorProviderVenta.SetIconPadding(dataGridViewDetallesVenta, 10);
                
                errorProviderVenta.SetError(dataGridViewDetallesVenta, "Por favor, cargue productos para registrar la venta.");
                countErrors++;
            }

            return countErrors == 0;
        }

  

        private void btnRegistrarVenta_Click(object sender, EventArgs e)
        {
            if (!IsFormValid())
                return;

            Venta venta = new Venta();
            string dniCliente = cmbBoxClientes.SelectedValue.ToString();
            venta.Cliente = new Cliente(dniCliente, null);
            venta.Fecha = dtTmPickerVenta.Value;

            List<VentaDetalle> ventaDetalles = new List<VentaDetalle>();

            foreach (DataGridViewRow rowDetalle in dataGridViewDetallesVenta.Rows)
            {
                VentaDetalle ventaDetalle = new VentaDetalle();

                string codigoProducto = Convert.ToString(rowDetalle.Cells[0].Value);
                decimal precioProducto = Convert.ToDecimal(rowDetalle.Cells[2].Value);
                ventaDetalle.Producto = new Producto(codigoProducto, precioProducto);

                ventaDetalle.Cantidad = Convert.ToDecimal(rowDetalle.Cells[3].Value);
                ventaDetalle.Total = Convert.ToDecimal(rowDetalle.Cells[4].Value);

                ventaDetalles.Add(ventaDetalle);
            }

            venta.detalles = ventaDetalles;
            VentaService.InsertVenta(venta);
            this.showToast(lblToast, "Venta registrada exitosamente", Color.FromArgb(25, 80, 40), Color.FromArgb(220, 240, 225));
            dataGridViewDetallesVenta.Rows.Clear();
            mapRowsItems.Clear();
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            ConsultaClientes consulta = new ConsultaClientes();
            consulta.ModoSeleccion = true;

            if (consulta.ShowDialog() == DialogResult.OK)
            {
                cmbBoxClientes.SelectedValue = consulta.ClienteSeleccionado.Cli_DNI;
            }
        }


    }
}
