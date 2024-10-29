using Api.Data;
using Api.Models;
using Api.Repositorios.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Any;

namespace Api.Repositorios
{
    public class CaronaRepositorio : ICaronaRepositorio
    {
        private readonly Contexto _dbContext;

        public CaronaRepositorio(Contexto dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<CaronaModel>> GetAll()
        {
            return await _dbContext.Carona.ToListAsync();
        }

        public async Task<CaronaModel> GetById(int id)
        {
            return await _dbContext.Carona.FirstOrDefaultAsync(x => x.CaronaId == id);
        }

        public async Task<CaronaModel> InsertCarona(CaronaModel carona)
        {
            await _dbContext.Carona.AddAsync(carona);
            await _dbContext.SaveChangesAsync();
            return carona;
        }

        public async Task<CaronaModel> UpdateCarona(CaronaModel carona, int id)
        {
            CaronaModel caronas = await GetById(id);
            if (caronas == null)
            {
                throw new Exception("Não encontrado.");
            }
            else
            {
                caronas.CaronaHorario = carona.CaronaHorario;
                caronas.CaronaVagas = carona.CaronaVagas;
                caronas.CaronaVeiculo = carona.CaronaVeiculo;
                caronas.CaronaOrigem = carona.CaronaOrigem;
                caronas.CaronaDestino = carona.CaronaDestino;
                _dbContext.Carona.Update(caronas);
                await _dbContext.SaveChangesAsync();
            }

            return caronas;

        }

        public async Task<bool> DeleteCarona(int id)
        {
            CaronaModel caronas = await GetById(id);
            if (caronas == null)
            {
                throw new Exception("Não encontrado.");
            }

            _dbContext.Carona.Remove(caronas);
            await _dbContext.SaveChangesAsync();
            return true;
        }

       
       
    }
}
