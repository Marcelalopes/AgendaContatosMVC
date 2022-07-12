using WebApplication3.Models;

namespace WebApplication3.Repositorio
{
    public interface IContatoRepositorio
    {
        List<ContatoModel> BuscatTodos();
        ContatoModel Adicionar(ContatoModel contato);
    }
}
