using Microsoft.EntityFrameworkCore;
using P1_JerryHurtado.Server.Models.ModelsDB;
using System.Configuration;

namespace P1_JerryHurtado.Server._Repository.ContextDB
{
    /// <summary>
    /// Clase derivada de DbContext, configura los tipos de entidad en un modelo y actua como una sesión para interactuar con la base de datos.
    /// </summary>
    public class RestUnedContext : DbContext
    {
        public virtual DbSet<CategoriaPlato> CategoriaPlato { get; set; }

        public virtual DbSet<Cliente> Cliente { get; set; }

        public virtual DbSet<Extra> Extra { get; set; }

        public virtual DbSet<Pedido> Pedido { get; set; }

        public virtual DbSet<Plato> Plato { get; set; }

        public virtual DbSet<PlatoRestaurante> PlatoRestaurante { get; set; }

        public virtual DbSet<Restaurante> Restaurante { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["RestUned"].ConnectionString);

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CategoriaPlato>(entity =>
            {
                entity.HasKey(e => e.IdCategoria);

                entity.Property(e => e.IdCategoria).ValueGeneratedNever();
                entity.Property(e => e.Descripcion)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Cliente>(entity =>
            {
                entity.HasKey(e => e.IdCliente);

                entity.Property(e => e.IdCliente)
                    .HasMaxLength(10)
                    .IsUnicode(false);
                entity.Property(e => e.FechaNacimiento).HasColumnType("datetime");
                entity.Property(e => e.Genero)
                    .HasMaxLength(1)
                    .IsUnicode(false);
                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsUnicode(false);
                entity.Property(e => e.PrimerApellido)
                    .HasMaxLength(255)
                    .IsUnicode(false);
                entity.Property(e => e.SegundoApellido)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Extra>(entity =>
            {
                entity.HasKey(e => e.IdExtra);

                entity.Property(e => e.IdExtra).ValueGeneratedNever();
                entity.Property(e => e.Descripcion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdCategoriaNavigation).WithMany(p => p.Extra)
                    .HasForeignKey(d => d.IdCategoria)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Extra_CategoriaPlato");
            });

            modelBuilder.Entity<Pedido>(entity =>
            {
                entity.HasKey(e => new { e.IdPedido, e.IdPlato });

                entity.Property(e => e.FechaPedido).HasColumnType("datetime");
                entity.Property(e => e.IdCliente)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdClienteNavigation).WithMany(p => p.Pedido)
                    .HasForeignKey(d => d.IdCliente)
                    .HasConstraintName("FK_Pedido_Cliente");

                entity.HasOne(d => d.IdPlatoNavigation).WithMany(p => p.Pedido)
                    .HasForeignKey(d => d.IdPlato)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Pedido_Plato");

                entity.HasMany(d => d.IdExtra).WithMany(p => p.IdP)
                    .UsingEntity<Dictionary<string, object>>(
                        "ExtraPedido",
                        r => r.HasOne<Extra>().WithMany()
                            .HasForeignKey("IdExtra")
                            .OnDelete(DeleteBehavior.ClientSetNull)
                            .HasConstraintName("FK_ExtraPedido_Extra"),
                        l => l.HasOne<Pedido>().WithMany()
                            .HasForeignKey("IdPedido", "IdPlato")
                            .OnDelete(DeleteBehavior.ClientSetNull)
                            .HasConstraintName("FK_ExtraPedido_Pedido"),
                        j =>
                        {
                            j.HasKey("IdPedido", "IdPlato", "IdExtra");
                        });
            });

            modelBuilder.Entity<Plato>(entity =>
            {
                entity.HasKey(e => e.IdPlato);

                entity.Property(e => e.IdPlato).ValueGeneratedNever();
                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdCategoriaNavigation).WithMany(p => p.Plato)
                    .HasForeignKey(d => d.IdCategoria)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Plato_CategoriaPlato");
            });

            modelBuilder.Entity<PlatoRestaurante>(entity =>
            {
                entity.HasKey(e => new { e.IdRestaurante, e.IdPlato });

                entity.Property(e => e.FechaAsignacion).HasColumnType("datetime");

                entity.HasOne(d => d.IdPlatoNavigation).WithMany(p => p.PlatoRestaurante)
                    .HasForeignKey(d => d.IdPlato)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PlatoRestaurante_Plato");

                entity.HasOne(d => d.IdRestauranteNavigation).WithMany(p => p.PlatoRestaurante)
                    .HasForeignKey(d => d.IdRestaurante)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PlatoRestaurante_Restaurante");
            });

            modelBuilder.Entity<Restaurante>(entity =>
            {
                entity.HasKey(e => e.IdRestaurante);

                entity.Property(e => e.IdRestaurante).ValueGeneratedNever();
                entity.Property(e => e.Direccion)
                    .HasMaxLength(255)
                    .IsUnicode(false);
                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsUnicode(false);
                entity.Property(e => e.Telefono)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            base.OnModelCreating(modelBuilder);
        }
    }
}