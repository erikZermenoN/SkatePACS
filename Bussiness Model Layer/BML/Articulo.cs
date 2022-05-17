using DAL;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BML
{
    public class Articulo
    {
        public int idArticulo { get; set; }
        public int idCategoria { get; set; }
        public int idProveedor { get; set; }
        public string codigo { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public double precio { get; set; }
        public int existencia { get; set; }
        public string imagen { get; set; }
        public bool activo { get; set; }

        private DataAccess dataAccess = DataAccess.Instance();

        public Articulo() { }

        public int Add()
        {
            var parameters = new DynamicParameters();
            parameters.Add("@idCategoria", idCategoria);
            parameters.Add("@idProveedor", idProveedor);
            parameters.Add("@codigo", codigo);
            parameters.Add("@nombre", nombre);
            parameters.Add("@descripcion", descripcion);
            parameters.Add("@precio", precio);
            parameters.Add("@existencia", existencia);
            parameters.Add("@imagen", imagen);
            return dataAccess.Execute("stp_articulos_add", parameters);
        }

        public int Delete()
        {
            var parameters = new DynamicParameters();
            parameters.Add("@idArticulo", idArticulo);
            return dataAccess.Execute("stp_articulos_delete", parameters);
        }

        public IEnumerable<Articulo> GetAll()
        {
            return dataAccess.Query<Articulo>("stp_articulos_getall");
        }

        public Articulo GetById()
        {
            var parameters = new DynamicParameters();
            parameters.Add("@idArticulo", idArticulo);
            return dataAccess.QuerySingle<Articulo>("stp_articulos_getbyid", parameters);
        }
        public Articulo GetByNombre()
        {
            var parameters = new DynamicParameters();
            parameters.Add("@nombre", nombre);
            return dataAccess.QuerySingle<Articulo>("stp_articulos_getbynombre", parameters);
        }
        public int Update()
        {
            var parameters = new DynamicParameters();
            parameters.Add("@idArticulo", idArticulo);
            parameters.Add("@idCategoria", idCategoria);
            parameters.Add("@idProveedor", idProveedor);
            parameters.Add("@codigo", codigo);
            parameters.Add("@nombre", nombre);
            parameters.Add("@descripcion", descripcion);
            parameters.Add("@precio", precio);
            parameters.Add("@existencia", existencia);
            parameters.Add("@imagen", imagen);
            return dataAccess.Execute("stp_articulos_update", parameters);
        }
    }
}
