using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiCatalogo.Models
{
    public class Produto
    {
        [Key]
        public int ProdutoId { get; set; }

        [Required]
        [StringLength(100)]
        public string? Nome { get; set; }

        [StringLength(100)]
        public string? Descricao { get; set; }

        [Column(TypeName ="decimal(15,2")]
        public decimal Preco { get; set; }

        [StringLength(100)]
        public string? ImageUrl { get; set; }


        public float Estoque { get; set; }
        public DateTime DataCadastro { get; set; }


        public int IdCategoria {  get; set; }

        [ForeignKey(nameof(IdCategoria))]
        public Categoria? Categoria { get; set; }
    }
}
