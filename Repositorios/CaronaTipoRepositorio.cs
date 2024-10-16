using Api.Data;
using Api.Models;
using Api.Repositorios.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Api.Repositorios
{
    public class CaronaTipoRepositorio : ICaronaTipoRepositorio
    {
        private readonly Contexto _dbContext;

        public CaronaTipoRepositorio(Contexto dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<CaronaTipoModel>> GetAll()
        {
            return await _dbContext.CaronaTipo.ToListAsync();
        }

        public async Task<CaronaTipoModel> GetById(int id)
        {
            return await _dbContext.CaronaTipo.FirstOrDefaultAsync(x => x.CaronaTipoId == id);
        }

        public async Task<CaronaTipoModel> InsertCaronaTipo(CaronaTipoModel caronatipo)
        {
            await _dbContext.CaronaTipo.AddAsync(caronatipo);
            await _dbContext.SaveChangesAsync();
            return caronatipo;
        }

        public async Task<CaronaTipoModel> UpdateCaronaTipo(CaronaTipoModel caronatipo, int id)
        {
            CaronaTipoModel caronatipos = await GetById(id);
            if (caronatipos == null)
            {
                throw new Exception("Não encontrado.");
            }
            else
            {
                caronatipos.CaronaTipoDescricao = caronatipo.CaronaTipoDescricao;

                _dbContext.CaronaTipo.Update(caronatipos);
                await _dbContext.SaveChangesAsync();
            }

            return caronatipos;

        }

        public async Task<bool> DeleteCaronaTipo(int id)
        {
            CaronaTipoModel caronatipos = await GetById(id);
            if (caronatipos == null)
            {
                throw new Exception("Não encontrado.");
            }

            _dbContext.CaronaTipo.Remove(caronatipos);
            await _dbContext.SaveChangesAsync();
            return true;
        }
    }
}
