using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi_CottonKnit.Repositorios.Interfaces
{
    public interface ILectStikersRepository<T>
    {
        Task<object> GetAll(T obj);
    }
}
