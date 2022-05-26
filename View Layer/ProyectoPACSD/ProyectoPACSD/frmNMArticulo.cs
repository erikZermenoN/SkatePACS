using BML;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPACSD
{
    public partial class frmNMArticulo : DevExpress.XtraEditors.XtraForm
    {
        private int idArticulo = 0;

        #region Constructores
        public frmNMArticulo()// Constructor para un nuevo registro
        {
            InitializeComponent();
            this.Text = "Nuevo Articulo";
            categoriaBindingSource.DataSource = new Categoria().GetAll();
            proveedorBindingSource.DataSource = new Proveedor().GetAll();
            txtCodigo.Focus();        
        }

        public frmNMArticulo(int idArticulo)// Constructor para modificar un registro
        {
            InitializeComponent();
            categoriaBindingSource.DataSource = new Categoria().GetAll();
            proveedorBindingSource.DataSource = new Proveedor().GetAll();
            this.Text = "Modificar Articulo";
            this.idArticulo = idArticulo;
            Articulo articulo = new Articulo() { idArticulo = idArticulo }.GetById();
            txtCodigo.Text = articulo.codigo;
            txtNombre.Text = articulo.nombre;
            txtDescripcion.Text = articulo.descripcion;
            txtPrecio.Text = articulo.precio.ToString();
            txtExistencia.Text = articulo.existencia.ToString();
            txtImagen.Text = articulo.imagen;
            lupCategoria.EditValue = articulo.idCategoria;
            lupProveedor.EditValue = articulo.idProveedor;
            txtCodigo.Focus();         
        }
        #endregion

        #region Botones
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (idArticulo == 0)// Se ejecuta si se esta agregando nuevo articulo
            {
                if (validar())
                {
                    if (new Articulo() {
                        idCategoria = Convert.ToInt32(lupCategoria.EditValue),
                        idProveedor = Convert.ToInt32(lupProveedor.EditValue),
                        nombre = txtNombre.Text,
                        descripcion = txtDescripcion.Text,
                        codigo = txtCodigo.Text,
                        precio = Convert.ToDouble(txtPrecio.Text),
                        existencia = Convert.ToInt32(txtExistencia.Text),
                        imagen = txtImagen.Text
                    }.Add() > 0)
                    {

                        MessageBox.Show("El articulo se a registrado correctamente", Application.ProductName,
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Clean();

                    }
                    else
                    {
                        MessageBox.Show("A ocurrido un error. Vuelve a intentarlo", Application.ProductName,
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
            else// Se ejecuta si se esta modificando un articulo
            {
                if (validar())
                {
                    if (new Articulo()
                    {
                        idArticulo = this.idArticulo,
                        idCategoria = Convert.ToInt32(lupCategoria.EditValue),
                        idProveedor = Convert.ToInt32(lupProveedor.EditValue),
                        nombre = txtNombre.Text,
                        descripcion = txtDescripcion.Text,
                        codigo = txtCodigo.Text,
                        precio = Convert.ToDouble(txtPrecio.Text),
                        existencia = Convert.ToInt32(txtExistencia.Text),
                        imagen = txtImagen.Text
                    }.Update() > 0)
                    {
                        MessageBox.Show("El articulo se a modificado correctamente", Application.ProductName,
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Clean();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("A ocurrido un error. Vuelve a intentarlo", Application.ProductName,
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        #endregion

        #region Revisión de campos
        private bool Check() // Revisa almenos uno de los campos esten lleno
        {
            if (txtCodigo.Text != "" || txtNombre.Text != "" ||
                txtDescripcion.Text != "" || txtPrecio.Text != "" ||
                txtExistencia.Text != "" || txtImagen.Text != "" ||
                lupCategoria.EditValue != null || lupProveedor.EditValue != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private bool validar()
        {
            var ban = false;
            if (txtCodigo.EditValue == null || txtCodigo.Text.Equals(""))
            {
                txtCodigo.ErrorText = "Ingrese el codigo del producto";
                txtCodigo.Focus();
                ban = true;
            }
            else
            {
                if (txtNombre.EditValue == null || txtNombre.Text.Equals(""))
                {
                    txtNombre.ErrorText = "Ingrese el nombre del producto";
                    txtNombre.Focus();
                    ban = true;
                }
                else
                {
                    if (txtDescripcion.EditValue == null || txtDescripcion.Text.Equals(""))
                    {
                        txtDescripcion.ErrorText = "Ingrese la descripción del producto";
                        txtDescripcion.Focus();
                        ban = true;
                    }
                    else
                    {
                        if (lupCategoria.EditValue == null || lupCategoria.Text.Equals(""))
                        {
                            lupCategoria.ErrorText = "Ingrese la categoria del producto";
                            lupCategoria.Focus();
                            ban = true;
                        }
                        else
                        {
                            if (lupProveedor.EditValue == null || lupProveedor.Text.Equals(""))
                            {
                                lupProveedor.ErrorText = "Ingrese el nombre del proveedor";
                                lupProveedor.Focus();
                                ban = true;
                            }
                            else
                            {
                                if (txtPrecio.EditValue == null || txtPrecio.Text.Equals(""))
                                {
                                    txtPrecio.ErrorText = "Ingrese el precio del producto";
                                    txtPrecio.Focus();
                                    ban = true;
                                }
                                else
                                {
                                    if (txtExistencia.EditValue == null || txtExistencia.Text.Equals(""))
                                    {
                                        txtExistencia.ErrorText = "Ingrese la existencia del producto";
                                        txtExistencia.Focus();
                                        ban = true;
                                    }
                                    else
                                    {
                                        if (txtImagen.EditValue == null || txtImagen.Text.Equals(""))
                                        {
                                            txtImagen.ErrorText = "Ingrese la ruta de la imagen";
                                            txtImagen.Focus();
                                            ban = true;
                                        }
                                        else
                                        {
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }

            if (ban == true)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        #endregion

        #region Limpieza
        private void Clean()// Limpieza de los campos
        {
            txtCodigo.Text = "";
            txtDescripcion.Text = "";
            txtPrecio.Text = "";
            txtExistencia.Text = "";
            txtImagen.Text = "";
            txtNombre.Text = "";
            lupCategoria.EditValue = null;
            lupProveedor.EditValue = null;
            txtCodigo.Focus();
        }
        #endregion

        #region Cerrar formulario
        private void frmNMArticulo_FormClosing(object sender, FormClosingEventArgs e)// Metodo de cerrar
        {
            if (Check())
            {

                DialogResult opcion = MessageBox.Show("Seguro que dese salir?", "Salir",
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                if (opcion == DialogResult.OK)
                {
                    e.Cancel = false;
                }
                else
                {
                    e.Cancel = true;
                }

            }
        }
        #endregion
    }
}