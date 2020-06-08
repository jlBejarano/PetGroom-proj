using Microsoft.EntityFrameworkCore.Migrations;

namespace PetGroom.Data.Migrations
{
    public partial class ImageModelFK : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "142b7f79-002c-4bcf-acdf-a2b52268e9df");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7321f223-3c6d-4a3c-a75f-55c5f8baa0b6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bb846536-b8b7-459d-99dd-961779803e66");

            migrationBuilder.AddColumn<int>(
                name: "ImageId",
                table: "Groomers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ImagePath",
                table: "Groomers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Groomers",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a6a9b584-c71c-4700-a5de-df04a1857503", "80fbf7cb-3467-457e-b9c3-9ac4b3f5122c", "Groomer", "GROOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "aea8411a-20cc-4372-b2b0-154c3e0c03ec", "ab689cde-3622-4a8d-8dad-0394dbb9b57c", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f81a146a-7ed7-4009-8bc6-080edb1e0e18", "6cfe9be0-9221-46c2-9c50-836cf8627aef", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a6a9b584-c71c-4700-a5de-df04a1857503");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "aea8411a-20cc-4372-b2b0-154c3e0c03ec");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f81a146a-7ed7-4009-8bc6-080edb1e0e18");

            migrationBuilder.DropColumn(
                name: "ImageId",
                table: "Groomers");

            migrationBuilder.DropColumn(
                name: "ImagePath",
                table: "Groomers");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "Groomers");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "bb846536-b8b7-459d-99dd-961779803e66", "b4d54b16-0488-457c-9b9e-b5d1f267e151", "Groomer", "GROOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7321f223-3c6d-4a3c-a75f-55c5f8baa0b6", "ad633179-c7b2-4e4c-b8ad-9adcdc8c3d1c", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "142b7f79-002c-4bcf-acdf-a2b52268e9df", "2f90f0a3-e270-4ce6-82b7-8ebe86aa8fae", "Employee", "EMPLOYEE" });
        }
    }
}
