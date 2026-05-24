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
    public partial class ConsultaProductos : Form
    {
        

        public ConsultaProductos()
        {
            InitializeComponent();
            
        }

        private void ConsultaProductos_Load(object sender, EventArgs e)
        {
            load_productos();
        }

        private void load_productos()
        {
            dgvProductos.DataSource = ProductoService.list_productos();
        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            if (txtBuscar.Text != "")
                dgvProductos.DataSource = ProductoService.search_productos(txtBuscar.Text);
            else
                load_productos();
        }

        private void btnModificar_Click_1(object sender, EventArgs e)
        {
            if (dgvProductos.CurrentRow != null)
            {
                string codigo = dgvProductos.CurrentRow.Cells["Código"].Value.ToString();

                AltaProductosForm form = new AltaProductosForm(codigo);

                form.ShowDialog();

                load_productos();
            }
            else
            {
                MessageBox.Show("Seleccione un producto");
            }
        }

        private void btnBorrar_Click_1(object sender, EventArgs e)
        {
            if (dgvProductos.CurrentRow != null)
            {
                string codigo = dgvProductos.CurrentRow.Cells["Código"].Value.ToString();

                DialogResult r = MessageBox.Show(
                    "¿Seguro que querés eliminar este producto?",
                    "Confirmar",
                    MessageBoxButtons.YesNo
                );

                if (r == DialogResult.Yes)
                {
                    ProductoService.delete_producto(codigo);
                    load_productos();
                }
            }
        }
    }
}