using Api.Models;

namespace Api.Repositorios.Interfaces
{
    public interface ILoginRepositorio
    {
        Task<List<LoginModel>> GetAll();

        Task<LoginModel> GetById(int id);

        Task<LoginModel> InsertLogin(LoginModel login);

        Task<LoginModel> UpdateLogin(LoginModel login, int id);

        Task<bool> DeleteLogin(int id);

    }
}
