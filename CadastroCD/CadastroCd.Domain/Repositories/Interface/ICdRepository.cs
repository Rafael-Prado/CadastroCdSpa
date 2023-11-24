

using Cd.Domain.Model;

namespace Cd.Domain.Repositories.Interface
{
    public interface ICdRepository
    {
        int AddCd(CdMusica cd);
        Task<CdMusica> CdsFiltro(string tituloCd, string artista, string generoMusical, string musica);
        Task<List<CdMusica>> GetAll();
        int UpdateCd(CdMusica cd);       
    }
}
