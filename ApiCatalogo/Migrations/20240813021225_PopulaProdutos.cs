using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiCatalogo.Migrations
{
    /// <inheritdoc />
    public partial class PopulaProdutos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
        INSERT INTO Produtos (Nome, Descricao, Preco, ImageUrl, Estoque, DataCadastro, IdCategoria)
        VALUES 
        ('Smartphone X100', 'Smartphone com tela de 6.5 polegadas e 128GB de armazenamento.', 1999.99, 'http://exemplo.com/imagens/smartphone-x100.jpg', 150.0, '2024-08-01', 1),

        ('Notebook Pro 15', 'Notebook com processador Intel i7, 16GB RAM e 512GB SSD.', 5499.90, 'http://exemplo.com/imagens/notebook-pro15.jpg', 85.0, '2024-08-02', 2),

        ('Fone de Ouvido Wireless', 'Fone de ouvido Bluetooth com cancelamento de ruído.', 299.99, 'http://exemplo.com/imagens/fone-wireless.jpg', 300.0, '2024-08-03', 3),

        ('Câmera DSLR Pro', 'Câmera profissional com lente 18-55mm e resolução de 24.2MP.', 3599.00, 'http://exemplo.com/imagens/camera-dslr.jpg', 25.0, '2024-08-04', 4),

        ('Smartwatch Série 5', 'Relógio inteligente com monitoramento cardíaco e GPS integrado.', 1299.99, 'http://exemplo.com/imagens/smartwatch-serie5.jpg', 200.0, '2024-08-05', 5),

        ('Teclado Mecânico Gamer', 'Teclado com iluminação RGB e switches mecânicos.', 499.90, 'http://exemplo.com/imagens/teclado-gamer.jpg', 120.0, '2024-08-06', 6),

        ('Monitor UltraWide 34""', 'Monitor UltraWide com resolução QHD e taxa de atualização de 75Hz.', 2899.99, 'http://exemplo.com/imagens/monitor-ultrawide.jpg', 50.0, '2024-08-07', 7),

        ('Mouse Gamer Pro', 'Mouse com 12 botões programáveis e sensor óptico de 16000 DPI.', 349.99, 'http://exemplo.com/imagens/mouse-gamer.jpg', 180.0, '2024-08-08', 8),

        ('Impressora Multifuncional', 'Impressora com funções de cópia, digitalização e impressão colorida.', 899.90, 'http://exemplo.com/imagens/impressora-multifuncional.jpg', 40.0, '2024-08-09', 9),

        ('Tablet 10 pol', 'Tablet com tela de 10 polegadas e 64GB de armazenamento.', 1499.90, 'http://exemplo.com/imagens/tablet-10.jpg', 70.0, '2024-08-10', 10);");
        }


        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("delete from produtos");
        }
    }
}
