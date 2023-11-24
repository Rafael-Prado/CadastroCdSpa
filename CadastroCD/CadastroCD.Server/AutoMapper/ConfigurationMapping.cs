using AutoMapper;
using CadastroCD.Server.Model;
using Cd.Domain.Model;

namespace CadastroCD.Server.AutoMapper
{
    public class ConfigurationMapping: Profile
    {
        public ConfigurationMapping()
        {
            CreateMap<CdMusica, CdMusicaModel>();
            CreateMap<CdMusicaModel, CdMusica>().ForMember(p => p.Musicas, x => x.Ignore());

            CreateMap<Musica, MusicaModel>();
            CreateMap<MusicaModel, Musica>().ForMember(p => p.CdMusica, x => x.Ignore());
        }
        
    }
}
