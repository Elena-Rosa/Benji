using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BenjiApi.Migrations
{
    public partial class species : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "AnimalType",
                table: "Animals",
                newName: "Species");

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "AnimalId", "AdoptionStatus", "Age", "Breed", "Gender", "Name", "Species" },
                values: new object[,]
                {
                    { 1, null, 7, null, null, "Benji", "Dog" },
                    { 2, null, 10, null, null, "Pepper", "Dog" },
                    { 3, null, 2, null, null, "Billy", "Bird" },
                    { 4, null, 4, null, null, "Paco", "Dog" },
                    { 5, null, 22, null, null, "Mao", "Cat" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 5);

            migrationBuilder.RenameColumn(
                name: "Species",
                table: "Animals",
                newName: "AnimalType");
        }
    }
}
