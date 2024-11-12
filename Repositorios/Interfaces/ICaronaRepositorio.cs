using Api.Models;
using Microsoft.OpenApi.Any;

namespace Api.Repositorios.Interfaces
{
    public interface ICaronaRepositorio
    {
        Task<List<CaronaModel>> GetAll();

        Task<List<CaronaModel>> FiltroCarona( String origem, String destino);

        Task<CaronaModel> GetById(int id);

        Task<CaronaModel> InsertCarona(CaronaModel carona);

        Task<CaronaModel> UpdateCarona(CaronaModel carona, int id);

        Task<bool> DeleteCarona(int id);
    }
}
