using GestorGenshinCharacters.Models;

namespace GestorGenshinCharacters.Repositorio
{
    public interface iPersonagemRepositorio
    {
        PersonagemModel Adicionar(PersonagemModel personagem);
    }
}
