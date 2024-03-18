using Microsoft.EntityFrameworkCore;
using tp3.Models;

namespace tp3.DAL
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {

        }
        public DbSet<Computadores> computadores { get; set; }
    }
}
