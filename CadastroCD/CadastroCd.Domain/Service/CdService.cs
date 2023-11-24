using Cd.Domain.Model;
using Cd.Domain.Repositories.Interface;
using Cd.Domain.Service.Interface;

namespace Cd.Domain.Service
{
    public class CdService : ICdService
    {
        private readonly ICdRepository _repository;
        public CdService(ICdRepository repository)
        {
            _repository = repository;

        }
        public int AddCd(CdMusica cd)
        {
            return _repository.AddCd(cd);

        }

        public async Task<CdMusica> CdsFiltro(string tituloCd, string artista, string generoMusical, string musica)
        {
            return await _repository.CdsFiltro(tituloCd, artista, generoMusical, musica);
        }

        public async Task<List<CdMusica>> GetAll()
        {
           return await _repository.GetAll();
        }

        public int UpdateCd(CdMusica cd)
        {
            return _repository.UpdateCd(cd);
        }
    }
}
