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
    public partial class frmArticulos : DevExpress.XtraEditors.XtraForm
    {
        public frmArticulos()
        {
            InitializeComponent();
        }

        private void frmArticulos_Load(object sender, EventArgs e)
        {
            cargarInformacion();
        }

        #region Botones
        private void btnActualizar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            articuloBindingSource.DataSource = null;
            categoriaBindingSource.DataSource = null;
            proveedorBindingSource.DataSource = null;
            cargarInformacion();
            if (articuloBindingSource.DataSource != null && categoriaBindingSource.DataSource != null && proveedorBindingSource.DataSource != null)
            {
                MessageBox.Show("Tabla actualizada correctamente", "Información",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new frmNMArticulo().ShowDialog();
            cargarInformacion();
        }

        private void btnModificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if ((int)gvArticulo.GetFocusedRowCellValue("idArticulo") > 0)
            {
                int idArticulo = (int)gvArticulo.GetFocusedRowCellValue("idArticulo");
                new frmNMArticulo(idArticulo).ShowDialog();
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
            if (articuloBindingSource.Count > 0)
            {
                if ((int)gvArticulo.GetFocusedRowCellValue("idArticulo") > 0)
                {
                    DialogResult opcion = MessageBox.Show("¿Está seguro de eliminar el elemento seleccionado?", "Advertencia",
                            MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                    if (opcion == DialogResult.OK)
                    {
                        int idArticulo = (int)gvArticulo.GetFocusedRowCellValue("idArticulo");
                        if (new Articulo { idArticulo = idArticulo }.Delete() > 0)
                        {
                            MessageBox.Show("Articulo eliminado correctamente", "Información",
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
        #endregion

        private void cargarInformacion()
        {
            articuloBindingSource.DataSource = new Articulo().GetAll();
            categoriaBindingSource.DataSource = new Categoria().GetAll();
            proveedorBindingSource.DataSource = new Proveedor().GetAll();
            gvArticulo.BestFitColumns();
        }
    }
}