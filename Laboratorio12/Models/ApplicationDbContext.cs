using Microsoft.EntityFrameworkCore;

namespace Laboratorio12.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(
            DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Instructor> Instructores { get; set; }

        public DbSet<Estudiante> Estudiantes { get; set; }

        public DbSet<Curso> Cursos { get; set; }

        public DbSet<Matricula> Matriculas { get; set; }

        public DbSet<Pago> Pagos { get; set; }
    }
}
