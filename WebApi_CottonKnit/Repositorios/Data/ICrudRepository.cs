using WebApi_CottonKnit.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi_CottonKnit.Repositorios
{
    public interface ICrudRepository<T>
    {
        object GetColaboradorAll();
        object GetColaboradorDetail(int id);

        bool Update(T colaborador);
        IEnumerable<T> Gets();
        T Get(int id);
        bool Delete(int id);
    }
}
