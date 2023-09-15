using GestorGenshinCharacters.Data;
using GestorGenshinCharacters.Models;

namespace GestorGenshinCharacters.Repositorio
{
    public class PersonagemRepositorio : iPersonagemRepositorio
    {
        private readonly BancoContext _bancoContext;
        public PersonagemRepositorio(BancoContext bancoContext) {
            _bancoContext = bancoContext;
        }
        public PersonagemModel Adicionar(PersonagemModel personagem)
        {
            throw new NotImplementedException();
        }
    }
}
