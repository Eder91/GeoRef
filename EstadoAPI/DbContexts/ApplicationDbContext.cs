using EstadoAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace EstadoAPI.DbContexts
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {

        }

        public DbSet<Estados> Estados { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Estados>().HasData(new Estados { idEstado = 1, Descripcion = "AGUASCALIENTES", Clave_Fiscal = "AGS" });
            modelBuilder.Entity<Estados>().HasData(new Estados { idEstado = 2, Descripcion = "BAJA CALIFORNIA", Clave_Fiscal = "BCN" });
            modelBuilder.Entity<Estados>().HasData(new Estados { idEstado = 3, Descripcion = "BAJA CALIFORNIA SUR", Clave_Fiscal = "BCS" });
            modelBuilder.Entity<Estados>().HasData(new Estados { idEstado = 4, Descripcion = "CAMPECHE", Clave_Fiscal = "CAMP" });
            modelBuilder.Entity<Estados>().HasData(new Estados { idEstado = 5, Descripcion = "COAHUILA", Clave_Fiscal = "COAH" });
            modelBuilder.Entity<Estados>().HasData(new Estados { idEstado = 6, Descripcion = "COLIMA", Clave_Fiscal = "COL" });
            modelBuilder.Entity<Estados>().HasData(new Estados { idEstado = 7, Descripcion = "CHIAPAS", Clave_Fiscal = "CHIS" });
            modelBuilder.Entity<Estados>().HasData(new Estados { idEstado = 8, Descripcion = "CHIHUAHUA", Clave_Fiscal = "CHIH" });
            modelBuilder.Entity<Estados>().HasData(new Estados { idEstado = 9, Descripcion = "DISTRITO FEDERAL", Clave_Fiscal = "DF" });
            modelBuilder.Entity<Estados>().HasData(new Estados { idEstado = 10, Descripcion = "DURANGO", Clave_Fiscal = "DGO" });
            modelBuilder.Entity<Estados>().HasData(new Estados { idEstado = 11, Descripcion = "GUANAJUATO", Clave_Fiscal = "GTO" });
            modelBuilder.Entity<Estados>().HasData(new Estados { idEstado = 12, Descripcion = "GUERRERO", Clave_Fiscal = "GRO" });
            modelBuilder.Entity<Estados>().HasData(new Estados { idEstado = 13, Descripcion = "HIDALGO", Clave_Fiscal = "HGO" });
            modelBuilder.Entity<Estados>().HasData(new Estados { idEstado = 14, Descripcion = "JALISCO", Clave_Fiscal = "JAL" });
            modelBuilder.Entity<Estados>().HasData(new Estados { idEstado = 15, Descripcion = "ESTADO DE MEXICO", Clave_Fiscal = "MEX" });
            modelBuilder.Entity<Estados>().HasData(new Estados { idEstado = 16, Descripcion = "MICHOACAN", Clave_Fiscal = "MICH" });
            modelBuilder.Entity<Estados>().HasData(new Estados { idEstado = 17, Descripcion = "MORELOS", Clave_Fiscal = "MOR" });
            modelBuilder.Entity<Estados>().HasData(new Estados { idEstado = 18, Descripcion = "NAYARIT", Clave_Fiscal = "NAY" });
            modelBuilder.Entity<Estados>().HasData(new Estados { idEstado = 19, Descripcion = "NUEVO LEON", Clave_Fiscal = "NL" });
            modelBuilder.Entity<Estados>().HasData(new Estados { idEstado = 20, Descripcion = "OAXACA", Clave_Fiscal = "OAX" });
            modelBuilder.Entity<Estados>().HasData(new Estados { idEstado = 21, Descripcion = "PUEBLA", Clave_Fiscal = "PUE" });
            modelBuilder.Entity<Estados>().HasData(new Estados { idEstado = 22, Descripcion = "QUERETARO", Clave_Fiscal = "QRO" });
            modelBuilder.Entity<Estados>().HasData(new Estados { idEstado = 23, Descripcion = "QUINTANA ROO", Clave_Fiscal = "QROO" });
            modelBuilder.Entity<Estados>().HasData(new Estados { idEstado = 24, Descripcion = "SAN LUIS POTOSI", Clave_Fiscal = "SLP" });
            modelBuilder.Entity<Estados>().HasData(new Estados { idEstado = 25, Descripcion = "SINALOA", Clave_Fiscal = "SIN" });
            modelBuilder.Entity<Estados>().HasData(new Estados { idEstado = 26, Descripcion = "SONORA", Clave_Fiscal = "SON" });
            modelBuilder.Entity<Estados>().HasData(new Estados { idEstado = 27, Descripcion = "TABASCO", Clave_Fiscal = "TAB" });
            modelBuilder.Entity<Estados>().HasData(new Estados { idEstado = 28, Descripcion = "TAMAULIPAS", Clave_Fiscal = "TAMP" });
            modelBuilder.Entity<Estados>().HasData(new Estados { idEstado = 29, Descripcion = "TLAXCALA", Clave_Fiscal = "TLAX" });
            modelBuilder.Entity<Estados>().HasData(new Estados { idEstado = 30, Descripcion = "VERACRUZ", Clave_Fiscal = "VER" });
            modelBuilder.Entity<Estados>().HasData(new Estados { idEstado = 31, Descripcion = "YUCATAN", Clave_Fiscal = "YUC" });
            modelBuilder.Entity<Estados>().HasData(new Estados { idEstado = 32, Descripcion = "ZACATECAS", Clave_Fiscal = "ZAC" });
            modelBuilder.Entity<Estados>().HasData(new Estados { idEstado = 33, Descripcion = "CIUDAD DE MÉXICO", Clave_Fiscal = "CDMX" });
        }
    }
}
