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
    public partial class frmCategorias : DevExpress.XtraEditors.XtraForm
    {
        public frmCategorias()
        {
            InitializeComponent();
        }

        private void frmCategorias_Load(object sender, EventArgs e)
        {
            cargarInformacion();
        }

        private void btnActualizar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            cargarInformacion();
        }

        private void btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new frmNMCategoria().ShowDialog();
            cargarInformacion();
        }

        private void btnModificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (categoriaBindingSource.Count > 0)
            {
                new frmNMCategoria((int)gvCategoria.GetFocusedRowCellValue("idCategoria")).ShowDialog();
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
            if (categoriaBindingSource.Count > 0)
            {
                if ((int)gvCategoria.GetFocusedRowCellValue("idCategoria") > 0)
                {
                    DialogResult opcion = MessageBox.Show("¿Está seguro de eliminar el elemento seleccionado?", "Advertencia",
                            MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                    if (opcion == DialogResult.OK)
                    {
                        int idCategoria = (int)gvCategoria.GetFocusedRowCellValue("idCategoria");
                        if (new Categoria { idCategoria = idCategoria }.Delete() > 0)
                        {
                            MessageBox.Show("Categoria eliminada correctamente", "Información",
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
            categoriaBindingSource.DataSource = new Categoria().GetAll();
            gvCategoria.BestFitColumns();
        }
    }
}