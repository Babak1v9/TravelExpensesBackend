using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TravelExpensesAPI.Migrations
{
    public partial class newModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TravelReasonId",
                table: "Applications",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "TravelReason",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Internal = table.Column<bool>(type: "bit", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    DayRate = table.Column<double>(type: "float", nullable: false),
                    KilometerAllowance = table.Column<double>(type: "float", nullable: false),
                    BreakfastAllowance = table.Column<double>(type: "float", nullable: false),
                    OtherMealAllowance = table.Column<double>(type: "float", nullable: false),
                    HoursArrivalDay = table.Column<double>(type: "float", nullable: false),
                    HoursDepartureDay = table.Column<double>(type: "float", nullable: false),
                    IsDirty = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TravelReason", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Applications_TravelReasonId",
                table: "Applications",
                column: "TravelReasonId");

            migrationBuilder.AddForeignKey(
                name: "FK_Applications_TravelReason_TravelReasonId",
                table: "Applications",
                column: "TravelReasonId",
                principalTable: "TravelReason",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Applications_TravelReason_TravelReasonId",
                table: "Applications");

            migrationBuilder.DropTable(
                name: "TravelReason");

            migrationBuilder.DropIndex(
                name: "IX_Applications_TravelReasonId",
                table: "Applications");

            migrationBuilder.DropColumn(
                name: "TravelReasonId",
                table: "Applications");
        }
    }
}
