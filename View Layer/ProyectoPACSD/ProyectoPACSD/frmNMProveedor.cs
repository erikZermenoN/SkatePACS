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
    public partial class frmNMProveedor : DevExpress.XtraEditors.XtraForm
    {
        private int idProveedor = 0;

        public frmNMProveedor()
        {
            InitializeComponent();
            this.Text = "Nuevo Proveedor";
        }

        public frmNMProveedor(int idProveedor)
        {
            InitializeComponent();
            this.Text = "Modificar Proveedor";
            this.idProveedor = idProveedor;
        }

        private void frmNMProveedor_Load(object sender, EventArgs e)
        {
            obtenerDatos();
        }

        private void frmNMProveedor_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Check())
            {
                var result = MessageBox.Show("Seguro que desea salir?", "Salir",
                                 MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Question);

                // If the no button was pressed ...
                if (result == DialogResult.Yes)
                {
                    this.Dispose();
                }
                else
                {
                    e.Cancel = true;
                }


            }
            else
            {
                this.Dispose();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                if (idProveedor > 0)
                {
                    if (new Proveedor
                    {
                        idProveedor = this.idProveedor,
                        nombre = txtNombre.Text,
                        telefono = txtTelefono.Text,
                        correo = txtCorreo.Text,
                    }.Update() > 0)
                    {
                        XtraMessageBox.Show("Proveedor actualizado correctamente", Application.ProductName,
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Clean();
                        this.Close();
                    }
                }
                else
                {
                    if (new Proveedor
                    {
                        idProveedor = this.idProveedor,
                        nombre = txtNombre.Text,
                        telefono = txtTelefono.Text,
                        correo = txtCorreo.Text,
                    }.Add() > 0)
                    {
                        XtraMessageBox.Show("Proveedor almacenado correctamente", Application.ProductName,
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Clean();
                    }
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Clean()// Limpieza de los campos
        {
            txtNombre.Text = "";
            txtCorreo.Text = "";
            txtTelefono.Text = "";
            txtNombre.Focus();
        }

        private void obtenerDatos()
        {
            if (idProveedor > 0)
            {
                try
                {
                    txtNombre.EditValue = new Proveedor { idProveedor = this.idProveedor }.GetById().nombre;
                    txtTelefono.EditValue = new Proveedor { idProveedor = this.idProveedor }.GetById().telefono;
                    txtCorreo.EditValue = new Proveedor { idProveedor = this.idProveedor }.GetById().correo;
                    txtNombre.Select();
                    txtNombre.Focus();
                }
                catch (NullReferenceException ex) { }
            }
        }

        private bool Check()
        {
            if (txtNombre.Text != "" || txtCorreo.Text != "" ||
                txtTelefono.Text != "")
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
            if (txtNombre.EditValue == null || txtNombre.Text.Equals(""))
            {
                txtNombre.ErrorText = "Ingrese el nombre del proveedor";
                txtNombre.Focus();
                ban = true;
            }
            else
            {
                if (txtTelefono.EditValue == null || txtTelefono.Text.Equals(""))
                {
                    txtTelefono.ErrorText = "Ingrese el telefono del proveedor";
                    txtTelefono.Focus();
                    ban = true;
                }
                else
                {
                    if (txtCorreo.EditValue == null || txtCorreo.Text.Equals(""))
                    {
                        txtCorreo.ErrorText = "Ingrese el correo del proveedor";
                        txtCorreo.Focus();
                        ban = true;
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
    }
}