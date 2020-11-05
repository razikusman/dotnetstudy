using Microsoft.EntityFrameworkCore.Migrations;

namespace MReportWebAPI.Migrations
{
    public partial class Create_Table_patients : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Patients",
                columns: table => new
                {
                    PatientId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GuardName = table.Column<string>(nullable: true),
                    GuardContact = table.Column<int>(nullable: false),
                    GuardType = table.Column<string>(nullable: true),
                    PatientContact = table.Column<int>(nullable: false),
                    Password = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    arae = table.Column<string>(nullable: true),
                    Gender = table.Column<string>(nullable: true),
                    Status = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    PatientAddress = table.Column<string>(nullable: true),
                    GuardEmail = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patients", x => x.PatientId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Patients");
        }
    }
}
