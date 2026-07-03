using System;
using System.Data;
using System.Windows.Forms;
using ClasesBase.services;
using ClasesBase;


namespace Vistas
{
    public partial class AltaClienteForm : Form
    {
        ClienteService clienteService = new ClienteService();
        ObraSocialService obraSocialService = new ObraSocialService();

        public AltaClienteForm()
        {
            InitializeComponent();
        }

        Cliente clienteModificado = null;

        public AltaClienteForm(Cliente cliente) 
        {
            InitializeComponent();

            lblTittle.Text = "Modificar Cliente";
            clienteModificado = cliente;
        }



        private void AltaClienteForm_Load(object sender, EventArgs e)
        {
            CargarObrasSociales();

            if(clienteModificado != null)
            {
                txtDni.Text = clienteModificado.Cli_DNI;
                txtNombre.Text = clienteModificado.Cli_Nombre;
                txtApellido.Text = clienteModificado.Cli_Apellido;
                txtDireccion.Text = clienteModificado.Cli_Direccion;
                txtNroCarnet.Text = clienteModificado.Cli_NroCarnet;
                cmbObraSocial.SelectedValue = clienteModificado.OS_CUIT;
                txtDni.Enabled = false;
            }
            
        }

        private void CargarObrasSociales()
        {
            DataTable dt = obraSocialService.obtenerTodas();

            DataRow defaultOptionRow = dt.NewRow();
            defaultOptionRow["CUIT"] = "0";
            defaultOptionRow["RAZON_SOCIAL"] = "Seleccione...";
            dt.Rows.InsertAt(defaultOptionRow, 0);

            cmbObraSocial.DataSource = dt;
            cmbObraSocial.DisplayMember = "RAZON_SOCIAL";
            cmbObraSocial.ValueMember = "CUIT";
        }

        bool IsValidForm()
        {   
            const string VALIDATE_MESSAGE = "Este campo es requerida.";
            errorProviderCliente.Clear();

            int countErrors = 0;

            if (Convert.ToInt64(cmbObraSocial.SelectedValue) == 0) 
            {
                errorProviderCliente.SetError(cmbObraSocial, VALIDATE_MESSAGE);
                countErrors++;
            }

            if (string.IsNullOrWhiteSpace(txtDni.Text))
            {
                errorProviderCliente.SetError(txtDni, VALIDATE_MESSAGE);
                countErrors++;
            }


            if (string.IsNullOrWhiteSpace(txtNroCarnet.Text))
            {
                errorProviderCliente.SetError(txtNroCarnet, VALIDATE_MESSAGE);
                countErrors++;
            }


            if (string.IsNullOrWhiteSpace(txtNombre.Text)) 
            {
                errorProviderCliente.SetError(txtNombre, VALIDATE_MESSAGE);
                countErrors++;
            }


            if (string.IsNullOrWhiteSpace(txtApellido.Text)) 
            {
                errorProviderCliente.SetError(txtApellido, VALIDATE_MESSAGE);
                countErrors++;
            }


            if (string.IsNullOrWhiteSpace(txtDireccion.Text)) 
            {
                errorProviderCliente.SetError(txtDireccion, VALIDATE_MESSAGE);
                countErrors++;
            }
                

            return countErrors == 0;
        }



        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!IsValidForm())
                return;

            try
            {
                if (clienteModificado == null)
                {
                    Cliente cliente = buildClienteFromForm();

                    clienteService.GuardarCliente(cliente);
                }
                else
                {
                    ClienteService.ModificarCliente(buildClienteFromForm());
                }

                MessageBox.Show("Cliente guardado correctamente");
                if (clienteModificado != null)
                    this.DialogResult = DialogResult.Cancel;
                else
                    LimpiarCampos();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar cliente: " + ex.Message);
            }
        }

        Cliente buildClienteFromForm()
        {
            return new Cliente(txtNombre.Text,
                        txtApellido.Text, txtDni.Text, txtDireccion.Text,
                        cmbObraSocial.SelectedValue.ToString(), txtNroCarnet.Text);
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
