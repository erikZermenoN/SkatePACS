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
    public partial class frmNDetalleVenta : DevExpress.XtraEditors.XtraForm
    {
        int idVenta = 0;
        public frmNDetalleVenta(int idVenta)
        {
            InitializeComponent();
            this.idVenta = idVenta;
            articuloBindingSource.DataSource = new Articulo().GetAll();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                if (!(txtCantidad.Text == "0"))
                {
                    try
                    {
                        if (new DetalleVenta()
                        {
                            idVenta = this.idVenta,
                            idArticulo = Convert.ToInt32(lupArticulo.EditValue)
                        }.GetByNoRepite() == null)
                        {
                            double precio = new Articulo() { idArticulo = Convert.ToInt32(lupArticulo.EditValue) }.GetById().precio;
                            double total = precio * Convert.ToDouble(txtCantidad.Text);
                            if (new DetalleVenta()
                            {
                                idVenta = this.idVenta,
                                idArticulo = Convert.ToInt32(lupArticulo.EditValue),
                                cantidad = Convert.ToInt32(txtCantidad.Text),
                                total = total
                            }.Add() > 0) { }
                            lupArticulo.EditValue = null;
                            txtCantidad.Text = "";
                        }
                        else
                        {
                            MessageBox.Show("No se puede agregar dos veces el mismo articulo", "¡Atención!",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            lupArticulo.EditValue = null;
                            txtCantidad.Text = "";
                        }
                    }catch (Exception ex)
                    {
                        double precio = new Articulo() { idArticulo = Convert.ToInt32(lupArticulo.EditValue) }.GetById().precio;
                        double total = precio * Convert.ToDouble(txtCantidad.Text);
                        if (new DetalleVenta()
                        {
                            idVenta = this.idVenta,
                            idArticulo = Convert.ToInt32(lupArticulo.EditValue),
                            cantidad = Convert.ToInt32(txtCantidad.Text),
                            total = total
                        }.Add() > 0) { }
                        lupArticulo.EditValue = null;
                        txtCantidad.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("La cantidad minima es 1", "¡Atención!",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void frmNDetalleVenta_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (lupArticulo.EditValue != null || txtCantidad.Text != "")
            {
                DialogResult opcion = MessageBox.Show("¿Está seguro de salir del formulario?", "Advertencia",
                            MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                if (opcion == DialogResult.OK)
                {
                    e.Cancel = false;
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

        private bool validar()
        {
            var ban = false;
            if (lupArticulo.EditValue == null || lupArticulo.Text.Equals(""))
            {
                lupArticulo.ErrorText = "Seleccione un articulo";
                lupArticulo.Focus();
                ban = true;
            }
            else
            {
                if (txtCantidad.EditValue == null || txtCantidad.Text.Equals(""))
                {
                    txtCantidad.ErrorText = "Ingrese la cantidad";
                    txtCantidad.Focus();
                    ban = true;
                }
                else
                {
                }
            }

            if (ban == true)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}