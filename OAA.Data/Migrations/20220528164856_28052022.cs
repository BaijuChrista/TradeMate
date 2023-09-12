using Microsoft.EntityFrameworkCore.Migrations;

namespace SC.Data.Migrations
{
    public partial class _28052022 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DeliveryItem_ApplicationUser_userAssignedId",
                table: "DeliveryItem");

            migrationBuilder.AlterColumn<long>(
                name: "userAssignedId",
                table: "DeliveryItem",
                nullable: true,
                oldClrType: typeof(long));

            migrationBuilder.AddForeignKey(
                name: "FK_DeliveryItem_ApplicationUser_userAssignedId",
                table: "DeliveryItem",
                column: "userAssignedId",
                principalTable: "ApplicationUser",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DeliveryItem_ApplicationUser_userAssignedId",
                table: "DeliveryItem");

            migrationBuilder.AlterColumn<long>(
                name: "userAssignedId",
                table: "DeliveryItem",
                nullable: false,
                oldClrType: typeof(long),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_DeliveryItem_ApplicationUser_userAssignedId",
                table: "DeliveryItem",
                column: "userAssignedId",
                principalTable: "ApplicationUser",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
