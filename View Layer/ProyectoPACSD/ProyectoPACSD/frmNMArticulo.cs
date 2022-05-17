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
                if (CheckFull())
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
                else
                {
                    MessageBox.Show("Debes llenar todos los campos", Application.ProductName,
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else// Se ejecuta si se esta modificando un articulo
            {
                if (CheckFull())
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
                else
                {
                    MessageBox.Show("Debes llenar todos los campos", Application.ProductName,
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        #endregion

        #region Revisión de campos
        private bool CheckFull()// Revisa que todos los campos esten llenos
        {
            if (txtCodigo.Text != "" && txtNombre.Text != "" &&
                txtDescripcion.Text != "" && txtPrecio.Text != "" &&
                txtExistencia.Text != "" && txtImagen.Text != "" &&
                lupCategoria.EditValue != null && lupProveedor.EditValue != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

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

        #region Habilitar
        private void habilitar()
        {
            if (txtCodigo.Text.Length == 10 && txtNombre.Text.Length > 0 && txtDescripcion.Text.Length > 0 &&
                 lupProveedor.Text.Length > 0 && txtPrecio.Text.Length > 0 && txtExistencia.Text.Length > 0 &&
                  txtImagen.Text.Length > 0)
            {
                btnGuardar.Enabled = true;
            }
            else
            {
                btnGuardar.Enabled = false;
            }
        }
        #endregion

        #region Campos
        private void txtCodigo_EditValueChanged(object sender, EventArgs e)
        {
            habilitar();
        }

        private void txtNombre_EditValueChanged(object sender, EventArgs e)
        {
            habilitar();
        }

        private void txtDescripcion_EditValueChanged(object sender, EventArgs e)
        {
            habilitar();
        }

        private void lupCategoria_EditValueChanged(object sender, EventArgs e)
        {
            habilitar();
        }

        private void lupProveedor_EditValueChanged(object sender, EventArgs e)
        {
            habilitar();
        }

        private void txtPrecio_EditValueChanged(object sender, EventArgs e)
        {
            habilitar();
        }

        private void txtExistencia_EditValueChanged(object sender, EventArgs e)
        {
            habilitar();
        }

        private void txtImagen_EditValueChanged(object sender, EventArgs e)
        {
            habilitar();
        }
        #endregion

        private void frmNMArticulo_Load(object sender, EventArgs e)
        {
            btnGuardar.Enabled = false;
        }
    }
}