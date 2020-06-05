using Microsoft.EntityFrameworkCore.Migrations;

namespace PetGroom.Data.Migrations
{
    public partial class Views : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { "72d6b783-03cb-4875-9809-994d2a3f8662", "767266f3-7a23-4d82-8121-351161244d2d", "Groomer", "GROOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5ba1d13a-fb28-4695-8755-05b4e6a6ef00", "adbbd202-bf3d-4c27-a173-c4412b881682", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "40137a39-b067-4051-a90d-82c15070d359", "f806d5e1-b291-4b4b-815c-e49411f19dca", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "40137a39-b067-4051-a90d-82c15070d359");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5ba1d13a-fb28-4695-8755-05b4e6a6ef00");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "72d6b783-03cb-4875-9809-994d2a3f8662");

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
    }
}
