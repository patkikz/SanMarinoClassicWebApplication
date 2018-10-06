using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SanMarinoClassicWebsite.Migrations
{
    public partial class AddedMonhtlyDues : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Dues",
                columns: table => new
                {
                    MonthlyDueId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Amount = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dues", x => x.MonthlyDueId);
                });

            migrationBuilder.CreateTable(
                name: "MonthlyDues",
                columns: table => new
                {
                    MonthlyDueRecordId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    MonthlyDueId = table.Column<int>(nullable: false),
                    DateDue = table.Column<DateTime>(nullable: false),
                    DatePaid = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MonthlyDues", x => x.MonthlyDueRecordId);
                    table.ForeignKey(
                        name: "FK_MonthlyDues_Dues_MonthlyDueId",
                        column: x => x.MonthlyDueId,
                        principalTable: "Dues",
                        principalColumn: "MonthlyDueId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MonthlyDues_MonthlyDueId",
                table: "MonthlyDues",
                column: "MonthlyDueId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MonthlyDues");

            migrationBuilder.DropTable(
                name: "Dues");
        }
    }
}
