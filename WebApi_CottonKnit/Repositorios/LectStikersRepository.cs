using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi_CottonKnit.Modelos;
using WebApi_CottonKnit.Repositorios.Interfaces;

namespace WebApi_CottonKnit.Repositorios
{
    public class LectStikersRepository : ILectStikersRepository<Stikers>
    {
        CottonData db;
        public async Task<object> GetAll(Stikers obj)
        {
            try
            {
                db = new CottonData();
                DbParametro[] parametros = new DbParametro[2];
                parametros[0] = new DbParametro("p_orderprod", obj.ordem_producao);
                parametros[1] = new DbParametro("p_ordenconfec", obj.ordem_confeccao);
                var resurl = await db.GetData("GETCK_STIKERSMOVILP", parametros);
                return resurl;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
