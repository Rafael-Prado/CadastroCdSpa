using Cd.Domain.Model;
using Cd.Domain.Repositories.Interface;
using Cd.Repository.EFCoreInMemory.Models;
using Microsoft.EntityFrameworkCore;

namespace Cd.Repository.Repositories
{
    public class MusicaRepository : IMusicaRepository
    {
        private readonly ApiContext _context;

        public MusicaRepository(ApiContext context)
        {
            _context = context;
        }
        public int AddMusica(Musica musica)
        {
            _context.Add(musica);
            return _context.SaveChanges();
        }

        public async Task<List<Musica>> GetAll()
        {
            var musicas = await _context.Musica
                                 .ToListAsync();

            return musicas;
        }

        public async Task<List<Musica>> GetMusicaIdCd(int id)
        {
            var musicas = await _context.Musica
                                 .Where(x => x.IdCd == id).ToListAsync();

            return musicas;
        }
    }
}
