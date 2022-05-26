using BML;
using DevExpress.XtraEditors;
using System;
using System.Windows.Forms;

namespace ProyectoPACSD
{
    public partial class frmNMUsuario : DevExpress.XtraEditors.XtraForm
    {
        private int idUsuario = 0;

        public frmNMUsuario()
        {
            InitializeComponent();
            this.Text = "Nuevo Usuario";
        }

        public frmNMUsuario(int idUsuario)
        {
            InitializeComponent();
            this.Text = "Modificar Usuario";
            this.idUsuario = idUsuario;
        }

        private void frmNMUsuario_Load(object sender, EventArgs e)
        {
            obtenerDatos();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                if (idUsuario > 0)
                {
                    if (new Usuario
                    {
                        idUsuario = this.idUsuario,
                        nombre = txtNombre.Text,
                        apellidoP = txtApellidoP.Text,
                        apellidoM = txtApellidoM.Text,
                        telefono = txtTelefono.Text,
                        correo = txtCorreo.Text,
                        tipo = txtTipoUsuario.Text,
                        usuario = txtUsuario.Text,
                        contrasena = txtContrasena.Text,

                    }.Update() > 0)
                    {
                        XtraMessageBox.Show("Usuario actualizado correctamente", Application.ProductName,
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Clean();
                        this.Close();
                    }
                }
                else
                {
                    if (new Usuario
                    {
                        idUsuario = this.idUsuario,
                        nombre = txtNombre.Text,
                        apellidoP = txtApellidoP.Text,
                        apellidoM = txtApellidoM.Text,
                        telefono = txtTelefono.Text,
                        correo = txtCorreo.Text,
                        tipo = txtTipoUsuario.Text,
                        usuario = txtUsuario.Text,
                        contrasena = txtContrasena.Text,
                    }.Add() > 0)
                    {
                        XtraMessageBox.Show("Usuario almacenado correctamente", Application.ProductName,
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

        private void frmNMUsuario_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Check())
            {
                var result = MessageBox.Show("Seguro que dese salir?", "Salir",
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

        private bool Check()
        {
            if (txtNombre.Text != "" || txtApellidoP.Text != "" || txtApellidoM.Text != "" ||
                txtTelefono.Text != "" || txtCorreo.Text != "" || txtTipoUsuario.Text != "" ||
                     txtUsuario.Text != "" || txtContrasena.Text != "")
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
                txtNombre.ErrorText = "Ingrese el nombre del usuario";
                txtNombre.Focus();
                ban = true;
            }
            else
            {
                if (txtApellidoP.EditValue == null || txtApellidoP.Text.Equals(""))
                {
                    txtApellidoP.ErrorText = "Ingrese el apellido paterno del usuario";
                    txtApellidoP.Focus();
                    ban = true;
                }
                else
                {
                    if (txtApellidoM.EditValue == null || txtApellidoM.Text.Equals(""))
                    {
                        txtApellidoM.ErrorText = "Ingrese el apellido materno del usuario";
                        txtApellidoM.Focus();
                        ban = true;
                    }
                    else
                    {
                        if (txtTelefono.EditValue == null || txtTelefono.Text.Equals(""))
                        {
                            txtTelefono.ErrorText = "Ingrese el telefono del usuario";
                            txtTelefono.Focus();
                            ban = true;
                        }
                        else
                        {
                            if (txtCorreo.EditValue == null || txtCorreo.Text.Equals(""))
                            {
                                txtCorreo.ErrorText = "Ingrese el correo del usuario";
                                txtCorreo.Focus();
                                ban = true;
                            }
                            else
                            {
                                if (txtTipoUsuario.EditValue == null || txtTipoUsuario.Text.Equals(""))
                                {
                                    txtTipoUsuario.ErrorText = "Ingrese el tipo del usuario";
                                    txtTipoUsuario.Focus();
                                    ban = true;
                                }
                                else
                                {
                                    if (txtUsuario.EditValue == null || txtUsuario.Text.Equals(""))
                                    {
                                        txtUsuario.ErrorText = "Ingrese el usuario";
                                        txtUsuario.Focus();
                                        ban = true;
                                    }
                                    else
                                    {
                                        if (txtContrasena.EditValue == null || txtContrasena.Text.Equals(""))
                                        {
                                            txtContrasena.ErrorText = "Ingrese la contraseña";
                                            txtContrasena.Focus();
                                            ban = true;
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

        private void Clean()// Limpieza de los campos
        {
            txtNombre.Text = "";
            txtApellidoP.Text = "";
            txtApellidoM.Text = "";
            txtTelefono.Text = "";
            txtCorreo.Text = "";
            txtTipoUsuario.Text = "";
            txtUsuario.Text = "";
            txtContrasena.Text = "";
            txtNombre.Focus();
        }

        private void obtenerDatos()
        {
            if (idUsuario > 0)
            {


                try
                {
                    txtNombre.EditValue = new Usuario { idUsuario = this.idUsuario }.GetById().nombre;
                    txtApellidoP.EditValue = new Usuario { idUsuario = this.idUsuario }.GetById().apellidoP;
                    txtApellidoM.EditValue = new Usuario { idUsuario = this.idUsuario }.GetById().apellidoM;
                    txtTelefono.EditValue = new Usuario { idUsuario = this.idUsuario }.GetById().telefono;
                    txtCorreo.EditValue = new Usuario { idUsuario = this.idUsuario }.GetById().correo;
                    txtTipoUsuario.EditValue = new Usuario { idUsuario = this.idUsuario }.GetById().tipo;
                    txtUsuario.EditValue = new Usuario { idUsuario = this.idUsuario }.GetById().usuario;
                    txtContrasena.EditValue = new Usuario { idUsuario = this.idUsuario }.GetById().contrasena;
                    txtNombre.Select();
                    txtNombre.Focus();
                }
                catch (NullReferenceException ex) { }
            }
        }
    }
}