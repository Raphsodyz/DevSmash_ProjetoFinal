using System;
using System.Collections.Generic;
using DevSmash___Projeto_Final.Models.Entidades;
using DevSmash___Projeto_Final.Models.Usuario;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DevSmash___Projeto_Final
{
    public partial class SiteContext : IdentityDbContext<usuarioADM>
    {
        private readonly IConfiguration _configuration;

        public SiteContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public SiteContext()
        {
        }

        public virtual DbSet<Cliente> Clientes { get; set; } = null!;
        public virtual DbSet<Integrante> Integrantes { get; set; } = null!;
        public virtual DbSet<Post> Posts { get; set; } = null!;
        public virtual DbSet<Servico> Servicos { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {  
                string connection = _configuration.GetSection("ConnectionStrings").GetSection("default").Value;
                optionsBuilder.UseMySql(connection, ServerVersion.AutoDetect(connection));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseCollation("utf8mb4_0900_ai_ci")
                .HasCharSet("utf8mb4");

            modelBuilder.Entity<Cliente>(entity =>
            {
                entity.ToTable("clientes");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Cpf)
                    .HasMaxLength(70)
                    .HasColumnName("cpf");

                entity.Property(e => e.Email)
                    .HasMaxLength(70)
                    .HasColumnName("email");

                entity.Property(e => e.Nome)
                    .HasMaxLength(50)
                    .HasColumnName("nome");

                entity.Property(e => e.Telefone)
                    .HasMaxLength(70)
                    .HasColumnName("telefone");
            });

            modelBuilder.Entity<Integrante>(entity =>
            {
                entity.ToTable("integrantes");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Funcao)
                    .HasMaxLength(50)
                    .HasColumnName("funcao");

                entity.Property(e => e.Nome)
                    .HasMaxLength(50)
                    .HasColumnName("nome");

                entity.Property(e => e.RedeSocial)
                    .HasMaxLength(80)
                    .HasColumnName("redeSocial");

                entity.Property(e => e.Sobre).HasColumnName("sobre");
            });

            modelBuilder.Entity<Post>(entity =>
            {
                entity.ToTable("posts");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Autor)
                    .HasMaxLength(50)
                    .HasColumnName("autor");

                entity.Property(e => e.Conteudo).HasColumnName("conteudo");

                entity.Property(e => e.Criacao)
                    .HasColumnType("datetime")
                    .HasColumnName("criacao");

                entity.Property(e => e.Titulo)
                    .HasMaxLength(50)
                    .HasColumnName("titulo");
            });

            modelBuilder.Entity<Servico>(entity =>
            {
                entity.ToTable("servicos");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Nome)
                    .HasMaxLength(50)
                    .HasColumnName("nomeServico");

                entity.Property(e => e.Descricao).HasColumnName("descricao");

                entity.Property(e => e.Valor).HasColumnName("valor");

            });

            OnModelCreatingPartial(modelBuilder);

            base.OnModelCreating(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

    }
}
