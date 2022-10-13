using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TravelExpensesAPI.Migrations
{
    public partial class newDBSets : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Applications_TravelReason_TravelReasonId",
                table: "Applications");

            migrationBuilder.DropForeignKey(
                name: "FK_Approval_Applications_ApplicationId",
                table: "Approval");

            migrationBuilder.DropForeignKey(
                name: "FK_Approval_Users_UserId",
                table: "Approval");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TravelReason",
                table: "TravelReason");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Approval",
                table: "Approval");

            migrationBuilder.RenameTable(
                name: "TravelReason",
                newName: "TravelReasons");

            migrationBuilder.RenameTable(
                name: "Approval",
                newName: "Approvals");

            migrationBuilder.RenameIndex(
                name: "IX_Approval_UserId",
                table: "Approvals",
                newName: "IX_Approvals_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Approval_ApplicationId",
                table: "Approvals",
                newName: "IX_Approvals_ApplicationId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TravelReasons",
                table: "TravelReasons",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Approvals",
                table: "Approvals",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "AdditionalCost",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Amount = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdditionalCost", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Documents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    File = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    Filename = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FileType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AdditionalCostId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Documents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Documents_AdditionalCost_AdditionalCostId",
                        column: x => x.AdditionalCostId,
                        principalTable: "AdditionalCost",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Documents_AdditionalCostId",
                table: "Documents",
                column: "AdditionalCostId");

            migrationBuilder.AddForeignKey(
                name: "FK_Applications_TravelReasons_TravelReasonId",
                table: "Applications",
                column: "TravelReasonId",
                principalTable: "TravelReasons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Approvals_Applications_ApplicationId",
                table: "Approvals",
                column: "ApplicationId",
                principalTable: "Applications",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Approvals_Users_UserId",
                table: "Approvals",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Applications_TravelReasons_TravelReasonId",
                table: "Applications");

            migrationBuilder.DropForeignKey(
                name: "FK_Approvals_Applications_ApplicationId",
                table: "Approvals");

            migrationBuilder.DropForeignKey(
                name: "FK_Approvals_Users_UserId",
                table: "Approvals");

            migrationBuilder.DropTable(
                name: "Documents");

            migrationBuilder.DropTable(
                name: "AdditionalCost");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TravelReasons",
                table: "TravelReasons");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Approvals",
                table: "Approvals");

            migrationBuilder.RenameTable(
                name: "TravelReasons",
                newName: "TravelReason");

            migrationBuilder.RenameTable(
                name: "Approvals",
                newName: "Approval");

            migrationBuilder.RenameIndex(
                name: "IX_Approvals_UserId",
                table: "Approval",
                newName: "IX_Approval_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Approvals_ApplicationId",
                table: "Approval",
                newName: "IX_Approval_ApplicationId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TravelReason",
                table: "TravelReason",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Approval",
                table: "Approval",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Applications_TravelReason_TravelReasonId",
                table: "Applications",
                column: "TravelReasonId",
                principalTable: "TravelReason",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Approval_Applications_ApplicationId",
                table: "Approval",
                column: "ApplicationId",
                principalTable: "Applications",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Approval_Users_UserId",
                table: "Approval",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
