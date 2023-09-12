using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SC.Data.Migrations
{
    public partial class _01062022 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Deliverycategory",
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
                    Name = table.Column<string>(nullable: true),
                    DeliveryId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Deliverycategory", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Deliverycategory_ApplicationUser_CreatedUserId",
                        column: x => x.CreatedUserId,
                        principalTable: "ApplicationUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Deliverycategory_Deliverycategory_DeliveryId",
                        column: x => x.DeliveryId,
                        principalTable: "Deliverycategory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Deliverycategory_CreatedUserId",
                table: "Deliverycategory",
                column: "CreatedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Deliverycategory_DeliveryId",
                table: "Deliverycategory",
                column: "DeliveryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Deliverycategory");
        }
    }
}
