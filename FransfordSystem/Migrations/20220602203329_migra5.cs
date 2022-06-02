using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FransfordSystem.Migrations
{
    public partial class migra5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<float>(
                name: "PrecioExamen",
                table: "Examen",
                type: "real",
                nullable: false,
                defaultValue: 0f,
                oldClrType: typeof(double),
                oldType: "float",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "PrecioExamen",
                table: "Examen",
                type: "float",
                nullable: true,
                oldClrType: typeof(float),
                oldType: "real");
        }
    }
}
