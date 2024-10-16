using Api.Data;
using Api.Models;
using Api.Repositorios.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Api.Repositorios
{
    public class CadastroRepositorio : ICadastroRepositorio
    {
        private readonly Contexto _dbContext;

        public CadastroRepositorio(Contexto dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<CadastroModel>> GetAll()
        {
            return await _dbContext.Cadastro.ToListAsync();
        }

        public async Task<CadastroModel> GetById(int id)
        {
            return await _dbContext.Cadastro.FirstOrDefaultAsync(x => x.CadastroId == id);
        }

        public async Task<CadastroModel> InsertCadastro(CadastroModel cadastro)
        {
            await _dbContext.Cadastro.AddAsync(cadastro );
            await _dbContext.SaveChangesAsync();
            return cadastro;
        }

        public async Task<CadastroModel> UpdateCadastro(CadastroModel cadastro, int id)
        {
            CadastroModel cadastros = await GetById(id);
            if (cadastros == null)
            {
                throw new Exception("Não encontrado.");
            }
            else
            {
                cadastros.CadastroNomeCompleto = cadastro.CadastroNomeCompleto;
                cadastros.CadastroDataNascimento = cadastro.CadastroDataNascimento;
                cadastros.CadastroRm = cadastro.CadastroRm;
                cadastros.CadastroCurso = cadastro.CadastroCurso;
                cadastros.CadastroEmail = cadastro.CadastroEmail;
                cadastros.CadastroSenha = cadastro.CadastroSenha;
                cadastros.CadastroEndereço = cadastro.CadastroEndereço;
                _dbContext.Cadastro.Update(cadastros);
                await _dbContext.SaveChangesAsync();
            }

            return cadastros;

        }

        public async Task<bool> DeleteCadastro(int id)
        {
            CadastroModel cadastros = await GetById(id);
            if (cadastros == null)
            {
                throw new Exception("Não encontrado.");
            }

            _dbContext.Cadastro.Remove(cadastros);
            await _dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<CadastroModel> Login( string email, string password )
        {
            CadastroModel usuario;
            
            usuario = await _dbContext.Cadastro.FirstOrDefaultAsync(x => x.CadastroEmail == email && x.CadastroSenha == password);

            return usuario;


        }

       
    }
}
