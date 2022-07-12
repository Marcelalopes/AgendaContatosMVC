using Microsoft.EntityFrameworkCore;
using WebApplication3.Models;

namespace WebApplication3.Data
{
    public class Context: DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options) 
        {

        }

        public DbSet<ContatoModel> Contatos { get; set; }
    }
}
