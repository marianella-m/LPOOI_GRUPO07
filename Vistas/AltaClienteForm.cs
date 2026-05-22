using System;
using System.Data;
using System.Windows.Forms;
using ClasesBase.services;

namespace Vistas
{
    public partial class AltaClienteForm : Form
    {
        ClienteService clienteService = new ClienteService();

        public AltaClienteForm()
        {
            InitializeComponent();
        }

        private void AltaClienteForm_Load(object sender, EventArgs e)
        {
            CargarObrasSociales();
        }

        private void CargarObrasSociales()
        {
            DataTable dt = clienteService.CargarObrasSociales();

            cmbObraSocial.DataSource = dt;
            cmbObraSocial.DisplayMember = "RAZON_SOCIAL";
            cmbObraSocial.ValueMember = "CUIT";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                clienteService.GuardarCliente(
                    txtDni.Text,
                    txtApellido.Text,
                    txtNombre.Text,
                    txtDireccion.Text,
                    txtNroCarnet.Text,
                    cmbObraSocial.SelectedValue.ToString()
                );

                MessageBox.Show("Cliente guardado correctamente");

                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar cliente: " + ex.Message);
            }
        }

        private void LimpiarCampos()
        {
            txtDni.Clear();
            txtApellido.Clear();
            txtNombre.Clear();
            txtDireccion.Clear();
            txtNroCarnet.Clear();

            if (cmbObraSocial.Items.Count > 0)
            {
                cmbObraSocial.SelectedIndex = 0;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
