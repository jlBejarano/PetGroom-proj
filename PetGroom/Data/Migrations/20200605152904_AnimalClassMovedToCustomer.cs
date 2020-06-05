using Microsoft.EntityFrameworkCore.Migrations;

namespace PetGroom.Data.Migrations
{
    public partial class AnimalClassMovedToCustomer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Animals");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "47631621-12de-4acc-b611-d6a0afb6cddf");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "80a43188-ec69-4ff2-a59d-7ce834e160cf");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fca88b4c-f29e-436d-bd4f-b853d5217d6f");

            migrationBuilder.AddColumn<int>(
                name: "Age",
                table: "Customers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "Allergies",
                table: "Customers",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "AnimalId",
                table: "Customers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Breed",
                table: "Customers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MedicalConditions",
                table: "Customers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PetName",
                table: "Customers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Temper",
                table: "Customers",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Weight",
                table: "Customers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "caf85867-7163-495c-8e2a-acc7347f5084", "05401987-895e-41a2-ad04-542715447f94", "Groomer", "GROOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d2d2b9a8-8026-41e9-86fd-839adba486a6", "b5b6e9e4-75d3-42d5-b2e0-c24e9114fb03", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a9d8d6e5-17cd-4caa-96b2-f7c2b639c8ef", "fc6978c0-5a82-4a6f-ac20-cd881576ae1b", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a9d8d6e5-17cd-4caa-96b2-f7c2b639c8ef");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "caf85867-7163-495c-8e2a-acc7347f5084");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d2d2b9a8-8026-41e9-86fd-839adba486a6");

            migrationBuilder.DropColumn(
                name: "Age",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "Allergies",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "AnimalId",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "Breed",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "MedicalConditions",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "PetName",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "Temper",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "Weight",
                table: "Customers");

            migrationBuilder.CreateTable(
                name: "Animals",
                columns: table => new
                {
                    AnimalId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Allergies = table.Column<bool>(type: "bit", nullable: false),
                    Breed = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MedicalConditions = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Temper = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Weight = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Animals", x => x.AnimalId);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "80a43188-ec69-4ff2-a59d-7ce834e160cf", "0b59ca16-ba07-4b99-81fb-dd811a0c3a1f", "Groomer", "GROOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "47631621-12de-4acc-b611-d6a0afb6cddf", "0fdd8ccf-f9a9-49ca-942f-2961e8288d46", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "fca88b4c-f29e-436d-bd4f-b853d5217d6f", "f4dba399-d159-4cb3-be97-459fb8b522fb", "Employee", "EMPLOYEE" });
        }
    }
}
