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
        public int idUsuario { get; set; }
        public DateTime fechaInicio { get; set; }
        public DateTime fechaTermino { get; set; }
        public DateTime fechaLimite { get; set; }
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
            var parameters = new DynamicParameters();
            parameters.Add("@activo", activo);
            return dataAccess.QuerySingle<InicioSesion>("stp_iniciosesiones_getbyactivo", parameters);
        }

    }
}
