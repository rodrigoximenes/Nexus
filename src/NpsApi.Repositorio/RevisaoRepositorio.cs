using Microsoft.EntityFrameworkCore;
using NpsApi.Dominio;
using NpsApi.Repositorio.Interfaces;

namespace NpsApi.Repositorio
{
    public class RevisaoRepositorio : IRevisaoRepositorio
    {
        private readonly AppDbContext _context;

        public RevisaoRepositorio(AppDbContext context)
        {
            _context = context;
        }

        public async Task AdicionaRevisaoAsync(Revisao revisao)
        {
            await _context.Revisoes.AddAsync(revisao);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Revisao>> BuscaTodasRevisoesAsync()
        {
            return await _context.Revisoes.ToListAsync();
        }
    }
}