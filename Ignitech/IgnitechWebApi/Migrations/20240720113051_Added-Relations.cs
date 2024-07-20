using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IgnitechWebApi.Migrations
{
    /// <inheritdoc />
    public partial class AddedRelations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "StudentId",
                table: "Subject",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TeacherId",
                table: "Student",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SubjectId",
                table: "Grade",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Subject_StudentId",
                table: "Subject",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_Student_TeacherId",
                table: "Student",
                column: "TeacherId");

            migrationBuilder.CreateIndex(
                name: "IX_Grade_SubjectId",
                table: "Grade",
                column: "SubjectId");

            migrationBuilder.AddForeignKey(
                name: "FK_Grade_Subject_SubjectId",
                table: "Grade",
                column: "SubjectId",
                principalTable: "Subject",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Student_Teacher_TeacherId",
                table: "Student",
                column: "TeacherId",
                principalTable: "Teacher",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Subject_Student_StudentId",
                table: "Subject",
                column: "StudentId",
                principalTable: "Student",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Grade_Subject_SubjectId",
                table: "Grade");

            migrationBuilder.DropForeignKey(
                name: "FK_Student_Teacher_TeacherId",
                table: "Student");

            migrationBuilder.DropForeignKey(
                name: "FK_Subject_Student_StudentId",
                table: "Subject");

            migrationBuilder.DropIndex(
                name: "IX_Subject_StudentId",
                table: "Subject");

            migrationBuilder.DropIndex(
                name: "IX_Student_TeacherId",
                table: "Student");

            migrationBuilder.DropIndex(
                name: "IX_Grade_SubjectId",
                table: "Grade");

            migrationBuilder.DropColumn(
                name: "StudentId",
                table: "Subject");

            migrationBuilder.DropColumn(
                name: "TeacherId",
                table: "Student");

            migrationBuilder.DropColumn(
                name: "SubjectId",
                table: "Grade");
        }
    }
}
