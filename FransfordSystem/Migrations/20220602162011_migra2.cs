using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FransfordSystem.Migrations
{
    public partial class migra2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Examen_Categoria_categoriaIdCategoria",
                table: "Examen");

            migrationBuilder.AlterColumn<int>(
                name: "categoriaIdCategoria",
                table: "Examen",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Examen_Categoria_categoriaIdCategoria",
                table: "Examen",
                column: "categoriaIdCategoria",
                principalTable: "Categoria",
                principalColumn: "IdCategoria");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Examen_Categoria_categoriaIdCategoria",
                table: "Examen");

            migrationBuilder.AlterColumn<int>(
                name: "categoriaIdCategoria",
                table: "Examen",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Examen_Categoria_categoriaIdCategoria",
                table: "Examen",
                column: "categoriaIdCategoria",
                principalTable: "Categoria",
                principalColumn: "IdCategoria",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
