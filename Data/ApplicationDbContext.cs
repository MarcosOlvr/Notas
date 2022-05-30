using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Notas.Models;

namespace Notas.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<PrimeiroBi>()
                .HasOne<Aluno>()
                .WithMany()
                .HasForeignKey(a => a.AlunoId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<SegundoBi>()
                .HasOne<Aluno>()
                .WithMany()
                .HasForeignKey(a => a.AlunoId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<TerceiroBi>()
                .HasOne<Aluno>()
                .WithMany()
                .HasForeignKey(a => a.AlunoId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<QuartoBi>()
                .HasOne<Aluno>()
                .WithMany()
                .HasForeignKey(a => a.AlunoId)
                .OnDelete(DeleteBehavior.NoAction);
        }

        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<PrimeiroBi> PrimeiroBi { get; set; }
        public DbSet<SegundoBi> SegundoBi { get; set; }
        public DbSet<TerceiroBi> TerceiroBi { get; set; }
        public DbSet<QuartoBi> QuartoBi { get; set; }
    }
}