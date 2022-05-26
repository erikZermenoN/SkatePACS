using BML;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
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
    public partial class frmMain : DevExpress.XtraEditors.XtraForm
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnArticulo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (Form form in Application.OpenForms)

                if (form.GetType() == typeof(frmArticulos))
                {
                    form.Activate();
                    return;
                }
            new frmArticulos() { MdiParent = this }.Show();
        }

        private void btnsuario_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (Form form in Application.OpenForms)
                if (form.GetType() == typeof(frmUsuarios))
                {
                    form.Activate();
                    return;
                }

            SplashScreenManager.ShowDefaultWaitForm("Por favor espere", "Cargando Usuarios...");
            new frmUsuarios { MdiParent = this }.Show();
            SplashScreenManager.CloseDefaultWaitForm();
        }

        private void btnCategoria_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (Form form in Application.OpenForms)
                if (form.GetType() == typeof(frmCategorias))
                {
                    form.Activate();
                    return;
                }

            SplashScreenManager.ShowDefaultWaitForm("Por favor espere", "Cargando Categorias...");
            new frmCategorias { MdiParent = this }.Show();
            SplashScreenManager.CloseDefaultWaitForm();
        }

        private void btnProveedor_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (Form form in Application.OpenForms)
                if (form.GetType() == typeof(frmProveedores))
                {
                    form.Activate();
                    return;
                }

            SplashScreenManager.ShowDefaultWaitForm("Por favor espere", "Cargando Proveedores...");
            new frmProveedores { MdiParent = this }.Show();
            SplashScreenManager.CloseDefaultWaitForm();
        }

        private void btnCerrarSesion_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult opcion = MessageBox.Show("¿Está seguro cerrar la sesión?", "Advertencia",
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (opcion == DialogResult.OK)
            {

                    if (new InicioSesion
                    {
                        idInicioSesion = new InicioSesion { activo = true }.GetByActivo().idInicioSesion,
                        fechaTermino = DateTime.Now
                    }.CerrarSesion() > 0)
                    {
                    }

                
               frmLogin form  = new frmLogin();
               form.Show();
               this.Dispose();
            }
        }

        private void btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            cerrar();
        }

        private void btnVenta_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (Form form in Application.OpenForms)
                if (form.GetType() == typeof(frmVentas))
                {
                    form.Activate();
                    return;
                }

            SplashScreenManager.ShowDefaultWaitForm("Por favor espere", "Cargando Ventas...");
            new frmVentas { MdiParent = this }.Show();
            SplashScreenManager.CloseDefaultWaitForm();
        }

        private void cerrar()
        {
            var result = MessageBox.Show("Seguro que desea salir?", "Salir",
                             MessageBoxButtons.YesNo,
                             MessageBoxIcon.Question);

            // If the no button was pressed ...
            if (result == DialogResult.Yes)
            {
                if (new InicioSesion { activo = true }.GetByActivo().mantenerAbierto == false)
                {
                    if (new InicioSesion
                    {
                        idInicioSesion = new InicioSesion { activo = true }.GetByActivo().idInicioSesion,
                        fechaTermino = DateTime.Now
                    }.CerrarSesion() > 0)
                    {
                    }
                }
                Application.Exit();
            }
        }
    }
}