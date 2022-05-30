using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Notas.Migrations
{
    public partial class ColocandoAlunoIdNosBimestres : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AlunoId",
                table: "TerceiroBi",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AlunoId",
                table: "SegundoBi",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AlunoId",
                table: "QuartoBi",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AlunoId",
                table: "PrimeiroBi",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_TerceiroBi_AlunoId",
                table: "TerceiroBi",
                column: "AlunoId");

            migrationBuilder.CreateIndex(
                name: "IX_SegundoBi_AlunoId",
                table: "SegundoBi",
                column: "AlunoId");

            migrationBuilder.CreateIndex(
                name: "IX_QuartoBi_AlunoId",
                table: "QuartoBi",
                column: "AlunoId");

            migrationBuilder.CreateIndex(
                name: "IX_PrimeiroBi_AlunoId",
                table: "PrimeiroBi",
                column: "AlunoId");

            migrationBuilder.AddForeignKey(
                name: "FK_PrimeiroBi_Alunos_AlunoId",
                table: "PrimeiroBi",
                column: "AlunoId",
                principalTable: "Alunos",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_QuartoBi_Alunos_AlunoId",
                table: "QuartoBi",
                column: "AlunoId",
                principalTable: "Alunos",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SegundoBi_Alunos_AlunoId",
                table: "SegundoBi",
                column: "AlunoId",
                principalTable: "Alunos",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TerceiroBi_Alunos_AlunoId",
                table: "TerceiroBi",
                column: "AlunoId",
                principalTable: "Alunos",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PrimeiroBi_Alunos_AlunoId",
                table: "PrimeiroBi");

            migrationBuilder.DropForeignKey(
                name: "FK_QuartoBi_Alunos_AlunoId",
                table: "QuartoBi");

            migrationBuilder.DropForeignKey(
                name: "FK_SegundoBi_Alunos_AlunoId",
                table: "SegundoBi");

            migrationBuilder.DropForeignKey(
                name: "FK_TerceiroBi_Alunos_AlunoId",
                table: "TerceiroBi");

            migrationBuilder.DropIndex(
                name: "IX_TerceiroBi_AlunoId",
                table: "TerceiroBi");

            migrationBuilder.DropIndex(
                name: "IX_SegundoBi_AlunoId",
                table: "SegundoBi");

            migrationBuilder.DropIndex(
                name: "IX_QuartoBi_AlunoId",
                table: "QuartoBi");

            migrationBuilder.DropIndex(
                name: "IX_PrimeiroBi_AlunoId",
                table: "PrimeiroBi");

            migrationBuilder.DropColumn(
                name: "AlunoId",
                table: "TerceiroBi");

            migrationBuilder.DropColumn(
                name: "AlunoId",
                table: "SegundoBi");

            migrationBuilder.DropColumn(
                name: "AlunoId",
                table: "QuartoBi");

            migrationBuilder.DropColumn(
                name: "AlunoId",
                table: "PrimeiroBi");
        }
    }
}
