using Api.Models;
using Api.Repositorios;
using Api.Repositorios.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CadastroController : ControllerBase
    {
        private readonly ICadastroRepositorio _cadastroRepositorio;

        
        public CadastroController(ICadastroRepositorio cadastroRepositorio)
        {
            _cadastroRepositorio = cadastroRepositorio;
        }

        [HttpGet("GetAllCadastro")]
        public async Task<ActionResult<List<CadastroModel>>> GetAllCadastro()
        {
            List<CadastroModel> cadastros = await _cadastroRepositorio.GetAll();
            return Ok(cadastros);
        }

        [HttpPost("CreateCadastro")]
        public async Task<ActionResult<CadastroModel>> InsertCadastro([FromBody] CadastroModel cadastroModel)
        {
            CadastroModel cadastro = await _cadastroRepositorio.InsertCadastro(cadastroModel);
            return Ok(cadastro);
        }

        [HttpPut("UpdateCadastro/{id:int}")]
        public async Task<ActionResult<CadastroModel>> UpdateCadastro(int id, [FromBody] CadastroModel cadastroModel)
        {
            cadastroModel.CadastroId = id;
            CadastroModel cadastro = await _cadastroRepositorio.UpdateCadastro(cadastroModel, id);
            return Ok(cadastro);
        }

        [HttpDelete("DeleteCadastro/{id:int}")]
        public async Task<ActionResult<CadastroModel>> DeleteCadastro(int id)
        {
            bool deleted = await _cadastroRepositorio.DeleteCadastro(id);
            return Ok(deleted);
        }

        [HttpPost("Login")]
        public async Task<ActionResult<CadastroModel>> Login([FromBody] CadastroModel cadastroModel)
        {
            CadastroModel cadastro; 
            cadastro = await _cadastroRepositorio.Login(cadastroModel.CadastroEmail, cadastroModel.CadastroSenha );
            return Ok(cadastro);
        }

    }
}
