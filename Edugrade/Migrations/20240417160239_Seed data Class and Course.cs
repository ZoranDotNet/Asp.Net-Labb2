using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Edugrade.Migrations
{
    /// <inheritdoc />
    public partial class SeeddataClassandCourse : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_SchoolClasses_FkSchoolClassId",
                table: "Courses");

            migrationBuilder.AlterColumn<int>(
                name: "FkSchoolClassId",
                table: "Courses",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "FkSchoolClassId", "Name" },
                values: new object[,]
                {
                    { 1, null, "Programmering 1" },
                    { 2, null, "Programmering 2" },
                    { 3, null, "Programmering 3" },
                    { 4, null, "Frontend" },
                    { 5, null, "React" },
                    { 6, null, "Sql Databaser" },
                    { 7, null, "Asp.Net" },
                    { 8, null, "DevOps" },
                    { 9, null, "Agila Metoder" }
                });

            migrationBuilder.InsertData(
                table: "SchoolClasses",
                columns: new[] { "Id", "ClassName" },
                values: new object[,]
                {
                    { 1, "Net22" },
                    { 2, "Net23" },
                    { 3, "Net24" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_SchoolClasses_FkSchoolClassId",
                table: "Courses",
                column: "FkSchoolClassId",
                principalTable: "SchoolClasses",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_SchoolClasses_FkSchoolClassId",
                table: "Courses");

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "SchoolClasses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "SchoolClasses",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "SchoolClasses",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.AlterColumn<int>(
                name: "FkSchoolClassId",
                table: "Courses",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_SchoolClasses_FkSchoolClassId",
                table: "Courses",
                column: "FkSchoolClassId",
                principalTable: "SchoolClasses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
