using Microsoft.EntityFrameworkCore.Migrations;

namespace MReportWebAPI.Migrations
{
    public partial class Create_Table_Doctor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Doctors",
                columns: table => new
                {
                    DoctorId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Doctor_Status = table.Column<string>(nullable: true),
                    Doctor_Contact = table.Column<string>(nullable: true),
                    Doctor_Address = table.Column<string>(nullable: true),
                    Doctor_FirstName = table.Column<string>(nullable: true),
                    Doctor_LastName = table.Column<string>(nullable: true),
                    Doctor_Gender = table.Column<string>(nullable: true),
                    Doctor_Password = table.Column<string>(nullable: true),
                    Doctor_Email = table.Column<string>(nullable: true),
                    Doctor_Specialization = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doctors", x => x.DoctorId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Doctors");
        }
    }
}
