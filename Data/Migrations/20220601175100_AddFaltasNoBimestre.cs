using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Notas.Migrations
{
    public partial class AddFaltasNoBimestre : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Faltas",
                table: "TerceiroBi",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Faltas",
                table: "SegundoBi",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Faltas",
                table: "QuartoBi",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Faltas",
                table: "PrimeiroBi",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Faltas",
                table: "TerceiroBi");

            migrationBuilder.DropColumn(
                name: "Faltas",
                table: "SegundoBi");

            migrationBuilder.DropColumn(
                name: "Faltas",
                table: "QuartoBi");

            migrationBuilder.DropColumn(
                name: "Faltas",
                table: "PrimeiroBi");
        }
    }
}
