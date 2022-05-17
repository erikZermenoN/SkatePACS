using DAL;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BML
{
    public class Usuario
    {
        public int idUsuario { get; set; }
        public string nombre { get; set; }
        public string apellidoP { get; set; }
        public string apellidoM { get; set; }
        public string telefono { get; set; }
        public string correo { get; set; }
        public string tipo { get; set; }
        public string usuario { get; set; }
        public string contrasena { get; set; }
        public bool activo { get; set; }

        private DataAccess dataAccess = DataAccess.Instance();

        public Usuario() { }

        public int Add()
        {
            var parameters = new DynamicParameters();
            parameters.Add("@nombre", nombre);
            parameters.Add("@apellidoP", apellidoP);
            parameters.Add("@apellidoM", apellidoM);
            parameters.Add("@telefono", telefono);
            parameters.Add("@correo", correo);
            parameters.Add("@tipo", tipo);
            parameters.Add("@usuario", usuario);
            parameters.Add("@contrasena", contrasena);
            return dataAccess.Execute("stp_usuarios_add", parameters);
        }

        public int Delete()
        {
            var parameters = new DynamicParameters();
            parameters.Add("@idUsuario", idUsuario);
            return dataAccess.Execute("stp_usuarios_delete", parameters);
        }

        public IEnumerable<Usuario> GetAll()
        {
            return dataAccess.Query<Usuario>("stp_usuarios_getall");
        }

        public Usuario GetById()
        {
            var parameters = new DynamicParameters();
            parameters.Add("@idUsuario", idUsuario);
            return dataAccess.QuerySingle<Usuario>("stp_usuarios_getbyid", parameters);
        }
        public Usuario Login()
        {
            var parameters = new DynamicParameters();
            parameters.Add("@usuario", usuario);
            parameters.Add("@contrasena", contrasena);
            return dataAccess.QuerySingle<Usuario>("stp_usuarios_login", parameters);
        }
        public Usuario GetByNombre()
        {
            var parameters = new DynamicParameters();
            parameters.Add("@nombre", nombre);
            return dataAccess.QuerySingle<Usuario>("stp_usuarios_getbynombre", parameters);
        }
        public int Update()
        {
            var parameters = new DynamicParameters();
            parameters.Add("@idUsuario", idUsuario);
            parameters.Add("@idUsuario", idUsuario);
            parameters.Add("@nombre", nombre);
            parameters.Add("@apellidoP", apellidoP);
            parameters.Add("@apellidoM", apellidoM);
            parameters.Add("@telefono", telefono);
            parameters.Add("@correo", correo);
            parameters.Add("@tipo", tipo);
            parameters.Add("@usuario", usuario);
            parameters.Add("@contrasena", contrasena);
            return dataAccess.Execute("stp_usuarios_update", parameters);
        }
    }
}
