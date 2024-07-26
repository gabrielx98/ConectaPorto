using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ConectaPorto.Api.Migrations
{
    /// <inheritdoc />
    public partial class QuartaMigracao : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "CNPJ",
                table: "Clientes",
                type: "NUMBER(11)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "NUMBER(10)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "CNPJ",
                table: "Clientes",
                type: "NUMBER(10)",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "NUMBER(11)");
        }
    }
}
