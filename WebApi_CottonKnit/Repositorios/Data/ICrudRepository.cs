using WebApi_CottonKnit.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi_CottonKnit.Repositorios
{
    public interface ICrudRepository<T>
    {
        Task<object> GetAll();
        Task<object> GetDetail(int id);
        Task<bool> Delete(int id);
        Task<bool> Update(T obj);
        Task<bool> Insert(T obj);
        //IEnumerable<T> Gets();
        //T Get(int id);
    }
    public interface ICrudIERepository<T>
    {
        IEnumerable<T> Gets();
        T Get(int id);
    }
}
