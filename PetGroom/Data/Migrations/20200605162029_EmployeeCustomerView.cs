using Microsoft.EntityFrameworkCore.Migrations;

namespace PetGroom.Data.Migrations
{
    public partial class EmployeeCustomerView : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5ca7e408-e9a7-45f6-b405-be6484b7d31b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "696b3947-4532-400a-86b8-d6102daa775c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bf6a455c-e077-4e58-952f-0f73d45881a2");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "aab9c9a2-0502-488f-a10f-2789eac189a0", "5f81033f-f3da-4833-9118-4105027ea67b", "Groomer", "GROOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "590aea44-6ccc-4906-b6f0-4aa9f12365ee", "de7e620c-e0c4-4d63-b9b8-9ee368303284", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "bce0364d-da6e-4f4c-a9b6-a10a8f10df20", "dff68345-9ad0-4c7d-937c-0192f236bedc", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "590aea44-6ccc-4906-b6f0-4aa9f12365ee");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "aab9c9a2-0502-488f-a10f-2789eac189a0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bce0364d-da6e-4f4c-a9b6-a10a8f10df20");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "bf6a455c-e077-4e58-952f-0f73d45881a2", "dbbee77c-935e-4751-85e0-17153d1ebc24", "Groomer", "GROOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "696b3947-4532-400a-86b8-d6102daa775c", "1b6b22bb-41bd-4e06-bceb-01a10a559f2f", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5ca7e408-e9a7-45f6-b405-be6484b7d31b", "40de0fbd-ce31-4aa0-a060-873d5988c471", "Employee", "EMPLOYEE" });
        }
    }
}
