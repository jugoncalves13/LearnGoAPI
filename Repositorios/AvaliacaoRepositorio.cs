using Api.Data;
using Api.Models;
using Api.Repositorios.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Api.Repositorios
{
    public class AvaliacaoRepositorio : IAvaliacaoRepositorio
    {
        private readonly Contexto _dbContext;

        public AvaliacaoRepositorio(Contexto dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<AvaliacaoModel>> GetAll()
        {
            return await _dbContext.Avaliacao.ToListAsync();
        }

        public async Task<AvaliacaoModel> GetById(int id)
        {
            return await _dbContext.Avaliacao.FirstOrDefaultAsync(x => x.AvaliacaoId == id);
        }

        public async Task<AvaliacaoModel> InsertAvaliacao(AvaliacaoModel avaliacao)
        {
            await _dbContext.Avaliacao.AddAsync(avaliacao);
            await _dbContext.SaveChangesAsync();
            return avaliacao;
        }

        public async Task<AvaliacaoModel> UpdateAvaliacao(AvaliacaoModel avaliacao, int id)
        {
            AvaliacaoModel avaliacoes = await GetById(id);
            if (avaliacoes == null)
            {
                throw new Exception("Não encontrado.");
            }
            else
            {
                avaliacoes.AvaliacaoComentario = avaliacao.AvaliacaoComentario;
                _dbContext.Avaliacao.Update(avaliacoes);
                await _dbContext.SaveChangesAsync();
            }
            return avaliacoes;

        }

        public async Task<bool> DeleteAvaliacao(int id)
        {
            AvaliacaoModel avaliacoes = await GetById(id);
            if (avaliacoes == null)
            {
                throw new Exception("Não encontrado.");
            }

            _dbContext.Avaliacao.Remove(avaliacoes);
            await _dbContext.SaveChangesAsync();
            return true;
        }


    }
}
