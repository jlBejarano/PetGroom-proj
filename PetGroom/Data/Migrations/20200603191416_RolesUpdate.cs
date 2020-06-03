using Microsoft.EntityFrameworkCore.Migrations;

namespace PetGroom.Data.Migrations
{
    public partial class RolesUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4a9157e7-aa79-4475-8d0d-c7aec90b32bd");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f824977f-6c78-45a2-8d72-2cf43697c579");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a7ebe433-700d-4e7e-9a4c-1fd445b885e7", "83e8149d-bfcd-4600-99d1-7112722fdd5c", "Groomer", "GROOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3ea1fd32-d836-4394-b348-6c00cc28de04", "cb5e267a-c17e-41c1-b3e3-56de9eb9b27d", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1addb81c-640a-4f50-b96d-c1576f4ffd3b", "e4f43cf9-7bd6-4d61-9bf8-3e9484c71a08", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1addb81c-640a-4f50-b96d-c1576f4ffd3b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3ea1fd32-d836-4394-b348-6c00cc28de04");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a7ebe433-700d-4e7e-9a4c-1fd445b885e7");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4a9157e7-aa79-4475-8d0d-c7aec90b32bd", "266115b6-130a-4949-b0d0-31fa9982f405", "Groomer", "GROOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f824977f-6c78-45a2-8d72-2cf43697c579", "e34bf10f-cd4d-4772-bd7c-735dffcaa387", "Customer", "CUSTOMER" });
        }
    }
}
