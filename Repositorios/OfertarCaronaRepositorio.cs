using Api.Data;
using Api.Models;
using Api.Repositorios.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Api.Repositorios
{
    public class OfertarCaronaRepositorio : IOfertarCaronaRepositorio
    {
        private readonly Contexto _dbContext;

        public OfertarCaronaRepositorio(Contexto dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<OfertarCaronaModel>> GetAll()
        {
            return await _dbContext.OfertarCarona.ToListAsync();
        }

        public async Task<OfertarCaronaModel> GetById(int id)
        {
            return await _dbContext.OfertarCarona.FirstOrDefaultAsync(x => x.OfertarCaronaId == id);
        }

        public async Task<OfertarCaronaModel> InsertOfertarCarona(OfertarCaronaModel ofertarcarona)
        {
            await _dbContext.OfertarCarona.AddAsync(ofertarcarona);
            await _dbContext.SaveChangesAsync();
            return ofertarcarona;
        }

        public async Task<OfertarCaronaModel> UpdateOfertarCarona(OfertarCaronaModel ofertarcarona, int id)
        {
            OfertarCaronaModel ofertarcaronas = await GetById(id);
            if (ofertarcaronas == null)
            {
                throw new Exception("Não encontrado.");
            }
            else
            {
                ofertarcaronas.OfertarCaronaPeriodo = ofertarcarona.OfertarCaronaPeriodo;
                ofertarcaronas.OfertarCaronaHorário = ofertarcarona.OfertarCaronaHorário;
                ofertarcaronas.OfertarCaronaEndereço = ofertarcarona.OfertarCaronaEndereço;
                ofertarcaronas.OfertarCaronaVagas = ofertarcarona.OfertarCaronaVagas;
                ofertarcaronas.OfertarCaronaVeiculo = ofertarcarona.OfertarCaronaVeiculo;
                _dbContext.OfertarCarona.Update(ofertarcaronas);
                await _dbContext.SaveChangesAsync();
            }

            return ofertarcaronas;

        }

        public async Task<bool> DeleteOfertarCarona(int id)
        {
            OfertarCaronaModel ofertarcaronas = await GetById(id);
            if (ofertarcaronas == null)
            {
                throw new Exception("Não encontrado.");
            }

            _dbContext.OfertarCarona.Remove(ofertarcaronas);
            await _dbContext.SaveChangesAsync();
            return true;
        }


    }
}
