using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mago.Services.Identity.Migrations
{
    public partial class newuserstable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "AspNetUsers",
                newName: "RFC");

            migrationBuilder.RenameColumn(
                name: "FirstName",
                table: "AspNetUsers",
                newName: "Nombre");

            migrationBuilder.AddColumn<DateTime>(
                name: "Fecha_Creacion",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "idUsuario",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "Fecha_Creacion", "LockoutEnabled", "LockoutEnd", "Nombre", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RFC", "SecurityStamp", "TwoFactorEnabled", "UserName", "idUsuario" },
                values: new object[,]
                {
                    { "07bcfb3d-2a66-4dd4-b066-ea3b50086d96", 0, "4267bba9-bec5-407c-ba54-ce255dfc0894", null, false, new DateTime(2005, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "PRODUCTORES DE LA ESTANCIA DE CUQUIO, S.C.  DE  R.L.", null, null, null, null, false, "PEC051021HX7", "032ca67d-0b9b-4c56-99e7-9974657dabfb", false, null, 17 },
                    { "0e73b970-2745-4188-ad9b-48dde90380ae", 0, "5ff7eabb-2668-4f90-87e7-f36197e36043", null, false, new DateTime(2006, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "GANADERIA LA GREÑUDA, S.C. DE R.L.", null, null, null, null, false, "GGR060624JV4", "29e56b18-f9ee-4c4e-8625-00f43a8d7a39", false, null, 16 },
                    { "3661ca1e-467a-41c1-a30d-6c336894133a", 0, "5530921a-9740-4358-89ab-afa025783d9d", null, false, new DateTime(2002, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "EL GREÑERO, S. DE R.L. DE C.V.", null, null, null, null, false, "GRE0205086JA", "6773b697-0c76-4870-bb6d-6e5450f161b9", false, null, 19 },
                    { "3d2435f1-8c1a-4a6d-b697-b90611e3377d", 0, "aaf65c8f-447f-4c64-bd1e-f4b13e07b51d", null, false, new DateTime(2003, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "INOVAGRO, S.A. DE C.V.", null, null, null, null, false, "INO030616JN5", "378ed4ae-a0a7-47e6-a5d7-90bd257a89b3", false, null, 15 },
                    { "480ff59e-8b24-4c0a-9b01-fa4ece96e44b", 0, "a445dc16-da6d-49c2-981e-427aef3859ab", null, false, new DateTime(2005, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "UNION GANADERA LAS TROJES", null, null, null, null, false, "UGD0511148J3", "25b257f4-99ab-48ea-af87-7add0c0069d0", false, null, 8 },
                    { "6d0c7dd4-86e8-408d-8895-3147c10d178c", 0, "39ec6785-0c4d-404b-bd33-66a8d7236050", null, false, new DateTime(2006, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "CHIVOS Y BORREGOS DE AGUASCALIENTES, S.P.R. DE R.L", null, null, null, null, false, "CBA051107TKA", "5dc0339b-ada7-42d1-9391-455123f25435", false, null, 12 },
                    { "6e033ad4-ad33-4334-b6ce-e920a7d90b83", 0, "fc1cd745-cf02-45eb-8fbd-310c7f1cd810", null, false, new DateTime(1997, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "EL SILOGISMO SPR DE RL", null, null, null, null, false, "SIL971106652", "9da27bfd-9d0c-4e11-8222-cdd97dc758c8", false, null, 4 },
                    { "7785a58b-6be1-476e-97b6-ea70de8a4228", 0, "23d26ea6-7efe-4ba0-9085-9302026d548e", null, false, new DateTime(2004, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "PROVEEDORES AGROALIMENTARIOS DEL DISTRITO DE RIEGO 01 SPR DE RL", null, null, null, null, false, "PAD0405282B1", "c72b4a99-a547-401b-be13-2da001d7709f", false, null, 3 },
                    { "781264a3-b62d-43b8-ab1d-a783e9d8779c", 0, "f51d89dd-7ef6-453f-8c8d-955937fb92bd", null, false, new DateTime(2002, 12, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "GANADEROS UNIDOS DE TEQUILILLA", null, null, null, null, false, "GUT021209P8G", "25fc164b-2087-4874-ae99-3419575806a3", false, null, 13 },
                    { "9bc87bbc-e214-4e52-8065-1825e1313b06", 0, "39c7dcf1-03ec-4ee7-9d78-faf389756ad5", null, false, new DateTime(2005, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "PRODUCTORES UNIDOS DE LAGOS, S.C. DE R.L. DE C.V.", null, null, null, null, false, "PUL0507113N6", "f1e4b527-f176-4ae8-b3fc-adcd80c377f2", false, null, 5 },
                    { "9db60ea4-c082-49be-a41c-f6f4227df59d", 0, "63cb62bb-b55e-4d7d-8af5-472218d81548", null, false, new DateTime(2004, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "GRANJA EL 13 DE LOS ACUÑA, S.P.R.  DE  R.L.", null, null, null, null, false, "GTA040327Q39", "64b0c2de-bb6d-4c88-8b95-adc86d281aa3", false, null, 18 },
                    { "a2eb1d03-3ca2-4ec3-8d9f-44627ec4d20b", 0, "b42603b6-f0b4-4a4e-8083-50faa62048db", null, false, new DateTime(2005, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "QUESOS LOS MARTINEZ, S. DE R.L. M.I. DE C.V.", null, null, null, null, false, "QMA050614F17", "0c642e54-bfd8-45b4-9b5a-950f28e30f07", false, null, 9 },
                    { "a394068a-6886-4b97-8ff9-9a177fb6451c", 0, "b69c95dc-b24e-444d-b57e-c65ecd034199", null, false, new DateTime(2005, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "PORCICULTORES EL HIBRIDO S DE RL", null, null, null, null, false, "PHI0501116U3", "15dd0f18-284c-4637-9c53-f8207beb087c", false, null, 1 },
                    { "b58f0eed-07d6-475c-8846-caee0d19c41d", 0, "89ac9246-44ef-4fe1-a64e-a4cce706799c", null, false, new DateTime(2002, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "MARTIN RUIZ BERNAL, S. DE P.R. DE R.L.", null, null, null, null, false, "MRB0112136W7", "50d15c76-6429-4c8c-a3e5-004637b780ad", false, null, 11 },
                    { "c557a079-5b72-4141-b45f-05b05b715f03", 0, "08f4a292-1706-45fc-bda6-4d1ca8add1c2", null, false, new DateTime(2006, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "ALIMENTOS PROCESADOS EL ZARCO S DE R.L. M.I. DE C.V.", null, null, null, null, false, "APZ060201412", "2c14a66c-133e-4335-8f78-70ebd29a322d", false, null, 6 },
                    { "de9774ac-289d-4295-8397-7c1a267b9bae", 0, "2bba5118-9afe-4b18-8b93-96186b81bca9", null, false, new DateTime(1995, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "HSBC MEXICO S.A., INSTITUCION DE BANCA MULTIPLE GRUPO FINANCIERO HSBC", null, null, null, null, false, "HMI950125KG8", "b1726154-51fd-458d-a0b0-eb63bfaed411", false, null, 7 },
                    { "dfd7a735-92ea-4b02-bce4-e0d9fe3a92e5", 0, "41f93cc8-bde2-455f-8391-cf9c0173fe23", null, false, new DateTime(2000, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "AGROPECUARIA EL GIGANTE S.A. DE C.V.", null, null, null, null, false, "AGI000114C70", "084f3f25-03fc-4428-8358-25064856765c", false, null, 2 },
                    { "e3c3751b-64cd-4b7d-b1ea-5b693bb594c2", 0, "55b21dd5-33e3-44d7-9d88-68fa6c78fa3d", null, false, new DateTime(1998, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "RANCHO MEDIO KILO, S. P.R. DE R.L.", null, null, null, null, false, "RMK9802033P7", "5bb968cc-a168-4819-87d2-1681ff759602", false, null, 10 },
                    { "e60ff932-0236-45fe-aa40-00be64053616", 0, "a0cdd06a-db9e-49dd-809e-56d839771585", null, false, new DateTime(1999, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "COMUNIDAD PRODUCTORA 2000, S.P.R.DE R.L.", null, null, null, null, false, "CPD9912105S7", "6210b3e6-b459-4905-a4a7-6a8c191d6409", false, null, 14 },
                    { "f06ef08b-72fc-4ca3-9b30-9371e2a3e8f7", 0, "e1046be5-0961-4340-ba1e-a7ce60497352", null, false, new DateTime(2001, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "AGRASISA, S.A. DE C.V.", null, null, null, null, false, "AGR011109ST4", "26cd0aed-e937-410d-bc4e-4fb31d43e005", false, null, 20 }
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
                name: "UsuariosRelEstados");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "07bcfb3d-2a66-4dd4-b066-ea3b50086d96");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0e73b970-2745-4188-ad9b-48dde90380ae");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3661ca1e-467a-41c1-a30d-6c336894133a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3d2435f1-8c1a-4a6d-b697-b90611e3377d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "480ff59e-8b24-4c0a-9b01-fa4ece96e44b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d0c7dd4-86e8-408d-8895-3147c10d178c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6e033ad4-ad33-4334-b6ce-e920a7d90b83");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7785a58b-6be1-476e-97b6-ea70de8a4228");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "781264a3-b62d-43b8-ab1d-a783e9d8779c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9bc87bbc-e214-4e52-8065-1825e1313b06");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9db60ea4-c082-49be-a41c-f6f4227df59d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a2eb1d03-3ca2-4ec3-8d9f-44627ec4d20b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a394068a-6886-4b97-8ff9-9a177fb6451c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b58f0eed-07d6-475c-8846-caee0d19c41d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c557a079-5b72-4141-b45f-05b05b715f03");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "de9774ac-289d-4295-8397-7c1a267b9bae");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dfd7a735-92ea-4b02-bce4-e0d9fe3a92e5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e3c3751b-64cd-4b7d-b1ea-5b693bb594c2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e60ff932-0236-45fe-aa40-00be64053616");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f06ef08b-72fc-4ca3-9b30-9371e2a3e8f7");

            migrationBuilder.DropColumn(
                name: "Fecha_Creacion",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "idUsuario",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "RFC",
                table: "AspNetUsers",
                newName: "LastName");

            migrationBuilder.RenameColumn(
                name: "Nombre",
                table: "AspNetUsers",
                newName: "FirstName");
        }
    }
}
