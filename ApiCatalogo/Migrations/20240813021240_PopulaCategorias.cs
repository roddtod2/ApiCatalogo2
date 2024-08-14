using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiCatalogo.Migrations
{
    /// <inheritdoc />
    public partial class PopulaCategorias : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Categorias (Nome, Descricao)\r\nVALUES \r\n('Smartphones', 'Dispositivos móveis com funcionalidades avançadas, como tela sensível ao toque, internet e câmeras de alta qualidade.'),\r\n\r\n('Notebooks', 'Computadores portáteis projetados para uso em movimento, oferecendo uma combinação de desempenho e portabilidade.'),\r\n\r\n('Acessórios de Áudio', 'Dispositivos e equipamentos relacionados ao áudio, como fones de ouvido, alto-falantes e microfones.'),\r\n\r\n('Câmeras e Fotografia', 'Equipamentos e acessórios para captura de imagens e vídeos, incluindo câmeras, lentes e tripés.'),\r\n\r\n('Smartwatches', 'Relógios inteligentes com funcionalidades adicionais, como monitoramento de saúde, GPS e conectividade com smartphones.'),\r\n\r\n('Teclados e Periféricos', 'Dispositivos de entrada e outros acessórios para computadores, como teclados, mouses e controladores de jogos.'),\r\n\r\n('Monitores', 'Dispositivos de exibição usados com computadores, variando de monitores de tela plana padrão a telas UltraWide.'),\r\n\r\n('Mouses e Periféricos', 'Dispositivos de entrada usados para controlar o cursor em um computador, além de outros acessórios como mouse pads.'),\r\n\r\n('Impressoras', 'Dispositivos usados para criar cópias físicas de documentos digitais, frequentemente com funções adicionais como digitalização e cópia.'),\r\n\r\n('Tablets', 'Dispositivos portáteis com telas sensíveis ao toque, usados para navegação na internet, consumo de mídia e aplicativos diversos.');\r\n");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("delete from categorias");
        }
    }
}
