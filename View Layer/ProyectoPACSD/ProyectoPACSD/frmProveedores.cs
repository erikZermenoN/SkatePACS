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
    public partial class frmProveedores : DevExpress.XtraEditors.XtraForm
    {
        public frmProveedores()
        {
            InitializeComponent();
        }

        private void frmProveedores_Load(object sender, EventArgs e)
        {
            cargarInformacion();
        }

        private void btnActualizar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            cargarInformacion();
        }

        private void btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new frmNMProveedor().ShowDialog();
            cargarInformacion();
        }

        private void btnModificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (proveedorBindingSource.Count > 0)
            {
                new frmNMProveedor((int)gvProveedor.GetFocusedRowCellValue("idProveedor")).ShowDialog();
                cargarInformacion();
            }
            else
            {
                MessageBox.Show("Seleccione primeramente una fila de la tabla", "¡Atención!",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnEliminar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (proveedorBindingSource.Count > 0)
            {
                if ((int)gvProveedor.GetFocusedRowCellValue("idProveedor") > 0)
                {
                    DialogResult opcion = MessageBox.Show("¿Está seguro de eliminar el elemento seleccionado?", "Advertencia",
                            MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                    if (opcion == DialogResult.OK)
                    {
                        int idProveedor = (int)gvProveedor.GetFocusedRowCellValue("idProveedor");
                        if (new Proveedor { idProveedor = idProveedor }.Delete() > 0)
                        {
                            MessageBox.Show("Proveedor eliminado correctamente", "Información",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                            cargarInformacion();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione primeramente una fila de la tabla", "¡Atención!",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Seleccione primeramente una fila de la tabla", "¡Atención!",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void cargarInformacion()
        {
            proveedorBindingSource.DataSource = new Proveedor().GetAll();
            gvProveedor.BestFitColumns();
        }
    }
}