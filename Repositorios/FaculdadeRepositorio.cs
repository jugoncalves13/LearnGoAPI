using Api.Data;
using Api.Models;
using Api.Repositorios.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Api.Repositorios
{
    public class FaculdadeRepositorio : IFaculdadeRepositorio
    {
        private readonly Contexto _dbContext;

        public FaculdadeRepositorio(Contexto dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<FaculdadeModel>> GetAll()
        {
            return await _dbContext.Faculdade.ToListAsync();
        }

        public async Task<FaculdadeModel> GetById(int id)
        {
            return await _dbContext.Faculdade.FirstOrDefaultAsync(x => x.FaculdadeId == id);
        }

        public async Task<FaculdadeModel> InsertFaculdade(FaculdadeModel faculdade)
        {
            await _dbContext.Faculdade.AddAsync(faculdade);
            await _dbContext.SaveChangesAsync();
            return faculdade;
        }

        public async Task<FaculdadeModel> UpdateFaculdade(FaculdadeModel faculdade, int id)
        {
            FaculdadeModel faculdades = await GetById(id);
            if (faculdades == null)
            {
                throw new Exception("Não encontrado.");
            }
            else
            {
                faculdades.FaculdadeNome = faculdade.FaculdadeNome;
                faculdades.FaculdadeCidade = faculdade.FaculdadeCidade;
                _dbContext.Faculdade.Update(faculdades);
                await _dbContext.SaveChangesAsync();
            }
            return faculdades;

        }

        public async Task<bool> DeleteFaculdade(int id)
        {
            FaculdadeModel faculdades = await GetById(id);
            if (faculdades == null)
            {
                throw new Exception("Não encontrado.");
            }

            _dbContext.Faculdade.Remove(faculdades);
            await _dbContext.SaveChangesAsync();
            return true;
        }

 
    }
}
