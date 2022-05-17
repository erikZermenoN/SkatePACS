using DAL;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BML
{
    public class Proveedor
    {
        public int idProveedor { get; set; }
        public string nombre { get; set; }
        public string telefono { get; set; }
        public string correo { get; set; }
        public bool activo { get; set; }

        private DataAccess dataAccess = DataAccess.Instance();

        public Proveedor() { }

        public int Add()
        {
            var parameters = new DynamicParameters();
            parameters.Add("@nombre", nombre);
            parameters.Add("@telefono", telefono);
            parameters.Add("@correo", correo);
            return dataAccess.Execute("stp_proveedores_add", parameters);
        }

        public int Delete()
        {
            var parameters = new DynamicParameters();
            parameters.Add("@idProveedor", idProveedor);
            return dataAccess.Execute("stp_proveedores_delete", parameters);
        }

        public IEnumerable<Proveedor> GetAll()
        {
            return dataAccess.Query<Proveedor>("stp_proveedores_getall");
        }

        public Proveedor GetById()
        {
            var parameters = new DynamicParameters();
            parameters.Add("@idProveedor", idProveedor);
            return dataAccess.QuerySingle<Proveedor>("stp_proveedores_getbyid", parameters);
        }
        public Proveedor GetByNombre()
        {
            var parameters = new DynamicParameters();
            parameters.Add("@nombre", nombre);
            return dataAccess.QuerySingle<Proveedor>("stp_proveedores_getbynombre", parameters);
        }
        public int Update()
        {
            var parameters = new DynamicParameters();
            parameters.Add("@idProveedor", idProveedor);
            parameters.Add("@nombre", nombre);
            parameters.Add("@telefono", telefono);
            parameters.Add("@correo", correo);
            return dataAccess.Execute("stp_proveedores_update", parameters);
        }
    }
}
