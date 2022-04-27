using Microsoft.EntityFrameworkCore.Migrations;

namespace AuditServices.Migrations
{
    public partial class AddedOrderAndImageToHomeTrendingSection : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "HomePageTrendingSections",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Order",
                table: "HomePageTrendingSectionParts",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "HomePageTrendingSections");

            migrationBuilder.DropColumn(
                name: "Order",
                table: "HomePageTrendingSectionParts");
        }
    }
}
