using GeoReferenceAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace GeoReferenceAPI.DbContexts
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<GeoReference> GeoReferences { get; set; }

        public DbSet<Estados> Estados { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Estados>().ToTable(nameof(Estados), x => x.ExcludeFromMigrations());

            modelBuilder.Entity<GeoReference>().HasData(new GeoReference { idGeoreferencia = 1, idEstado = 1, Latitud = 21.13180225, Longitud = -89.50884361 });
            modelBuilder.Entity<GeoReference>().HasData(new GeoReference { idGeoreferencia = 2, idEstado = 1, Latitud = 22.302625, Longitud = 102.2263139 });
            modelBuilder.Entity<GeoReference>().HasData(new GeoReference { idGeoreferencia = 3, idEstado = 1, Latitud = 23.2336, Longitud = 103.3168167 });
            modelBuilder.Entity<GeoReference>().HasData(new GeoReference { idGeoreferencia = 4, idEstado = 1, Latitud = 23.23353333, Longitud = 103.3335528 });
            modelBuilder.Entity<GeoReference>().HasData(new GeoReference { idGeoreferencia = 5, idEstado = 1, Latitud = 22.07935, Longitud = 102.0409833 });
            modelBuilder.Entity<GeoReference>().HasData(new GeoReference { idGeoreferencia = 6, idEstado = 1, Latitud = 22.39769444, Longitud = 102.2899333 });
            modelBuilder.Entity<GeoReference>().HasData(new GeoReference { idGeoreferencia = 7, idEstado = 1, Latitud = 22.39863333, Longitud = 102.2900556 });
            modelBuilder.Entity<GeoReference>().HasData(new GeoReference { idGeoreferencia = 8, idEstado = 1, Latitud = 21.98357222, Longitud = 102.2667667 });
            modelBuilder.Entity<GeoReference>().HasData(new GeoReference { idGeoreferencia = 9, idEstado = 1, Latitud = 21.9836, Longitud = 102.2502306 });
            modelBuilder.Entity<GeoReference>().HasData(new GeoReference { idGeoreferencia = 10, idEstado = 1, Latitud = 22.616775, Longitud = 102.2335389 });
            modelBuilder.Entity<GeoReference>().HasData(new GeoReference { idGeoreferencia = 11, idEstado = 5, Latitud = 25.506789, Longitud = -102.2433589 });
            modelBuilder.Entity<GeoReference>().HasData(new GeoReference { idGeoreferencia = 12, idEstado = 5, Latitud = 25.50705411, Longitud = -102.2443927 });
            modelBuilder.Entity<GeoReference>().HasData(new GeoReference { idGeoreferencia = 13, idEstado = 5, Latitud = 26.30458298, Longitud = -103.0647895 });
            modelBuilder.Entity<GeoReference>().HasData(new GeoReference { idGeoreferencia = 14, idEstado = 5, Latitud = 26.30687434, Longitud = -103.0620606 });
            modelBuilder.Entity<GeoReference>().HasData(new GeoReference { idGeoreferencia = 15, idEstado = 5, Latitud = 26.30047677, Longitud = -103.0553136 });
            modelBuilder.Entity<GeoReference>().HasData(new GeoReference { idGeoreferencia = 16, idEstado = 5, Latitud = 26.29786489, Longitud = -103.0583045 });
            modelBuilder.Entity<GeoReference>().HasData(new GeoReference { idGeoreferencia = 17, idEstado = 5, Latitud = 26.30464132, Longitud = -103.0648854 });
            modelBuilder.Entity<GeoReference>().HasData(new GeoReference { idGeoreferencia = 18, idEstado = 5, Latitud = 26.30694835, Longitud = -103.0622138 });
            modelBuilder.Entity<GeoReference>().HasData(new GeoReference { idGeoreferencia = 19, idEstado = 5, Latitud = 26.31341072, Longitud = -103.0691436 });
            modelBuilder.Entity<GeoReference>().HasData(new GeoReference { idGeoreferencia = 20, idEstado = 5, Latitud = 26.31077704, Longitud = -103.0722422 });
            modelBuilder.Entity<GeoReference>().HasData(new GeoReference { idGeoreferencia = 21, idEstado = 25, Latitud = 24.20180556, Longitud = 107.1031389 });
            modelBuilder.Entity<GeoReference>().HasData(new GeoReference { idGeoreferencia = 22, idEstado = 25, Latitud = 2.201583333, Longitud = 107.1035556 });
            modelBuilder.Entity<GeoReference>().HasData(new GeoReference { idGeoreferencia = 23, idEstado = 25, Latitud = 24.22061111, Longitud = 107.1337222 });
            modelBuilder.Entity<GeoReference>().HasData(new GeoReference { idGeoreferencia = 24, idEstado = 25, Latitud = 24.22238889, Longitud = 107.1337222 });
            modelBuilder.Entity<GeoReference>().HasData(new GeoReference { idGeoreferencia = 25, idEstado = 25, Latitud = 24.10958333, Longitud = 107.0839722 });
            modelBuilder.Entity<GeoReference>().HasData(new GeoReference { idGeoreferencia = 26, idEstado = 25, Latitud = 24.11113889, Longitud = 107.08325 });
            modelBuilder.Entity<GeoReference>().HasData(new GeoReference { idGeoreferencia = 27, idEstado = 25, Latitud = 24.10941667, Longitud = 107.0788889 });
            modelBuilder.Entity<GeoReference>().HasData(new GeoReference { idGeoreferencia = 28, idEstado = 25, Latitud = 24.10727778, Longitud = 107.0763611 });
            modelBuilder.Entity<GeoReference>().HasData(new GeoReference { idGeoreferencia = 29, idEstado = 25, Latitud = 24.21880556, Longitud = 107.1337778 });
            modelBuilder.Entity<GeoReference>().HasData(new GeoReference { idGeoreferencia = 30, idEstado = 25, Latitud = 24.22055556, Longitud = 107.13375 });
            modelBuilder.Entity<GeoReference>().HasData(new GeoReference { idGeoreferencia = 31, idEstado = 14, Latitud = 20.62366667, Longitud = 103.8016111 });
            modelBuilder.Entity<GeoReference>().HasData(new GeoReference { idGeoreferencia = 32, idEstado = 14, Latitud = 20.44083333, Longitud = 103.9239167 });
            modelBuilder.Entity<GeoReference>().HasData(new GeoReference { idGeoreferencia = 33, idEstado = 14, Latitud = 20.48036111, Longitud = 103.9556111 });
            modelBuilder.Entity<GeoReference>().HasData(new GeoReference { idGeoreferencia = 34, idEstado = 14, Latitud = 20.48425, Longitud = 103.9726389 });
            modelBuilder.Entity<GeoReference>().HasData(new GeoReference { idGeoreferencia = 35, idEstado = 14, Latitud = 19.88372222, Longitud = 103.372 });
            modelBuilder.Entity<GeoReference>().HasData(new GeoReference { idGeoreferencia = 36, idEstado = 14, Latitud = 19.62819444, Longitud = 103.7716944 });
            modelBuilder.Entity<GeoReference>().HasData(new GeoReference { idGeoreferencia = 37, idEstado = 14, Latitud = 19.64733333, Longitud = 103.7284444 });
            modelBuilder.Entity<GeoReference>().HasData(new GeoReference { idGeoreferencia = 38, idEstado = 14, Latitud = 19.65225, Longitud = 103.7428056 });
            modelBuilder.Entity<GeoReference>().HasData(new GeoReference { idGeoreferencia = 39, idEstado = 14, Latitud = 19.65730556, Longitud = 103.7916111 });
            modelBuilder.Entity<GeoReference>().HasData(new GeoReference { idGeoreferencia = 40, idEstado = 14, Latitud = 19.5935, Longitud = 103.8120556 });
            modelBuilder.Entity<GeoReference>().HasData(new GeoReference { idGeoreferencia = 41, idEstado = 28, Latitud = 25.74877778, Longitud = 97.57894444 });
            modelBuilder.Entity<GeoReference>().HasData(new GeoReference { idGeoreferencia = 42, idEstado = 28, Latitud = 25.30605556, Longitud = 97.86688889 });
            modelBuilder.Entity<GeoReference>().HasData(new GeoReference { idGeoreferencia = 43, idEstado = 28, Latitud = 25.30605556, Longitud = 97.86688889 });
            modelBuilder.Entity<GeoReference>().HasData(new GeoReference { idGeoreferencia = 44, idEstado = 28, Latitud = 24.61438889, Longitud = 97.91577778 });
            modelBuilder.Entity<GeoReference>().HasData(new GeoReference { idGeoreferencia = 45, idEstado = 28, Latitud = 25.31441667, Longitud = 97.79305556 });
            modelBuilder.Entity<GeoReference>().HasData(new GeoReference { idGeoreferencia = 46, idEstado = 28, Latitud = 24.61452778, Longitud = 97.91575 });
            modelBuilder.Entity<GeoReference>().HasData(new GeoReference { idGeoreferencia = 47, idEstado = 28, Latitud = 25.29966667, Longitud = 97.85988889 });
            modelBuilder.Entity<GeoReference>().HasData(new GeoReference { idGeoreferencia = 48, idEstado = 28, Latitud = 25.29966667, Longitud = 97.85988889 });
            modelBuilder.Entity<GeoReference>().HasData(new GeoReference { idGeoreferencia = 49, idEstado = 28, Latitud = 25.74986111, Longitud = 97.60216667 });
            modelBuilder.Entity<GeoReference>().HasData(new GeoReference { idGeoreferencia = 50, idEstado = 28, Latitud = 25.74986111, Longitud = 97.60218611 });

        }
    }
}
