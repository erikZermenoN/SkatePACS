using DAL;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BML
{
    public class Venta
    {
        public int idVenta { get; set; }
        public int idUsuario { get; set; }
        public string noComprobante { get; set; }
        public string fecha { get; set; }
        public double subtotal { get; set; }
        public double iva { get; set; }
        public double total { get; set; }

        private DataAccess dataAccess = DataAccess.Instance();

        public Venta() { }

        public int Add()
        {
            var parameters = new DynamicParameters();
            parameters.Add("@idUsuario", idUsuario);
            parameters.Add("@noComprobante", noComprobante);
            parameters.Add("@fecha", fecha);
            parameters.Add("@subtotal", subtotal);
            parameters.Add("@iva", iva);
            parameters.Add("@total", total);
            return dataAccess.Execute("stp_ventas_add", parameters);
        }
        public int Delete()
        {
            var parameters = new DynamicParameters();
            parameters.Add("@idVenta", idVenta);
            return dataAccess.Execute("stp_ventas_delete", parameters);
        }
        public IEnumerable<Venta> GetAll()
        {
            return dataAccess.Query<Venta>("stp_ventas_getall");
        }

        public Venta GetById()
        {
            var parameters = new DynamicParameters();
            parameters.Add("@idVenta", idVenta);
            return dataAccess.QuerySingle<Venta>("stp_ventas_getbyid", parameters);
        }
        public Venta GetByNoComprobante()
        {
            var parameters = new DynamicParameters();
            parameters.Add("@noComprobante", noComprobante);
            return dataAccess.QuerySingle<Venta>("stp_ventas_getbynocomprobante", parameters);
        }
        public Venta GetByLast()
        {
            return dataAccess.QuerySingle<Venta>("stp_ventas_getbylast");
        }

        public int UpdateTotal()
        {
            var parameters = new DynamicParameters();
            parameters.Add("@idVenta", idVenta);
            return dataAccess.Execute("stp_ventas_updatetotal", parameters);
        }
        
        public int Update()
        {
            var parameters = new DynamicParameters();
            parameters.Add("@idVenta", idVenta);
            parameters.Add("@idUsuario", idUsuario);
            parameters.Add("@noComprobante", noComprobante);
            parameters.Add("@fecha", fecha);
            parameters.Add("@subtotal", subtotal);
            parameters.Add("@iva", iva);
            parameters.Add("@total", total);
            return dataAccess.Execute("stp_ventas_update", parameters);
        }
    }
}
