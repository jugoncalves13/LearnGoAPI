using Api.Models;
using Api.Repositorios;
using Api.Repositorios.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AvaliacaoController : ControllerBase
    {
        private readonly IAvaliacaoRepositorio _avaliacaoRepositorio;

        public AvaliacaoController(IAvaliacaoRepositorio avaliacaoRepositorio)
        {
            _avaliacaoRepositorio = avaliacaoRepositorio;
        }

        [HttpGet("GetAllAvaliacao")]
        public async Task<ActionResult<List<AvaliacaoModel>>> GetAllAvaliacao()
        {
            List<AvaliacaoModel> avaliacoes = await _avaliacaoRepositorio.GetAll();
            return Ok(avaliacoes);
        }

        [HttpGet("GetAvaliacaoId/{id}")]
        public async Task<ActionResult<AvaliacaoModel>> GetAvaliacaoId(int id)
        {
            AvaliacaoModel avaliacao = await _avaliacaoRepositorio.GetById(id);
            return Ok(avaliacao);
        }
        [HttpPost("CreateAvaliacao")]
        public async Task<ActionResult<AvaliacaoModel>> InsertAvaliacao([FromBody] AvaliacaoModel avaliacaoModel)
        {
            AvaliacaoModel avaliacao = await _avaliacaoRepositorio.InsertAvaliacao(avaliacaoModel);
            return Ok(avaliacao);
        }

        [HttpPut("UpdateAvaliacao/{id:int}")]
        public async Task<ActionResult<AvaliacaoModel>> UpdateAvaliacao(int id, [FromBody] AvaliacaoModel avaliacaoModel)
        {
            avaliacaoModel.AvaliacaoId = id;
            AvaliacaoModel avaliacao = await _avaliacaoRepositorio.UpdateAvaliacao(avaliacaoModel, id);
            return Ok(avaliacao);
        }

        [HttpDelete("DeleteAvaliacao/{id:int}")]
        public async Task<ActionResult<AvaliacaoModel>> DeleteAvaliacao(int id)
        {
            bool deleted = await _avaliacaoRepositorio.DeleteAvaliacao(id);
            return Ok(deleted);
        }
    }
}
