using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FolhaPagamento.Migrations
{
    public partial class populando : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Funcionarios",
                columns: new[] { "FuncionarioId", "Nome", "cpf" },
                values: new object[] { 1, "Alisson", "08803431926" });

            migrationBuilder.InsertData(
                table: "Funcionarios",
                columns: new[] { "FuncionarioId", "Nome", "cpf" },
                values: new object[] { 2, "Wendel", "12285720971" });

            migrationBuilder.InsertData(
                table: "Folhas",
                columns: new[] { "Id", "Ano", "FuncionarioId", "Mes", "Quantidade", "Valor" },
                values: new object[] { 1, 2023, 1, 2, 40, 30m });

            migrationBuilder.InsertData(
                table: "Folhas",
                columns: new[] { "Id", "Ano", "FuncionarioId", "Mes", "Quantidade", "Valor" },
                values: new object[] { 2, 2023, 2, 1, 60, 40m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Folhas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Folhas",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Funcionarios",
                keyColumn: "FuncionarioId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Funcionarios",
                keyColumn: "FuncionarioId",
                keyValue: 2);
        }
    }
}
