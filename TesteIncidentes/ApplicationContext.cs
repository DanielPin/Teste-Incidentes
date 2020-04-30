using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TesteIncidentes.Models;

namespace TesteIncidentes
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Sexo> Sexo { get; set; }

        public ApplicationContext(DbContextOptions options) : base(options)
        {
        }

        public ApplicationContext()
        {
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Usuario>();
            modelBuilder.Entity<Sexo>().HasKey(c => c.SexoId);
           
        }




    }
}
