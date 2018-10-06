using Microsoft.EntityFrameworkCore.Migrations;

namespace SanMarinoClassicWebsite.Migrations
{
    public partial class ChangeEquipmentModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Equipments_EquipmentTypes_EquipmentTypeId",
                table: "Equipments");

            migrationBuilder.DropColumn(
                name: "TypeId",
                table: "Equipments");

            migrationBuilder.AlterColumn<int>(
                name: "EquipmentTypeId",
                table: "Equipments",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Equipments_EquipmentTypes_EquipmentTypeId",
                table: "Equipments",
                column: "EquipmentTypeId",
                principalTable: "EquipmentTypes",
                principalColumn: "EquipmentTypeId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Equipments_EquipmentTypes_EquipmentTypeId",
                table: "Equipments");

            migrationBuilder.AlterColumn<int>(
                name: "EquipmentTypeId",
                table: "Equipments",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "TypeId",
                table: "Equipments",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Equipments_EquipmentTypes_EquipmentTypeId",
                table: "Equipments",
                column: "EquipmentTypeId",
                principalTable: "EquipmentTypes",
                principalColumn: "EquipmentTypeId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
