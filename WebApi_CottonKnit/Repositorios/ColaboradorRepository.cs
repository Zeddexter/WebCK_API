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
using WebApi_CottonKnit.Modelos;

namespace WebApi_CottonKnit.Repositorios
{

    public class ColaboradorRepository : ICrudRepository<Colaborador>//IColaboradorRepository
    {
        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }
        public Colaborador Get(int id)
        {
            throw new NotImplementedException();
        }

        public object GetColaboradorAll()
        {
            try
            {
                CottonData db = new CottonData();
                DbParametro[] parametro = new DbParametro[0];
                var colab = db.GetData("GETCK_FUNCIONARIOSWEB", parametro);
                return colab;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public object GetColaboradorDetail(int id)
        {
            try
            {
                CottonData db = new CottonData();
                DbParametro[] parametro = new DbParametro[1];
                parametro[0] = new DbParametro("pfuncionario", id);
                var colab = db.GetData("GETCK_FUNCIONARIOSWEB", parametro);
                return colab;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<Colaborador> Gets()
        {
            try
            {
                CottonData db = new CottonData();
                DbParametro[] parametro = new DbParametro[0];
                return db.GetDataClass<Colaborador>("GETCK_FUNCIONARIOSWEB", parametro);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool Update(Colaborador colaborador)
        {
            throw new NotImplementedException();
        }
        /*IConfiguration Configuration;
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
        }*/
    }
}
