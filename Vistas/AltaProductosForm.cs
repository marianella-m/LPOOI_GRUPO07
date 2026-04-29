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
    public partial class AltaProductosForm : Form
    {
        public AltaProductosForm()
        {
            InitializeComponent();
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
               
                if (string.IsNullOrWhiteSpace(txtCodigo.Text) ||
                    string.IsNullOrWhiteSpace(txtCategoria.Text) ||
                    string.IsNullOrWhiteSpace(txtDescripcion.Text) ||
                    string.IsNullOrWhiteSpace(txtPrecio.Text))
                {
                    MessageBox.Show("Completa todos los campos");
                    return;
                }
                

                string codigo = txtCodigo.Text;
                string categoria = txtCategoria.Text;
                string descripcion = txtDescripcion.Text;
                decimal precio = Convert.ToDecimal(txtPrecio.Text);

                Producto p = new Producto(codigo, categoria, descripcion, precio);

                DialogResult resultado = MessageBox.Show(
                    "¿Seguro que quieres guardar este producto?\n\n" +
                    "Código: " + codigo + "\n" +
                    "Descripción: " + descripcion + "\n" +
                    "Precio: " + precio,
                    "Confirmar guardado",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (resultado == DialogResult.No)
                {
                    return;
                }

                ProductoService.AgregarProducto(p);

                txtCodigo.Clear();
                txtCategoria.Clear();
                txtDescripcion.Clear();
                txtPrecio.Clear();

                FormControlUtil.showToast(lblToast, "Guardado exitosamente", Color.FromArgb(25, 80, 40), Color.FromArgb(220, 240, 225));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        

    }

       
}
