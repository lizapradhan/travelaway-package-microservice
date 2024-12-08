using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PackageMicroservice.Core.API.Migrations
{
    /// <inheritdoc />
    public partial class addedOtherTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    CityId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.CityId);
                });

            migrationBuilder.CreateTable(
                name: "Hotels",
                columns: table => new
                {
                    HotelId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CityId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hotels", x => x.HotelId);
                    table.ForeignKey(
                        name: "FK_Hotels_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "CityId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Rooms",
                columns: table => new
                {
                    RoomId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoomType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PricePerNight = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    HotelId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rooms", x => x.RoomId);
                    table.ForeignKey(
                        name: "FK_Rooms_Hotels_HotelId",
                        column: x => x.HotelId,
                        principalTable: "Hotels",
                        principalColumn: "HotelId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "CityId", "Name" },
                values: new object[,]
                {
                    { 1, "Manali" },
                    { 2, "Goa" },
                    { 3, "Varanasi" },
                    { 4, "Rajasthan" },
                    { 5, "Kaziranga" },
                    { 6, "Swiss Alps" },
                    { 7, "Maldives" },
                    { 8, "Jerusalem" },
                    { 9, "Japanese Countryside" },
                    { 10, "Amazon Rainforest" }
                });

            migrationBuilder.UpdateData(
                table: "Packages",
                keyColumn: "PackageId",
                keyValue: 6,
                column: "IsInternationalPackage",
                value: true);

            migrationBuilder.UpdateData(
                table: "Packages",
                keyColumn: "PackageId",
                keyValue: 7,
                column: "IsInternationalPackage",
                value: true);

            migrationBuilder.UpdateData(
                table: "Packages",
                keyColumn: "PackageId",
                keyValue: 8,
                column: "IsInternationalPackage",
                value: true);

            migrationBuilder.UpdateData(
                table: "Packages",
                keyColumn: "PackageId",
                keyValue: 9,
                column: "IsInternationalPackage",
                value: true);

            migrationBuilder.UpdateData(
                table: "Packages",
                keyColumn: "PackageId",
                keyValue: 10,
                column: "IsInternationalPackage",
                value: true);

            migrationBuilder.UpdateData(
                table: "SubPackages",
                keyColumn: "SubPackageId",
                keyValue: 1,
                column: "IsAccomodationAvailable",
                value: true);

            migrationBuilder.UpdateData(
                table: "SubPackages",
                keyColumn: "SubPackageId",
                keyValue: 2,
                column: "IsAccomodationAvailable",
                value: true);

            migrationBuilder.UpdateData(
                table: "SubPackages",
                keyColumn: "SubPackageId",
                keyValue: 3,
                column: "IsAccomodationAvailable",
                value: true);

            migrationBuilder.UpdateData(
                table: "SubPackages",
                keyColumn: "SubPackageId",
                keyValue: 4,
                column: "IsAccomodationAvailable",
                value: true);

            migrationBuilder.UpdateData(
                table: "SubPackages",
                keyColumn: "SubPackageId",
                keyValue: 5,
                column: "IsAccomodationAvailable",
                value: true);

            migrationBuilder.UpdateData(
                table: "SubPackages",
                keyColumn: "SubPackageId",
                keyValue: 6,
                column: "IsAccomodationAvailable",
                value: true);

            migrationBuilder.UpdateData(
                table: "SubPackages",
                keyColumn: "SubPackageId",
                keyValue: 7,
                column: "IsAccomodationAvailable",
                value: true);

            migrationBuilder.UpdateData(
                table: "SubPackages",
                keyColumn: "SubPackageId",
                keyValue: 8,
                column: "IsAccomodationAvailable",
                value: true);

            migrationBuilder.UpdateData(
                table: "SubPackages",
                keyColumn: "SubPackageId",
                keyValue: 9,
                column: "IsAccomodationAvailable",
                value: true);

            migrationBuilder.UpdateData(
                table: "SubPackages",
                keyColumn: "SubPackageId",
                keyValue: 10,
                column: "IsAccomodationAvailable",
                value: true);

            migrationBuilder.UpdateData(
                table: "SubPackages",
                keyColumn: "SubPackageId",
                keyValue: 11,
                column: "IsAccomodationAvailable",
                value: true);

            migrationBuilder.UpdateData(
                table: "SubPackages",
                keyColumn: "SubPackageId",
                keyValue: 12,
                column: "IsAccomodationAvailable",
                value: true);

            migrationBuilder.UpdateData(
                table: "SubPackages",
                keyColumn: "SubPackageId",
                keyValue: 13,
                column: "IsAccomodationAvailable",
                value: true);

            migrationBuilder.UpdateData(
                table: "SubPackages",
                keyColumn: "SubPackageId",
                keyValue: 14,
                column: "IsAccomodationAvailable",
                value: true);

            migrationBuilder.UpdateData(
                table: "SubPackages",
                keyColumn: "SubPackageId",
                keyValue: 15,
                column: "IsAccomodationAvailable",
                value: true);

            migrationBuilder.UpdateData(
                table: "SubPackages",
                keyColumn: "SubPackageId",
                keyValue: 16,
                column: "IsAccomodationAvailable",
                value: true);

            migrationBuilder.UpdateData(
                table: "SubPackages",
                keyColumn: "SubPackageId",
                keyValue: 17,
                column: "IsAccomodationAvailable",
                value: true);

            migrationBuilder.UpdateData(
                table: "SubPackages",
                keyColumn: "SubPackageId",
                keyValue: 18,
                column: "IsAccomodationAvailable",
                value: true);

            migrationBuilder.InsertData(
                table: "Hotels",
                columns: new[] { "HotelId", "CityId", "Name", "Type" },
                values: new object[,]
                {
                    { 1, 1, "Hotel Manali Inn", "5-star" },
                    { 2, 1, "Manali Budget Stay", "2-star" },
                    { 3, 1, "Snowy Peaks Resort", "4-star" },
                    { 4, 1, "Mountain View Lodge", "3-star" }
                });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "RoomId", "HotelId", "PricePerNight", "RoomType" },
                values: new object[,]
                {
                    { 1, 1, 2000.00m, "Single" },
                    { 2, 1, 3000.00m, "Double" },
                    { 3, 1, 4000.00m, "Deluxe" },
                    { 4, 1, 5000.00m, "Suite" },
                    { 5, 2, 800.00m, "Single" },
                    { 6, 2, 1200.00m, "Double" },
                    { 7, 2, 1500.00m, "Deluxe" },
                    { 8, 2, 2000.00m, "Suite" },
                    { 9, 3, 1200.00m, "Single" },
                    { 10, 3, 1800.00m, "Double" },
                    { 11, 3, 2200.00m, "Deluxe" },
                    { 12, 3, 2500.00m, "Suite" },
                    { 13, 4, 1500.00m, "Single" },
                    { 14, 4, 2200.00m, "Double" },
                    { 15, 4, 2800.00m, "Deluxe" },
                    { 16, 4, 3500.00m, "Suite" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Hotels_CityId",
                table: "Hotels",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_HotelId",
                table: "Rooms",
                column: "HotelId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Rooms");

            migrationBuilder.DropTable(
                name: "Hotels");

            migrationBuilder.DropTable(
                name: "Cities");

            migrationBuilder.UpdateData(
                table: "Packages",
                keyColumn: "PackageId",
                keyValue: 6,
                column: "IsInternationalPackage",
                value: false);

            migrationBuilder.UpdateData(
                table: "Packages",
                keyColumn: "PackageId",
                keyValue: 7,
                column: "IsInternationalPackage",
                value: false);

            migrationBuilder.UpdateData(
                table: "Packages",
                keyColumn: "PackageId",
                keyValue: 8,
                column: "IsInternationalPackage",
                value: false);

            migrationBuilder.UpdateData(
                table: "Packages",
                keyColumn: "PackageId",
                keyValue: 9,
                column: "IsInternationalPackage",
                value: false);

            migrationBuilder.UpdateData(
                table: "Packages",
                keyColumn: "PackageId",
                keyValue: 10,
                column: "IsInternationalPackage",
                value: false);

            migrationBuilder.UpdateData(
                table: "SubPackages",
                keyColumn: "SubPackageId",
                keyValue: 1,
                column: "IsAccomodationAvailable",
                value: false);

            migrationBuilder.UpdateData(
                table: "SubPackages",
                keyColumn: "SubPackageId",
                keyValue: 2,
                column: "IsAccomodationAvailable",
                value: false);

            migrationBuilder.UpdateData(
                table: "SubPackages",
                keyColumn: "SubPackageId",
                keyValue: 3,
                column: "IsAccomodationAvailable",
                value: false);

            migrationBuilder.UpdateData(
                table: "SubPackages",
                keyColumn: "SubPackageId",
                keyValue: 4,
                column: "IsAccomodationAvailable",
                value: false);

            migrationBuilder.UpdateData(
                table: "SubPackages",
                keyColumn: "SubPackageId",
                keyValue: 5,
                column: "IsAccomodationAvailable",
                value: false);

            migrationBuilder.UpdateData(
                table: "SubPackages",
                keyColumn: "SubPackageId",
                keyValue: 6,
                column: "IsAccomodationAvailable",
                value: false);

            migrationBuilder.UpdateData(
                table: "SubPackages",
                keyColumn: "SubPackageId",
                keyValue: 7,
                column: "IsAccomodationAvailable",
                value: false);

            migrationBuilder.UpdateData(
                table: "SubPackages",
                keyColumn: "SubPackageId",
                keyValue: 8,
                column: "IsAccomodationAvailable",
                value: false);

            migrationBuilder.UpdateData(
                table: "SubPackages",
                keyColumn: "SubPackageId",
                keyValue: 9,
                column: "IsAccomodationAvailable",
                value: false);

            migrationBuilder.UpdateData(
                table: "SubPackages",
                keyColumn: "SubPackageId",
                keyValue: 10,
                column: "IsAccomodationAvailable",
                value: false);

            migrationBuilder.UpdateData(
                table: "SubPackages",
                keyColumn: "SubPackageId",
                keyValue: 11,
                column: "IsAccomodationAvailable",
                value: false);

            migrationBuilder.UpdateData(
                table: "SubPackages",
                keyColumn: "SubPackageId",
                keyValue: 12,
                column: "IsAccomodationAvailable",
                value: false);

            migrationBuilder.UpdateData(
                table: "SubPackages",
                keyColumn: "SubPackageId",
                keyValue: 13,
                column: "IsAccomodationAvailable",
                value: false);

            migrationBuilder.UpdateData(
                table: "SubPackages",
                keyColumn: "SubPackageId",
                keyValue: 14,
                column: "IsAccomodationAvailable",
                value: false);

            migrationBuilder.UpdateData(
                table: "SubPackages",
                keyColumn: "SubPackageId",
                keyValue: 15,
                column: "IsAccomodationAvailable",
                value: false);

            migrationBuilder.UpdateData(
                table: "SubPackages",
                keyColumn: "SubPackageId",
                keyValue: 16,
                column: "IsAccomodationAvailable",
                value: false);

            migrationBuilder.UpdateData(
                table: "SubPackages",
                keyColumn: "SubPackageId",
                keyValue: 17,
                column: "IsAccomodationAvailable",
                value: false);

            migrationBuilder.UpdateData(
                table: "SubPackages",
                keyColumn: "SubPackageId",
                keyValue: 18,
                column: "IsAccomodationAvailable",
                value: false);
        }
    }
}
