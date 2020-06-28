using FiltrDinamico.Core;
using FiltrDinamico.WebApp.Context;
using FiltrDinamico.WebApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace FiltrDinamico.WebApp.Controllers
{
    [Route("pessoa")]
    public class PessoaController : Controller
    {
        private readonly IFiltroDinamico _filtroDinamico;
        private readonly FiltroDinamicoContext _context;

        public PessoaController(IFiltroDinamico filtroDinamico, FiltroDinamicoContext context)
        {
            _filtroDinamico = filtroDinamico;
            _context = context;
        }

        [HttpPost("filtrar")]
        public IActionResult Filtrar([FromBody]PaginationFilter paginationFilter)
        {

            var expressionDynamic = _filtroDinamico.FromFiltroItemList<Pessoa>(paginationFilter.Filtro.ToList());

            var pessoas = _context.Pessoa.Where(expressionDynamic).ToList();

            return Ok(pessoas);
        }
    }
}
