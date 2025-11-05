using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ControleClientess.Migrations
{
    /// <inheritdoc />
    public partial class AjusteCidadeNullable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clientes_Cidade_CidadeId",
                table: "Clientes");

            migrationBuilder.AlterColumn<int>(
                name: "CidadeId",
                table: "Clientes",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddForeignKey(
                name: "FK_Clientes_Cidade_CidadeId",
                table: "Clientes",
                column: "CidadeId",
                principalTable: "Cidade",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clientes_Cidade_CidadeId",
                table: "Clientes");

            migrationBuilder.AlterColumn<int>(
                name: "CidadeId",
                table: "Clientes",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Clientes_Cidade_CidadeId",
                table: "Clientes",
                column: "CidadeId",
                principalTable: "Cidade",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
