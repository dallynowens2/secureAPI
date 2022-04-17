using Microsoft.EntityFrameworkCore.Migrations;

namespace secureAPI.Migrations
{
    public partial class Images : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "profile_picture_name",
                table: "user_model_info",
                type: "text",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "profile_picture_name",
                table: "user_model_info");
        }
    }
}
