using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Edugrade.Migrations
{
    /// <inheritdoc />
    public partial class changemodels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_SchoolClasses_FkSchoolClassId",
                table: "Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_Enrollments_Students_FkStudentId",
                table: "Enrollments");

            migrationBuilder.DropIndex(
                name: "IX_Courses_FkSchoolClassId",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "FkSchoolClassId",
                table: "Courses");

            migrationBuilder.RenameColumn(
                name: "FkStudentId",
                table: "Enrollments",
                newName: "FkSchoolClassId");

            migrationBuilder.RenameIndex(
                name: "IX_Enrollments_FkStudentId",
                table: "Enrollments",
                newName: "IX_Enrollments_FkSchoolClassId");

            migrationBuilder.AddColumn<int>(
                name: "FkSchoolClassId",
                table: "Students",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Students_FkSchoolClassId",
                table: "Students",
                column: "FkSchoolClassId");

            migrationBuilder.AddForeignKey(
                name: "FK_Enrollments_SchoolClasses_FkSchoolClassId",
                table: "Enrollments",
                column: "FkSchoolClassId",
                principalTable: "SchoolClasses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_SchoolClasses_FkSchoolClassId",
                table: "Students",
                column: "FkSchoolClassId",
                principalTable: "SchoolClasses",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Enrollments_SchoolClasses_FkSchoolClassId",
                table: "Enrollments");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_SchoolClasses_FkSchoolClassId",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_FkSchoolClassId",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "FkSchoolClassId",
                table: "Students");

            migrationBuilder.RenameColumn(
                name: "FkSchoolClassId",
                table: "Enrollments",
                newName: "FkStudentId");

            migrationBuilder.RenameIndex(
                name: "IX_Enrollments_FkSchoolClassId",
                table: "Enrollments",
                newName: "IX_Enrollments_FkStudentId");

            migrationBuilder.AddColumn<int>(
                name: "FkSchoolClassId",
                table: "Courses",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1,
                column: "FkSchoolClassId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 2,
                column: "FkSchoolClassId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 3,
                column: "FkSchoolClassId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 4,
                column: "FkSchoolClassId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 5,
                column: "FkSchoolClassId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 6,
                column: "FkSchoolClassId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 7,
                column: "FkSchoolClassId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 8,
                column: "FkSchoolClassId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 9,
                column: "FkSchoolClassId",
                value: null);

            migrationBuilder.CreateIndex(
                name: "IX_Courses_FkSchoolClassId",
                table: "Courses",
                column: "FkSchoolClassId");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_SchoolClasses_FkSchoolClassId",
                table: "Courses",
                column: "FkSchoolClassId",
                principalTable: "SchoolClasses",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Enrollments_Students_FkStudentId",
                table: "Enrollments",
                column: "FkStudentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
