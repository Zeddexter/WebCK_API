using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi_CottonKnit.Repositorios;

namespace WebApi_CottonKnit.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LineaCosturaController : ControllerBase
    {
        LineaCosturaRepository _LineaCostura = new LineaCosturaRepository;
        [HttpGet("{id}")]
        public IActionResult GetColaboradorDetails(int id)
        {
            var result = _LineaCostura.GetLineaCostura(id);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }
    }
}
