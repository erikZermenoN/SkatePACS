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
    public partial class frmNVenta : DevExpress.XtraEditors.XtraForm
    {
        bool ventaCreada = false, ventaGuardada = false;

        public frmNVenta()
        {
            InitializeComponent();
        }

        private void frmNVenta_Load(object sender, EventArgs e)
        {
            txtFecha.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            usuarioBindingSource.DataSource = new Usuario().GetAll();
            articuloBindingSource.DataSource = new Articulo().GetAll();
            try
            {
                ventaBindingSource.DataSource = new Venta().GetAll();
                txtNoComprobante.Text = (Convert.ToInt32(new Venta().GetByLast().noComprobante) + 1).ToString();
            }
            catch (Exception)
            {
                txtNoComprobante.Text = "100000";
            }
            
            txtTotal.Text = "0";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (lupUsuario.EditValue != null)
            {
                if (ventaCreada)
                {
                    new frmNDetalleVenta(new Venta() { noComprobante = txtNoComprobante.Text }.GetByNoComprobante().idVenta).ShowDialog();
                    cargarInformacion();
                }
                else
                {
                    if (new Venta()
                    {
                        idUsuario = Convert.ToInt32(lupUsuario.EditValue),
                        noComprobante = txtNoComprobante.Text,
                        fecha = txtFecha.Text,
                        total = Convert.ToDouble(txtTotal.Text)
                    }.Add() > 0)
                    {
                        ventaCreada = true;
                        new frmNDetalleVenta(new Venta() { noComprobante = txtNoComprobante.Text }.GetByNoComprobante().idVenta).ShowDialog();
                        cargarInformacion();
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione el empleado a realizar la venta", "¡Atención!",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (detalleVentaBindingSource.Count > 0)
            {
                if ((int)gvDetalleVenta.GetFocusedRowCellValue("idDetalleVenta") > 0)
                {
                    DialogResult opcion = MessageBox.Show("¿Está seguro de eliminar el elemento seleccionado?", "Advertencia",
                            MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                    if (opcion == DialogResult.OK)
                    {
                        int idDetalleVenta = (int)gvDetalleVenta.GetFocusedRowCellValue("idDetalleVenta");
                        if (new DetalleVenta { idDetalleVenta = idDetalleVenta }.Delete() > 0)
                        {
                            MessageBox.Show("Registro eliminado correctamente", "Información",
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
                MessageBox.Show("Primeramente debe agregar algún registro", "¡Atención!",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (lupUsuario.EditValue != null)
            {
                if (ventaCreada)
                {
                    if (detalleVentaBindingSource.Count>0)
                    {
                        int idVenta = new Venta() { noComprobante = txtNoComprobante.Text }.GetByNoComprobante().idVenta;
                        if (new Venta()
                        {
                            idVenta = idVenta,
                            idUsuario = Convert.ToInt32(lupUsuario.EditValue),
                            total = Convert.ToDouble(txtTotal.Text),
                            fecha = txtFecha.Text,
                            noComprobante = txtNoComprobante.Text
                        }.Update() > 0)
                        {
                            MessageBox.Show("La venta se a registrado correctamente", Application.ProductName,
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ventaGuardada = true;
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("A ocurrido un error. Vuelve a intentarlo", Application.ProductName,
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Agregue almenos un producto a la venta", "¡Atención!",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("Agregue almenos un producto a la venta", "¡Atención!",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Seleccione el empleado a realizar la venta", "¡Atención!",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void cargarInformacion()
        {
            articuloBindingSource.DataSource = null;
            detalleVentaBindingSource.DataSource = null;
            articuloBindingSource.DataSource = new Articulo().GetAll();
            int idVenta = new Venta() { noComprobante = txtNoComprobante.Text }.GetByNoComprobante().idVenta;
            Console.WriteLine(idVenta);
            detalleVentaBindingSource.DataSource = new DetalleVenta()
            {
                idVenta = idVenta
            }.GetByIdVenta();
            if (detalleVentaBindingSource.Count > 0)
            {
                if (new Venta() { idVenta = new Venta() { noComprobante = txtNoComprobante.Text }.GetByNoComprobante().idVenta }.UpdateTotal() > 0) { }
                txtTotal.Text = new Venta() { noComprobante = txtNoComprobante.Text }.GetByNoComprobante().total.ToString();
            }
        }

        private void frmNVenta_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!ventaGuardada)
            {
                DialogResult opcion = MessageBox.Show("¿Está seguro de salir del formulario?", "Advertencia",
                            MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                if (opcion == DialogResult.OK)
                {
                    if (ventaCreada)
                    {

                        int idVenta = new Venta() { noComprobante = txtNoComprobante.Text }.GetByNoComprobante().idVenta;
                        if (new Venta() { idVenta = idVenta }.Delete() > 0) { }
                        if (new DetalleVenta() { idVenta = idVenta }.DeleteIdVenta() > 0) { }
                        e.Cancel = false;

                    }
                    else
                    {
                        e.Cancel = false;
                    }

                }
                else
                {
                    e.Cancel = true;
                }
            }
        }
    }
}