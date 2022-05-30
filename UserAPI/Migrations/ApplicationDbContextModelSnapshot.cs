﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using UserAPI.DbContexts;

#nullable disable

namespace UserAPI.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("UserAPI.Models.Estados", b =>
                {
                    b.Property<int>("idEstado")
                        .HasColumnType("int");

                    b.Property<string>("Clave_Fiscal")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idEstado");

                    b.ToTable("Estados", null, t => t.ExcludeFromMigrations());
                });

            modelBuilder.Entity("UserAPI.Models.Usuarios", b =>
                {
                    b.Property<int>("idUsuario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("idUsuario"), 1L, 1);

                    b.Property<DateTime>("Fecha_Creacion")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RFC")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idUsuario");

                    b.ToTable("Usuarios");

                    b.HasData(
                        new
                        {
                            idUsuario = 1,
                            Fecha_Creacion = new DateTime(2005, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nombre = "PORCICULTORES EL HIBRIDO S DE RL",
                            Password = "abcde",
                            RFC = "PHI0501116U3"
                        },
                        new
                        {
                            idUsuario = 2,
                            Fecha_Creacion = new DateTime(2000, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nombre = "AGROPECUARIA EL GIGANTE S.A. DE C.V.",
                            Password = "abcde",
                            RFC = "AGI000114C70"
                        },
                        new
                        {
                            idUsuario = 3,
                            Fecha_Creacion = new DateTime(2004, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nombre = "PROVEEDORES AGROALIMENTARIOS DEL DISTRITO DE RIEGO 01 SPR DE RL",
                            Password = "abcde",
                            RFC = "PAD0405282B1"
                        },
                        new
                        {
                            idUsuario = 4,
                            Fecha_Creacion = new DateTime(1997, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nombre = "EL SILOGISMO SPR DE RL",
                            Password = "abcde",
                            RFC = "SIL971106652"
                        },
                        new
                        {
                            idUsuario = 5,
                            Fecha_Creacion = new DateTime(2005, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nombre = "PRODUCTORES UNIDOS DE LAGOS, S.C. DE R.L. DE C.V.",
                            Password = "abcde",
                            RFC = "PUL0507113N6"
                        },
                        new
                        {
                            idUsuario = 6,
                            Fecha_Creacion = new DateTime(2006, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nombre = "ALIMENTOS PROCESADOS EL ZARCO S DE R.L. M.I. DE C.V.",
                            Password = "abcde",
                            RFC = "APZ060201412"
                        },
                        new
                        {
                            idUsuario = 7,
                            Fecha_Creacion = new DateTime(1995, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nombre = "HSBC MEXICO S.A., INSTITUCION DE BANCA MULTIPLE GRUPO FINANCIERO HSBC",
                            Password = "abcde",
                            RFC = "HMI950125KG8"
                        },
                        new
                        {
                            idUsuario = 8,
                            Fecha_Creacion = new DateTime(2005, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nombre = "UNION GANADERA LAS TROJES",
                            Password = "abcde",
                            RFC = "UGD0511148J3"
                        },
                        new
                        {
                            idUsuario = 9,
                            Fecha_Creacion = new DateTime(2005, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nombre = "QUESOS LOS MARTINEZ, S. DE R.L. M.I. DE C.V.",
                            Password = "abcde",
                            RFC = "QMA050614F17"
                        },
                        new
                        {
                            idUsuario = 10,
                            Fecha_Creacion = new DateTime(1998, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nombre = "RANCHO MEDIO KILO, S. P.R. DE R.L.",
                            Password = "abcde",
                            RFC = "RMK9802033P7"
                        },
                        new
                        {
                            idUsuario = 11,
                            Fecha_Creacion = new DateTime(2002, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nombre = "MARTIN RUIZ BERNAL, S. DE P.R. DE R.L.",
                            Password = "abcde",
                            RFC = "MRB0112136W7"
                        },
                        new
                        {
                            idUsuario = 12,
                            Fecha_Creacion = new DateTime(2006, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nombre = "CHIVOS Y BORREGOS DE AGUASCALIENTES, S.P.R. DE R.L",
                            Password = "abcde",
                            RFC = "CBA051107TKA"
                        },
                        new
                        {
                            idUsuario = 13,
                            Fecha_Creacion = new DateTime(2002, 12, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nombre = "GANADEROS UNIDOS DE TEQUILILLA",
                            Password = "abcde",
                            RFC = "GUT021209P8G"
                        },
                        new
                        {
                            idUsuario = 14,
                            Fecha_Creacion = new DateTime(1999, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nombre = "COMUNIDAD PRODUCTORA 2000, S.P.R.DE R.L.",
                            Password = "abcde",
                            RFC = "CPD9912105S7"
                        },
                        new
                        {
                            idUsuario = 15,
                            Fecha_Creacion = new DateTime(2003, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nombre = "INOVAGRO, S.A. DE C.V.",
                            Password = "abcde",
                            RFC = "INO030616JN5"
                        },
                        new
                        {
                            idUsuario = 16,
                            Fecha_Creacion = new DateTime(2006, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nombre = "GANADERIA LA GREÑUDA, S.C. DE R.L.",
                            Password = "abcde",
                            RFC = "GGR060624JV4"
                        },
                        new
                        {
                            idUsuario = 17,
                            Fecha_Creacion = new DateTime(2005, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nombre = "PRODUCTORES DE LA ESTANCIA DE CUQUIO, S.C.  DE  R.L.",
                            Password = "abcde",
                            RFC = "PEC051021HX7"
                        },
                        new
                        {
                            idUsuario = 18,
                            Fecha_Creacion = new DateTime(2004, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nombre = "GRANJA EL 13 DE LOS ACUÑA, S.P.R.  DE  R.L.",
                            Password = "abcde",
                            RFC = "GTA040327Q39"
                        },
                        new
                        {
                            idUsuario = 19,
                            Fecha_Creacion = new DateTime(2002, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nombre = "EL GREÑERO, S. DE R.L. DE C.V.",
                            Password = "abcde",
                            RFC = "GRE0205086JA"
                        },
                        new
                        {
                            idUsuario = 20,
                            Fecha_Creacion = new DateTime(2001, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nombre = "AGRASISA, S.A. DE C.V.",
                            Password = "abcde",
                            RFC = "AGR011109ST4"
                        });
                });

            modelBuilder.Entity("UserAPI.Models.UsuariosRelEstado", b =>
                {
                    b.Property<int>("idPermiso")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("idPermiso"), 1L, 1);

                    b.Property<int>("idEstado")
                        .HasColumnType("int");

                    b.Property<int>("idUsuario")
                        .HasColumnType("int");

                    b.HasKey("idPermiso");

                    b.HasIndex("idEstado");

                    b.ToTable("UsuariosRelEstados");

                    b.HasData(
                        new
                        {
                            idPermiso = 1,
                            idEstado = 1,
                            idUsuario = 1
                        },
                        new
                        {
                            idPermiso = 2,
                            idEstado = 5,
                            idUsuario = 2
                        },
                        new
                        {
                            idPermiso = 3,
                            idEstado = 25,
                            idUsuario = 3
                        },
                        new
                        {
                            idPermiso = 4,
                            idEstado = 14,
                            idUsuario = 4
                        },
                        new
                        {
                            idPermiso = 5,
                            idEstado = 28,
                            idUsuario = 5
                        },
                        new
                        {
                            idPermiso = 6,
                            idEstado = 5,
                            idUsuario = 6
                        },
                        new
                        {
                            idPermiso = 7,
                            idEstado = 5,
                            idUsuario = 7
                        },
                        new
                        {
                            idPermiso = 8,
                            idEstado = 5,
                            idUsuario = 8
                        },
                        new
                        {
                            idPermiso = 9,
                            idEstado = 1,
                            idUsuario = 9
                        },
                        new
                        {
                            idPermiso = 10,
                            idEstado = 25,
                            idUsuario = 10
                        },
                        new
                        {
                            idPermiso = 11,
                            idEstado = 14,
                            idUsuario = 11
                        },
                        new
                        {
                            idPermiso = 12,
                            idEstado = 28,
                            idUsuario = 12
                        },
                        new
                        {
                            idPermiso = 13,
                            idEstado = 28,
                            idUsuario = 13
                        },
                        new
                        {
                            idPermiso = 14,
                            idEstado = 28,
                            idUsuario = 14
                        },
                        new
                        {
                            idPermiso = 15,
                            idEstado = 14,
                            idUsuario = 15
                        },
                        new
                        {
                            idPermiso = 16,
                            idEstado = 14,
                            idUsuario = 16
                        },
                        new
                        {
                            idPermiso = 17,
                            idEstado = 1,
                            idUsuario = 17
                        },
                        new
                        {
                            idPermiso = 18,
                            idEstado = 25,
                            idUsuario = 18
                        },
                        new
                        {
                            idPermiso = 19,
                            idEstado = 25,
                            idUsuario = 19
                        },
                        new
                        {
                            idPermiso = 20,
                            idEstado = 1,
                            idUsuario = 20
                        });
                });

            modelBuilder.Entity("UserAPI.Models.UsuariosRelEstado", b =>
                {
                    b.HasOne("UserAPI.Models.Estados", "Estados")
                        .WithMany()
                        .HasForeignKey("idEstado")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Estados");
                });
#pragma warning restore 612, 618
        }
    }
}
