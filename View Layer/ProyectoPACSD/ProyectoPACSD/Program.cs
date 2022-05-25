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
                Application.Run(new frmMain());
            }
            else
            {
                Application.Run(new frmLogin());
            }

        }
    }
}
