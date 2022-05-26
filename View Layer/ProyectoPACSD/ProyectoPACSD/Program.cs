using BML;
using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.UserSkins;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ProyectoPACSD
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (new InicioSesion { activo = true }.GetByActivo() != null)
            {
                int resultado = DateTime.Compare(new InicioSesion { activo = true }.GetByActivo().fechaLimite, DateTime.Now);
                if(resultado < 0)
                {
                    if (new InicioSesion
                    {
                        idInicioSesion = new InicioSesion { activo = true }.GetByActivo().idInicioSesion,
                        fechaTermino = DateTime.Now
                    }.CerrarSesion() > 0)
                    {
                    }
                    frmLogin login = new frmLogin();
                    login.FormClosed += MainForm_Closed;
                    login.Show();
                    Application.Run();
                }
                else
                {
                    frmMain main = new frmMain();
                    main.FormClosed += MainForm_Closed;
                    main.Show();
                    Application.Run();
                }
                
            }
            else
            {
                frmLogin login = new frmLogin();
                login.FormClosed += MainForm_Closed;
                login.Show();
                Application.Run();
            }

        }

        private static void MainForm_Closed(object sender, FormClosedEventArgs e)
        {
            ((Form)sender).FormClosed -= MainForm_Closed;

            if (Application.OpenForms.Count == 0)
            {
                Application.Exit();
            }
            else
            {
                Application.OpenForms[0].FormClosed += MainForm_Closed;
            }
        }
    }
}
