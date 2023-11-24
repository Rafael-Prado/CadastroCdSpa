
using System.Text.Json.Serialization;

namespace Cd.Domain.Model
{
    public  class Musica
    {
        public Musica(int id,int idCd, string nomeMusica, string tempoMusica)
        {
            Id = id;
            IdCd = idCd;
            NomeMusica = nomeMusica;
            TempoMusica = tempoMusica;
        }

        public int Id { get; set; }
        public int IdCd { get; set; }
        public string NomeMusica { get; set; }
        public string TempoMusica { get; set; }

        [JsonIgnore]
        public virtual CdMusica CdMusica { get; set; }
    }
}
