using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TradeSoft.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class TradeSoftDb1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "Calculations",
                type: "text",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Calculations");
        }
    }
}
