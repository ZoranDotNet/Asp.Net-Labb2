using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Edugrade.Migrations
{
    /// <inheritdoc />
    public partial class Changedmodelsagain : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Enrollments_SchoolClasses_FkSchoolClassId",
                table: "Enrollments");

            migrationBuilder.RenameColumn(
                name: "FkSchoolClassId",
                table: "Enrollments",
                newName: "FkStudentId");

            migrationBuilder.RenameIndex(
                name: "IX_Enrollments_FkSchoolClassId",
                table: "Enrollments",
                newName: "IX_Enrollments_FkStudentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Enrollments_Students_FkStudentId",
                table: "Enrollments",
                column: "FkStudentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Enrollments_Students_FkStudentId",
                table: "Enrollments");

            migrationBuilder.RenameColumn(
                name: "FkStudentId",
                table: "Enrollments",
                newName: "FkSchoolClassId");

            migrationBuilder.RenameIndex(
                name: "IX_Enrollments_FkStudentId",
                table: "Enrollments",
                newName: "IX_Enrollments_FkSchoolClassId");

            migrationBuilder.AddForeignKey(
                name: "FK_Enrollments_SchoolClasses_FkSchoolClassId",
                table: "Enrollments",
                column: "FkSchoolClassId",
                principalTable: "SchoolClasses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
