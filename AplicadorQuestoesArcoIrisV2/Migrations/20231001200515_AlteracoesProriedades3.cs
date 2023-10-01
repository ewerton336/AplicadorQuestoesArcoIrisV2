using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AplicadorQuestoesArcoIrisV2.Migrations
{
    /// <inheritdoc />
    public partial class AlteracoesProriedades3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Alternativas_Perguntas_PerguntaId",
                table: "Alternativas");

            migrationBuilder.DropIndex(
                name: "IX_Alternativas_PerguntaId",
                table: "Alternativas");

            migrationBuilder.AddColumn<int>(
                name: "QuestaoId",
                table: "Alternativas",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Alternativas_QuestaoId",
                table: "Alternativas",
                column: "QuestaoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Alternativas_Perguntas_QuestaoId",
                table: "Alternativas",
                column: "QuestaoId",
                principalTable: "Perguntas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Alternativas_Perguntas_QuestaoId",
                table: "Alternativas");

            migrationBuilder.DropIndex(
                name: "IX_Alternativas_QuestaoId",
                table: "Alternativas");

            migrationBuilder.DropColumn(
                name: "QuestaoId",
                table: "Alternativas");

            migrationBuilder.CreateIndex(
                name: "IX_Alternativas_PerguntaId",
                table: "Alternativas",
                column: "PerguntaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Alternativas_Perguntas_PerguntaId",
                table: "Alternativas",
                column: "PerguntaId",
                principalTable: "Perguntas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
