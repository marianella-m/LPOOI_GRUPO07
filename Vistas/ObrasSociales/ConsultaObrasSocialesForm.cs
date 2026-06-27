using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClasesBase.services;

namespace Vistas
{
    public partial class ConsultaObrasSocialesForm : Form
    {
        ClienteService clienteService = new ClienteService();

        public ConsultaObrasSocialesForm()
        {
            InitializeComponent();
            this.Load += new EventHandler(ConsultaObrasSocialesForm_Load);
            cmbObraSocial.SelectionChangeCommitted += new EventHandler(cmbObraSocial_SelectionChangeCommitted);
        }

        private void ConsultaObrasSocialesForm_Load(object sender, EventArgs e)
        {
            // 1. Cargar el ComboBox
            DataTable dtObras = clienteService.CargarObrasSociales();
            cmbObraSocial.DataSource = dtObras;
            cmbObraSocial.DisplayMember = "RAZON_SOCIAL";
            cmbObraSocial.ValueMember = "CUIT";
            cmbObraSocial.SelectedIndex = -1;

            // 2. Intentar buscar y cargar la primera opción válida
            CargarPrimeraObraSocialValida(dtObras);
        }

        private void cmbObraSocial_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cmbObraSocial.SelectedIndex == -1) return;

            string osCuit = cmbObraSocial.SelectedValue.ToString();
            DataTable dt = ClienteService.BuscarClientesPorObraSocial(osCuit);

            // Validación: Si el usuario seleccionó una vacía
            if (dt == null || dt.Rows.Count == 0)
            {
                // 1. Ocultamos el grid inmediatamente para que no se vea vacío detrás del mensaje
                dgvClientes.Visible = false;
                lblCantidad.Text = "Cantidad de clientes: " + 0;

                // 2. Mostramos el mensaje emergente
                MessageBox.Show("Esa obra social no cuenta con ningún registro de cliente.", "Sin Registros", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // 3. Reutilizamos el módulo para restaurar la primera con datos
                DataTable dtObras = (DataTable)cmbObraSocial.DataSource;
                CargarPrimeraObraSocialValida(dtObras);
                return;
            }

            // Si tiene registros, procesa la carga con normalidad
            CargarYDimensionarGrid(dt);
        }

        /// <summary>
        /// Método modular que busca la primera obra social con registros y la muestra.
        /// </summary>
        private void CargarPrimeraObraSocialValida(DataTable dtObras)
        {
            if (dtObras != null && dtObras.Rows.Count > 0)
            {
                foreach (DataRow fila in dtObras.Rows)
                {
                    string cuit = fila["CUIT"].ToString();
                    DataTable dtClientes = ClienteService.BuscarClientesPorObraSocial(cuit);

                    if (dtClientes != null && dtClientes.Rows.Count > 0)
                    {
                        cmbObraSocial.SelectedValue = cuit;
                        CargarYDimensionarGrid(dtClientes);
                        return; // Se encontró una válida, finaliza el método exitosamente
                    }
                }
            }

            // Si ninguna obra social tiene datos en todo el DataTable
            dgvClientes.Visible = false;
            lblCantidad.Text = "No se encontraron obras sociales con clientes registrados.";
        }

        /// <summary>
        /// Método modular que maneja la carga de datos y el autoajuste de dimensiones.
        /// </summary>
        private void CargarYDimensionarGrid(DataTable dt)
        {
            dgvClientes.Visible = true;
            dgvClientes.DataSource = dt;
            dgvClientes.RowHeadersVisible = false;
            dgvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

            // Ajustar Ancho
            int anchoTotal = 0;
            foreach (DataGridViewColumn col in dgvClientes.Columns)
            {
                if (col.Visible) anchoTotal += col.Width;
            }
            dgvClientes.Width = anchoTotal + 2;

            // Ajustar Alto sin espacios grises residuales
            int altoTotal = dgvClientes.ColumnHeadersHeight;
            foreach (DataGridViewRow fila in dgvClientes.Rows)
            {
                if (fila.Visible) altoTotal += fila.Height;
            }

            int altoMaximo = 400;
            if (altoTotal > altoMaximo)
            {
                dgvClientes.Height = altoMaximo;
                dgvClientes.ScrollBars = ScrollBars.Both;
            }
            else
            {
                dgvClientes.Height = altoTotal + 2;
                dgvClientes.ScrollBars = ScrollBars.Horizontal;
            }

            lblCantidad.Text = "Cantidad de clientes: " + dt.Rows.Count.ToString();
        }
    }
}