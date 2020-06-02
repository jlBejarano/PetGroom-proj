using Microsoft.EntityFrameworkCore.Migrations;

namespace PetGroom.Data.Migrations
{
    public partial class AdminRegChangedToGroomer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9702ea17-1404-4e5f-851d-631712759280");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b137c94f-acb8-4e99-ae22-b2719d9f33be");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "fa908405-73ef-4fcf-b994-90a3931c278c", "9d2a4d12-496f-43dc-9244-52d7d95f605e", "Groomer", "GROOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7dda9c92-c864-46a7-b867-ff31e275ad8d", "1441310b-69f7-4b3f-a797-1effd4e4dec7", "Customer", "CUSTOMER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7dda9c92-c864-46a7-b867-ff31e275ad8d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fa908405-73ef-4fcf-b994-90a3931c278c");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9702ea17-1404-4e5f-851d-631712759280", "fd370abb-f08a-4dc2-8778-afa52b37e3f5", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b137c94f-acb8-4e99-ae22-b2719d9f33be", "2f51d54c-84a6-4cec-b0e0-15093608026f", "Customer", "CUSTOMER" });
        }
    }
}
