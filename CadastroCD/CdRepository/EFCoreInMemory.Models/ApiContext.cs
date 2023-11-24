using Cd.Domain.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Cd.Repository.EFCoreInMemory.Models
{
    public class ApiContext : DbContext
    {
        public ApiContext(DbContextOptions<ApiContext> options)
          : base(options)
        { }

        public DbSet<CdMusica> CdMusica { get; set; }
        public DbSet<Musica> Musica { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CdMusica>()
                .HasMany(cd => cd.Musicas)
                .WithOne(m => m.CdMusica)
                .HasForeignKey(m => m.IdCd);


            base.OnModelCreating(modelBuilder);

        }
    }
}
