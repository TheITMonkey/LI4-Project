namespace MinhoShine.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class MinhoShineContext : DbContext
    {
        public MinhoShineContext()
            : base("name=MinhoShineContext")
        {
        }

        public virtual DbSet<Cliente> Clientes { get; set; }
        public virtual DbSet<Funcionario> Funcionarios { get; set; }
        public virtual DbSet<Recomendacao> Recomendacoes { get; set; }
        public virtual DbSet<Servico> Servicos { get; set; }
        public object Cliente { get; internal set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>()
                .Property(e => e.Nome)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.Morada)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.Contacto)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .HasMany(e => e.Recomendacaos)
                .WithRequired(e => e.Cliente)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Cliente>()
                .HasMany(e => e.Servicoes)
                .WithRequired(e => e.Cliente)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Funcionario>()
                .Property(e => e.Nome)
                .IsUnicode(false);

            modelBuilder.Entity<Funcionario>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Funcionario>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<Funcionario>()
                .Property(e => e.Contacto)
                .IsUnicode(false);

            modelBuilder.Entity<Funcionario>()
                .HasMany(e => e.Servicoes)
                .WithRequired(e => e.Funcionario)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Recomendacao>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Recomendacao>()
                .Property(e => e.Mensagem)
                .IsUnicode(false);

            modelBuilder.Entity<Servico>()
                .Property(e => e.Morada)
                .IsUnicode(false);

            modelBuilder.Entity<Servico>()
                .Property(e => e.Descricao)
                .IsUnicode(false);
        }
    }
}
