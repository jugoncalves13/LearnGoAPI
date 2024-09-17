using Api.Models;

namespace Api.Repositorios.Interfaces
{
    public interface IPerfilRepositorio
    {
        Task<List<PerfilModel>> GetAll();

        Task<PerfilModel> GetById(int id);

        Task<PerfilModel> InsertPerfil(PerfilModel perfil);

        Task<PerfilModel> UpdatePerfil(PerfilModel perfil, int id);

        Task<bool> DeletePerfil(int id);
    }
}
