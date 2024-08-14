using ApiCatalogo.Context;
using ApiCatalogo.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiCatalogo.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CategoriasController : ControllerBase
    {
        private readonly AppDbContext? _context;

        public CategoriasController(AppDbContext? context)
        {
            _context = context;
        }


        [HttpGet]
        public ActionResult<IEnumerable<Categoria>> Get()
        {
            var categoria = _context.Categorias.ToList();

            if(categoria == null)
            {
                return NotFound();
            }
            
            return Ok(categoria);
        }


        [HttpPost]
        public ActionResult Post(Categoria categoria)
        {


            if (categoria == null)
                return BadRequest();

            _context.Categorias.Add(categoria);
            _context.SaveChanges();

            return new CreatedAtRouteResult("ObterCategoria",new {id=categoria.CategoriaId},categoria);
        }

        //[HttpPut]

        //[HttpDelete]

    }
}
