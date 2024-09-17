using Api.Models;
using Api.Repositorios.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PerfilController : ControllerBase
    {
        private readonly IPerfilRepositorio _perfilRepositorio;

        public PerfilController(IPerfilRepositorio perfilRepositorio)
        {
            _perfilRepositorio = perfilRepositorio;
        }

        [HttpGet("GetAllPerfil")]
        public async Task<ActionResult<List<PerfilModel>>> GetAllPerfil()
        {
            List<PerfilModel> perfis = await _perfilRepositorio.GetAll();
            return Ok(perfis);
        }


        [HttpPost("CreatePerfil")]
        public async Task<ActionResult<PerfilModel>> InsertPerfil([FromBody] PerfilModel perfilModel)
        {
            PerfilModel perfil = await _perfilRepositorio.InsertPerfil(perfilModel);
            return Ok(perfil);
        }


        [HttpPut("UpdateFaculdade/{id:int}")]
        public async Task<ActionResult<PerfilModel>> UpdatePerfil(int id, [FromBody] PerfilModel perfilModel)
        {
            perfilModel.PerfilId = id;
            PerfilModel perfil = await _perfilRepositorio.UpdatePerfil(perfilModel, id);
            return Ok(perfil);
        }

        [HttpDelete("DeletePerfil/{id:int}")]
        public async Task<ActionResult<PerfilModel>> DeletePerfil(int id)
        {
            bool deleted = await _perfilRepositorio.DeletePerfil(id);
            return Ok(deleted);
        }
    }
}
