using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace es_5_EFC_start.Migrations
{
    /// <inheritdoc />
    public partial class AddProductRelation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products_db",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Order_str = table.Column<string>(type: "TEXT", nullable: false),
                    Customer_id = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products_db", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_db_Customers_db_Customer_id",
                        column: x => x.Customer_id,
                        principalTable: "Customers_db",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_db_Customer_id",
                table: "Products_db",
                column: "Customer_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products_db");
        }
    }
}
