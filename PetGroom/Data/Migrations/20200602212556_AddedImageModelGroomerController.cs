using Microsoft.EntityFrameworkCore.Migrations;

namespace PetGroom.Data.Migrations
{
    public partial class AddedImageModelGroomerController : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7dda9c92-c864-46a7-b867-ff31e275ad8d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fa908405-73ef-4fcf-b994-90a3931c278c");

            migrationBuilder.CreateTable(
                name: "Images",
                columns: table => new
                {
                    ImageId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true),
                    ImagePath = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.ImageId);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f92f3f14-3765-45eb-9115-9c700ce8483f", "56162bb9-c107-4c94-9ef8-efe257ade8b1", "Groomer", "GROOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7aa78f56-5e29-4c1f-91f5-4b077504d2c8", "2f4839a5-9b17-4514-afcd-4f42d38c5b7b", "Customer", "CUSTOMER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Images");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7aa78f56-5e29-4c1f-91f5-4b077504d2c8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f92f3f14-3765-45eb-9115-9c700ce8483f");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "fa908405-73ef-4fcf-b994-90a3931c278c", "9d2a4d12-496f-43dc-9244-52d7d95f605e", "Groomer", "GROOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7dda9c92-c864-46a7-b867-ff31e275ad8d", "1441310b-69f7-4b3f-a797-1effd4e4dec7", "Customer", "CUSTOMER" });
        }
    }
}
