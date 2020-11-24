using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApi_CottonKnit.Repositorios;

namespace WebApi_CottonKnit.Controllers
{
    //[Route("api/[controller]")]
    //[ApiController]
    [Produces("application/json")]
    public class RepDespachosController : ControllerBase
    {
        IRepDespachos RepDespachos;
        public RepDespachosController(IRepDespachos _repDespachos)
        {
            RepDespachos = _repDespachos;
        }
        [Route("api/GetDespachos")]
        //[HttpGet]
        public IActionResult GetDespachos()
        {
            var result = RepDespachos.GetDespachos();
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }
    }
}