using Api.Data;
using Api.Models;
using Api.Repositorios.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Api.Repositorios
{
    public class LoginRepositorio : ILoginRepositorio
    {
        private readonly Contexto _dbContext;

        public LoginRepositorio(Contexto dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<LoginModel>> GetAll()
        {
            return await _dbContext.Login.ToListAsync();
        }

        public async Task<LoginModel> GetById(int id)
        {
            return await _dbContext.Login.FirstOrDefaultAsync(x => x.LoginId == id);
        }

        public async Task<LoginModel> InsertLogin(LoginModel login)
        {
            await _dbContext.Login.AddAsync(login);
            await _dbContext.SaveChangesAsync();
            return login;
        }

        public async Task<LoginModel> UpdateLogin(LoginModel login, int id)
        {
            LoginModel logins = await GetById(id);
            if (logins == null)
            {
                throw new Exception("Não encontrado.");
            }
            else
            {
                logins.LoginEmail = login.LoginEmail;
                logins.LoginSenha = login.LoginSenha;
                _dbContext.Login.Update(logins);
                await _dbContext.SaveChangesAsync();
            }
            return logins;

        }

        public async Task<bool> DeleteLogin(int id)
        {
            LoginModel logins = await GetById(id);
            if (logins == null)
            {
                throw new Exception("Não encontrado.");
            }

            _dbContext.Login.Remove(logins);
            await _dbContext.SaveChangesAsync();
            return true;
        }


    }
}
