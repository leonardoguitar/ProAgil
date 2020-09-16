using Microsoft.EntityFrameworkCore;
using ProAgil.API.Model;

namespace ProAgil.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base (options){}

        //Definie quais tabelas quero usar no banco
        public DbSet<Evento> Eventos { get; set;}
     
    }
}