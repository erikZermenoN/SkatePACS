using DAL;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BML
{
    public class Categoria
    {
        public int idCategoria { get; set; }
        public string nombre { get; set; }
        public bool activo { get; set; }

        private DataAccess dataAccess = DataAccess.Instance();

        public Categoria() { }

        public int Add()
        {
            var parameters = new DynamicParameters();
            parameters.Add("@nombre", nombre);
            return dataAccess.Execute("stp_categorias_add", parameters);
        }

        public int Delete()
        {
            var parameters = new DynamicParameters();
            parameters.Add("@idCategoria", idCategoria);
            return dataAccess.Execute("stp_categorias_delete", parameters);
        }

        public IEnumerable<Categoria> GetAll()
        {
            return dataAccess.Query<Categoria>("stp_categorias_getall");
        }

        public Categoria GetById()
        {
            var parameters = new DynamicParameters();
            parameters.Add("@idCategoria", idCategoria);
            return dataAccess.QuerySingle<Categoria>("stp_categorias_getbyid", parameters);
        }
        public Categoria GetByNombre()
        {
            var parameters = new DynamicParameters();
            parameters.Add("@nombre", nombre);
            return dataAccess.QuerySingle<Categoria>("stp_categorias_getbynombre", parameters);
        }
        public int Update()
        {
            var parameters = new DynamicParameters();
            parameters.Add("@idCategoria", idCategoria);
            parameters.Add("@nombre", nombre);
            return dataAccess.Execute("stp_categorias_update", parameters);
        }
    }
}
