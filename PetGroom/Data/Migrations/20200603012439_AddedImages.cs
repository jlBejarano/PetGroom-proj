using Microsoft.EntityFrameworkCore.Migrations;

namespace PetGroom.Data.Migrations
{
    public partial class AddedImages : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9d90f83f-a4cf-4078-816e-88958fb3b6e8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e5b63522-22e1-4892-9ae1-77a943a52e4a");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "861dceb5-0a60-418b-bca8-911e35c9008c", "aadecfbb-8a9d-406d-9102-78f23f40938b", "Groomer", "GROOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e2e17e73-4b34-4d8f-ba3f-0ba1a957dc36", "94a7ed89-5786-48d7-8cb2-85eb72fa0fc5", "Customer", "CUSTOMER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "861dceb5-0a60-418b-bca8-911e35c9008c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e2e17e73-4b34-4d8f-ba3f-0ba1a957dc36");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e5b63522-22e1-4892-9ae1-77a943a52e4a", "fad9af21-3c68-4bde-9f3f-285f28806031", "Groomer", "GROOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9d90f83f-a4cf-4078-816e-88958fb3b6e8", "ae2807f9-008a-4c14-a872-acc74e9103b9", "Customer", "CUSTOMER" });
        }
    }
}
