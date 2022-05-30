using UsersAPI.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace UsersAPI.DbContexts
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<ApplicationUser> Usuarios { get; set; }
        public DbSet<UsuariosRelEstado> UsuariosRelEstados { get; set; }
        public DbSet<Estados> Estados { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Estados>().ToTable(nameof(Estados), x => x.ExcludeFromMigrations());

            modelBuilder.Entity<ApplicationUser>().HasData(new ApplicationUser { idUsuario = 1, Nombre = "PORCICULTORES EL HIBRIDO S DE RL", Fecha_Creacion = DateTime.Parse("11/01/2005"), RFC = "PHI0501116U3" });
            modelBuilder.Entity<ApplicationUser>().HasData(new ApplicationUser { idUsuario = 2, Nombre = "AGROPECUARIA EL GIGANTE S.A. DE C.V.", Fecha_Creacion = DateTime.Parse("14/01/2000"), RFC = "AGI000114C70" });
            modelBuilder.Entity<ApplicationUser>().HasData(new ApplicationUser { idUsuario = 3, Nombre = "PROVEEDORES AGROALIMENTARIOS DEL DISTRITO DE RIEGO 01 SPR DE RL", Fecha_Creacion = DateTime.Parse("28/05/2004"), RFC = "PAD0405282B1" });
            modelBuilder.Entity<ApplicationUser>().HasData(new ApplicationUser { idUsuario = 4, Nombre = "EL SILOGISMO SPR DE RL", Fecha_Creacion = DateTime.Parse("06/11/1997"), RFC = "SIL971106652" });
            modelBuilder.Entity<ApplicationUser>().HasData(new ApplicationUser { idUsuario = 5, Nombre = "PRODUCTORES UNIDOS DE LAGOS, S.C. DE R.L. DE C.V.", Fecha_Creacion = DateTime.Parse("11/07/2005"), RFC = "PUL0507113N6" });
            modelBuilder.Entity<ApplicationUser>().HasData(new ApplicationUser { idUsuario = 6, Nombre = "ALIMENTOS PROCESADOS EL ZARCO S DE R.L. M.I. DE C.V.", Fecha_Creacion = DateTime.Parse("01/02/2006"), RFC = "APZ060201412" });
            modelBuilder.Entity<ApplicationUser>().HasData(new ApplicationUser { idUsuario = 7, Nombre = "HSBC MEXICO S.A., INSTITUCION DE BANCA MULTIPLE GRUPO FINANCIERO HSBC", Fecha_Creacion = DateTime.Parse("25/01/1995"), RFC = "HMI950125KG8" });
            modelBuilder.Entity<ApplicationUser>().HasData(new ApplicationUser { idUsuario = 8, Nombre = "UNION GANADERA LAS TROJES", Fecha_Creacion = DateTime.Parse("14/11/2005"), RFC = "UGD0511148J3" });
            modelBuilder.Entity<ApplicationUser>().HasData(new ApplicationUser { idUsuario = 9, Nombre = "QUESOS LOS MARTINEZ, S. DE R.L. M.I. DE C.V.", Fecha_Creacion = DateTime.Parse("14/06/2005"), RFC = "QMA050614F17" });
            modelBuilder.Entity<ApplicationUser>().HasData(new ApplicationUser { idUsuario = 10, Nombre = "RANCHO MEDIO KILO, S. P.R. DE R.L.", Fecha_Creacion = DateTime.Parse("03/02/1998"), RFC = "RMK9802033P7" });
            modelBuilder.Entity<ApplicationUser>().HasData(new ApplicationUser { idUsuario = 11, Nombre = "MARTIN RUIZ BERNAL, S. DE P.R. DE R.L.", Fecha_Creacion = DateTime.Parse("20/02/2002"), RFC = "MRB0112136W7" });
            modelBuilder.Entity<ApplicationUser>().HasData(new ApplicationUser { idUsuario = 12, Nombre = "CHIVOS Y BORREGOS DE AGUASCALIENTES, S.P.R. DE R.L", Fecha_Creacion = DateTime.Parse("13/02/2006"), RFC = "CBA051107TKA" });
            modelBuilder.Entity<ApplicationUser>().HasData(new ApplicationUser { idUsuario = 13, Nombre = "GANADEROS UNIDOS DE TEQUILILLA", Fecha_Creacion = DateTime.Parse("09/12/2002"), RFC = "GUT021209P8G" });
            modelBuilder.Entity<ApplicationUser>().HasData(new ApplicationUser { idUsuario = 14, Nombre = "COMUNIDAD PRODUCTORA 2000, S.P.R.DE R.L.", Fecha_Creacion = DateTime.Parse("10/12/1999"), RFC = "CPD9912105S7" });
            modelBuilder.Entity<ApplicationUser>().HasData(new ApplicationUser { idUsuario = 15, Nombre = "INOVAGRO, S.A. DE C.V.", Fecha_Creacion = DateTime.Parse("16/06/2003"), RFC = "INO030616JN5" });
            modelBuilder.Entity<ApplicationUser>().HasData(new ApplicationUser { idUsuario = 16, Nombre = "GANADERIA LA GREÑUDA, S.C. DE R.L.", Fecha_Creacion = DateTime.Parse("24/06/2006"), RFC = "GGR060624JV4" });
            modelBuilder.Entity<ApplicationUser>().HasData(new ApplicationUser { idUsuario = 17, Nombre = "PRODUCTORES DE LA ESTANCIA DE CUQUIO, S.C.  DE  R.L.", Fecha_Creacion = DateTime.Parse("21/10/2005"), RFC = "PEC051021HX7" });
            modelBuilder.Entity<ApplicationUser>().HasData(new ApplicationUser { idUsuario = 18, Nombre = "GRANJA EL 13 DE LOS ACUÑA, S.P.R.  DE  R.L.", Fecha_Creacion = DateTime.Parse("27/03/2004"), RFC = "GTA040327Q39" });
            modelBuilder.Entity<ApplicationUser>().HasData(new ApplicationUser { idUsuario = 19, Nombre = "EL GREÑERO, S. DE R.L. DE C.V.", Fecha_Creacion = DateTime.Parse("08/05/2002"), RFC = "GRE0205086JA" });
            modelBuilder.Entity<ApplicationUser>().HasData(new ApplicationUser { idUsuario = 20, Nombre = "AGRASISA, S.A. DE C.V.", Fecha_Creacion = DateTime.Parse("09/11/2001"), RFC = "AGR011109ST4" });


            modelBuilder.Entity<UsuariosRelEstado>().HasData(new UsuariosRelEstado { idPermiso = 1, idUsuario = 1, idEstado = 1 });
            modelBuilder.Entity<UsuariosRelEstado>().HasData(new UsuariosRelEstado { idPermiso = 2, idUsuario = 2, idEstado = 5 });
            modelBuilder.Entity<UsuariosRelEstado>().HasData(new UsuariosRelEstado { idPermiso = 3, idUsuario = 3, idEstado = 25 });
            modelBuilder.Entity<UsuariosRelEstado>().HasData(new UsuariosRelEstado { idPermiso = 4, idUsuario = 4, idEstado = 14 });
            modelBuilder.Entity<UsuariosRelEstado>().HasData(new UsuariosRelEstado { idPermiso = 5, idUsuario = 5, idEstado = 28 });
            modelBuilder.Entity<UsuariosRelEstado>().HasData(new UsuariosRelEstado { idPermiso = 6, idUsuario = 6, idEstado = 5 });
            modelBuilder.Entity<UsuariosRelEstado>().HasData(new UsuariosRelEstado { idPermiso = 7, idUsuario = 7, idEstado = 5 });
            modelBuilder.Entity<UsuariosRelEstado>().HasData(new UsuariosRelEstado { idPermiso = 8, idUsuario = 8, idEstado = 5 });
            modelBuilder.Entity<UsuariosRelEstado>().HasData(new UsuariosRelEstado { idPermiso = 9, idUsuario = 9, idEstado = 1 });
            modelBuilder.Entity<UsuariosRelEstado>().HasData(new UsuariosRelEstado { idPermiso = 10, idUsuario = 10, idEstado = 25 });
            modelBuilder.Entity<UsuariosRelEstado>().HasData(new UsuariosRelEstado { idPermiso = 11, idUsuario = 11, idEstado = 14 });
            modelBuilder.Entity<UsuariosRelEstado>().HasData(new UsuariosRelEstado { idPermiso = 12, idUsuario = 12, idEstado = 28 });
            modelBuilder.Entity<UsuariosRelEstado>().HasData(new UsuariosRelEstado { idPermiso = 13, idUsuario = 13, idEstado = 28 });
            modelBuilder.Entity<UsuariosRelEstado>().HasData(new UsuariosRelEstado { idPermiso = 14, idUsuario = 14, idEstado = 28 });
            modelBuilder.Entity<UsuariosRelEstado>().HasData(new UsuariosRelEstado { idPermiso = 15, idUsuario = 15, idEstado = 14 });
            modelBuilder.Entity<UsuariosRelEstado>().HasData(new UsuariosRelEstado { idPermiso = 16, idUsuario = 16, idEstado = 14 });
            modelBuilder.Entity<UsuariosRelEstado>().HasData(new UsuariosRelEstado { idPermiso = 17, idUsuario = 17, idEstado = 1 });
            modelBuilder.Entity<UsuariosRelEstado>().HasData(new UsuariosRelEstado { idPermiso = 18, idUsuario = 18, idEstado = 25 });
            modelBuilder.Entity<UsuariosRelEstado>().HasData(new UsuariosRelEstado { idPermiso = 19, idUsuario = 19, idEstado = 25 });
            modelBuilder.Entity<UsuariosRelEstado>().HasData(new UsuariosRelEstado { idPermiso = 20, idUsuario = 20, idEstado = 1 });


        }
    }
}
