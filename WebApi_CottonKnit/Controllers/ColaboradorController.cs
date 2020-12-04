using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebApi_CottonKnit.Modelos;
using WebApi_CottonKnit.Repositorios;

namespace WebApi_CottonKnit.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    //[Produces("application/json")]
    public class ColaboradorController : Controller
    {
        ICrudRepository<Colaborador> colaboradorRepository;
        public ColaboradorController(ICrudRepository<Colaborador> _colaboradorRepository)
        {
            colaboradorRepository = _colaboradorRepository;
        }
        //[Route("api/GetColaboradorList")]
        [HttpGet]
        public async Task<IActionResult> GetColaboradorList()
        {
            try
            {
                var result = await colaboradorRepository.GetAll();
                if (result == null)
                {
                    return NotFound();
                }
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        //[Route("api/GetColaboradorDetails/{idCol}")]
        [HttpGet("{id}")]
        public IActionResult GetColaboradorDetails(int id)
        {
            var result = colaboradorRepository.GetDetail(id);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }
    }
}