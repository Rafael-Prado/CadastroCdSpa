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
        [Route("list")]
        public async  Task<ActionResult<IEnumerable<CdMusica>>> ListCdAsync()
        {
            var cds = await _service.GetAll();
            return Ok(cds);
        }

        /// <summary>
        /// Pegar todos os CDS e suas musicas
        /// </summary>
        /// <returns>Objetos cd com suas musicas</returns>
        [HttpGet]
        [Route("detalhes/{id}")]
        public ActionResult Details(int id)
        {
            return View();
        }

        // POST: Cd/Create
        [HttpPost]
        [Route("create")]
        public ActionResult Create([FromBody] CdMusicaModel cd)
        {
           var id = _service.AddCd(_mapper.Map<CdMusica>(cd));
            return Ok(id);
        }

        [HttpPut]
        [Route("edit")]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
