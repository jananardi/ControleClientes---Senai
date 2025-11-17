using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace ControleClientess.Migrations
{
    /// <inheritdoc />
    public partial class Enum : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clientes_GestaoOrdens_GestaoOrdensId",
                table: "Clientes");

            migrationBuilder.DropForeignKey(
                name: "FK_OrdensDeServico_Clientes_ClienteId",
                table: "OrdensDeServico");

            migrationBuilder.DropForeignKey(
                name: "FK_OrdensDeServico_Servicos_ServicoId",
                table: "OrdensDeServico");

            migrationBuilder.DropForeignKey(
                name: "FK_Servicos_GestaoOrdens_GestaoOrdensId",
                table: "Servicos");

            migrationBuilder.DropTable(
                name: "GestaoOrdens");

            migrationBuilder.DropIndex(
                name: "IX_Servicos_GestaoOrdensId",
                table: "Servicos");

            migrationBuilder.DropIndex(
                name: "IX_Clientes_GestaoOrdensId",
                table: "Clientes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OrdensDeServico",
                table: "OrdensDeServico");

            migrationBuilder.DropColumn(
                name: "GestaoOrdensId",
                table: "Servicos");

            migrationBuilder.DropColumn(
                name: "GestaoOrdensId",
                table: "Clientes");

            migrationBuilder.RenameTable(
                name: "OrdensDeServico",
                newName: "OrdemDeServicos");

            migrationBuilder.RenameIndex(
                name: "IX_OrdensDeServico_ServicoId",
                table: "OrdemDeServicos",
                newName: "IX_OrdemDeServicos_ServicoId");

            migrationBuilder.RenameIndex(
                name: "IX_OrdensDeServico_ClienteId",
                table: "OrdemDeServicos",
                newName: "IX_OrdemDeServicos_ClienteId");

            migrationBuilder.AlterColumn<int>(
                name: "Quantidade",
                table: "OrdemDeServicos",
                type: "integer",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "numeric");

            migrationBuilder.AddColumn<int>(
                name: "StatusOS",
                table: "OrdemDeServicos",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrdemDeServicos",
                table: "OrdemDeServicos",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_OrdemDeServicos_Clientes_ClienteId",
                table: "OrdemDeServicos",
                column: "ClienteId",
                principalTable: "Clientes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrdemDeServicos_Servicos_ServicoId",
                table: "OrdemDeServicos",
                column: "ServicoId",
                principalTable: "Servicos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrdemDeServicos_Clientes_ClienteId",
                table: "OrdemDeServicos");

            migrationBuilder.DropForeignKey(
                name: "FK_OrdemDeServicos_Servicos_ServicoId",
                table: "OrdemDeServicos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OrdemDeServicos",
                table: "OrdemDeServicos");

            migrationBuilder.DropColumn(
                name: "StatusOS",
                table: "OrdemDeServicos");

            migrationBuilder.RenameTable(
                name: "OrdemDeServicos",
                newName: "OrdensDeServico");

            migrationBuilder.RenameIndex(
                name: "IX_OrdemDeServicos_ServicoId",
                table: "OrdensDeServico",
                newName: "IX_OrdensDeServico_ServicoId");

            migrationBuilder.RenameIndex(
                name: "IX_OrdemDeServicos_ClienteId",
                table: "OrdensDeServico",
                newName: "IX_OrdensDeServico_ClienteId");

            migrationBuilder.AddColumn<int>(
                name: "GestaoOrdensId",
                table: "Servicos",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "GestaoOrdensId",
                table: "Clientes",
                type: "integer",
                nullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Quantidade",
                table: "OrdensDeServico",
                type: "numeric",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrdensDeServico",
                table: "OrdensDeServico",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "GestaoOrdens",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    DataAbertura = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    DataConclusao = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    IdCliente = table.Column<int>(type: "integer", nullable: true),
                    IdGestao = table.Column<int>(type: "integer", nullable: true),
                    IdServico = table.Column<int>(type: "integer", nullable: true),
                    Quantidade = table.Column<int>(type: "integer", nullable: false),
                    Total = table.Column<double>(type: "double precision", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GestaoOrdens", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Servicos_GestaoOrdensId",
                table: "Servicos",
                column: "GestaoOrdensId");

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_GestaoOrdensId",
                table: "Clientes",
                column: "GestaoOrdensId");

            migrationBuilder.AddForeignKey(
                name: "FK_Clientes_GestaoOrdens_GestaoOrdensId",
                table: "Clientes",
                column: "GestaoOrdensId",
                principalTable: "GestaoOrdens",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_OrdensDeServico_Clientes_ClienteId",
                table: "OrdensDeServico",
                column: "ClienteId",
                principalTable: "Clientes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrdensDeServico_Servicos_ServicoId",
                table: "OrdensDeServico",
                column: "ServicoId",
                principalTable: "Servicos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Servicos_GestaoOrdens_GestaoOrdensId",
                table: "Servicos",
                column: "GestaoOrdensId",
                principalTable: "GestaoOrdens",
                principalColumn: "Id");
        }
    }
}
