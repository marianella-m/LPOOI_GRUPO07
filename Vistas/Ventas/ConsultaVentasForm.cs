using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClasesBase.services;

namespace Vistas
{
    public partial class ConsultaVentasForm : Form
    {

        private DataGridView ultimaGrillaSeleccionada = null;

        public ConsultaVentasForm()
        {
            InitializeComponent();
            // carga de combox clientes para seleccionar 
            load_combo_clientes();
        }

        private void ConsultaVentasForm_Load(object sender, EventArgs e)
        {
            //dtGridVentas.DataSource = VentaService.FindAllVentas();

        }

        // cargar clientes en combox 
        private void load_combo_clientes()
        {
            DataTable dtClientes = ClienteService.findAllClientes();
            DataRow filaInformativa = dtClientes.NewRow();

            filaInformativa["DNI"] = "";
            filaInformativa["NOMBRE"] = "Seleccione Usuario";

            dtClientes.Rows.InsertAt(filaInformativa, 0);

            comboClientes.DisplayMember = "NOMBRE";
            comboClientes.ValueMember = "DNI";
            comboClientes.DataSource = dtClientes;

            comboClientes.SelectedIndex = 0;
        }

        // Boton consultar ventas por cliente
        private void btnConsultarVentasCliente_Click(object sender, EventArgs e)
        {
            if (comboClientes.SelectedValue != null)
            {
                try
                {
                    string dniSeleccionado = comboClientes.SelectedValue.ToString();
                    DataTable dtVentas = VentaService.listar_ventas_por_cliente_sp(dniSeleccionado);
                    dtGridVentas.DataSource = dtVentas;

                    int totalRegistros = dtGridVentas.RowCount;
                    lblTotalVentasPorCliente.Text = "Total ventas " + comboClientes.Text + " : " + totalRegistros;
                    lblTotalVentasPorCliente.Visible = (totalRegistros > 0);


                    if (totalRegistros > 0)
                    {
                        decimal sumaAcumulada = Convert.ToDecimal(dtVentas.Compute("SUM([Total])", ""));

                        lblGastoAcumulado.Text = "Monto Total Acumulado: $ " + sumaAcumulada.ToString("N2");
                        lblGastoAcumulado.Visible = true;
                    }
                    else
                    {
                        lblGastoAcumulado.Visible = false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        // boton para consultar ventas entre fechas
        private void btnConsultarbyRango_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime fechaInicioSeleccionada = dtVentaInicio.Value;
                DateTime fechaFinSeleccionada = dtVentaFin.Value.AddMinutes(1);

                DataTable dtVentas = VentaService.listar_ventas_por_fecha_sp(fechaInicioSeleccionada, fechaFinSeleccionada);
                dtGridFechas.DataSource = dtVentas;

                int totalRegistros = dtGridFechas.RowCount;
                lblTotalVentasPorRangoFechas.Text = "Total ventas: " + totalRegistros;
                lblTotalVentasPorRangoFechas.Visible = (totalRegistros > 0);

                if (totalRegistros > 0)
                {
                    if (dtGridFechas.Columns["Total"] != null)
                    {
                        dtGridFechas.Columns["Total"].DefaultCellStyle.Format = "$ #,##0.00";
                    }
                    decimal sumaAcumulada = Convert.ToDecimal(dtVentas.Compute("SUM([Total])", ""));

                    lblGastoAcumuladoFechas.Text = "Monto Total Acumulado: $ " + sumaAcumulada.ToString("N2");
                    lblGastoAcumuladoFechas.Visible = true;
                }
                else
                {
                    lblGastoAcumuladoFechas.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al consultar por fechas: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnEliminarVenta_Click(object sender, EventArgs e)
        {
            if (ultimaGrillaSeleccionada == null || ultimaGrillaSeleccionada.CurrentRow == null)
            {
                MessageBox.Show("Por favor, haga clic sobre la venta que desea eliminar en cualquiera de las dos tablas.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Se pide confirmacion previa para elimnar 
            DialogResult resultado = MessageBox.Show("¿Está seguro de que desea eliminar la venta seleccionada? Esta acción borrará también sus detalles.", "Confirmar Baja", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                try
                {

                    int nroVenta = Convert.ToInt32(ultimaGrillaSeleccionada.CurrentRow.Cells["Número"].Value);

                    ClasesBase.services.VentaService.DeleteVenta(nroVenta);
                    // se muestra mensaje informativo de eliminacion
                    MessageBox.Show("La venta se ha eliminado correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // se actualiza grilla 
                    if (ultimaGrillaSeleccionada == dtGridVentas)
                    {
                        string dniSeleccionado = comboClientes.SelectedValue.ToString();
                        dtGridVentas.DataSource = ClasesBase.services.VentaService.listar_ventas_por_cliente_sp(dniSeleccionado);
                    }
                    else
                    {
                        dtGridFechas.DataSource = ClasesBase.services.VentaService.listar_ventas_por_fecha_sp(dtVentaInicio.Value, dtVentaFin.Value);
                    }

                    ultimaGrillaSeleccionada = null;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dtGridVentas_Click(object sender, EventArgs e)
        {
            dtGridFechas.ClearSelection();
            ultimaGrillaSeleccionada = dtGridVentas;
        }

        private void dtGridFechas_Click(object sender, EventArgs e)
        {
            dtGridVentas.ClearSelection(); // 
            ultimaGrillaSeleccionada = dtGridFechas;
        }

    }
}
