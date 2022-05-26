using BML;
using DevExpress.XtraSplashScreen;
using System;
using System.Windows.Forms;

namespace ProyectoPACSD
{
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                Usuario usuario = new Usuario
                {
                    usuario = txtUsuario.Text,
                    contrasena = txtContrasena.Text
                }.Login();

                if (usuario != null)
                {

                        if (new InicioSesion
                        {
                            idUsuario = usuario.idUsuario,
                            fechaInicio = DateTime.Now,
                            fechaLimite = DateTime.Now.AddDays(15),
                            fechaTermino = DateTime.Now,
                            mantenerAbierto = chMantener.Checked

                        }.InicioDeSesion() > 0)
                        {

                        }
                    SplashScreenManager.ShowDefaultWaitForm("Iniciando Sesion");
                    frmMain frmMain = new frmMain();
                    frmMain.Visible = true;
                    this.Dispose();
                    SplashScreenManager.CloseDefaultWaitForm();
                }
                else
                {
                    MessageBox.Show("Error al ingresar, verifique su usuario y contraseña", "Error de informacion",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clean();
                }
            }
            
        }

        private void Clean()
        {
            txtUsuario.Text = "";
            txtContrasena.Text = "";
            txtUsuario.Focus();
        }

        private bool validar()
        {
            var ban = false;
            if (txtUsuario.EditValue == null || txtUsuario.Text.Equals(""))
            {
                txtUsuario.ErrorText = "Ingrese su usuario";
                txtUsuario.Focus();
                ban = true;
            }
            else
            {
                if (txtContrasena.EditValue == null || txtContrasena.Text.Equals(""))
                {
                    txtContrasena.ErrorText = "Ingrese su contraseña";
                    txtContrasena.Focus();
                    ban = true;
                }
                else
                {
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

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (txtUsuario.EditValue != null || txtContrasena.EditValue != null)
            {

                DialogResult opcion = MessageBox.Show("Seguro que desea salir?", "Salir",
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
    }
}