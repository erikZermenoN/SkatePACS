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

            if (new Usuario
            {
                usuario = txtUsuario.Text,
                contrasena = txtContrasena.Text
            }.Login() != null)
            {
                MessageBox.Show("Has accedido correctamente", "BIENVENIDO",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                SplashScreenManager.ShowDefaultWaitForm("Iniciando Sesion");
                frmMain frmMain = new frmMain();
                frmMain.Visible = true;
                this.Dispose(false);
                SplashScreenManager.CloseDefaultWaitForm();
            }
            else
            {
                MessageBox.Show("Error al ingresar, verifique su usuario y contraseña", "Error de informacion",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clean();
            }
            
        }

        private void Clean()
        {
            txtUsuario.Text = "";
            txtContrasena.Text = "";
            txtUsuario.Focus();
        }
    }
}