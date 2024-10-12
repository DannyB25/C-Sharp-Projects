using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TechStoreInventory.Migrations
{
    /// <inheritdoc />
    public partial class ChangedNametoProduct : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Products",
                newName: "Product");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Products",
                newName: "Amount");

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Products",
                type: "decimal(7,2)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Product",
                table: "Products",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "Amount",
                table: "Products",
                newName: "Description");

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Products",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(7,2",
                oldNullable: true);
        }
    }
}
