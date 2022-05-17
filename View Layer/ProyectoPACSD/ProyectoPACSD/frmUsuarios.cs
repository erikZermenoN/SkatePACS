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
    public partial class frmUsuarios : DevExpress.XtraEditors.XtraForm
    {
        public frmUsuarios()
        {
            InitializeComponent();
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            cargarInformacion();
        }

        private void btnActualizar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            cargarInformacion();
        }

        private void btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new frmNMUsuario().ShowDialog();
            cargarInformacion();
        }

        private void btnModificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (usuarioBindingSource.Count > 0)
            {
                new frmNMUsuario((int)gvUsuario.GetFocusedRowCellValue("idUsuario")).ShowDialog();
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
            if (usuarioBindingSource.Count > 0)
            {
                if (usuarioBindingSource.Count > 1)
                {
                    if ((int)gvUsuario.GetFocusedRowCellValue("idUsuario") > 0)
                    {
                        DialogResult opcion = MessageBox.Show("¿Está seguro de eliminar el elemento seleccionado?", "Advertencia",
                                MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                        if (opcion == DialogResult.OK)
                        {
                            int idUsuario = (int)gvUsuario.GetFocusedRowCellValue("idUsuario");
                            if (new Usuario { idUsuario = idUsuario }.Delete() > 0)
                            {
                                MessageBox.Show("Usuario eliminado correctamente", "Información",
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
                    MessageBox.Show("El sistema requiere de un usuario activo para su funcionamiento", "¡Atención!",
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
            usuarioBindingSource.DataSource = new Usuario().GetAll();
            gvUsuario.BestFitColumns();
        }
    }
}