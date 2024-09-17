using Api.Models;
using Api.Repositorios.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OfertarCaronaController : ControllerBase
    {
        private readonly IOfertarCaronaRepositorio _ofertarcaronaRepositorio;

        public OfertarCaronaController(IOfertarCaronaRepositorio ofertarcaronaRepositorio)
        {
            _ofertarcaronaRepositorio = ofertarcaronaRepositorio;
        }

        [HttpGet("GetAllOfertarCarona")]
        public async Task<ActionResult<List<OfertarCaronaModel>>> GetAllOfertarCarona()
        {
            List<OfertarCaronaModel> ofertarcaronas = await _ofertarcaronaRepositorio.GetAll();
            return Ok(ofertarcaronas);
        }


        [HttpPost("CreateOfertarCarona")]
        public async Task<ActionResult<OfertarCaronaModel>> InsertOfertarCarona([FromBody] OfertarCaronaModel ofertarcaronaModel)
        {
            OfertarCaronaModel ofertarcarona = await _ofertarcaronaRepositorio.InsertOfertarCarona(ofertarcaronaModel);
            return Ok(ofertarcarona);
        }


        [HttpPut("UpdateOfertarCarona/{id:int}")]
        public async Task<ActionResult<OfertarCaronaModel>> UpdateOfertarCarona(int id, [FromBody] OfertarCaronaModel ofertarcaronaModel)
        {
            ofertarcaronaModel.OfertarCaronaId = id;
            OfertarCaronaModel ofertarcarona = await _ofertarcaronaRepositorio.UpdateOfertarCarona(ofertarcaronaModel, id);
            return Ok(ofertarcarona);
        }

        [HttpDelete("DeleteOfertarCarona/{id:int}")]
        public async Task<ActionResult<OfertarCaronaModel>> DeleteOfertarCarona(int id)
        {
            bool deleted = await _ofertarcaronaRepositorio.DeleteOfertarCarona(id);
            return Ok(deleted);
        }
    }
}
