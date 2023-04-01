using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GranHotelApi.Migrations
{
    public partial class SeedHabitaciones : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            for (int i = 1; i <= 10; i++)
            {
                migrationBuilder.InsertData(
                    table: "Habitaciones",
                    column: "Ocupada",
                    value: false
                );
            }
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Habitaciones WHERE Id <= 10;");
        }
    }
}
