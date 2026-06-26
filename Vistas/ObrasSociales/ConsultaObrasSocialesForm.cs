using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        }

        private void ConsultaObrasSocialesForm_Load(object sender, EventArgs e)
        {
            cmbObraSocial.DataSource = clienteService.CargarObrasSociales();
            cmbObraSocial.DisplayMember = "RAZON_SOCIAL";
            cmbObraSocial.ValueMember = "CUIT";
            cmbObraSocial.SelectedIndex = -1;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (cmbObraSocial.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione una obra social.");
                return;
            }

            string osCuit = cmbObraSocial.SelectedValue.ToString();

            DataTable dt = ClienteService.BuscarClientesPorObraSocial(osCuit);

            dgvClientes.DataSource = dt;

            lblCantidad.Text = "Cantidad de clientes: " + dt.Rows.Count.ToString();
        }
    }
}
