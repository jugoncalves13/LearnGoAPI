using Api.Models;

namespace Api.Repositorios.Interfaces
{
    public interface IFaculdadeRepositorio
    {
        Task<List<FaculdadeModel>> GetAll();

        Task<FaculdadeModel> GetById(int id);

        Task<FaculdadeModel> InsertFaculdade(FaculdadeModel faculdade);

        Task<FaculdadeModel> UpdateFaculdade(FaculdadeModel faculdade, int id);

        Task<bool> DeleteFaculdade(int id);

    }
}
