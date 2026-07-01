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
    public partial class AltaProductosForm : FormBase
    {
        string verificacion;

        public AltaProductosForm(string codigo = null)
        {
            this.verificacion = codigo;
            InitializeComponent();
            if (!string.IsNullOrEmpty(codigo))
            {
                txtTitulo.Text = "Modificar Producto";
                //txtCodigo.Enabled = false;
                cargar_producto(codigo);
            }
        }

        private void cargar_producto(string codigo)
        {
            Producto p = ProductoService.buscarPorCodigo(codigo);

            if (p != null)
            {
                txtCategoria.Text = p.Prod_Categoria;
                txtDescripcion.Text = p.Prod_Descripcion;
                txtPrecio.Text = p.Prod_Precio.ToString();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (
                string.IsNullOrWhiteSpace(txtCategoria.Text) ||
                string.IsNullOrWhiteSpace(txtDescripcion.Text) ||
                string.IsNullOrWhiteSpace(txtPrecio.Text))
            {
                MessageBox.Show("Completa todos los campos");
                return;
            }

            decimal precio;
            if (!decimal.TryParse(txtPrecio.Text, out precio))
            {
                MessageBox.Show("Precio inválido");
                return;
            }
            if (precio < 0)
            {
                MessageBox.Show("El precio no puede ser negativo");
                return;
            }

            Producto p = new Producto(
             
                txtCategoria.Text,
                txtDescripcion.Text,
                precio
            );

            if (!string.IsNullOrEmpty(this.verificacion))
            {
                ProductoService.update_producto(
                    this.verificacion,
                    p.Prod_Categoria,
                    p.Prod_Descripcion,
                    p.Prod_Precio
                );

                MessageBox.Show("Producto modificado correctamente");
                this.showToast(lblToast, "Modificado exitosamente", Color.FromArgb(25, 80, 40), Color.FromArgb(220, 240, 225));
                this.Hide();
            }
            else
            {
                ProductoService.insert_producto(
                   
                    p.Prod_Categoria,
                    p.Prod_Descripcion,
                    p.Prod_Precio
                );

                this.showToast(lblToast, "Guardado exitosamente", Color.FromArgb(25, 80, 40), Color.FromArgb(220, 240, 225));

                txtCategoria.Clear();
                txtDescripcion.Clear();
                txtPrecio.Clear();
            }
        }

        private void AltaProductosForm_Load(object sender, EventArgs e)
        {

        }
    }
       
}
