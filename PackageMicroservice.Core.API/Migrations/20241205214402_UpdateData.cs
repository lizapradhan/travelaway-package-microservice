using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PackageMicroservice.Core.API.Migrations
{
    /// <inheritdoc />
    public partial class UpdateData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Hotels",
                columns: new[] { "HotelId", "CityId", "Name", "Type" },
                values: new object[,]
                {
                    { 5, 2, "Hotel Goa Inn", "5-star" },
                    { 6, 2, "Goa Budget Stay", "2-star" },
                    { 7, 2, "Snowy Peaks ResortGoa", "4-star" },
                    { 8, 2, "Mountain View Lodge Goa", "3-star" }
                });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "RoomId", "HotelId", "PricePerNight", "RoomType" },
                values: new object[,]
                {
                    { 17, 5, 2000.00m, "Single" },
                    { 18, 5, 3000.00m, "Double" },
                    { 19, 5, 4000.00m, "Deluxe" },
                    { 20, 5, 5000.00m, "Suite" },
                    { 21, 6, 800.00m, "Single" },
                    { 22, 6, 1200.00m, "Double" },
                    { 23, 6, 1500.00m, "Deluxe" },
                    { 24, 6, 2000.00m, "Suite" },
                    { 25, 7, 1200.00m, "Single" },
                    { 26, 7, 1800.00m, "Double" },
                    { 27, 7, 2200.00m, "Deluxe" },
                    { 28, 7, 2500.00m, "Suite" },
                    { 29, 8, 1500.00m, "Single" },
                    { 30, 8, 2200.00m, "Double" },
                    { 31, 8, 2800.00m, "Deluxe" },
                    { 32, 8, 3500.00m, "Suite" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "HotelId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "HotelId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "HotelId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "HotelId",
                keyValue: 8);
        }
    }
}
