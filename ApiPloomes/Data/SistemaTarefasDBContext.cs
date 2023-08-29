using ApiPloomes.Data.Map;
using ApiPloomes.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiPloomes.Data
{
    public class SistemaTarefasDBContext : DbContext
    {
        public SistemaTarefasDBContext(DbContextOptions<SistemaTarefasDBContext> options) : base(options)
        {

        }

        public DbSet<UsuarioModel> Usuarios { get; set; }
        public DbSet<TarefaModel> Tarefas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UsuarioMap());
            modelBuilder.ApplyConfiguration(new TarefaMap());
            base.OnModelCreating(modelBuilder);
            //modelBuilder.Entity<UsuarioModel>().ToTable("Usuario");
            //modelBuilder.Entity<TarefaModel>().ToTable("Tarefa");
        }   

    } 
}
