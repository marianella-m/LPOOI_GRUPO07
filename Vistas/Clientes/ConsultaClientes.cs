using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClasesBase.services;
using ClasesBase;

namespace Vistas
{
    public partial class ConsultaClientes : Form
    {
        public bool ModoSeleccion { get; set; }
        public Cliente ClienteSeleccionado { get; private set; }
        public ConsultaClientes()
        {
            InitializeComponent();
            dtGridClientes.DataSource = ClienteService.FindByDniApellidoNombre(null, null, null, null);
        }
        private void btnBuscarClientes_Click(object sender, EventArgs e)
        {   
            string dni = txtDni.Text;
            string apellido = txtApellido.Text;
            string nombre = txtNombre.Text;
            string categoria = cmbCategoria.Text;
            dtGridClientes.DataSource = ClienteService.FindByDniApellidoNombre(dni, apellido, nombre, categoria);
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

            Cliente clienteSeleccionado = mapClienteForRow(dtGridClientes.CurrentRow);
            AltaClienteForm form = new AltaClienteForm(clienteSeleccionado);

            DialogResult resultado = form.ShowDialog();
            
            if (resultado == DialogResult.Cancel)
                dtGridClientes.DataSource = ClienteService.FindByDniApellidoNombre(null, null, null,null);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {   
            DialogResult dialogResult = MessageBox.Show("¿Seguro que quieres eliminar este cliente?\n\n", "Confirmar Eliminacíón", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                string dniCliente = dtGridClientes.CurrentRow.Cells["Dni"].Value.ToString();
                ClienteService.EliminarCliente(dniCliente);
                dtGridClientes.DataSource = ClienteService.FindByDniApellidoNombre(null, null, null, null);
            }

        }

        static Cliente mapClienteForRow(DataGridViewRow currentRow) 
        {
            string dni = currentRow.Cells["Dni"].Value.ToString();
            string apellido = currentRow.Cells["Apellido"].Value.ToString();
            string nombre = currentRow.Cells["Nombre"].Value.ToString();
            string direccion = currentRow.Cells["Dirección"].Value.ToString();
            string nroCarnet = currentRow.Cells["Número carnet"].Value.ToString();
            string cuitObraSocial = currentRow.Cells["Cuit obra social"].Value.ToString();

            return new Cliente(nombre, apellido, dni, direccion, cuitObraSocial, nroCarnet);
            
        }

        private void ConsultaClientes_Load(object sender, EventArgs e)
        {
            cmbCategoria.Items.Add("Dni");
            cmbCategoria.Items.Add("Apellido");
            cmbCategoria.Items.Add("Nombre");
            cmbCategoria.Items.Add("Dirección");
            cmbCategoria.Items.Add("Número carnet");
            cmbCategoria.Items.Add("Cuit obra social");
            cmbCategoria.SelectedIndex = 0;

            btnSeleccionar.Visible = ModoSeleccion;
            btnActualizar.Visible = !ModoSeleccion;
            btnEliminar.Visible = !ModoSeleccion;
        }

        private void btnSeleccionar_Click_1(object sender, EventArgs e)
        {
            if (dtGridClientes.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un cliente.");
                return;
            }

            ClienteSeleccionado = mapClienteForRow(dtGridClientes.CurrentRow);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }


    }
}
