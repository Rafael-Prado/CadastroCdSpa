using AutoMapper;
using CadastroCD.Server.Model;
using Cd.Domain.Model;
using Cd.Domain.Service.Interface;
using Microsoft.AspNetCore.Mvc;

namespace CadastroCD.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CdController : Controller
    {
        private readonly ICdService _service;
        private readonly IMapper _mapper;

        public CdController(ICdService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        /// <summary>
        /// Pegar todos os CDS
        /// </summary>
        /// <returns>Objetos contendo valores do cds</returns>
        [HttpGet]
        public async  Task<ActionResult<List<CdMusica>>> ListCdAsync()
        {
            var cds = await _service.GetAll();
            return Ok(cds);
        }

        /// <summary>
        /// Fitro de musicas
        /// </summary>
        /// <returns>Objetos cd com suas musicas</returns>
        [HttpGet]
        [Route("filtro")]
        public async Task<ActionResult<CdMusica>> CdsFiltro(string tituloCd, string artista, string GeneroMusical, string musica)
        {
            var cd = await _service.CdsFiltro(tituloCd, artista, GeneroMusical, musica);
            return Ok(cd);
        }

        // POST: Cd/Create
        [HttpPost]
        [Route("create")]
        public ActionResult Create([FromBody] CdMusicaModel cd)
        {
            var teste = 0;
            while (teste <= 10)
            {
                teste++;

                _service.AddCd(_mapper.Map<CdMusica>(new CdMusicaModel
                {
                    Id = teste,
                    Artista = "teste" + teste,
                    GeneroMusical = "Musicas" + teste,
                    Titulo = "Minhas musicas" + teste
                }));
            }
            return Ok();
        }
    }
}
