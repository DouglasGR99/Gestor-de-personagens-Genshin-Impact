using GestorGenshinCharacters.Models;
using Microsoft.EntityFrameworkCore;

namespace GestorGenshinCharacters.Data
{
    public class BancoContext : DbContext
    {
        //construtor
        public BancoContext(DbContextOptions<BancoContext> options) : base(options) //tipado como a propria classe - injeção dos dados
        {
        }

        //trazendo as entidades

        //tabela dos personagnes
        public DbSet<PersonagemModel> Personagem { get; set; }
    }
}
