using Microsoft.EntityFrameworkCore.Migrations;

namespace PetGroom.Data.Migrations
{
    public partial class Details : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
