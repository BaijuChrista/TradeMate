using Microsoft.EntityFrameworkCore.Migrations;

namespace SC.Data.Migrations
{
    public partial class _202APr : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "comments",
                table: "PurchaseDetail",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "comments",
                table: "PurchaseDetail");
        }
    }
}
