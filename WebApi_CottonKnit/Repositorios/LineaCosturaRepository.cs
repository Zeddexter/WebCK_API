using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi_CottonKnit.Repositorios
{
    public class LineaCosturaRepository
    {
        public async Task<object> GetLineaCostura(int id)
        {
            try
            {
                CottonData db = new CottonData();
                DbParametro[] parametro = new DbParametro[1];
                parametro[0] = new DbParametro("plinea", id);
                var linea = await db.GetData("GETCK_CONF_LINEACOSTURA", parametro);
                return linea;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
