using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EFTask1.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "name",
                table: "categories",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "description",
                table: "categories",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.InsertData(
                table: "authors",
                columns: new[] { "Id", "Bio", "Country", "DOB", "Email", "firstName", "lastName" },
                values: new object[,]
                {
                    { 1, "English novelist and essayist, author of 1984 and Animal Farm.", "United Kingdom", new DateTime(1903, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "george.orwell@example.com", "George", "Orwell" },
                    { 2, "English novelist known for her novels about the British gentry.", "United Kingdom", new DateTime(1775, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "jane.austen@example.com", "Jane", "Austen" },
                    { 3, "Egyptian writer and winner of the Nobel Prize in Literature.", "Egypt", new DateTime(1911, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "naguib.mahfouz@example.com", "Naguib", "Mahfouz" }
                });

            migrationBuilder.InsertData(
                table: "categories",
                columns: new[] { "id", "description", "isActive", "name" },
                values: new object[,]
                {
                    { 1, "Novels and stories", true, "Fiction" },
                    { 2, "Classic literature", true, "Classic" },
                    { 3, "Science books", false, "Science" }
                });

            migrationBuilder.InsertData(
                table: "books",
                columns: new[] { "ID", "AuthorId", "CategoryId", "ISBN", "Title", "publishYear", "published" },
                values: new object[,]
                {
                    { 1, 1, 1, "978-0451524935", "1984", "1949", true },
                    { 2, 1, 2, "978-0451526342", "Animal Farm", "1945", true },
                    { 3, 2, 2, "978-0141439518", "Pride and Prejudice", "1813", true },
                    { 4, 3, 1, "978-0385264662", "Cairo Trilogy", "1956", true }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.AlterColumn<int>(
                name: "name",
                table: "categories",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "description",
                table: "categories",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
