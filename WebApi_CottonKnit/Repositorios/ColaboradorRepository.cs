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

    public class ColaboradorRepository : ICrudRepository<Colaborador>
    {
        public Task<bool> Delete(int id)
        {
            throw new NotImplementedException();
        }
        public async Task<object> GetAll()
        {
            try
            {
                CottonData db = new CottonData();
                DbParametro[] parametro = new DbParametro[0];
                var colab = await db.GetData("GETCK_FUNCIONARIOSWEB", parametro);
                return colab;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<object> GetDetail(int id)
        {
            try
            {
                CottonData db = new CottonData();
                DbParametro[] parametro = new DbParametro[1];
                parametro[0] = new DbParametro("pfuncionario", id);
                var colab = await db.GetData("GETCK_FUNCIONARIOSWEB", parametro);
                return colab;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Task<bool> Update(Colaborador obj)
        {
            throw new NotImplementedException();
        }
        public Task<bool> Insert(Colaborador obj)
        {
            throw new NotImplementedException();
        }
    }
}
