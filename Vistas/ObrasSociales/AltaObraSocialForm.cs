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
    public partial class AltaObraSocialForm : FormBase
    {
        char REQUIRED_CHAR = '*';                                                
        ObraSocialService service;

        public AltaObraSocialForm()
        {
            InitializeComponent();
            setRequiredChar();
            service = new ObraSocialService();
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

            if (service.buscarPorCuit(txtCuit.Text) != null)
            {
                errorMessageBuilder.AppendLine("Cuit ya esta registrado");
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
            
            string messageProperties = "CUIT: " +
                cuit + "\nRazón Social: " +
                razonSocial + "\nDirección: " +
                direccion + "\nTeléfono: " +
                telefono;

            DialogResult dialogResult = MessageBox.Show("¿Seguro que quieres guardar esta obra social?\n\n" + messageProperties, "Confirmar guardado", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes) {
                ObraSocial obraSocial = new ObraSocial(cuit, razonSocial, direccion, telefono);
                service.guardar(obraSocial);
                this.showToast(lblToast, "Guardado exitosamente", Color.FromArgb(25, 80, 40), Color.FromArgb(220, 240, 225));
                clearControls();
            }

        }
    }
}
