using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AplicadorQuestoesArcoIrisV2.Migrations
{
    /// <inheritdoc />
    public partial class AlteracoesProriedades : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "RespostaCorretaId",
                table: "Perguntas",
                newName: "AlternativaCorretaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "AlternativaCorretaId",
                table: "Perguntas",
                newName: "RespostaCorretaId");
        }
    }
}
