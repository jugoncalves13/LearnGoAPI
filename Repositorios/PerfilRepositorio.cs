using Api.Data;
using Api.Models;
using Api.Repositorios.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Api.Repositorios
{
    public class PerfilRepositorio : IPerfilRepositorio
    {
        private readonly Contexto _dbContext;

        public PerfilRepositorio(Contexto dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<PerfilModel>> GetAll()
        {
            return await _dbContext.Perfil.ToListAsync();
        }

        public async Task<PerfilModel> GetById(int id)
        {
            return await _dbContext.Perfil.FirstOrDefaultAsync(x => x.PerfilId == id);
        }

        public async Task<PerfilModel> InsertPerfil(PerfilModel perfil)
        {
            await _dbContext.Perfil.AddAsync(perfil);
            await _dbContext.SaveChangesAsync();
            return perfil;
        }

        public async Task<PerfilModel> UpdatePerfil(PerfilModel perfil, int id)
        {
            PerfilModel perfis = await GetById(id);
            if (perfis == null)
            {
                throw new Exception("Não encontrado.");
            }
            else
            {
                perfis.PerfilFoto = perfil.PerfilFoto;
                _dbContext.Perfil.Update(perfis);
                await _dbContext.SaveChangesAsync();
            }
            return perfis;

        }

        public async Task<bool> DeletePerfil(int id)
        {
            PerfilModel perfis = await GetById(id);
            if (perfis == null)
            {
                throw new Exception("Não encontrado.");
            }

            _dbContext.Perfil.Remove(perfis);
            await _dbContext.SaveChangesAsync();
            return true;
        }


    }
}
