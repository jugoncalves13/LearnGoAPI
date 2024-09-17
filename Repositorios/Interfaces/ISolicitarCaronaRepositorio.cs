using Api.Models;

namespace Api.Repositorios.Interfaces
{
    public interface ISolicitarCaronaRepositorio
    {
        Task<List<SolicitarCaronaModel>> GetAll();

        Task<SolicitarCaronaModel> GetById(int id);

        Task<SolicitarCaronaModel> InsertSolicitarCarona(SolicitarCaronaModel solicitarcarona);

        Task<SolicitarCaronaModel> UpdateSolicitarCarona(SolicitarCaronaModel solicitarcarona, int id);

        Task<bool> DeleteSolicitarCarona(int id);
    }
}
