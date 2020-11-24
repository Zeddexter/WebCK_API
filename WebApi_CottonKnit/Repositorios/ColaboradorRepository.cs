using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using Dapper.Oracle;
using Oracle.ManagedDataAccess.Client;
using System.Data;
using System.Runtime.InteropServices.WindowsRuntime;
using Microsoft.Win32.SafeHandles;

namespace WebApi_CottonKnit.Repositorios
{

    public class ColaboradorRepository : IColaboradorRepository
    {
        IConfiguration Configuration;
        public ColaboradorRepository(IConfiguration _configuration)
        {
            Configuration = _configuration;
        }

        public object GetColaboradorDetails(int idCol)
        {
            object result = null;
            try
            {
                var dyParam = new OracleDynamicParameters();
                dyParam.Add("pfuncionario", idCol, OracleMappingType.Int32, ParameterDirection.Input);
                dyParam.Add("PCURSOR", null, OracleMappingType.RefCursor, ParameterDirection.Output);
                var conn = this.GetConnection();
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                if (conn.State == ConnectionState.Open)
                {
                    var query = "GETCK_FUNCIONARIOS";
                    result = SqlMapper.Query(conn, query, param: dyParam, commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
        public object GetColaboradorList()
        {
            object result = null;
            try
            {
                var dyParam = new OracleDynamicParameters();
               // dyParam.Add("cod_funcionario", idCol, OracleMappingType.Int32, ParameterDirection.Input);
                dyParam.Add("PCURSOR", null, OracleMappingType.RefCursor, ParameterDirection.Output);
                var conn = this.GetConnection();
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                if (conn.State == ConnectionState.Open)
                {
                    var query = "GETCK_FUNCIONARIOS";
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
