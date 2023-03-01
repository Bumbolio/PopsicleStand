using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PopsicleStand.Migrations
{
    /// <inheritdoc />
    public partial class ProductsSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Name", "Price" },
                values: new object[] { new Guid("382f6336-f6ad-457e-b65f-7d7e9f3c06e6"), "Onions", 11.0 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("382f6336-f6ad-457e-b65f-7d7e9f3c06e6"));
        }
    }
}
