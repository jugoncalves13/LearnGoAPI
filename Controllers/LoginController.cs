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

        [HttpPost("CreateLogin")]
        public async Task<ActionResult<LoginModel>> InsertLogin([FromBody] LoginModel loginModel)
        {
            LoginModel login = await _loginRepositorio.InsertLogin(loginModel);
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
