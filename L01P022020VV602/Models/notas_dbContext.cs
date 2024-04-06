using Microsoft.EntityFrameworkCore;

namespace L01P022020VV602.Models
{
    public class notas_dbDbContext : DbContext
    {
        public notas_dbDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<alumnos> alumnos { get; set; }
        public DbSet<departamentos> departamentos { get; set; }
        public DbSet<facultades> facultades { get; set; }
        public DbSet<materias> materias { get; set; }
    }
}
