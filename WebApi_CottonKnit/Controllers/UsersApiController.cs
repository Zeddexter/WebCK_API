﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi_CottonKnit.Modelos;
using WebApi_CottonKnit.Repositorios;

namespace WebApi_CottonKnit.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersApiController : Controller
    {
        ICrudRepository<UsersApi> _crudRepository;
        public UsersApiController(ICrudRepository<UsersApi> crudRepository)
        {
            _crudRepository = crudRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetUserApiAll()
        {
            try
            {
                var result = await _crudRepository.GetAll();
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
        [HttpGet("{id}")]
        public async Task<IActionResult> GetUserDetail(string id)
        {
            try
            {
                var result = await _crudRepository.GetDetail(Convert.ToInt32(id));
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

        [HttpPost]
        public async Task<IActionResult> insertUserApi([FromBody] UsersApi usersApi)
        {
            try
            {
                if (usersApi == null)
                {
                    return BadRequest();
                }
                if (usersApi.Nombre.Trim() == string.Empty && usersApi.Apellido_1.Trim() == string.Empty && usersApi.Usuario.Trim() == string.Empty)
                {
                    ModelState.AddModelError("error", "uno de los Siguietes datos están vacíos");
                }
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
                bool created = true;
                if (usersApi.Id == string.Empty || usersApi.Id == null)
                {
                    created = await _crudRepository.Insert(usersApi);
                }
                return Created("created", created);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }            
        }

        [HttpPut]
        public async Task<IActionResult> UpdateUsersApi([FromBody] UsersApi userApi)
        {
            try
            {
                if (userApi == null)
                {
                    return BadRequest();
                }                   
                if (userApi.Nombre.Trim() == string.Empty && userApi.Apellido_1.Trim() == string.Empty && userApi.Usuario.Trim() == string.Empty)
                {
                    ModelState.AddModelError("error", "uno de los Siguietes datos están vacíos");
                }
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
                if (userApi.Id.Trim() == string.Empty || userApi.Id == null)
                {
                    return BadRequest();
                }
                await _crudRepository.Update(userApi);

                return NoContent();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }            
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUserApi(string id)
        {
            try
            {
                if (id.Trim() == string.Empty|| id == null)
                {
                    return BadRequest();
                }                   
                await _crudRepository.Delete(Convert.ToInt32(id));
                return NoContent();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
