using Microsoft.EntityFrameworkCore.Migrations;

namespace Wetherforecast.Migrations
{
    public partial class drop_subtitle_and_maintitile_and_add_title_colomn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Books",
                nullable: true);

            migrationBuilder.Sql(@"update Books set Title = MainTitle + ' : ' + SubTitle");

            migrationBuilder.DropColumn(
                name: "MainTitle",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "SubTitle",
                table: "Books");

            
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Title",
                table: "Books");

            migrationBuilder.AddColumn<string>(
                name: "MainTitle",
                table: "Books",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SubTitle",
                table: "Books",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
