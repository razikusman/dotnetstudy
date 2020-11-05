using Microsoft.EntityFrameworkCore.Migrations;

namespace MReportWebAPI.Migrations
{
    public partial class Create_Table_Admin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Addmins",
                columns: table => new
                {
                    AddminId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HospitalArea = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Contact = table.Column<int>(nullable: false),
                    Password = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    OTP = table.Column<string>(nullable: true),
                    OwnerNIC = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addmins", x => x.AddminId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Addmins");
        }
    }
}
