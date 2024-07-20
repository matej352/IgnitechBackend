using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace IgnitechWebApi.Migrations
{
    /// <inheritdoc />
    public partial class AddedSeededData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TeacherId",
                table: "Subject",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "Teacher",
                columns: new[] { "Id", "FirstName", "LastName", "TeacherCode" },
                values: new object[,]
                {
                    { -2, "Joško", "Gvardiol", new Guid("9b2bc88c-dcd5-44aa-8d46-2da6a95a088e") },
                    { -1, "Luka", "Modrić", new Guid("ae078d76-d7ae-4527-a10b-8bb23e16cb8d") }
                });

            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "Id", "FirstName", "LastName", "StudentCode", "TeacherId" },
                values: new object[,]
                {
                    { -2, "Jane", "Doe", new Guid("16cd18a5-6d54-4b6c-a73a-728af11b5fcb"), -1 },
                    { -1, "John", "Doe", new Guid("611a5d54-d103-43d0-b76b-ef5551016dcb"), -1 }
                });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "Id", "Name", "StudentId", "TeacherId" },
                values: new object[,]
                {
                    { -5, "Uvod u programiranje", -2, -2 },
                    { -4, "Osnove elektrotehnike", -2, -1 },
                    { -3, "Fizika", -1, -1 },
                    { -2, "Matematička analiza 1", -2, -1 },
                    { -1, "Matematička analiza 1", -1, -1 }
                });

            migrationBuilder.InsertData(
                table: "Grade",
                columns: new[] { "Id", "CreatedOn", "SubjectId", "Value" },
                values: new object[,]
                {
                    { -6, new DateTime(2024, 7, 19, 14, 51, 5, 24, DateTimeKind.Utc).AddTicks(5141), -3, 5 },
                    { -5, new DateTime(2024, 7, 19, 14, 51, 5, 24, DateTimeKind.Utc).AddTicks(5140), -3, 1 },
                    { -4, new DateTime(2024, 7, 19, 14, 51, 5, 24, DateTimeKind.Utc).AddTicks(5139), -2, 4 },
                    { -3, new DateTime(2024, 7, 18, 14, 51, 5, 24, DateTimeKind.Utc).AddTicks(5138), -2, 2 },
                    { -2, new DateTime(2024, 7, 18, 14, 51, 5, 24, DateTimeKind.Utc).AddTicks(5137), -1, 5 },
                    { -1, new DateTime(2024, 7, 18, 14, 51, 5, 24, DateTimeKind.Utc).AddTicks(5131), -1, 3 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Subject_TeacherId",
                table: "Subject",
                column: "TeacherId");

            migrationBuilder.AddForeignKey(
                name: "FK_Subject_Teacher_TeacherId",
                table: "Subject",
                column: "TeacherId",
                principalTable: "Teacher",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Subject_Teacher_TeacherId",
                table: "Subject");

            migrationBuilder.DropIndex(
                name: "IX_Subject_TeacherId",
                table: "Subject");

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "Id",
                keyValue: -6);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "Id",
                keyValue: -5);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "Id",
                keyValue: -4);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "Id",
                keyValue: -3);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "Id",
                keyValue: -2);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "Id",
                keyValue: -1);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: -5);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: -4);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: -3);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: -2);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: -1);

            migrationBuilder.DeleteData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: -2);

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "Id",
                keyValue: -2);

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "Id",
                keyValue: -1);

            migrationBuilder.DeleteData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: -1);

            migrationBuilder.DropColumn(
                name: "TeacherId",
                table: "Subject");
        }
    }
}
