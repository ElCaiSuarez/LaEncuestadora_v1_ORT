using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using WebApp.NET_MVC_2022_12D_PP_Encuestadora.Models;

namespace WebApp.NET_MVC_2022_12D_PP_Encuestadora.Context
{
    public class EncuestadoraDBContext : DbContext
    {
        //CAMBIAMOS A ENCUESTA RESPONDIDA
        ////Configuring Many To Many Relationships in Entity Framework Core
        ////https://www.learnentityframeworkcore.com/configuration/many-to-many-relationship-configuration
        ////Fluent API - Relacion N a N entre Encuesta y Usuario
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<EncuestasUsuarios>()
        //        .HasKey(bc => new { bc.EncuestaId, bc.UsuarioId });
        //    modelBuilder.Entity<EncuestasUsuarios>()
        //        .HasOne(bc => bc.Encuesta)
        //        .WithMany(b => b.EncuestasUsuarios)
        //        .HasForeignKey(bc => bc.EncuestaId);
        //    modelBuilder.Entity<EncuestasUsuarios>()
        //        .HasOne(bc => bc.Usuario)
        //        .WithMany(c => c.EncuestasUsuarios)
        //        .HasForeignKey(bc => bc.UsuarioId);
        //}
        public EncuestadoraDBContext(DbContextOptions<EncuestadoraDBContext> options) : base(options)
        {
        }
        public DbSet<Cliente> clientes { get; set; }

        public DbSet<Usuario> usuarios { get; set; }

        public DbSet<Encuesta> encuestas { get; set; }

        public DbSet<Pregunta> preguntas { get; set; }

        public DbSet<OpcionPregunta> opciones { get; set; }
        
        //CAMBIAMOS A ENCUESTA RESPONDIDA
        //public DbSet<EncuestasUsuarios> encuestasUsuarios { get; set; }     

        public DbSet<EncuestaRespondida> encuestasRespondidas { get; set; }
    }

}
