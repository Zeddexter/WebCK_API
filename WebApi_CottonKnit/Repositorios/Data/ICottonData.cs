using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi_CottonKnit.Repositorios
{
    public interface ICottonData
    {
         Task<object> GetData(string stored, DbParametro[] parametro);
        Task<bool> SetData(string stored, DbParametro[] parametro);
    }
}
