using FiltrDinamico.WebApp.Models;
using Microsoft.EntityFrameworkCore;

namespace FiltrDinamico.WebApp.Context
{
    public class FiltroDinamicoContext : DbContext
    {
        public DbSet<Pessoa> Pessoa { get; set; }

        public FiltroDinamicoContext(DbContextOptions options) : base(options)
        {
        }
    }
}
