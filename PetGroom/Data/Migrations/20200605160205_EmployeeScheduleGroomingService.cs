using Microsoft.EntityFrameworkCore.Migrations;

namespace PetGroom.Data.Migrations
{
    public partial class EmployeeScheduleGroomingService : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                name: "Price",
                table: "GroomServices");

            migrationBuilder.AddColumn<bool>(
                name: "HairCut",
                table: "GroomServices",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "NailTrim",
                table: "GroomServices",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "PetBath",
                table: "GroomServices",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "PetMassage",
                table: "GroomServices",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "PickUpDropOff",
                table: "Customers",
                nullable: false,
                defaultValue: false);

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "HairCut",
                table: "GroomServices");

            migrationBuilder.DropColumn(
                name: "NailTrim",
                table: "GroomServices");

            migrationBuilder.DropColumn(
                name: "PetBath",
                table: "GroomServices");

            migrationBuilder.DropColumn(
                name: "PetMassage",
                table: "GroomServices");

            migrationBuilder.DropColumn(
                name: "PickUpDropOff",
                table: "Customers");

            migrationBuilder.AddColumn<int>(
                name: "Price",
                table: "GroomServices",
                type: "int",
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
    }
}
