using Microsoft.EntityFrameworkCore.Migrations;

namespace PetGroom.Data.Migrations
{
    public partial class AnimalModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2df5a5e6-2b1b-4063-97c8-1e125e5c1dae");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c4cca012-a5a9-4531-847f-a10dd75b155d");

            migrationBuilder.CreateTable(
                name: "Animals",
                columns: table => new
                {
                    AnimalId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Breed = table.Column<string>(nullable: true),
                    Weight = table.Column<int>(nullable: false),
                    Age = table.Column<int>(nullable: false),
                    Temper = table.Column<string>(nullable: true),
                    MedicalConditions = table.Column<string>(nullable: true),
                    Allergies = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Animals", x => x.AnimalId);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "235d7e49-5b63-4546-9ce1-7d6269883b2e", "8ef21914-e8ce-4dd4-b918-0010f8fe2be8", "Groomer", "GROOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4aa43e57-a4e2-47de-8e07-5372c4c828ac", "325effa9-5cc1-4e3c-8e87-957ae5f1cc02", "Customer", "CUSTOMER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Animals");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "235d7e49-5b63-4546-9ce1-7d6269883b2e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4aa43e57-a4e2-47de-8e07-5372c4c828ac");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c4cca012-a5a9-4531-847f-a10dd75b155d", "ef81eb42-e4ee-4bfa-922b-0121cab3a27b", "Groomer", "GROOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2df5a5e6-2b1b-4063-97c8-1e125e5c1dae", "9844e680-82fe-49a7-bd03-92c5b8912c57", "Customer", "CUSTOMER" });
        }
    }
}
