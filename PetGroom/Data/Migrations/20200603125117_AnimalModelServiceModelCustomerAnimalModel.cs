using Microsoft.EntityFrameworkCore.Migrations;

namespace PetGroom.Data.Migrations
{
    public partial class AnimalModelServiceModelCustomerAnimalModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6cd0d6a6-f2b3-44d7-a271-afdd2edb44f4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9500bc73-8c0c-4703-b6ae-4f8090bbd3c4");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c4cca012-a5a9-4531-847f-a10dd75b155d", "ef81eb42-e4ee-4bfa-922b-0121cab3a27b", "Groomer", "GROOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2df5a5e6-2b1b-4063-97c8-1e125e5c1dae", "9844e680-82fe-49a7-bd03-92c5b8912c57", "Customer", "CUSTOMER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2df5a5e6-2b1b-4063-97c8-1e125e5c1dae");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c4cca012-a5a9-4531-847f-a10dd75b155d");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9500bc73-8c0c-4703-b6ae-4f8090bbd3c4", "d8a0e059-4cf9-4874-ba85-2b9c56b8cfc9", "Groomer", "GROOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6cd0d6a6-f2b3-44d7-a271-afdd2edb44f4", "7d6b491d-2f9e-427e-a39c-93f4d3859215", "Customer", "CUSTOMER" });
        }
    }
}
