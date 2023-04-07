using Microsoft.EntityFrameworkCore;
using PresentacionWebApiCore.Models;

namespace PresentacionWebApiCore.Context
{
    public class AppDbContext:Microsoft.EntityFrameworkCore.DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Alumno> Alumnos { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Seed();
            base.OnModelCreating(modelBuilder);
        }
    }
}
