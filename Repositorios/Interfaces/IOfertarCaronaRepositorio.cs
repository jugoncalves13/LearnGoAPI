using Api.Models;

namespace Api.Repositorios.Interfaces
{
    public interface IOfertarCaronaRepositorio
    {
        Task<List<OfertarCaronaModel>> GetAll();

        Task<OfertarCaronaModel> GetById(int id);

        Task<OfertarCaronaModel> InsertOfertarCarona(OfertarCaronaModel ofertarcarona);

        Task<OfertarCaronaModel> UpdateOfertarCarona(OfertarCaronaModel ofertarcarona, int id);

        Task<bool> DeleteOfertarCarona(int id);
    }
}
