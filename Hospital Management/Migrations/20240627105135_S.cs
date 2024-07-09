using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hospital_Management.Migrations
{
    /// <inheritdoc />
    public partial class S : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_DoctorDetails",
                table: "DoctorDetails");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BillDetails",
                table: "BillDetails");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "DoctorDetails");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "BillDetails");

            migrationBuilder.AlterColumn<string>(
                name: "PatientID",
                table: "DoctorDetails",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "PatientID",
                table: "BillDetails",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DoctorDetails",
                table: "DoctorDetails",
                column: "PatientID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BillDetails",
                table: "BillDetails",
                column: "PatientID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_DoctorDetails",
                table: "DoctorDetails");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BillDetails",
                table: "BillDetails");

            migrationBuilder.AlterColumn<string>(
                name: "PatientID",
                table: "DoctorDetails",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "DoctorDetails",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "PatientID",
                table: "BillDetails",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "BillDetails",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DoctorDetails",
                table: "DoctorDetails",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BillDetails",
                table: "BillDetails",
                column: "Id");
        }
    }
}
