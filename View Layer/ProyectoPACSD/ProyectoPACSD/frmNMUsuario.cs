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
            btnGuardar.Enabled = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtNombre_EditValueChanged(object sender, EventArgs e)
        {
            habilitar();
        }

        private void txtApellidoP_EditValueChanged(object sender, EventArgs e)
        {
            habilitar();
        }

        private void txtApellidoM_EditValueChanged(object sender, EventArgs e)
        {
            habilitar();
        }

        private void txtTelefono_EditValueChanged(object sender, EventArgs e)
        {
            habilitar();
        }

        private void txtCorreo_EditValueChanged(object sender, EventArgs e)
        {
            habilitar();
        }

        private void txtTipoUsuario_EditValueChanged(object sender, EventArgs e)
        {
            habilitar();
        }

        private void txtUsuario_EditValueChanged(object sender, EventArgs e)
        {
            habilitar();
        }

        private void txtContrasena_EditValueChanged(object sender, EventArgs e)
        {
            habilitar();
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

        private void habilitar()
        {
            if (txtNombre.Text.Length > 0 && txtApellidoP.Text.Length > 0 && txtApellidoM.Text.Length > 0
                && txtTelefono.Text.Length == 10 && txtCorreo.Text.Length > 0 && txtTipoUsuario.Text.Length == 1
                && txtUsuario.Text.Length > 0 && txtContrasena.Text.Length > 0)
            {
                btnGuardar.Enabled = true;
            }
            else
            {
                btnGuardar.Enabled = false;
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