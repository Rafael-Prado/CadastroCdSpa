
namespace Cd.Domain.Model
{
    public  class Musica
    {
        public int Id { get; set; }
        public string NameMusica { get; set; }
        public DateTime TempoMusica { get; set; }

        public virtual CdMusica CdMusica { get; set; }
    }
}
