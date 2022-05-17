using DAL;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BML
{
    public class InicioSesion
    {
        public int idInicioSesion { get; set; }
        public string idUsuario { get; set; }
        public string fechaInicio { get; set; }
        public string fechaTermino { get; set; }
        public string fechaLimite { get; set; }
        public bool activo { get; set; }

        private DataAccess dataAccess = DataAccess.Instance();

        public InicioSesion() { }

        public int InicioDeSesion()
        {
            var parameters = new DynamicParameters();
            parameters.Add("@idUsuario", idUsuario);
            parameters.Add("@fechaInicio", fechaInicio);
            parameters.Add("@fechaTermino", fechaTermino);
            parameters.Add("@fechaLimite", fechaLimite);
            return dataAccess.Execute("stp_iniciosesiones_inicio", parameters);
        }

        public int CerrarSesion()
        {
            var parameters = new DynamicParameters();
            parameters.Add("@idInicioSesion", idInicioSesion);
            parameters.Add("@fechaTermino", fechaTermino);
            return dataAccess.Execute("stp_iniciosesiones_cerrar", parameters);
        }

        public InicioSesion GetByActivo()
        {
            return dataAccess.QuerySingle<InicioSesion>("stp_iniciosesiones_getbyActivo");
        }

    }
}
