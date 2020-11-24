using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi_CottonKnit.Modelos;

namespace WebApi_CottonKnit.Repositorios
{
    public interface IColaboradorRepository
    {
        object GetColaboradorList();
        object GetColaboradorDetails(int idCol);
    }
    //public class RpColaborador
    //{
    //    //public Colaborador ObtenerColaborador(int id)
    //    //{
    //    //    var colaborador = 
    //    //    return colaborador.fir
    //    //}
    //}
}
