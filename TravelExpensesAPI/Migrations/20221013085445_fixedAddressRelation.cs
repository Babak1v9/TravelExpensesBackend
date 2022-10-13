using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TravelExpensesAPI.Migrations
{
    public partial class fixedAddressRelation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Applications_EndAddressId",
                table: "Applications");

            migrationBuilder.DropIndex(
                name: "IX_Applications_StartAddressId",
                table: "Applications");

            migrationBuilder.CreateIndex(
                name: "IX_Applications_EndAddressId",
                table: "Applications",
                column: "EndAddressId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Applications_StartAddressId",
                table: "Applications",
                column: "StartAddressId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Applications_EndAddressId",
                table: "Applications");

            migrationBuilder.DropIndex(
                name: "IX_Applications_StartAddressId",
                table: "Applications");

            migrationBuilder.CreateIndex(
                name: "IX_Applications_EndAddressId",
                table: "Applications",
                column: "EndAddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Applications_StartAddressId",
                table: "Applications",
                column: "StartAddressId");
        }
    }
}
