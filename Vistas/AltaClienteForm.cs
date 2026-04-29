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
    public partial class AltaClienteForm : Form
    {
        public AltaClienteForm()
        {
            InitializeComponent();
        }

        private void btnRegistrarCliente_Click(object sender, EventArgs e)
        {


            var save = MessageBox.Show("Desea guardar cambios?", "Atencion", MessageBoxButtons.YesNo);
            if (save == DialogResult.Yes)
            {

                this.Hide(); //cerrando la ventana anterior

                string nombre = txtNombreCliente.Text;
                string apellido = txtApellidoCliente.Text;
                string dni = txtDNICliente.Text;
                string direccion = txtDireccionCliente.Text;
                string cuit = txtCUITCliente.Text;
                string nCarnet = txtNcarnetCliente.Text;

                //mostrando datos por msgbox
                MessageBox.Show("USUARIO REGISTRADO! \nNOMBRE: " + nombre + "\nAPELLIDO: " + apellido +
                    "\nDNI: " + dni + "\nDIRECCION: " + direccion + "\nCUIT: " + cuit
                     + "\nNº DE CARNET : " + nCarnet);

            }

        }

        // boton volver en alta cliente
        private void btnAtrasFormCliente_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }


    }
}
