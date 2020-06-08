using Microsoft.EntityFrameworkCore.Migrations;

namespace PetGroom.Data.Migrations
{
    public partial class ImageModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { "2c225785-7a32-47c5-9a5d-65303b161754", "2ce91a87-7197-4f70-9074-02ea3d90ed37", "Groomer", "GROOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d487c8ae-7a27-4b3f-b030-815bb0e9b6f7", "50dac67c-ab0f-402d-bc7a-227236ab69ed", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e4857eff-5e17-4cf0-b253-fe6ea7f7bce0", "5e5b6db9-4875-4e66-b978-e1bee7135e89", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c225785-7a32-47c5-9a5d-65303b161754");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d487c8ae-7a27-4b3f-b030-815bb0e9b6f7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e4857eff-5e17-4cf0-b253-fe6ea7f7bce0");

            migrationBuilder.AddColumn<int>(
                name: "ImageId",
                table: "Groomers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ImagePath",
                table: "Groomers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Groomers",
                type: "nvarchar(max)",
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
    }
}
