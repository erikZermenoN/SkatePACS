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
    public partial class frmVentas : DevExpress.XtraEditors.XtraForm
    {
        public frmVentas()
        {
            InitializeComponent();
        }

        private void frmVentas_Load(object sender, EventArgs e)
        {
            cargarInformacion();
        }

        private void btnActualizar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ventaBindingSource.DataSource = null;
            usuarioBindingSource.DataSource = null;
            cargarInformacion();
            if (ventaBindingSource.DataSource != null && usuarioBindingSource.DataSource != null)
            {
                MessageBox.Show("Tabla actualizada correctamente", "Información",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new frmNVenta().ShowDialog();
            cargarInformacion();
        }

        private void btnMostrarFactura_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (ventaBindingSource.Count > 0)
            {
                if ((int)gvVenta.GetFocusedRowCellValue("idVenta") > 0)
                {
                    int idVenta = (int)gvVenta.GetFocusedRowCellValue("idVenta");
                    new frmMFVenta(idVenta).ShowDialog();
                }
                else
                {
                    MessageBox.Show("Seleccione primeramente una fila de la tabla", "¡Atención!",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Seleccione primeramente una fila de la tabla para mostrar el detalle de la venta", "¡Atención!",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void cargarInformacion()
        {
            ventaBindingSource.DataSource = new Venta().GetAll();
            usuarioBindingSource.DataSource = new Usuario().GetAll();
            gvVenta.BestFitColumns();
        }
    }
}