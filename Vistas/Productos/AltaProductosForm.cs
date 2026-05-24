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
                txtCodigo.Enabled = false;
                cargar_producto(codigo);
            }
        }

        private void cargar_producto(string codigo)
        {
            Producto p = ProductoService.buscarPorCodigo(codigo);

            if (p != null)
            {
                txtCodigo.Text = p.Prod_Codigo;
                txtCategoria.Text = p.Prod_Categoria;
                txtDescripcion.Text = p.Prod_Descripcion;
                txtPrecio.Text = p.Prod_Precio.ToString();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCodigo.Text) ||
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

            Producto p = new Producto(
                txtCodigo.Text,
                txtCategoria.Text,
                txtDescripcion.Text,
                precio
            );

            if (!string.IsNullOrEmpty(this.verificacion))
            {
                ProductoService.update_producto(
                    p.Prod_Codigo,
                    p.Prod_Categoria,
                    p.Prod_Descripcion,
                    p.Prod_Precio
                );


                this.showToast(lblToast, "Modificado exitosamente", Color.FromArgb(25, 80, 40), Color.FromArgb(220, 240, 225));
                this.Hide();
            }
            else
            {
                ProductoService.insert_producto(
                    p.Prod_Codigo,
                    p.Prod_Categoria,
                    p.Prod_Descripcion,
                    p.Prod_Precio
                );

                this.showToast(lblToast, "Guardado exitosamente", Color.FromArgb(25, 80, 40), Color.FromArgb(220, 240, 225));

                txtCodigo.Clear();
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
