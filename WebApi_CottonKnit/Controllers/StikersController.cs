using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi_CottonKnit.Modelos;
using WebApi_CottonKnit.Repositorios.Interfaces;

namespace WebApi_CottonKnit.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StikersController : Controller
    {
        ILectStikersRepository<Stikers> _StikersRepos;
        public StikersController(ILectStikersRepository<Stikers> stikersRepos)
        {
            _StikersRepos = stikersRepos;
        }

        [HttpPost]
        public async Task<IActionResult> getall ([FromBody] Stikers stikers)
        {
            try
            {
                if (stikers == null)
                {
                    return BadRequest();
                }
                if (stikers.ordem_confeccao.Trim() == string.Empty && stikers.ordem_producao.Trim() == string.Empty)
                {
                    ModelState.AddModelError("error", "uno de los Siguietes datos están vacíos");
                }
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
                var result = await _StikersRepos.GetAll(stikers);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}
