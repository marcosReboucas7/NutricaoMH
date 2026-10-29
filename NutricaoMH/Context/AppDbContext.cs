using Microsoft.EntityFrameworkCore;
using NutricaoMH.Models;

namespace NutricaoMH.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Paciente> Pacientes { get; set; }
    }
}
