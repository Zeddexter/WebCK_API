using WebApi_CottonKnit.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi_CottonKnit.Repositorios
{
    public interface ICrudRepository<T>
    {
        object GetAll();
        object GetDetail(int id);
        bool Delete(int id);
        bool Update(T obj);
        bool Insert(T obj);
        //IEnumerable<T> Gets();
        //T Get(int id);
    }
    public interface ICrudIERepository<T>
    {
        IEnumerable<T> Gets();
        T Get(int id);
    }
}
