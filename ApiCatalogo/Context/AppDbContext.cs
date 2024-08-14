using ApiCatalogo.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiCatalogo.Context;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) //no construtor da classe appdb chamo o construtor da classe base
    {

    }


    //nessa entidade crio a conexão com o banco e faço o mapeamento das classes que vão virar tabelas

    public DbSet<Categoria>?Categorias { get; set; }
    public DbSet<Produto>?Produtos { get; set; }
}
