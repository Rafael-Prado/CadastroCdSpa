

using Cd.Domain.Model;

namespace Cd.Domain.Service.Interface
{
    public interface ICdService
    {
        int AddCd(CdMusica cd);
        Task<CdMusica> CdsFiltro(string tituloCd, string artista, string generoMusical, string musica);
        Task<List<CdMusica>> GetAll();
        int UpdateCd(CdMusica cd);
    }
}
