using Api.Models;
using Api.Repositorios.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SolicitarCaronaController : ControllerBase
    {
        private readonly ISolicitarCaronaRepositorio _solicitarcaronaRepositorio;

        public SolicitarCaronaController(ISolicitarCaronaRepositorio solicitarcaronaRepositorio)
        {
            _solicitarcaronaRepositorio = solicitarcaronaRepositorio;
        }

        [HttpGet("GetAllSolicitarCarona")]
        public async Task<ActionResult<List<SolicitarCaronaModel>>> GetAllSolicitarCarona()
        {
            List<SolicitarCaronaModel> solicitarcaronas = await _solicitarcaronaRepositorio.GetAll();
            return Ok(solicitarcaronas);
        }


        [HttpPost("CreateSolicitarCarona")]
        public async Task<ActionResult<SolicitarCaronaModel>> InsertSolicitarCarona([FromBody] SolicitarCaronaModel solicitarcaronaModel)
        {
            SolicitarCaronaModel solicitarcarona = await _solicitarcaronaRepositorio.InsertSolicitarCarona(solicitarcaronaModel);
            return Ok(solicitarcarona);
        }


        [HttpPut("UpdateSolicitarCarona/{id:int}")]
        public async Task<ActionResult<SolicitarCaronaModel>> UpdateSolicitarCarona(int id, [FromBody] SolicitarCaronaModel solicitarcaronaModel)
        {
            solicitarcaronaModel.SolicitarCaronaId = id;
            SolicitarCaronaModel solicitarcarona = await _solicitarcaronaRepositorio.UpdateSolicitarCarona(solicitarcaronaModel, id);
            return Ok(solicitarcarona);
        }

        [HttpDelete("DeleteSolicitarCarona/{id:int}")]
        public async Task<ActionResult<SolicitarCaronaModel>> DeleteSolicitarCarona(int id)
        {
            bool deleted = await _solicitarcaronaRepositorio.DeleteSolicitarCarona(id);
            return Ok(deleted);
        }
    }
}
