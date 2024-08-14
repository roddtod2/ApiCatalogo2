using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace ApiCatalogo.Models;

public class Categoria
{
    [Key]
    public int CategoriaId { get; set; }
    public string? Nome { get; set; }
    public string? ImagemUrl { get; set; }


    public Categoria()
    {
        Produtos = new Collection<Produto>();
    }
    

    public ICollection<Produto> Produtos { get;}
}
