
using Cd.Domain.Model;
using Cd.Domain.Repositories.Interface;
using Cd.Repository.EFCoreInMemory.Models;
using Microsoft.EntityFrameworkCore;

namespace Cd.Repository.Repositories
{
    public class CdRepository : ICdRepository
    {
        private readonly ApiContext _context;

        public CdRepository(ApiContext context)
        {
            _context = context;
        }

        public int AddCd(CdMusica cd)
        {
           _context.Add(cd);
           return _context.SaveChanges();
            
        }

        public async Task<CdMusica> CdsFiltro(string tituloCd, string artista, string generoMusical, string musica)
        {
            var cds = await _context.CdMusica
                           .Include(u => u.Musicas)
                           .Where(cd =>
                               (string.IsNullOrEmpty(tituloCd) || cd.Titulo.Contains(tituloCd)) &&
                               (string.IsNullOrEmpty(artista) || cd.Artista.Contains(artista)) &&
                               (string.IsNullOrEmpty(generoMusical) || cd.GeneroMusical.Contains(generoMusical)) &&
                               (string.IsNullOrEmpty(musica) || cd.Musicas.Any(m => m.NomeMusica.Contains(musica)))
                           )
                           .ToListAsync();

            return cds.FirstOrDefault();
        }

        public async Task<List<CdMusica>> GetAll()
        {
            var cds = await _context.CdMusica
                                 .Include(u => u.Musicas)
                                 .ToListAsync();

            return cds;
        }

        public int UpdateCd(CdMusica cd)
        {
            throw new NotImplementedException();
        }
    }
}
