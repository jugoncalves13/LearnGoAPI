using Api.Data;
using Api.Models;
using Api.Repositorios.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Api.Repositorios
{
    public class SolicitarCaronaRepositorio : ISolicitarCaronaRepositorio
    {
        private readonly Contexto _dbContext;

        public SolicitarCaronaRepositorio(Contexto dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<SolicitarCaronaModel>> GetAll()
        {
            return await _dbContext.SolicitarCarona.ToListAsync();
        }

        public async Task<SolicitarCaronaModel> GetById(int id)
        {
            return await _dbContext.SolicitarCarona.FirstOrDefaultAsync(x => x.SolicitarCaronaId == id);
        }

        public async Task<SolicitarCaronaModel> InsertSolicitarCarona(SolicitarCaronaModel solicitarcarona)
        {
            await _dbContext.SolicitarCarona.AddAsync(solicitarcarona);
            await _dbContext.SaveChangesAsync();
            return solicitarcarona;
        }

        public async Task<SolicitarCaronaModel> UpdateSolicitarCarona(SolicitarCaronaModel solicitarcarona, int id)
        {
            SolicitarCaronaModel solicitarcaronas = await GetById(id);
            if (solicitarcaronas == null)
            {
                throw new Exception("Não encontrado.");
            }
            else
            {
                solicitarcaronas.SolicitarCaronaNome = solicitarcarona.SolicitarCaronaNome;
                solicitarcaronas.SolicitarCaronaHorário = solicitarcarona.SolicitarCaronaHorário;
                solicitarcaronas.SolicitarCaronaEndereço = solicitarcarona.SolicitarCaronaEndereço;
                _dbContext.SolicitarCarona.Update(solicitarcaronas);
                await _dbContext.SaveChangesAsync();
            }

            return solicitarcaronas;

        }

        public async Task<bool> DeleteSolicitarCarona(int id)
        {
            SolicitarCaronaModel solicitarcaronas = await GetById(id);
            if (solicitarcaronas == null)
            {
                throw new Exception("Não encontrado.");
            }

            _dbContext.SolicitarCarona.Remove(solicitarcaronas);
            await _dbContext.SaveChangesAsync();
            return true;
        }


    }
}
