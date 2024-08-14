using ApiCatalogo.Context;
using ApiCatalogo.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiCatalogo.Controllers
{
    [Route("[controller]")] //aqui vai pegar apenas o nome do controller PRODUTOS, no caso
    [ApiController]
    public class ProdutosController : ControllerBase
    {


        //readonly não pode ser alterada depois de atribuida
        private readonly AppDbContext? _appDbContext;

        public ProdutosController(AppDbContext appDbContext)
        {

            //o que isso faz, no construtor desse controller eu passo o app db context, o qual vai mostrar pro controller todo o contexto de bd
            _appDbContext = appDbContext;
        }

        [HttpGet] //sem action result não consigo usar os codigos de retorno
        public ActionResult<IEnumerable<Produto>> Get()
        {


            //db context tem acesso as classes que representam tabelas no banco de dados
           var produtos=_appDbContext.Produtos.ToList();

            if(produtos == null)
            {
                return NotFound();
            }

            return Ok(produtos);
        }

    }
}
