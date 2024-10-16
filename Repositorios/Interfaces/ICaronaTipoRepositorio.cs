using Api.Models;

namespace Api.Repositorios.Interfaces
{
    public interface ICaronaTipoRepositorio
    {
        Task<List<CaronaTipoModel>> GetAll();

        Task<CaronaTipoModel> GetById(int id);

        Task<CaronaTipoModel> InsertCaronaTipo(CaronaTipoModel login);

        Task<CaronaTipoModel> UpdateCaronaTipo(CaronaTipoModel login, int id);

        Task<bool> DeleteCaronaTipo(int id);

    }
}
