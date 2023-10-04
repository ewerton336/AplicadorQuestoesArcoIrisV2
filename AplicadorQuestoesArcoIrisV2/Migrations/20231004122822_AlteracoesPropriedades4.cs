using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AplicadorQuestoesArcoIrisV2.Migrations
{
    /// <inheritdoc />
    public partial class AlteracoesPropriedades4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Alternativas_Perguntas_QuestaoId",
                table: "Alternativas");

            migrationBuilder.DropForeignKey(
                name: "FK_Respostas_Perguntas_PerguntaId",
                table: "Respostas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Perguntas",
                table: "Perguntas");

            migrationBuilder.DropColumn(
                name: "Correta",
                table: "Alternativas");

            migrationBuilder.DropColumn(
                name: "AlternativaCorretaId",
                table: "Perguntas");

            migrationBuilder.RenameTable(
                name: "Perguntas",
                newName: "Questao");

            migrationBuilder.RenameColumn(
                name: "PerguntaId",
                table: "Alternativas",
                newName: "AlternativaCorreta");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Questao",
                table: "Questao",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Alternativas_Questao_QuestaoId",
                table: "Alternativas",
                column: "QuestaoId",
                principalTable: "Questao",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Respostas_Questao_PerguntaId",
                table: "Respostas",
                column: "PerguntaId",
                principalTable: "Questao",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Alternativas_Questao_QuestaoId",
                table: "Alternativas");

            migrationBuilder.DropForeignKey(
                name: "FK_Respostas_Questao_PerguntaId",
                table: "Respostas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Questao",
                table: "Questao");

            migrationBuilder.RenameTable(
                name: "Questao",
                newName: "Perguntas");

            migrationBuilder.RenameColumn(
                name: "AlternativaCorreta",
                table: "Alternativas",
                newName: "PerguntaId");

            migrationBuilder.AddColumn<bool>(
                name: "Correta",
                table: "Alternativas",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "AlternativaCorretaId",
                table: "Perguntas",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Perguntas",
                table: "Perguntas",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Alternativas_Perguntas_QuestaoId",
                table: "Alternativas",
                column: "QuestaoId",
                principalTable: "Perguntas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Respostas_Perguntas_PerguntaId",
                table: "Respostas",
                column: "PerguntaId",
                principalTable: "Perguntas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
