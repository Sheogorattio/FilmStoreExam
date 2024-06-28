using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FilmStoreExam.Migrations
{
    /// <inheritdoc />
    public partial class ActorUpadated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ActorProduct");

            migrationBuilder.AlterColumn<int>(
                name: "ProductId",
                table: "Actors",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Actors_ProductId",
                table: "Actors",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_Actors_Products_ProductId",
                table: "Actors",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Actors_Products_ProductId",
                table: "Actors");

            migrationBuilder.DropIndex(
                name: "IX_Actors_ProductId",
                table: "Actors");

            migrationBuilder.AlterColumn<string>(
                name: "ProductId",
                table: "Actors",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "ActorProduct",
                columns: table => new
                {
                    ActorId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActorProduct", x => new { x.ActorId, x.ProductId });
                    table.ForeignKey(
                        name: "FK_ActorProduct_Actors_ActorId",
                        column: x => x.ActorId,
                        principalTable: "Actors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ActorProduct_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ActorProduct_ProductId",
                table: "ActorProduct",
                column: "ProductId");
        }
    }
}
