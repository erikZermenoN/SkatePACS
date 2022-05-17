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
    public partial class frmNMCategoria : DevExpress.XtraEditors.XtraForm
    {
        private int idCategoria = 0;

        public frmNMCategoria()
        {
            InitializeComponent();
            this.Text = "Nueva Categoria";
        }

        public frmNMCategoria(int idCategoria)
        {
            InitializeComponent();
            this.Text = "Modificar Categoria";
            this.idCategoria = idCategoria;
        }

        private void frmNMCategoria_Load(object sender, EventArgs e)
        {
            obtenerDatos();
            btnGuardar.Enabled = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (idCategoria > 0)
            {
                if (new Categoria
                {
                    idCategoria = this.idCategoria,
                    nombre = txtNombre.Text,
                }.Update() > 0)
                {
                    XtraMessageBox.Show("Categoria actualizada correctamente", Application.ProductName,
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clean();
                    this.Close();
                }
            }
            else
            {
                if (new Categoria
                {
                    idCategoria = this.idCategoria,
                    nombre = txtNombre.Text,
                }.Add() > 0)
                {
                    XtraMessageBox.Show("Categoria almacenada correctamente", Application.ProductName,
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clean();
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtNombre_EditValueChanged(object sender, EventArgs e)
        {
            habilitar();
        }

        private void frmNMCategoria_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Check())
            {
                var result = MessageBox.Show("Seguro que dese salir?", "Salir",
                                 MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Question);

                // If the no button was pressed ...
                if (result == DialogResult.Yes)
                {
                    this.Dispose();
                }
                else
                {
                    e.Cancel = true;
                }


            }
            else
            {
                this.Dispose();
            }
        }

        private void habilitar()
        {
            if (txtNombre.Text.Length > 0)
            {
                btnGuardar.Enabled = true;
            }
            else
            {
                btnGuardar.Enabled = false;
            }
        }

        private void obtenerDatos()
        {
            if (idCategoria > 0)
            {
                try
                {
                    txtNombre.EditValue = new Categoria { idCategoria = this.idCategoria }.GetById().nombre;
                    txtNombre.Select();
                    txtNombre.Focus();
                }
                catch (NullReferenceException ex) { }
            }
        }

        private bool Check()
        {
            if (txtNombre.Text != "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void Clean()// Limpieza de los campos
        {
            txtNombre.Text = "";
        }
    }
}