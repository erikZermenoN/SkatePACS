using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataAccess
    {
        #region Singleton
        private static volatile DataAccess instance = null;
        private static readonly object padlock = new object();
        public static string conString = "Data Source=JRAD;Initial Catalog=ProyectoPACSD;Integrated Security=True";
        public string initialCatalog = "";
        public string DataSource = "";
        public string UserID = "";
        public string Password = "";
        private byte[] Clave = Encoding.ASCII.GetBytes("PACS.2021");
        private byte[] IV = Encoding.ASCII.GetBytes("Devjoker7.37hAES");

        public DataAccess() { }

        public static DataAccess Instance()
        {
            if (instance == null)
                lock (padlock)
                    if (instance == null)
                        instance = new DataAccess();
            return instance;
        }
        #endregion

        #region Query/Execute
        public T QuerySingle<T>(string query)
        {
            using (var con = new SqlConnection(conString))
            {
                return con.QuerySingle<T>(query, commandType: CommandType.StoredProcedure, commandTimeout: 300);
            }
        }

        public T QuerySingle<T>(string query, DynamicParameters parameters)
        {
            using (var con = new SqlConnection(conString))
            {
                return con.QuerySingleOrDefault<T>(query, parameters, commandType: CommandType.StoredProcedure, commandTimeout: 300);
            }
        }

        public T QuerySingleOrDefault<T>(string query, DynamicParameters parameters)
        {
            using (var con = new SqlConnection(conString))
            {
                return con.QuerySingleOrDefault<T>(query, parameters, commandType: CommandType.StoredProcedure, commandTimeout: 300);
            }
        }

        public string QueryString(string query)
        {
            using (var con = new SqlConnection(conString))
            {
                return con.QuerySingle(query, commandType: CommandType.StoredProcedure, commandTimeout: 300);
            }
        }

        public string QueryString(string query, DynamicParameters parameters)
        {
            using (var con = new SqlConnection(conString))
            {
                return con.QuerySingle(query, parameters, commandType: CommandType.StoredProcedure, commandTimeout: 300);
            }
        }

        public IEnumerable<T> Query<T>(String query)
        {
            using (var con = new SqlConnection(conString))
            {
                return con.Query<T>(query, commandType: CommandType.StoredProcedure, commandTimeout: 300);
            }
        }

        public IEnumerable<T> Query<T>(String query, DynamicParameters parameters)
        {
            using (var con = new SqlConnection(conString))
            {
                return con.Query<T>(query, parameters, commandType: CommandType.StoredProcedure, commandTimeout: 300);
            }
        }

        public int Execute(string query, DynamicParameters parameters)
        {
            using (var con = new SqlConnection(conString))
            {
                return con.Execute(query, parameters, commandType: CommandType.StoredProcedure, commandTimeout: 300);
            }
        }

        public int insert(string query, DynamicParameters parameters, string fielName)
        {
            using (var con = new SqlConnection(conString))
            {
                return (int)((IDictionary<string, object>)con.QuerySingle(query, parameters, commandType: CommandType.StoredProcedure, commandTimeout: 300))[fielName];
            }
        }
        #endregion
    }
}
