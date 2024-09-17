using Api.Models;
using Api.Repositorios;
using Api.Repositorios.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ObservacoesController : ControllerBase
    {
        private readonly IObservacoesRepositorio _observacoesRepositorio;

        public ObservacoesController(IObservacoesRepositorio observacoesRepositorio)
        {
            _observacoesRepositorio = observacoesRepositorio;
        }

        [HttpGet("GetAllObservacoes")]
        public async Task<ActionResult<List<ObservacoesModel>>> GetAllObservacoes()
        {
            List<ObservacoesModel> observacoess = await _observacoesRepositorio.GetAll();
            return Ok(observacoess);
        }

       

        [HttpPost("CreateObservacoes")]
        public async Task<ActionResult<ObservacoesModel>> InsertObservacoes([FromBody] ObservacoesModel observacoesModel)
        {
            ObservacoesModel observacoes = await _observacoesRepositorio.InsertObservacoes(observacoesModel);
            return Ok(observacoes);
        }

        [HttpPut("UpdateObservacoes/{id:int}")]
        public async Task<ActionResult<ObservacoesModel>> UpdateObservacoes(int id, [FromBody] ObservacoesModel observacoesModel)
        {
            observacoesModel.ObservacoesId = id;
            ObservacoesModel observacoes = await _observacoesRepositorio.UpdateObservacoes(observacoesModel, id);
            return Ok(observacoes);
        }

        [HttpDelete("DeleteObservacoes/{id:int}")]
        public async Task<ActionResult<ObservacoesModel>> DeleteObservacoes(int id)
        {
            bool deleted = await _observacoesRepositorio.DeleteObservacoes(id);
            return Ok(deleted);
        }
    }
}
