using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PackageMicroservice.Core.API.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Packages",
                columns: table => new
                {
                    PackageId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PackageName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Packages", x => x.PackageId);
                    table.ForeignKey(
                        name: "FK_Packages_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PackageImage",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PackageId = table.Column<int>(type: "int", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PackageImage", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PackageImage_Packages_PackageId",
                        column: x => x.PackageId,
                        principalTable: "Packages",
                        principalColumn: "PackageId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SubPackages",
                columns: table => new
                {
                    SubPackageId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PackageId = table.Column<int>(type: "int", nullable: false),
                    PlaceToVisit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DaysNights = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PricePerAdult = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubPackages", x => x.SubPackageId);
                    table.ForeignKey(
                        name: "FK_SubPackages_Packages_PackageId",
                        column: x => x.PackageId,
                        principalTable: "Packages",
                        principalColumn: "PackageId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[,]
                {
                    { 1, "Adventure" },
                    { 2, "Nature" },
                    { 3, "Religious" },
                    { 4, "Village" },
                    { 5, "Wildlife" }
                });

            migrationBuilder.InsertData(
                table: "Packages",
                columns: new[] { "PackageId", "CategoryId", "Description", "PackageName" },
                values: new object[,]
                {
                    { 1, 1, "Experience thrilling treks in the Himalayan region.", "Himalayan Trek" },
                    { 2, 2, "Relax on the serene beaches of Goa.", "Goa Beach Bliss" },
                    { 3, 3, "Discover the spiritual aura of Varanasi.", "Spiritual Varanasi" },
                    { 4, 4, "Explore the vibrant rural culture of Rajasthan.", "Rural Rajasthan" },
                    { 5, 5, "Witness the majestic one-horned rhinos in their natural habitat.", "Kaziranga Safari" },
                    { 6, 1, "Explore the snow-capped mountains of the Swiss Alps.", "Swiss Alps Adventure" },
                    { 7, 2, "Unwind in the tropical beauty of Maldives.", "Maldives Paradise" },
                    { 8, 3, "Walk through the sacred landmarks of Jerusalem.", "Holy Jerusalem" },
                    { 9, 4, "Immerse yourself in the tranquil Japanese villages.", "Japanese Countryside" },
                    { 10, 5, "Discover the incredible biodiversity of the Amazon.", "Amazon Rainforest" }
                });

            migrationBuilder.InsertData(
                table: "PackageImage",
                columns: new[] { "Id", "ImageUrl", "PackageId" },
                values: new object[,]
                {
                    { 1, "images/himalayan_trek.jpg", 1 },
                    { 2, "images/himalayan_trek1.jpg", 1 },
                    { 3, "images/himalayan_trek2.jpg", 1 },
                    { 4, "images/himalayan_trek3.jpg", 1 },
                    { 5, "images/goa_beach.jpg", 2 },
                    { 6, "images/goa_beach1.jpg", 2 },
                    { 7, "images/goa_beach2.jpg", 2 },
                    { 8, "images/varanasi.jpg", 3 },
                    { 9, "images/varanasi1.jpg", 3 },
                    { 10, "images/varanasi2.jpg", 3 },
                    { 11, "images/rural_rajasthan.jpg", 4 },
                    { 12, "images/rural_rajasthan1.jpg", 4 },
                    { 13, "images/rural_rajasthan2.jpg", 4 },
                    { 14, "images/kaziranga_safari.jpg", 5 },
                    { 15, "images/kaziranga_safari1.jpg", 5 },
                    { 16, "images/kaziranga_safari2.jpg", 5 },
                    { 17, "images/swiss_alps.jpg", 6 },
                    { 18, "images/swiss_alps1.jpg", 6 },
                    { 19, "images/swiss_alps2.jpg", 6 },
                    { 20, "images/maldives.jpg", 7 },
                    { 21, "images/jerusalem.jpg", 8 },
                    { 22, "images/japanese_countryside.jpg", 9 },
                    { 23, "images/amazon.jpg", 10 },
                    { 24, "images/maldives1.jpg", 7 },
                    { 25, "images/maldives2.jpg", 7 },
                    { 26, "images/jerusalem1.jpg", 8 },
                    { 27, "images/jerusalem2.jpg", 8 },
                    { 28, "images/japanese_countryside1.jpg", 9 },
                    { 29, "images/japanese_countryside2.jpg", 9 },
                    { 30, "images/amazon1.jpg", 10 },
                    { 31, "images/amazon2.jpg", 10 }
                });

            migrationBuilder.InsertData(
                table: "SubPackages",
                columns: new[] { "SubPackageId", "DaysNights", "Description", "PackageId", "PlaceToVisit", "PricePerAdult" },
                values: new object[,]
                {
                    { 1, "5 Days / 4 Nights", "A serene valley with stunning views.", 1, "Manali", 1200.00m },
                    { 2, "3 Days / 2 Nights", "A high-altitude pass with breathtaking vistas.", 1, "Rohtang Pass", 1000.00m },
                    { 3, "4 Days / 3 Nights", "A bustling beach with vibrant nightlife.", 2, "Calangute Beach", 800.00m },
                    { 4, "2 Days / 1 Night", "Spectacular waterfalls surrounded by lush greenery.", 2, "Dudhsagar Falls", 700.00m },
                    { 5, "3 Days / 2 Nights", "A sacred temple dedicated to Lord Shiva.", 3, "Kashi Vishwanath Temple", 500.00m },
                    { 6, "2 Days / 1 Night", "Experience the spiritual Ganga Aarti.", 3, "Ganga Ghats", 400.00m },
                    { 7, "3 Days / 2 Nights", "Explore the famous Pushkar Camel Fair.", 4, "Pushkar", 1000.00m },
                    { 8, "4 Days / 3 Nights", "Experience traditional Rajasthani hospitality.", 4, "Jodhpur Villages", 1200.00m },
                    { 9, "5 Days / 4 Nights", "A UNESCO World Heritage site.", 5, "Kaziranga National Park", 2000.00m },
                    { 10, "4 Days / 3 Nights", "A picturesque town surrounded by mountains.", 6, "Interlaken", 3000.00m },
                    { 11, "5 Days / 4 Nights", "Home to the iconic Matterhorn peak.", 6, "Zermatt", 3500.00m },
                    { 12, "3 Days / 2 Nights", "Explore the capital city of Maldives.", 7, "Male City", 2500.00m },
                    { 13, "4 Days / 3 Nights", "Relax in luxurious overwater villas.", 7, "Resort Islands", 4000.00m },
                    { 14, "4 Days / 3 Nights", "Walk through the historic landmarks.", 8, "Old City", 1800.00m },
                    { 15, "3 Days / 2 Nights", "A traditional Japanese village with iconic houses.", 9, "Shirakawa-go", 2200.00m },
                    { 16, "4 Days / 3 Nights", "Known for hot springs and Mount Fuji views.", 9, "Hakone", 2400.00m },
                    { 17, "5 Days / 4 Nights", "Gateway to the Amazon jungle.", 10, "Manaus", 2700.00m },
                    { 18, "6 Days / 5 Nights", "Discover the diverse wildlife of the Amazon.", 10, "Amazon River Cruise", 3000.00m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_PackageImage_PackageId",
                table: "PackageImage",
                column: "PackageId");

            migrationBuilder.CreateIndex(
                name: "IX_Packages_CategoryId",
                table: "Packages",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_SubPackages_PackageId",
                table: "SubPackages",
                column: "PackageId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PackageImage");

            migrationBuilder.DropTable(
                name: "SubPackages");

            migrationBuilder.DropTable(
                name: "Packages");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
