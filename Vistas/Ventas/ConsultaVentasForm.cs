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
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al consultar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnConsultarbyRango_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime fechaInicioSeleccionada = dtVentaInicio.Value;
                DateTime fechaFinSeleccionada = dtVentaFin.Value;
                DataTable dtVentas = VentaService.listar_ventas_por_fecha_sp(fechaInicioSeleccionada, fechaFinSeleccionada);
                dtGridFechas.DataSource = dtVentas;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al consultar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
