using Microsoft.EntityFrameworkCore.Migrations;

namespace SC.Data.Migrations
{
    public partial class _060920223 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DropOf_contact",
                table: "DeliveryItem",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DropOf_email",
                table: "DeliveryItem",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PickUp_contact",
                table: "DeliveryItem",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PickUp_email",
                table: "DeliveryItem",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "subcategoryId",
                table: "DeliveryItem",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_DeliveryItem_subcategoryId",
                table: "DeliveryItem",
                column: "subcategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_DeliveryItem_Deliverycategory_subcategoryId",
                table: "DeliveryItem",
                column: "subcategoryId",
                principalTable: "Deliverycategory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DeliveryItem_Deliverycategory_subcategoryId",
                table: "DeliveryItem");

            migrationBuilder.DropIndex(
                name: "IX_DeliveryItem_subcategoryId",
                table: "DeliveryItem");

            migrationBuilder.DropColumn(
                name: "DropOf_contact",
                table: "DeliveryItem");

            migrationBuilder.DropColumn(
                name: "DropOf_email",
                table: "DeliveryItem");

            migrationBuilder.DropColumn(
                name: "PickUp_contact",
                table: "DeliveryItem");

            migrationBuilder.DropColumn(
                name: "PickUp_email",
                table: "DeliveryItem");

            migrationBuilder.DropColumn(
                name: "subcategoryId",
                table: "DeliveryItem");
        }
    }
}
