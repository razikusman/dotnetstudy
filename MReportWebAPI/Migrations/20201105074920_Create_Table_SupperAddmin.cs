using Microsoft.EntityFrameworkCore.Migrations;

namespace MReportWebAPI.Migrations
{
    public partial class Create_Table_SupperAddmin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SuperAddmins",
                columns: table => new
                {
                    SuperAddminId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Active = table.Column<string>(nullable: true),
                    Contact = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SuperAddmins", x => x.SuperAddminId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SuperAddmins");
        }
    }
}
