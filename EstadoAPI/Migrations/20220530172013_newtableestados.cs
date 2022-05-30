using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EstadoAPI.Migrations
{
    public partial class newtableestados : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Estados",
                columns: table => new
                {
                    idEstado = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Clave_Fiscal = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estados", x => x.idEstado);
                });

            migrationBuilder.InsertData(
                table: "Estados",
                columns: new[] { "idEstado", "Clave_Fiscal", "Descripcion" },
                values: new object[,]
                {
                    { 1, "AGS", "AGUASCALIENTES" },
                    { 2, "BCN", "BAJA CALIFORNIA" },
                    { 3, "BCS", "BAJA CALIFORNIA SUR" },
                    { 4, "CAMP", "CAMPECHE" },
                    { 5, "COAH", "COAHUILA" },
                    { 6, "COL", "COLIMA" },
                    { 7, "CHIS", "CHIAPAS" },
                    { 8, "CHIH", "CHIHUAHUA" },
                    { 9, "DF", "DISTRITO FEDERAL" },
                    { 10, "DGO", "DURANGO" },
                    { 11, "GTO", "GUANAJUATO" },
                    { 12, "GRO", "GUERRERO" },
                    { 13, "HGO", "HIDALGO" },
                    { 14, "JAL", "JALISCO" },
                    { 15, "MEX", "ESTADO DE MEXICO" },
                    { 16, "MICH", "MICHOACAN" },
                    { 17, "MOR", "MORELOS" },
                    { 18, "NAY", "NAYARIT" },
                    { 19, "NL", "NUEVO LEON" },
                    { 20, "OAX", "OAXACA" },
                    { 21, "PUE", "PUEBLA" },
                    { 22, "QRO", "QUERETARO" },
                    { 23, "QROO", "QUINTANA ROO" },
                    { 24, "SLP", "SAN LUIS POTOSI" },
                    { 25, "SIN", "SINALOA" },
                    { 26, "SON", "SONORA" },
                    { 27, "TAB", "TABASCO" },
                    { 28, "TAMP", "TAMAULIPAS" },
                    { 29, "TLAX", "TLAXCALA" },
                    { 30, "VER", "VERACRUZ" },
                    { 31, "YUC", "YUCATAN" },
                    { 32, "ZAC", "ZACATECAS" },
                    { 33, "CDMX", "CIUDAD DE MÉXICO" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Estados");
        }
    }
}
