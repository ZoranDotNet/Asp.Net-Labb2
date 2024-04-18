using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Edugrade.Migrations
{
    /// <inheritdoc />
    public partial class changedmodelback : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Enrollments_Students_FkStudentId",
                table: "Enrollments");

            migrationBuilder.DropForeignKey(
                name: "FK_Enrollments_Teachers_FkTeacherId",
                table: "Enrollments");

            migrationBuilder.AlterColumn<int>(
                name: "FkTeacherId",
                table: "Enrollments",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "FkStudentId",
                table: "Enrollments",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Enrollments_Students_FkStudentId",
                table: "Enrollments",
                column: "FkStudentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Enrollments_Teachers_FkTeacherId",
                table: "Enrollments",
                column: "FkTeacherId",
                principalTable: "Teachers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Enrollments_Students_FkStudentId",
                table: "Enrollments");

            migrationBuilder.DropForeignKey(
                name: "FK_Enrollments_Teachers_FkTeacherId",
                table: "Enrollments");

            migrationBuilder.AlterColumn<int>(
                name: "FkTeacherId",
                table: "Enrollments",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "FkStudentId",
                table: "Enrollments",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Enrollments_Students_FkStudentId",
                table: "Enrollments",
                column: "FkStudentId",
                principalTable: "Students",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Enrollments_Teachers_FkTeacherId",
                table: "Enrollments",
                column: "FkTeacherId",
                principalTable: "Teachers",
                principalColumn: "Id");
        }
    }
}
