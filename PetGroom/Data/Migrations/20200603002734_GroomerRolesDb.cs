using Microsoft.EntityFrameworkCore.Migrations;

namespace PetGroom.Data.Migrations
{
    public partial class GroomerRolesDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Groomer",
                table: "Groomer");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "49128318-0f42-4220-af03-717b6a1bed0f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "946591e3-060e-4ec1-ac0a-c52f5ba3c2c9");

            migrationBuilder.RenameTable(
                name: "Groomer",
                newName: "Groomers");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Groomers",
                table: "Groomers",
                column: "GroomerId");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e5b63522-22e1-4892-9ae1-77a943a52e4a", "fad9af21-3c68-4bde-9f3f-285f28806031", "Groomer", "GROOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9d90f83f-a4cf-4078-816e-88958fb3b6e8", "ae2807f9-008a-4c14-a872-acc74e9103b9", "Customer", "CUSTOMER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Groomers",
                table: "Groomers");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9d90f83f-a4cf-4078-816e-88958fb3b6e8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e5b63522-22e1-4892-9ae1-77a943a52e4a");

            migrationBuilder.RenameTable(
                name: "Groomers",
                newName: "Groomer");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Groomer",
                table: "Groomer",
                column: "GroomerId");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "946591e3-060e-4ec1-ac0a-c52f5ba3c2c9", "b5cc3339-6856-40d3-8dc5-a34c0614333f", "Groomer", "GROOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "49128318-0f42-4220-af03-717b6a1bed0f", "c69043fe-7966-4e09-b743-f8688e256735", "Customer", "CUSTOMER" });
        }
    }
}
