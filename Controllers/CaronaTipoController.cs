using Api.Models;
using Api.Repositorios.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CaronaTipoController : ControllerBase
    {
        private readonly ICaronaTipoRepositorio _caronatipoRepositorio;

        public CaronaTipoController(ICaronaTipoRepositorio caronatipoRepositorio)
        {
            _caronatipoRepositorio = caronatipoRepositorio;
        }

        [HttpGet("GetAllCaronaTipo")]
        public async Task<ActionResult<List<CaronaTipoModel>>> GetAllCaronaTipo()
        {
            List<CaronaTipoModel> caronatipos = await _caronatipoRepositorio.GetAll();
            return Ok(caronatipos);
        }


        [HttpPost("CreateCaronaTipo")]
        public async Task<ActionResult<CaronaTipoModel>> InsertCaronaTipo([FromBody] CaronaTipoModel caronatipoModel)
        {
            CaronaTipoModel caronatipo = await _caronatipoRepositorio.InsertCaronaTipo(caronatipoModel);
            return Ok(caronatipo);
        }


        [HttpPut("UpdateCaronaTipo/{id:int}")]
        public async Task<ActionResult<CaronaTipoModel>> UpdateCaronaTipo(int id, [FromBody] CaronaTipoModel caronatipoModel)
        {
            caronatipoModel.CaronaTipoId = id;
            CaronaTipoModel caronatipo = await _caronatipoRepositorio.UpdateCaronaTipo(caronatipoModel, id);
            return Ok(caronatipo);
        }

        [HttpDelete("DeleteCaronaTipo/{id:int}")]
        public async Task<ActionResult<CaronaTipoModel>> DeleteCaronaTipo(int id)
        {
            bool deleted = await _caronatipoRepositorio.DeleteCaronaTipo(id);
            return Ok(deleted);
        }
    }
}
