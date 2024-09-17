using Api.Models;
using Api.Repositorios.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FaculdadeController : ControllerBase
    {
        private readonly IFaculdadeRepositorio _faculdadeRepositorio;

        public FaculdadeController(IFaculdadeRepositorio faculdadeRepositorio)
        {
            _faculdadeRepositorio = faculdadeRepositorio;
        }

        [HttpGet("GetAllFaculdade")]
        public async Task<ActionResult<List<FaculdadeModel>>> GetAllFaculdade()
        {
            List<FaculdadeModel> faculdades = await _faculdadeRepositorio.GetAll();
            return Ok(faculdades);
        }


        [HttpPost("CreateFaculdade")]
        public async Task<ActionResult<FaculdadeModel>> InsertFaculdade([FromBody] FaculdadeModel faculdadeModel)
        {
            FaculdadeModel faculdade = await _faculdadeRepositorio.InsertFaculdade(faculdadeModel);
            return Ok(faculdade);
        }


        [HttpPut("UpdateFaculdade/{id:int}")]
        public async Task<ActionResult<FaculdadeModel>> UpdateFaculdade(int id, [FromBody] FaculdadeModel faculdadeModel)
        {
            faculdadeModel.FaculdadeId = id;
            FaculdadeModel faculdade = await _faculdadeRepositorio.UpdateFaculdade(faculdadeModel, id);
            return Ok(faculdade);
        }

        [HttpDelete("DeleteFaculdade/{id:int}")]
        public async Task<ActionResult<FaculdadeModel>> DeleteFaculdade(int id)
        {
            bool deleted = await _faculdadeRepositorio.DeleteFaculdade(id);
            return Ok(deleted);
        }
    }
}
