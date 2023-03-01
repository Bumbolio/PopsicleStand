using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PopsicleStand.Migrations
{
    /// <inheritdoc />
    public partial class MoreProductsSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Name", "Price" },
                values: new object[] { new Guid("1bd3aea4-4c5a-4f19-b409-7cbca3fada73"), "Limes", 12.0 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1bd3aea4-4c5a-4f19-b409-7cbca3fada73"));
        }
    }
}
