using Api.Models;

namespace Api.Repositorios.Interfaces
{
    public interface ICaronaHasCadastroRepositorio
    {
        Task<List<CaronaHasCadastroModel>> GetAll();

        Task<CaronaHasCadastroModel> GetById(int id);

        Task<CaronaHasCadastroModel> InsertCaronaHasCadastro(CaronaHasCadastroModel caronahascadastro);

        Task<bool> DeleteCaronaHasCadastro(int id);
    }
}
