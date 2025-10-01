using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace es_5_EFC_start.Migrations
{
    /// <inheritdoc />
    public partial class CreateCustomerAndOrder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "Products_db",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "Products_db");
        }
    }
}
