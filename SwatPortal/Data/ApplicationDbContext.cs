using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SwatPortal.Entidades;

namespace SwatPortal.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {   
            }
            protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ciudades>().HasKey(x => new { x.IdCiudad, x.IdDepartamento, x.Ciudad, x.Activo, x.CodigoCiu });
            modelBuilder.Entity<Ciudades>(entity => {
                entity.HasKey(e => e.IdCiudad).HasName("PK_cen_ciudades");
                entity.Property(e => e.IdCiudad)
                    .HasColumnName("id_ciudad")
                    .ValueGeneratedNever();

                entity.Property(e => e.Activo)
                    .IsRequired()
                    .HasColumnName("activo")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Ciudad)
                    .HasColumnName("ciudad")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoCiu)
                    .HasColumnName("codigo_ciu")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.IdDepartamento).HasColumnName("id_departamento");
            });
            modelBuilder.Entity<Contacto>(entity =>
            {
                entity.HasKey(e => e.IdContacto);

                entity.Property(e => e.IdContacto).ValueGeneratedNever();

                entity.Property(e => e.Celular)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Email1)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Email2).HasMaxLength(50);

                entity.Property(e => e.Id_ciudad)
                    .IsRequired()
                    .HasColumnName("Id_ciudad")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(200);
            });
            var roleAdminId = "89086180-b978-4f90-9dbd-a7040bc93f41";
            var usuarioAdminId = "8095f754-629b-4a5c-92dd-fbcec41af12d";

            var roleAdmin = new IdentityRole()
            { Id = roleAdminId, Name = "admin", NormalizedName = "admin" };

            var hasher = new PasswordHasher<IdentityUser>();

            var usuarioAdmin = new IdentityUser()
            {
                Id = usuarioAdminId,
                Email = "user@example.com",
                UserName = "user@example.com",
                NormalizedUserName = "user@example.com",
                NormalizedEmail = "user@example.com",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "75d8d0f2-398c-46a2-B!d5e-03092cb1d513")
            };

            modelBuilder.Entity<IdentityUser>().HasData(usuarioAdmin);

            modelBuilder.Entity<IdentityUserRole<string>>()
                .HasData(new IdentityUserRole<string>() { RoleId = roleAdminId, UserId = usuarioAdminId });

            modelBuilder.Entity<IdentityRole>().HasData(roleAdmin);

            base.OnModelCreating(modelBuilder); 
        }
        public virtual DbSet<Ciudades> Ciudades { get; set; }
        public virtual DbSet<Contacto> Contacto { get; set; }
        //public virtual DbSet<FacElectronica> FacElectronica { get; set; }
        //public virtual DbSet<Grupo> Grupo { get; set; }
        //public virtual DbSet<LogApp> LogApp { get; set; }
        //public virtual DbSet<Prueba> Prueba { get; set; }
        //public virtual DbSet<Sucursal> Sucursal { get; set; }
        //public virtual DbSet<SucursalScript> SucursalScript { get; set; }
    }
}
