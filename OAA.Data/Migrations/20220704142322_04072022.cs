using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SC.Data.Migrations
{
    public partial class _04072022 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DeliveryPayment",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedUserId = table.Column<long>(nullable: false),
                    ModifiedUserId = table.Column<long>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    IpAddress = table.Column<string>(nullable: true),
                    Status = table.Column<int>(nullable: false),
                    deliveryItemId = table.Column<long>(nullable: false),
                    amount = table.Column<double>(nullable: false),
                    type = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeliveryPayment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DeliveryPayment_ApplicationUser_CreatedUserId",
                        column: x => x.CreatedUserId,
                        principalTable: "ApplicationUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_DeliveryPayment_DeliveryItem_deliveryItemId",
                        column: x => x.deliveryItemId,
                        principalTable: "DeliveryItem",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DeliveryPayment_CreatedUserId",
                table: "DeliveryPayment",
                column: "CreatedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_DeliveryPayment_deliveryItemId",
                table: "DeliveryPayment",
                column: "deliveryItemId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DeliveryPayment");
        }
    }
}
