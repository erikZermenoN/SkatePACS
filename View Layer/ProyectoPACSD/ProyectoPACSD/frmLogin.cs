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
            Usuario usuario = new Usuario
            {
                usuario = txtUsuario.Text,
                contrasena = txtContrasena.Text
            }.Login();

            if (usuario != null)
            {
                
                if (chMantener.Checked == true)
                {
                    if (new InicioSesion {
                        idUsuario = usuario.idUsuario,
                        fechaInicio = DateTime.Now,
                        fechaLimite = DateTime.Now.AddDays(15),
                        fechaTermino = DateTime.Now
                    }.InicioDeSesion() > 0)
                    {

                    }
                }

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