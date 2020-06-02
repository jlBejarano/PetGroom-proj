using Microsoft.EntityFrameworkCore.Migrations;

namespace PetGroom.Data.Migrations
{
    public partial class CustomerModelCustomerController : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "daf6c3b5-a215-49fd-a1de-61475869c830");

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CustomerId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerName = table.Column<string>(nullable: true),
                    StreetAddress = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    ZipCode = table.Column<int>(nullable: false),
                    CustomerPhoneNumber = table.Column<double>(nullable: false),
                    IdentityUserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CustomerId);
                    table.ForeignKey(
                        name: "FK_Customers_AspNetUsers_IdentityUserId",
                        column: x => x.IdentityUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9702ea17-1404-4e5f-851d-631712759280", "fd370abb-f08a-4dc2-8778-afa52b37e3f5", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b137c94f-acb8-4e99-ae22-b2719d9f33be", "2f51d54c-84a6-4cec-b0e0-15093608026f", "Customer", "CUSTOMER" });

            migrationBuilder.CreateIndex(
                name: "IX_Customers_IdentityUserId",
                table: "Customers",
                column: "IdentityUserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customers");

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
                values: new object[] { "daf6c3b5-a215-49fd-a1de-61475869c830", "e8f96614-7797-4951-829d-3e6ca377c8c2", "Admin", "ADMIN" });
        }
    }
}
