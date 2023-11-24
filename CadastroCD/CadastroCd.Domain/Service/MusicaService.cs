using Cd.Domain.Model;
using Cd.Domain.Repositories.Interface;
using Cd.Domain.Service.Interface;

namespace Cd.Domain.Service
{
    public class MusicaService : IMusicaService
    {
        private readonly IMusicaRepository _repository;

        public MusicaService(IMusicaRepository repository)
        {
            _repository = repository;
        }

        public int AddMusica(Musica musica)
        {
            return _repository.AddMusica(musica);
        }

        public async Task<List<Musica>> GetAll()
        {
            return await _repository.GetAll();
        }

        public async Task<List<Musica>> GetMusicaIdCd(int id)
        {
            return await _repository.GetMusicaIdCd(id);
        }
    }
}
