using WebApplication3.Data;
using WebApplication3.Models;

namespace WebApplication3.Repositorio
{
    public class ContatoRepositorio : IContatoRepositorio
    {
        private readonly Context _context;
        public ContatoRepositorio(Context context)
        {
            _context = context;
        }
        public List<ContatoModel> BuscatTodos() 
        {
            return _context.Contatos.ToList();
        }
        public ContatoModel Adicionar(ContatoModel contato)
        {
            _context.Contatos.Add(contato);
            _context.SaveChanges();

            return contato;
        }
    }
}
