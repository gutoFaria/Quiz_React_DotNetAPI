using backend.Models;
using backend.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TemaController : ControllerBase
    {
        private readonly ITemaService _service;

        public TemaController(ITemaService service)
        {
            _service = service;
        }

        [HttpGet]
        [Route("/getalltemas")]
        public async Task<IActionResult> GetAllTemas()
        {
            var res = await _service.GetAllTemas();
            return Ok(res);
        }

        [HttpGet]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme,Roles = "Administrator")]
        [Route("/gettemabyid/{id}")]
        public async Task<IActionResult> GetTemaById(int id)
        {
            var res = await _service.GetTemaById(id);
            if(res != null)
                return Ok(res);
            
            return NotFound();
        }

        [HttpPost]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme,Roles = "Administrator")]
        [Route("/createtema")]
        public async Task<IActionResult> CreateTema(Tema tema)
        {
            await _service.CreateTema(tema);
            return Ok(tema);
        }

        [HttpPut]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme,Roles = "Administrator")]
        [Route("/updatetema")]
        public async Task<IActionResult> UpdateTema(Tema tema)
        {
            var updateTema = await _service.UpdateTema(tema);
            if(updateTema is null)
                return NotFound("Post not found");
            return Ok(updateTema);
        }

        [HttpDelete]
        [Route("/deletetema/{id}")]
        public async Task<IActionResult> DeleteTema(int id)
        {
            var result = await _service.DeleteTema(id);
            if(!result) BadRequest("Somethingwent wrong");
            return Ok(result);
        }
    }
}