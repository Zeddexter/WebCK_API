using Dapper;
using Dapper.Oracle;
using Microsoft.Extensions.Configuration;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi_CottonKnit.Repositorios
{
    public class RepDespachosRepository: IRepDespachos
    {
        IConfiguration Configuration;
        public RepDespachosRepository(IConfiguration _configuration)
        {
            Configuration = _configuration;
        }

        public object GetDespachos()
        {
            object result = null;
            try
            {
                var dyParam = new OracleDynamicParameters();
                // dyParam.Add("cod_funcionario", idCol, OracleMappingType.Int32, ParameterDirection.Input);
                dyParam.Add("paniosem", 202011, OracleMappingType.Int32, ParameterDirection.Input);
                dyParam.Add("PCURSOR", null, OracleMappingType.RefCursor, ParameterDirection.Output);
                var conn = this.GetConnection();
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                if (conn.State == ConnectionState.Open)
                {
                    var query = "GETCK_COM_REPDESPACHOS";
                    result = SqlMapper.Query(conn, query, param: dyParam, commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
        public IDbConnection GetConnection()
        {
            var connectionString = Configuration.GetSection("ConnectionStrings").GetSection("BDConnection").Value;
            var conn = new OracleConnection(connectionString);
            return conn;
        }
    }
}
