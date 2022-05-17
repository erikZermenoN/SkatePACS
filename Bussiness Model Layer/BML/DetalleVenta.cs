using DAL;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BML
{
    public class DetalleVenta
    {
        public int idDetalleVenta { get; set; }
        public int idArticulo { get; set; }
        public int idVenta { get; set; }
        public int cantidad { get; set; }
        public double descuento { get; set; }
        public double total { get; set; }

        private DataAccess dataAccess = DataAccess.Instance();

        public DetalleVenta() { }

        public int Add()
        {
            var parameters = new DynamicParameters();
            parameters.Add("@idArticulo", idArticulo);
            parameters.Add("@idVenta", idVenta);
            parameters.Add("@cantidad", cantidad);
            parameters.Add("@descuento", descuento);
            parameters.Add("@total", total);
            return dataAccess.Execute("stp_detalleventas_add", parameters);
        }

        public int Delete()
        {
            var parameters = new DynamicParameters();
            parameters.Add("@idDetalleVenta", idDetalleVenta);
            return dataAccess.Execute("stp_detalleventas_delete", parameters);
        }

        public int DeleteIdVenta()
        {
            var parameters = new DynamicParameters();
            parameters.Add("@idVenta", idVenta);
            return dataAccess.Execute("stp_detalleventas_deleteidventa", parameters);
        }

        public IEnumerable<DetalleVenta> GetAll()
        {
            return dataAccess.Query<DetalleVenta>("stp_detalleventas_getall");
        }

        public DetalleVenta GetById()
        {
            var parameters = new DynamicParameters();
            parameters.Add("@idDetalleVenta", idDetalleVenta);
            return dataAccess.QuerySingle<DetalleVenta>("stp_detalleventas_getbyid", parameters);
        }

        public IEnumerable<DetalleVenta> GetByIdVenta()
        {
            var parameters = new DynamicParameters();
            parameters.Add("@idVenta", idVenta);
            return dataAccess.Query<DetalleVenta>("stp_detalleventas_getbyidventa", parameters);
        }

        public DetalleVenta GetByNoRepite()
        {
            var parameters = new DynamicParameters();
            parameters.Add("@idVenta", idVenta);
            parameters.Add("@idArticulo", idArticulo);
            return dataAccess.QuerySingle<DetalleVenta>("stp_detalleventas_getbynorepite", parameters);
        }

        public int Update()
        {
            var parameters = new DynamicParameters();
            parameters.Add("@idDetalleVenta", idDetalleVenta);
            parameters.Add("@idArticulo", idArticulo);
            parameters.Add("@idVenta", idVenta);
            parameters.Add("@cantidad", cantidad);
            parameters.Add("@descuento", descuento);
            parameters.Add("@total", total);
            return dataAccess.Execute("stp_detalleventas_update", parameters);
        }
    }
}
