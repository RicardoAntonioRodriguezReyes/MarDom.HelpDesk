using MarDom.Data.Entidades;
using System;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace MarDom.Data.Contexto
{
    public class HelpDeskModel : DbContext
    {
        public HelpDeskModel()
            : base("name=DefaultConnection")
        {
            base.Configuration.LazyLoadingEnabled = false;
            base.Configuration.ProxyCreationEnabled = false;
        }

        public virtual DbSet<Tickets> Tickets { get; set; }

        public virtual DbSet<tkCategoria> tkCategoria { get; set; }


        public virtual DbSet<tkProblemas> tkProblemas { get; set; }


        public virtual DbSet<tkOrigen> tkOrigenes { get; set; }

        public virtual DbSet<tkEstados> tkEstados { get; set; }

        public virtual DbSet<tkPrioridad> tkPrioridad { get; set; }

        public virtual DbSet<tkSeccion> tkSecciones { get; set; }


        public virtual DbSet<Usuario> Usuarios { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Tickets>()
                .Property(e => e.Id);

            modelBuilder.Entity<tkCategoria>()
                .Property(e => e.Id);

            modelBuilder.Entity<tkOrigen>()
            .Property(e => e.Id);

            modelBuilder.Entity<tkEstados>()
          .Property(e => e.Id);

            modelBuilder.Entity<tkPrioridad>()
          .Property(e => e.Id);

            modelBuilder.Entity<tkSeccion>()
.Property(e => e.Id);


            modelBuilder.Entity<Usuario>()
               .Property(e => e.Id);

            modelBuilder.Entity<tkProblemas>()
              .Property(e => e.Id);

        }


    }
}
