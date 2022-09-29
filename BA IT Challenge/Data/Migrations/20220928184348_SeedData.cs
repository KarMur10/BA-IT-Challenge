using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BA_IT_Challenge.Data.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "PublishDate",
                table: "Books",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "Genre", "ISBN", "LenderOrReserverId", "PublishDate", "Publisher", "Status", "Title" },
                values: new object[] { 1, "Nancy H. Kleinbaum", "Fiction", "4567876543678", null, "1988", "Disney Press", "Available", "Dead Poets Society" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "Genre", "ISBN", "LenderOrReserverId", "PublishDate", "Publisher", "Status", "Title" },
                values: new object[] { 2, "Dale Carnegie", "Self-help", "9876567098764", null, "1936", "Simon & Schuster", "Available", "How to Win Friends and Influence People" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "Genre", "ISBN", "LenderOrReserverId", "PublishDate", "Publisher", "Status", "Title" },
                values: new object[] { 3, "Chuck Palahniuk", null, "4567876543442", null, null, null, "Available", "Fight Club" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.AlterColumn<DateTime>(
                name: "PublishDate",
                table: "Books",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
