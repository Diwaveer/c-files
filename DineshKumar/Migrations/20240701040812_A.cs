using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DineshKumar.Migrations
{
    /// <inheritdoc />
    public partial class A : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Selection",
                table: "StaffDetails",
                newName: "Qualification");

            migrationBuilder.RenameColumn(
                name: "Qualifiaction",
                table: "StaffDetails",
                newName: "Masterdepartment");

            migrationBuilder.RenameColumn(
                name: "DepartmentNmae",
                table: "StaffDetails",
                newName: "DepartmentName");

            migrationBuilder.AlterColumn<int>(
                name: "StaffID",
                table: "StaffDetails",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Qualification",
                table: "StaffDetails",
                newName: "Selection");

            migrationBuilder.RenameColumn(
                name: "Masterdepartment",
                table: "StaffDetails",
                newName: "Qualifiaction");

            migrationBuilder.RenameColumn(
                name: "DepartmentName",
                table: "StaffDetails",
                newName: "DepartmentNmae");

            migrationBuilder.AlterColumn<int>(
                name: "StaffID",
                table: "StaffDetails",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");
        }
    }
}
