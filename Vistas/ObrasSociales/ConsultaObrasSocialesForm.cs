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
        private ObraSocialService obraSocialService = new ObraSocialService();

        public ConsultaObrasSocialesForm()
        {
            InitializeComponent();
            this.Load += new EventHandler(ConsultaObrasSocialesForm_Load);
            this.Shown += new EventHandler(ConsultaObrasSocialesForm_Shown);
            cmbObraSocial.SelectionChangeCommitted += new EventHandler(cmbObraSocial_SelectionChangeCommitted);
        }

        /// <summary>
        /// Carga la lista deplegable con los datos de las obras sociales registradas.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ConsultaObrasSocialesForm_Load(object sender, EventArgs e)
        {
            DataTable dtObras = obraSocialService.obtenerTodas();
            cargarComboBoxObrasSociales(dtObras);
        }

        private void ConsultaObrasSocialesForm_Shown(object sender, EventArgs e)
        {
            DataTable dtObras = (DataTable)cmbObraSocial.DataSource;
            
            if (existenClientesRegistrados(dtObras))
            {
                cargarComboBoxObrasSociales(dtObras);
                datosPrimerObraSocial(dtObras);
            }
            
        }
        
        /// <summary>
        /// Muestra mensaje si no hay clientes asociados a la obra social seleccionada.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbObraSocial_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cmbObraSocial.SelectedIndex == -1) return;

            string osCuit = cmbObraSocial.SelectedValue.ToString();
            DataTable dt = ClienteService.BuscarClientesPorObraSocial(osCuit);

            if (dt == null || dt.Rows.Count == 0)
            {
                dgvClientes.Visible = false;
                lblCantidad.Text = "Cantidad de clientes: 0";

                MessageBox.Show("Esa obra social no cuenta con ningún registro de cliente.", "Sin Registros", MessageBoxButtons.OK, MessageBoxIcon.Information);

                DataTable dtObras = (DataTable)cmbObraSocial.DataSource;
                datosPrimerObraSocial(dtObras);
                return;
            }

            cargarDatos(dt);
        }

        /// <summary>
        /// Carga las obras sociales en el control ComboBox.
        /// </summary>
        private void cargarComboBoxObrasSociales(DataTable dtObras)
        {
            cmbObraSocial.DataSource = dtObras;
            cmbObraSocial.DisplayMember = "RAZON_SOCIAL";
            cmbObraSocial.ValueMember = "CUIT";
            cmbObraSocial.SelectedIndex = -1;
        }

        /// <summary>
        /// Analiza si existen clientes cargados en el sistema bajo alguna obra social.
        /// Si no hay, muestra un mensaje con redirección opcional al registro de un cliente.
        /// </summary>
        private bool existenClientesRegistrados(DataTable dtObras)
        {
            bool existenClientes = false;

            if (dtObras != null && dtObras.Rows.Count > 0)
            {
                foreach (DataRow fila in dtObras.Rows)
                {
                    string cuit = fila["CUIT"].ToString();
                    DataTable dtClientes = ClienteService.BuscarClientesPorObraSocial(cuit);

                    if (dtClientes != null && dtClientes.Rows.Count > 0)
                    {
                        existenClientes = true;
                        break;
                    }
                }
            }

            if (!existenClientes)
            {
                dgvClientes.Visible = false;

                DialogResult respuesta = MessageBox.Show(
                    "No hay clientes registrados con ninguna obra social.\n\n¿Desea registrar un cliente?",
                    "Sin Registros",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (respuesta == DialogResult.Yes)
                {
                    redirigirAltaCliente();
                }

                return false;
            }

            return true;
        }

        /// <summary>
        /// Muestra la primera coincidencia, para mostrar en la tabla, con datos de una obra social con clientes.
        /// </summary>
        private void datosPrimerObraSocial(DataTable dtObras)
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
                        cargarDatos(dtClientes);
                        return;
                    }
                }
            }
        }

        /// <summary>
        /// Gestiona la navegación interna dentro del contenedor dinámico Home
        /// </summary>
        private void redirigirAltaCliente()
        {
            foreach (Form f in Application.OpenForms)
            {
                if (f is Home)
                {
                    Home homeForm = (Home)f;
                    Panel pnl = homeForm.Controls["pnlContent"] as Panel;

                    if (pnl != null)
                    {
                        homeForm.Navigate(pnl, new AltaClienteForm());
                    }
                    return;
                }
            }
        }

        /// <summary>
        /// Carga las filas de la tabla y redimensiona su tamaño segun la cantidad de filas.
        /// </summary>
        private void cargarDatos(DataTable dt)
        {
            dgvClientes.Visible = true;
            dgvClientes.DataSource = dt;
            dgvClientes.RowHeadersVisible = false;
            dgvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            int anchoTotal = 0;
            int margenAmpliacion = 20;

            foreach (DataGridViewColumn col in dgvClientes.Columns)
            {
                if (col.Visible) anchoTotal += col.Width;
            }

            dgvClientes.Width = anchoTotal + margenAmpliacion + 2;

            int altoCabecera = dgvClientes.ColumnHeadersHeight;
            int altoFilaPredeterminado = dgvClientes.RowTemplate.Height;
            int totalFilas = dgvClientes.Rows.Count;

            int altoMaximoPermitido = altoCabecera + (altoFilaPredeterminado * 9);
            int altoTotalReal = altoCabecera;

            foreach (DataGridViewRow fila in dgvClientes.Rows)
            {
                if (fila.Visible) altoTotalReal += fila.Height;
            }

            if (totalFilas > 9)
            {
                dgvClientes.Height = altoMaximoPermitido + 2;
                dgvClientes.ScrollBars = ScrollBars.Vertical;
            }
            else
            {
                dgvClientes.Height = altoTotalReal + 2;
                dgvClientes.ScrollBars = ScrollBars.None;
            }

            lblCantidad.Text = "Cantidad de clientes: " + dt.Rows.Count.ToString();
        }
    }
}