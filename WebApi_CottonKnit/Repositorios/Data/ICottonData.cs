using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi_CottonKnit.Repositorios
{
    public interface ICottonData
    {
        object GetData(string stored, DbParametro[] parametro);
        bool SetData(string stored, DbParametro[] parametro);
    }
}
