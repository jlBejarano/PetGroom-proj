using Microsoft.EntityFrameworkCore.Migrations;

namespace PetGroom.Data.Migrations
{
    public partial class AddedGroomerModelController : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7aa78f56-5e29-4c1f-91f5-4b077504d2c8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f92f3f14-3765-45eb-9115-9c700ce8483f");

            migrationBuilder.CreateTable(
                name: "Groomer",
                columns: table => new
                {
                    GroomerId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GroomerName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Groomer", x => x.GroomerId);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "946591e3-060e-4ec1-ac0a-c52f5ba3c2c9", "b5cc3339-6856-40d3-8dc5-a34c0614333f", "Groomer", "GROOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "49128318-0f42-4220-af03-717b6a1bed0f", "c69043fe-7966-4e09-b743-f8688e256735", "Customer", "CUSTOMER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Groomer");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "49128318-0f42-4220-af03-717b6a1bed0f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "946591e3-060e-4ec1-ac0a-c52f5ba3c2c9");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f92f3f14-3765-45eb-9115-9c700ce8483f", "56162bb9-c107-4c94-9ef8-efe257ade8b1", "Groomer", "GROOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7aa78f56-5e29-4c1f-91f5-4b077504d2c8", "2f4839a5-9b17-4514-afcd-4f42d38c5b7b", "Customer", "CUSTOMER" });
        }
    }
}
