using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Register_with_address.Migrations
{
    public partial class RelatedEntities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Unidade",
                table: "Endereço",
                newName: "ddd");

            migrationBuilder.AddColumn<string>(
                name: "Gia",
                table: "Endereço",
                type: "longtext",
                nullable: false,
                collation: "utf8mb4_0900_ai_ci")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Ibge",
                table: "Endereço",
                type: "longtext",
                nullable: false,
                collation: "utf8mb4_0900_ai_ci")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Numero",
                table: "Endereço",
                type: "longtext",
                nullable: false,
                collation: "utf8mb4_0900_ai_ci")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<int>(
                name: "PessoaId",
                table: "Endereço",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Siafi",
                table: "Endereço",
                type: "longtext",
                nullable: false,
                collation: "utf8mb4_0900_ai_ci")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Endereço_PessoaId",
                table: "Endereço",
                column: "PessoaId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Endereço_Pessoas_PessoaId",
                table: "Endereço",
                column: "PessoaId",
                principalTable: "Pessoas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Endereço_Pessoas_PessoaId",
                table: "Endereço");

            migrationBuilder.DropIndex(
                name: "IX_Endereço_PessoaId",
                table: "Endereço");

            migrationBuilder.DropColumn(
                name: "Gia",
                table: "Endereço");

            migrationBuilder.DropColumn(
                name: "Ibge",
                table: "Endereço");

            migrationBuilder.DropColumn(
                name: "Numero",
                table: "Endereço");

            migrationBuilder.DropColumn(
                name: "PessoaId",
                table: "Endereço");

            migrationBuilder.DropColumn(
                name: "Siafi",
                table: "Endereço");

            migrationBuilder.RenameColumn(
                name: "ddd",
                table: "Endereço",
                newName: "Unidade");
        }
    }
}
