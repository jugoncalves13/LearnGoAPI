using Api.Models;
using Api.Repositorios.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CaronaController : ControllerBase
    {
        private readonly ICaronaRepositorio _caronaRepositorio;

        public CaronaController(ICaronaRepositorio caronaRepositorio)
        {
            _caronaRepositorio = caronaRepositorio;
        }

        [HttpGet("GetAllCarona")]
        public async Task<ActionResult<List<CaronaModel>>> GetAllCarona()
        {
            List<CaronaModel> caronas = await _caronaRepositorio.GetAll();
            return Ok(caronas);
        }


        [HttpPost("CreateCarona")]
        public async Task<ActionResult<CaronaModel>> InsertCarona([FromBody] CaronaModel caronaModel)
        {
            CaronaModel carona = await _caronaRepositorio.InsertCarona(caronaModel);
            return Ok(carona);
        }


        [HttpPut("UpdateCarona/{id:int}")]
        public async Task<ActionResult<CaronaModel>> UpdateCarona(int id, [FromBody] CaronaModel caronaModel)
        {
            caronaModel.CaronaId = id;
            CaronaModel carona = await _caronaRepositorio.UpdateCarona(caronaModel, id);
            return Ok(carona);
        }

        [HttpDelete("DeleteCarona/{id:int}")]
        public async Task<ActionResult<CaronaModel>> DeleteCarona(int id)
        {
            bool deleted = await _caronaRepositorio.DeleteCarona(id);
            return Ok(deleted);
        }
    }
}
