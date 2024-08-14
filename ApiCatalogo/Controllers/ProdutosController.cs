using ApiCatalogo.Context;
using ApiCatalogo.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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

        [HttpGet("{id:int}",Name ="ObterProduto")] //sem action result não consigo usar os codigos de retorno
        public ActionResult<IEnumerable<Produto>> Get(int id) //sobrecarga
        {

            
            
            //first = se não achar nada, ou seja se for nulo, dá bo exceção
            //first or default se não retornar nada joga null

            var produtos = _appDbContext.Produtos.FirstOrDefault(p=> p.ProdutoId== id);

            if (produtos == null)
            {
                return NotFound("Koe, não tem esse role");
            }

            return Ok(produtos);
        }

        //post
        [HttpPost]
        public ActionResult Post(Produto produto)
        {

            if (produto == null)
                return BadRequest();

            _appDbContext.Produtos.Add(produto);
            _appDbContext.SaveChanges();


            //esse cara aqui se tudo der certo, retorna um código 200 retornando o código no status code 201
            return new CreatedAtRouteResult("ObterProduto", new { id = produto.ProdutoId }, produto);
        }

        [HttpPut("{id:int}")]
        public ActionResult Put(int? id,Produto produto)
        {
            //essa abordagem leva em consideração todo o objeto e alteração do mesmo

            if (id != produto.ProdutoId)
                return BadRequest();

            _appDbContext.Entry(produto).State = EntityState.Modified; //existem varios estados, aqui depois que ele validou o objeto ele já parte para verificar executar a alteração do objeto no banco
            _appDbContext.SaveChanges();


            //esse cara aqui se tudo der certo, retorna um código 200 retornando o código no status code 201
            return Ok(produto);
        }


        [HttpDelete("{id:int}")]
        public ActionResult Delete(int id)
        {
            var produto = _appDbContext.Produtos.FirstOrDefault(p=> p.ProdutoId== id);
            //var produto = _appDbContext.Produtos.Find(id); //procura no bd e na memória

            if(produto == null)
            {
                return NotFound();
            }
            
            _appDbContext.Produtos.Remove(produto);
            _appDbContext.SaveChanges();

            return Ok(produto);
        }

    }
}
