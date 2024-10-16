using Api.Models;
using Api.Repositorios.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CaronaHasCadastroController : ControllerBase
    {
        private readonly ICaronaHasCadastroRepositorio _caronahascadastroRepositorio;

        public CaronaHasCadastroController(ICaronaHasCadastroRepositorio caronahascadastroRepositorio)
        {
            _caronahascadastroRepositorio = caronahascadastroRepositorio;
        }

        [HttpGet("GetAllCaronaHasCadastro")]
        public async Task<ActionResult<List<CaronaHasCadastroModel>>> GetAllCaronaHasCadastro()
        {
            List<CaronaHasCadastroModel> caronahascadastro = await _caronahascadastroRepositorio.GetAll();
            return Ok(caronahascadastro);
        }


        [HttpPost("CreateCaronaHasCadastro")]
        public async Task<ActionResult<CaronaHasCadastroModel>> InsertCaronaHasCadastro([FromBody] CaronaHasCadastroModel caronahascadastroModel)
        {
            CaronaHasCadastroModel caronahascadastro= await _caronahascadastroRepositorio.InsertCaronaHasCadastro(caronahascadastroModel);
            return Ok(caronahascadastro);
        }


        [HttpDelete("DeleteCaronaHasCadastro/{id:int}")]
        public async Task<ActionResult<CaronaHasCadastroModel>> DeleteCaronaHasCadastro(int id)
        {
            bool deleted = await _caronahascadastroRepositorio.DeleteCaronaHasCadastro(id);
            return Ok(deleted);
        }
    }
}
