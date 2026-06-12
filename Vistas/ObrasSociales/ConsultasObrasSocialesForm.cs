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

namespace Vistas.ObrasSociales
{
    public partial class ConsultasObrasSocialesForm : FormBase
    {
        public ConsultasObrasSocialesForm()
        {
            InitializeComponent();
        }

        private void ConsultasObrasSocialesForm_Load(object sender, EventArgs e)
        {

            dataGridView1.DataSource = ObraSocialService.FindAllObrasSociales();

        }

        private void btnEliminarObraSocial_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                string cuitObra = dataGridView1.CurrentRow.Cells["Cuit"].Value.ToString();

                DialogResult r = MessageBox.Show(
                    "¿Seguro que querés eliminar esta Obra Social?",
                    "Confirmar",
                    MessageBoxButtons.YesNo
                );

                if (r == DialogResult.Yes)
                {
                    ObraSocialService.EliminarObraSocial(cuitObra);
                    dataGridView1.DataSource = ObraSocialService.FindAllObrasSociales();

                }
            }
        }






        private void btnModificarObraSocial_Click(object sender, EventArgs e)
        {
            ObraSocial obraSocialSeleccionada = mapObraSocialForRow(dataGridView1.CurrentRow);
            AltaObraSocialForm form = new AltaObraSocialForm(obraSocialSeleccionada);

            DialogResult resultado = form.ShowDialog();

            if (resultado == DialogResult.Cancel)
                dataGridView1.DataSource = ObraSocialService.FindByDniCuitOS(null, null);

        }


        static ObraSocial mapObraSocialForRow(DataGridViewRow currentRow)
        {

            string cuit = currentRow.Cells["Cuit"].Value.ToString();
            string razonSocial = currentRow.Cells["Razón Social"].Value.ToString();
            string direccion = currentRow.Cells["Dirección"].Value.ToString();
            string telefono = currentRow.Cells["Teléfono"].Value.ToString();

            return new ObraSocial(cuit, razonSocial, direccion, telefono);

        }



        private void btnSaveObraSocial_Click(object sender, EventArgs e)
        {
            string cuit = txtCuit.Text;
            string razonSocial = txtRazonSocial.Text;
            string direccion = txtDireccion.Text;
            string telefono = txtTelefono.Text;

            StringBuilder errorMessageBuilder = new StringBuilder();

            validarCampos(errorMessageBuilder);

            if (!string.IsNullOrWhiteSpace(errorMessageBuilder.ToString()))
            {
                MessageBox.Show(errorMessageBuilder.ToString(), "Validación de datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string messageProperties = "CUIT: " +
                cuit + "\nRazón Social: " +
                razonSocial + "\nDirección: " +
                direccion + "\nTeléfono: " +
                telefono;

            DialogResult dialogResult = MessageBox.Show("¿Seguro que quieres guardar esta obra social?\n\n" + messageProperties, "Confirmar guardado", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                ObraSocial obraSocial = new ObraSocial(cuit, razonSocial, direccion, telefono);
                ObraSocialService.saveObraSocial(cuit, razonSocial, direccion, telefono);

                this.showToast(lblToast, "Guardado exitosamente", Color.FromArgb(25, 80, 40), Color.FromArgb(220, 240, 225));
                clearControls();
            }

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


        void clearControls()
        {
            txtCuit.Clear();
            txtRazonSocial.Clear();
            txtDireccion.Clear();
            txtTelefono.Clear();
        }



    }
}
