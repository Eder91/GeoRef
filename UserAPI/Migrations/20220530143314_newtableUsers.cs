using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UserAPI.Migrations
{
    public partial class newtableUsers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    idUsuario = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fecha_Creacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RFC = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.idUsuario);
                });

            migrationBuilder.CreateTable(
                name: "UsuariosRelEstados",
                columns: table => new
                {
                    idPermiso = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    idUsuario = table.Column<int>(type: "int", nullable: false),
                    idEstado = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsuariosRelEstados", x => x.idPermiso);
                    table.ForeignKey(
                        name: "FK_UsuariosRelEstados_Estados_idEstado",
                        column: x => x.idEstado,
                        principalTable: "Estados",
                        principalColumn: "idEstado",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "idUsuario", "Fecha_Creacion", "Nombre", "Password", "RFC" },
                values: new object[,]
                {
                    { 1, new DateTime(2005, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "PORCICULTORES EL HIBRIDO S DE RL", "abcde", "PHI0501116U3" },
                    { 2, new DateTime(2000, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "AGROPECUARIA EL GIGANTE S.A. DE C.V.", "abcde", "AGI000114C70" },
                    { 3, new DateTime(2004, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "PROVEEDORES AGROALIMENTARIOS DEL DISTRITO DE RIEGO 01 SPR DE RL", "abcde", "PAD0405282B1" },
                    { 4, new DateTime(1997, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "EL SILOGISMO SPR DE RL", "abcde", "SIL971106652" },
                    { 5, new DateTime(2005, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "PRODUCTORES UNIDOS DE LAGOS, S.C. DE R.L. DE C.V.", "abcde", "PUL0507113N6" },
                    { 6, new DateTime(2006, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ALIMENTOS PROCESADOS EL ZARCO S DE R.L. M.I. DE C.V.", "abcde", "APZ060201412" },
                    { 7, new DateTime(1995, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "HSBC MEXICO S.A., INSTITUCION DE BANCA MULTIPLE GRUPO FINANCIERO HSBC", "abcde", "HMI950125KG8" },
                    { 8, new DateTime(2005, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "UNION GANADERA LAS TROJES", "abcde", "UGD0511148J3" },
                    { 9, new DateTime(2005, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "QUESOS LOS MARTINEZ, S. DE R.L. M.I. DE C.V.", "abcde", "QMA050614F17" },
                    { 10, new DateTime(1998, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "RANCHO MEDIO KILO, S. P.R. DE R.L.", "abcde", "RMK9802033P7" },
                    { 11, new DateTime(2002, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "MARTIN RUIZ BERNAL, S. DE P.R. DE R.L.", "abcde", "MRB0112136W7" },
                    { 12, new DateTime(2006, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "CHIVOS Y BORREGOS DE AGUASCALIENTES, S.P.R. DE R.L", "abcde", "CBA051107TKA" },
                    { 13, new DateTime(2002, 12, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "GANADEROS UNIDOS DE TEQUILILLA", "abcde", "GUT021209P8G" },
                    { 14, new DateTime(1999, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "COMUNIDAD PRODUCTORA 2000, S.P.R.DE R.L.", "abcde", "CPD9912105S7" },
                    { 15, new DateTime(2003, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "INOVAGRO, S.A. DE C.V.", "abcde", "INO030616JN5" },
                    { 16, new DateTime(2006, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "GANADERIA LA GREÑUDA, S.C. DE R.L.", "abcde", "GGR060624JV4" },
                    { 17, new DateTime(2005, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "PRODUCTORES DE LA ESTANCIA DE CUQUIO, S.C.  DE  R.L.", "abcde", "PEC051021HX7" },
                    { 18, new DateTime(2004, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "GRANJA EL 13 DE LOS ACUÑA, S.P.R.  DE  R.L.", "abcde", "GTA040327Q39" },
                    { 19, new DateTime(2002, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "EL GREÑERO, S. DE R.L. DE C.V.", "abcde", "GRE0205086JA" },
                    { 20, new DateTime(2001, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "AGRASISA, S.A. DE C.V.", "abcde", "AGR011109ST4" }
                });

            migrationBuilder.InsertData(
                table: "UsuariosRelEstados",
                columns: new[] { "idPermiso", "idEstado", "idUsuario" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 5, 2 },
                    { 3, 25, 3 },
                    { 4, 14, 4 },
                    { 5, 28, 5 },
                    { 6, 5, 6 },
                    { 7, 5, 7 },
                    { 8, 5, 8 },
                    { 9, 1, 9 },
                    { 10, 25, 10 },
                    { 11, 14, 11 },
                    { 12, 28, 12 },
                    { 13, 28, 13 },
                    { 14, 28, 14 },
                    { 15, 14, 15 },
                    { 16, 14, 16 },
                    { 17, 1, 17 },
                    { 18, 25, 18 },
                    { 19, 25, 19 },
                    { 20, 1, 20 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_UsuariosRelEstados_idEstado",
                table: "UsuariosRelEstados",
                column: "idEstado");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "UsuariosRelEstados");
        }
    }
}
