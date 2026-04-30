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

namespace Vistas
{
    public partial class AltaClienteForm : Form
    {
        public AltaClienteForm()
        {
            InitializeComponent();
        }

        private void btnRegistrarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtNombreCliente.Text)
                    || string.IsNullOrWhiteSpace(txtApellidoCliente.Text)
                    || string.IsNullOrWhiteSpace(txtDNICliente.Text)
                    || string.IsNullOrWhiteSpace(txtDireccionCliente.Text)
                    || string.IsNullOrWhiteSpace(txtCUITCliente.Text)
                    || string.IsNullOrWhiteSpace(txtNcarnetCliente.Text)
                   )
                {

                    MessageBox.Show("Existen campos sin completar", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    return;
                }

                string nombre = txtNombreCliente.Text;
                string apellido = txtApellidoCliente.Text;
                string dni = txtDNICliente.Text;
                string direccion = txtDireccionCliente.Text;
                string cuit = txtCUITCliente.Text;
                string nCarnet = txtNcarnetCliente.Text;

                Cliente c = new Cliente(nombre, apellido, dni, direccion, cuit, nCarnet);

                DialogResult resultado = MessageBox.Show(
                    "¿Desea guardar los cambios del cliente?\n\n" +
                    "Nombre: " + nombre + "\n" +
                    "Apellido: " + apellido + "\n" +
                    "DNI: " + dni + "\n" +
                    "Direccion: " + direccion +"\n"+
                    "CUIT: " + cuit +"\n"+
                    "Carnet: " + nCarnet + "\n"
                    , "Confirmar guardado",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (resultado == DialogResult.No)
                {
                    return;
                }

                ClienteService.AgregarCliente(c);

                txtNombreCliente.Clear();
                txtApellidoCliente.Clear();
                txtDNICliente.Clear();
                txtDireccionCliente.Clear();
                txtCUITCliente.Clear();
                txtNcarnetCliente.Clear();

                FormControlUtil.showToast(lblToast, "Guardado exitosamente", Color.FromArgb(25, 80, 40), Color.FromArgb(220, 240, 225));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
