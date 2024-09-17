using Api.Models;

namespace Api.Repositorios.Interfaces
{
    public interface ICadastroRepositorio
    {
        Task<List<CadastroModel>> GetAll();

        Task<CadastroModel> GetById(int id);

        Task<CadastroModel> InsertCadastro(CadastroModel cadastro);

        Task<CadastroModel> UpdateCadastro(CadastroModel cadastro, int id);

        Task<bool> DeleteCadastro(int id);
    }
}
