using AutoMapper;
using CadastroCD.Server.Model;
using Cd.Domain.Model;
using Cd.Domain.Service.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CadastroCD.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MusicaController : Controller
    {
        private readonly IMusicaService _service;
        private readonly IMapper _mapper;

        public MusicaController(IMusicaService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        /// <summary>
        /// Pegar todas as musicas
        /// </summary>
        /// <returns>Objetos contendo valores do cds</returns>
        [HttpGet]
        [Route("list")]
        public async  Task<ActionResult<List<Musica>>> ListMusicaAsync()
        {
            var musicas = await _service.GetAll();
            return Ok(musicas);
        }

        /// <summary>
        /// Fitro de musicas
        /// </summary>
        /// <returns>Objetos cd com suas musicas</returns>
        [HttpGet]
        [Route("cdmusicas/{id}")]
        public async Task<ActionResult<List<Musica>>> Details(int id)
        {
            var musicas = await _service.GetMusicaIdCd(id);
            return Ok(musicas);
        }

        // POST: Cd/Create
        [HttpPost]
        [Route("create")]
        public ActionResult Create([FromBody] MusicaModel musica)
        {
           var id = _service.AddMusica(_mapper.Map<Musica>(musica));
            return Ok(id);
        }

    }
}
