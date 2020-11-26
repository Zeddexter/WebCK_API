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
        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }
        public object GetAll()
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
        public object GetDetail(int id)
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
        public bool Update(Colaborador obj)
        {
            throw new NotImplementedException();
        }
        public bool Insert(Colaborador obj)
        {
            throw new NotImplementedException();
        }
    }
}
