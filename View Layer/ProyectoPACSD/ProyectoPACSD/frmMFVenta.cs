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
    public partial class frmMFVenta : DevExpress.XtraEditors.XtraForm
    {
        public frmMFVenta(int idVenta)
        {
            InitializeComponent();
            Venta venta = new Venta() { idVenta = idVenta }.GetById();
            this.Text = "Factura numero: " + venta.noComprobante;
            txtEmpleado.Text = new Usuario() { idUsuario = venta.idUsuario }.GetById().nombre;
            txtFecha.Text = venta.fecha;
            txtTotal.Text = venta.total.ToString();
            detalleVentaBindingSource.DataSource = new DetalleVenta() { idVenta = venta.idVenta }.GetByIdVenta();
            articuloBindingSource.DataSource = new Articulo().GetAll();
            gvDetalleVenta.BestFitColumns();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}