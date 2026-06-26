using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClasesBase.services;
using ClasesBase;

namespace Vistas
{
    public partial class ConsultaProductos : Form
    {
        

        public ConsultaProductos()
        {
            InitializeComponent();
            
        }

        private void ConsultaProductos_Load(object sender, EventArgs e)
        {
            load_clientes();
            load_productos();
        }

        private void load_productos()
        {
            dgvProductos.DataSource = ProductoService.list_productos();
        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            if (txtBuscar.Text != "")
                dgvProductos.DataSource = ProductoService.search_productos(txtBuscar.Text);
            else
                load_productos();
        }

        private void btnModificar_Click_1(object sender, EventArgs e)
        {
            if (dgvProductos.CurrentRow != null)
            {
                string codigo = dgvProductos.CurrentRow.Cells["Código"].Value.ToString();

                AltaProductosForm form = new AltaProductosForm(codigo);

                form.ShowDialog();

                cargarProductosSegunOrden();
            }
            else
            {
                MessageBox.Show("Seleccione un producto");
            }
        }

        private void btnBorrar_Click_1(object sender, EventArgs e)
        {
            if (dgvProductos.CurrentRow != null)
            {
                string codigo = dgvProductos.CurrentRow.Cells["Código"].Value.ToString();

                DialogResult r = MessageBox.Show(
                    "¿Seguro que querés eliminar este producto?",
                    "Confirmar",
                    MessageBoxButtons.YesNo
                );

                if (r == DialogResult.Yes)
                {
                    ProductoService.delete_producto(codigo);
                    cargarProductosSegunOrden();
                }
            }
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            cargarProductosSegunOrden();

            if (rbDescripcion.Checked)
            {
                dgvProductos.DataSource = ProductoService.list_productos_por_descripcion_sp();
            }
            else if (rbCategoria.Checked)
            {
                dgvProductos.DataSource = ProductoService.list_productos_por_categoria_sp();
            }
            else
            { 
                MessageBox.Show("Seleccione una opción");
            }
        }

        private void cargarProductosSegunOrden()
        {
            if (rbDescripcion.Checked)
            {
                dgvProductos.DataSource = ProductoService.list_productos_por_descripcion_sp();
            }
            else if (rbCategoria.Checked)
            {
                dgvProductos.DataSource = ProductoService.list_productos_por_categoria_sp();
            }
            else
            {
                load_productos();
            }
        }

        private void load_clientes()
        {
            DataTable dt = ClienteService.findAllClientes();
            DataRow filaInformativa = dt.NewRow();

            filaInformativa["DNI"] = "";
            filaInformativa["NOMBRE"] = "Seleccione Cliente";

            cmBoxCliente.DisplayMember = "NOMBRE";
            cmBoxCliente.ValueMember = "DNI";

            dt.Rows.InsertAt(filaInformativa, 0);
            cmBoxCliente.DataSource = dt;
        }

        private void cmBoxCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmBoxCliente.SelectedValue != null)
            {
                string dniSeleccionado = cmBoxCliente.SelectedValue.ToString();
                DataTable dt = ProductoService.list_productos_por_cliente_sp(dniSeleccionado);

                dgvProductos.DataSource = dt;

                int total = 0;

                foreach (DataRow fila in dt.Rows)
                {
                    total += Convert.ToInt32(fila["Cantidad"]);
                }

                lblCantidadTotal.Text = "Total Productos Cliente: " + total;

            }

        }
        
        private void btnConsultarbyRango_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime fechaInicioSeleccionada = dtProductoInicio.Value;
                DateTime fechaFinSeleccionada = dtProductoFin.Value.AddDays(1);
                DataTable dtProducto = ProductoService.listar_productos_por_fecha_sp(fechaInicioSeleccionada, fechaFinSeleccionada);
                dgvProductos.DataSource = dtProducto;

                int total = 0;

                foreach (DataRow fila in dtProducto.Rows)
                {
                    total += Convert.ToInt32(fila["Cantidad"]);
                }

                lblCantidadTotal.Text = "Total Productos Vendidos: " + total;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al consultar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}