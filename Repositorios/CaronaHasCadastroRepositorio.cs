using Api.Data;
using Api.Models;
using Api.Repositorios.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Api.Repositorios
{
    public class CaronaHasCadastroRepositorio : ICaronaHasCadastroRepositorio
    {
        private readonly Contexto _dbContext;

        public CaronaHasCadastroRepositorio(Contexto dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<CaronaHasCadastroModel>> GetAll()
        {
            return await _dbContext.CaronaHasCadastro.ToListAsync();
        }

        public async Task<CaronaHasCadastroModel> GetById(int id)
        {
            return await _dbContext.CaronaHasCadastro.FirstOrDefaultAsync(x => x.CaronaHasCadastroId == id);
        }

        public async Task<CaronaHasCadastroModel> InsertCaronaHasCadastro(CaronaHasCadastroModel caronahascadastro)
        {
            await _dbContext.CaronaHasCadastro.AddAsync(caronahascadastro);
            await _dbContext.SaveChangesAsync();
            return caronahascadastro;
        }

       
        
        public async Task<bool> DeleteCaronaHasCadastro(int id)
        {
        CaronaHasCadastroModel caronahascadastros = await GetById(id);
            if (caronahascadastros == null)
            {
                throw new Exception("Não encontrado.");
            }

            _dbContext.CaronaHasCadastro.Remove(caronahascadastros);
            await _dbContext.SaveChangesAsync();
            return true;
        }

    }
}
