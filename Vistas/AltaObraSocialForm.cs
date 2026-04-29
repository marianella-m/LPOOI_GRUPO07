using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClasesBase;

namespace Vistas
{
    public partial class AltaObraSocialForm : Form
    {
        char REQUIRED_CHAR = '*';

        public AltaObraSocialForm()
        {
            InitializeComponent();
            setRequiredChar();
        }

        void setRequiredChar() { 
            lblCuit.Text += REQUIRED_CHAR;
            lblRazonSocial.Text += REQUIRED_CHAR;
            lblDireccion.Text += REQUIRED_CHAR;
            lblTelefono.Text += REQUIRED_CHAR;
        }

        private void validarCampos(StringBuilder errorMessageBuilder)
        {
            if (string.IsNullOrWhiteSpace(txtCuit.Text))
            {
                errorMessageBuilder.AppendLine("Cuit es campo requerido");
            }

            if (string.IsNullOrWhiteSpace(txtRazonSocial.Text))
            {
                errorMessageBuilder.AppendLine("Razón social es campo requerido");
            }

            if (string.IsNullOrWhiteSpace(txtDireccion.Text))
            {
                errorMessageBuilder.AppendLine("Dirección es campo requerido");
            }

            if (string.IsNullOrWhiteSpace(txtTelefono.Text))
            {
                errorMessageBuilder.AppendLine("Teléfono es campo requerido");
            }
        }


        void clearControls() {
            txtCuit.Clear();
            txtRazonSocial.Clear();
            txtDireccion.Clear();
            txtTelefono.Clear();
        }

        private void btnSaveObraSocial_Click(object sender, EventArgs e)
        {
            string cuit = txtCuit.Text;
            string razonSocial = txtRazonSocial.Text;
            string direccion = txtDireccion.Text;
            string telefono = txtTelefono.Text;

            StringBuilder errorMessageBuilder = new StringBuilder();

            validarCampos(errorMessageBuilder);

            if(!string.IsNullOrWhiteSpace(errorMessageBuilder.ToString())){
                MessageBox.Show(errorMessageBuilder.ToString(), "Validación de datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            string messageProperties = "\nCuit: " +
                cuit + "\nRazon Social: " +
                razonSocial + "\nDirección: " +
                direccion + "\nTeléfono: " +
                telefono;

            DialogResult dialogResult = MessageBox.Show("Desea guardar los datos de la obra social ?" + messageProperties, "Alta Obra Social", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            if (dialogResult == DialogResult.OK) {
                ObraSocial obraSocial = new ObraSocial(cuit, razonSocial, razonSocial, telefono);
                FormControlUtil.showToast(lblToast, "Guardado exitosamente", Color.FromArgb(25, 80, 40), Color.FromArgb(220, 240, 225));
                clearControls();
            }

           
        }

    }
}
