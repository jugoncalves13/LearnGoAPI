using Api.Models;
using Api.Repositorios.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly ILoginRepositorio _loginRepositorio;

        public LoginController(ILoginRepositorio loginRepositorio)
        {
            _loginRepositorio = loginRepositorio;
        }

        [HttpGet("GetAllLogin")]
        public async Task<ActionResult<List<LoginModel>>> GetAllLogin()
        {
            List<LoginModel> logins = await _loginRepositorio.GetAll();
            return Ok(logins);
        }

        [HttpGet("GetLoginId/{id}")]
        public async Task<ActionResult<LoginModel>> GetLoginId(int id)
        {
            LoginModel usuario = await _loginRepositorio.GetById(id);
            return Ok(usuario);
        }

        [HttpPost("CreateLogin")]
        public async Task<ActionResult<LoginModel>> InsertLogin([FromBody] LoginModel loginModel)
        {
            LoginModel login = await _loginRepositorio.InsertLogin(loginModel);
            return Ok(login);
        }

        [HttpPost("Login")]
        public async Task<ActionResult<bool>> Login([FromBody] LoginModel loginModel)
        {
            var login = await _loginRepositorio.Login(loginModel.LoginEmail, loginModel.LoginSenha);
            return Ok(login);
        }

        [HttpPut("UpdateLogin/{id:int}")]
        public async Task<ActionResult<LoginModel>> UpdateLogin(int id, [FromBody] LoginModel loginModel)
        {
            loginModel.LoginId = id;
            LoginModel login = await _loginRepositorio.UpdateLogin(loginModel, id);
            return Ok(login);
        }

        [HttpDelete("DeleteLogin/{id:int}")]
        public async Task<ActionResult<LoginModel>> DeleteLogin(int id)
        {
            bool deleted = await _loginRepositorio.DeleteLogin(id);
            return Ok(deleted);
        }
    }

}
