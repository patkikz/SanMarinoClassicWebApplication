using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SanMarinoClassicWebsite.Migrations
{
    public partial class UpdateAdminAccount : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                columns: new[] { "ConcurrencyStamp", "Name" },
                values: new object[] { "20c67895-d1ae-4617-8d4f-5f1d6567a1d7", "Administrator" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                columns: new[] { "Birthdate", "City", "ConcurrencyStamp", "Country", "FirstName", "LastName", "PasswordHash" },
                values: new object[] { new DateTime(2018, 10, 14, 13, 58, 33, 276, DateTimeKind.Local), "Manila", "f31550c5-4c8b-41a0-b6ac-c84851e3b668", "Philippines", "Administrator", "Admin", "AQAAAAEAACcQAAAAEFNQqffZ6zqf4BNjjxk6zHlchs+bXyVzYuFwHP3+yHlp5hRsGXa9rsjQq0ZrF4bEOQ==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                columns: new[] { "ConcurrencyStamp", "Name" },
                values: new object[] { "654f2504-af6d-4d14-92db-df718bf0c9d0", "administrator" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                columns: new[] { "Birthdate", "City", "ConcurrencyStamp", "Country", "FirstName", "LastName", "PasswordHash" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "5e900fdd-78c1-4ec1-aa3b-2643392dfe3f", null, null, null, "AQAAAAEAACcQAAAAEChCEcnp/cMQK8DaN5C6xXf1QcM9tM/cwUkDRDhcxCY+xxAhDJLJiC+bX3HBXK7piA==" });
        }
    }
}
