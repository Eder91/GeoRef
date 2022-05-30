using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GeoReferenceAPI.Migrations
{
    public partial class newtablegeoreferences : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GeoReferences",
                columns: table => new
                {
                    idGeoreferencia = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    idEstado = table.Column<int>(type: "int", nullable: false),
                    Latitud = table.Column<double>(type: "float", nullable: false),
                    Longitud = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GeoReferences", x => x.idGeoreferencia);
                    table.ForeignKey(
                        name: "FK_GeoReferences_Estados_idEstado",
                        column: x => x.idEstado,
                        principalTable: "Estados",
                        principalColumn: "idEstado",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "GeoReferences",
                columns: new[] { "idGeoreferencia", "Latitud", "Longitud", "idEstado" },
                values: new object[,]
                {
                    { 1, 21.13180225, -89.50884361, 1 },
                    { 2, 22.302624999999999, 102.22631389999999, 1 },
                    { 3, 23.233599999999999, 103.3168167, 1 },
                    { 4, 23.23353333, 103.33355280000001, 1 },
                    { 5, 22.079350000000002, 102.04098329999999, 1 },
                    { 6, 22.397694439999999, 102.2899333, 1 },
                    { 7, 22.398633329999999, 102.2900556, 1 },
                    { 8, 21.983572219999999, 102.26676670000001, 1 },
                    { 9, 21.983599999999999, 102.25023059999999, 1 },
                    { 10, 22.616775000000001, 102.2335389, 1 },
                    { 11, 25.506789000000001, -102.2433589, 5 },
                    { 12, 25.507054109999999, -102.24439270000001, 5 },
                    { 13, 26.304582979999999, -103.0647895, 5 },
                    { 14, 26.30687434, -103.0620606, 5 },
                    { 15, 26.30047677, -103.05531360000001, 5 },
                    { 16, 26.29786489, -103.05830450000001, 5 },
                    { 17, 26.304641320000002, -103.06488539999999, 5 },
                    { 18, 26.306948349999999, -103.06221379999999, 5 },
                    { 19, 26.31341072, -103.0691436, 5 },
                    { 20, 26.310777040000001, -103.07224220000001, 5 },
                    { 21, 24.20180556, 107.1031389, 25 },
                    { 22, 2.2015833329999999, 107.10355560000001, 25 },
                    { 23, 24.22061111, 107.13372219999999, 25 },
                    { 24, 24.222388890000001, 107.13372219999999, 25 },
                    { 25, 24.10958333, 107.08397220000001, 25 },
                    { 26, 24.111138889999999, 107.08325000000001, 25 },
                    { 27, 24.109416670000002, 107.0788889, 25 },
                    { 28, 24.10727778, 107.0763611, 25 },
                    { 29, 24.21880556, 107.1337778, 25 },
                    { 30, 24.220555560000001, 107.13375000000001, 25 },
                    { 31, 20.623666669999999, 103.8016111, 14 },
                    { 32, 20.44083333, 103.92391670000001, 14 },
                    { 33, 20.48036111, 103.9556111, 14 },
                    { 34, 20.484249999999999, 103.97263890000001, 14 },
                    { 35, 19.883722219999999, 103.372, 14 },
                    { 36, 19.628194440000001, 103.7716944, 14 },
                    { 37, 19.647333329999999, 103.7284444, 14 },
                    { 38, 19.652249999999999, 103.7428056, 14 },
                    { 39, 19.657305560000001, 103.7916111, 14 },
                    { 40, 19.593499999999999, 103.81205559999999, 14 },
                    { 41, 25.748777780000001, 97.578944440000001, 28 },
                    { 42, 25.306055560000001, 97.866888889999998, 28 }
                });

            migrationBuilder.InsertData(
                table: "GeoReferences",
                columns: new[] { "idGeoreferencia", "Latitud", "Longitud", "idEstado" },
                values: new object[,]
                {
                    { 43, 25.306055560000001, 97.866888889999998, 28 },
                    { 44, 24.614388890000001, 97.915777779999999, 28 },
                    { 45, 25.31441667, 97.793055559999999, 28 },
                    { 46, 24.61452778, 97.915750000000003, 28 },
                    { 47, 25.299666670000001, 97.859888889999993, 28 },
                    { 48, 25.299666670000001, 97.859888889999993, 28 },
                    { 49, 25.749861110000001, 97.602166670000003, 28 },
                    { 50, 25.749861110000001, 97.602186110000005, 28 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_GeoReferences_idEstado",
                table: "GeoReferences",
                column: "idEstado");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GeoReferences");
        }
    }
}
