using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebApi_CottonKnit.Repositorios;

namespace WebApi_CottonKnit.Controllers
{
    //[Route("api/[controller]")]
    //[ApiController]
    [Produces("application/json")]
    public class ColaboradorController : ControllerBase
    {
        IColaboradorRepository colaboradorRepository;
        public ColaboradorController(IColaboradorRepository _colaboradorRepository)
        {
            colaboradorRepository = _colaboradorRepository;
        }
        [Route("api/GetColaboradorList")]
        //[HttpGet]
        public IActionResult GetColaboradorList()
        {
            var result = colaboradorRepository.GetColaboradorList();
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }
        [Route("api/GetColaboradorDetails/{idCol}")]
        //[HttpGet]
        public IActionResult GetColaboradorDetails(int idcol)
        {
            var result = colaboradorRepository.GetColaboradorDetails(idcol);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }

    }
}