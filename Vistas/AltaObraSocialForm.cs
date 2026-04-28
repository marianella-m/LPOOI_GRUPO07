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
        private string PLACEHOLDER_CUIT = "Ingrese Cuit";
        private string PLACEHOLDER_RAZON_SOCIAL = "Ingrese Razon Social";
        private string PLACEHOLDER_DIRECCION = "Ingrese Dirección";
        private string PLACEHOLDER_TELEFONO = "Ingrese Teléfono";

        public AltaObraSocialForm()
        {
            InitializeComponent();
            
            Color placeholderColor = Color.Gray;

            FormControlUtil.configTextBox(txtCuit, PLACEHOLDER_CUIT, placeholderColor);

            FormControlUtil.configTextBox(txtRazonSocial, PLACEHOLDER_RAZON_SOCIAL, placeholderColor);

            FormControlUtil.configTextBox(txtDireccion, PLACEHOLDER_DIRECCION, placeholderColor);

            FormControlUtil.configTextBox(txtTelefono, PLACEHOLDER_TELEFONO, placeholderColor);

        }

        private void btnSaveObraSocial_Click(object sender, EventArgs e)
        {
            string cuit = txtCuit.Text;
            string razonSocial = txtRazonSocial.Text;
            string direccion = txtDireccion.Text;
            string telefono = txtTelefono.Text;

            string messageProperties = "\nCuit: " +
                cuit + "\nRazon Social: " +
                razonSocial + "\nDirección: " +
                direccion + "\nTeléfono: " +
                telefono;
        

            DialogResult dialogResult = MessageBox.Show("Desea guardar los datos de la obra social ?" + messageProperties, "Alta Obra Social", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            if (dialogResult == DialogResult.OK) { 
                ObraSocial obraSocial = new ObraSocial();
                obraSocial.OS_CUIT = cuit;
                obraSocial.OS_RazonSocial = razonSocial;
                obraSocial.OS_Direccion = direccion;
                obraSocial.OS_Telefono = telefono;
                Console.WriteLine("GUARDADO EXITOSO");
            }
                

            
        }

        private void txtCuit_Enter(object sender, EventArgs e)
        {
            if (txtCuit.Text == "Ingrese Cuit")
            {
                txtCuit.Text = "";
                txtCuit.ForeColor = Color.Black;
            }
        }

        private void txtCuit_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCuit.Text))
            {
                txtCuit.Text = "Ingrese Cuit";
                txtCuit.ForeColor = Color.Gray;
            }
        }

        


    }
}
