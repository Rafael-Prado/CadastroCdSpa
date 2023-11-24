
namespace Cd.Domain.Model
{
    public  class CdMusica
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Artista { get; set; }
        public string GeneroMusical { get; set;}
        public List<Musica> Musicas { get; set; }

    }
}
