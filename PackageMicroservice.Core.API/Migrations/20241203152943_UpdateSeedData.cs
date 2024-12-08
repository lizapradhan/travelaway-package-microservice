using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PackageMicroservice.Core.API.Migrations
{
    /// <inheritdoc />
    public partial class UpdateSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DaysNights",
                table: "SubPackages");

            migrationBuilder.AddColumn<int>(
                name: "Days",
                table: "SubPackages",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Nights",
                table: "SubPackages",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "SubPackages",
                keyColumn: "SubPackageId",
                keyValue: 1,
                columns: new[] { "Days", "Nights" },
                values: new object[] { 5, 4 });

            migrationBuilder.UpdateData(
                table: "SubPackages",
                keyColumn: "SubPackageId",
                keyValue: 2,
                columns: new[] { "Days", "Nights" },
                values: new object[] { 3, 2 });

            migrationBuilder.UpdateData(
                table: "SubPackages",
                keyColumn: "SubPackageId",
                keyValue: 3,
                columns: new[] { "Days", "Nights" },
                values: new object[] { 4, 3 });

            migrationBuilder.UpdateData(
                table: "SubPackages",
                keyColumn: "SubPackageId",
                keyValue: 4,
                columns: new[] { "Days", "Nights" },
                values: new object[] { 2, 1 });

            migrationBuilder.UpdateData(
                table: "SubPackages",
                keyColumn: "SubPackageId",
                keyValue: 5,
                columns: new[] { "Days", "Nights" },
                values: new object[] { 3, 2 });

            migrationBuilder.UpdateData(
                table: "SubPackages",
                keyColumn: "SubPackageId",
                keyValue: 6,
                columns: new[] { "Days", "Nights" },
                values: new object[] { 2, 1 });

            migrationBuilder.UpdateData(
                table: "SubPackages",
                keyColumn: "SubPackageId",
                keyValue: 7,
                columns: new[] { "Days", "Nights" },
                values: new object[] { 3, 2 });

            migrationBuilder.UpdateData(
                table: "SubPackages",
                keyColumn: "SubPackageId",
                keyValue: 8,
                columns: new[] { "Days", "Nights" },
                values: new object[] { 4, 3 });

            migrationBuilder.UpdateData(
                table: "SubPackages",
                keyColumn: "SubPackageId",
                keyValue: 9,
                columns: new[] { "Days", "Nights" },
                values: new object[] { 5, 4 });

            migrationBuilder.UpdateData(
                table: "SubPackages",
                keyColumn: "SubPackageId",
                keyValue: 10,
                columns: new[] { "Days", "Nights" },
                values: new object[] { 4, 3 });

            migrationBuilder.UpdateData(
                table: "SubPackages",
                keyColumn: "SubPackageId",
                keyValue: 11,
                columns: new[] { "Days", "Nights" },
                values: new object[] { 5, 4 });

            migrationBuilder.UpdateData(
                table: "SubPackages",
                keyColumn: "SubPackageId",
                keyValue: 12,
                columns: new[] { "Days", "Nights" },
                values: new object[] { 3, 2 });

            migrationBuilder.UpdateData(
                table: "SubPackages",
                keyColumn: "SubPackageId",
                keyValue: 13,
                columns: new[] { "Days", "Nights" },
                values: new object[] { 4, 3 });

            migrationBuilder.UpdateData(
                table: "SubPackages",
                keyColumn: "SubPackageId",
                keyValue: 14,
                columns: new[] { "Days", "Nights" },
                values: new object[] { 4, 3 });

            migrationBuilder.UpdateData(
                table: "SubPackages",
                keyColumn: "SubPackageId",
                keyValue: 15,
                columns: new[] { "Days", "Nights" },
                values: new object[] { 3, 2 });

            migrationBuilder.UpdateData(
                table: "SubPackages",
                keyColumn: "SubPackageId",
                keyValue: 16,
                columns: new[] { "Days", "Nights" },
                values: new object[] { 4, 3 });

            migrationBuilder.UpdateData(
                table: "SubPackages",
                keyColumn: "SubPackageId",
                keyValue: 17,
                columns: new[] { "Days", "Nights" },
                values: new object[] { 5, 4 });

            migrationBuilder.UpdateData(
                table: "SubPackages",
                keyColumn: "SubPackageId",
                keyValue: 18,
                columns: new[] { "Days", "Nights" },
                values: new object[] { 6, 5 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Days",
                table: "SubPackages");

            migrationBuilder.DropColumn(
                name: "Nights",
                table: "SubPackages");

            migrationBuilder.AddColumn<string>(
                name: "DaysNights",
                table: "SubPackages",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "SubPackages",
                keyColumn: "SubPackageId",
                keyValue: 1,
                column: "DaysNights",
                value: "5 Days / 4 Nights");

            migrationBuilder.UpdateData(
                table: "SubPackages",
                keyColumn: "SubPackageId",
                keyValue: 2,
                column: "DaysNights",
                value: "3 Days / 2 Nights");

            migrationBuilder.UpdateData(
                table: "SubPackages",
                keyColumn: "SubPackageId",
                keyValue: 3,
                column: "DaysNights",
                value: "4 Days / 3 Nights");

            migrationBuilder.UpdateData(
                table: "SubPackages",
                keyColumn: "SubPackageId",
                keyValue: 4,
                column: "DaysNights",
                value: "2 Days / 1 Night");

            migrationBuilder.UpdateData(
                table: "SubPackages",
                keyColumn: "SubPackageId",
                keyValue: 5,
                column: "DaysNights",
                value: "3 Days / 2 Nights");

            migrationBuilder.UpdateData(
                table: "SubPackages",
                keyColumn: "SubPackageId",
                keyValue: 6,
                column: "DaysNights",
                value: "2 Days / 1 Night");

            migrationBuilder.UpdateData(
                table: "SubPackages",
                keyColumn: "SubPackageId",
                keyValue: 7,
                column: "DaysNights",
                value: "3 Days / 2 Nights");

            migrationBuilder.UpdateData(
                table: "SubPackages",
                keyColumn: "SubPackageId",
                keyValue: 8,
                column: "DaysNights",
                value: "4 Days / 3 Nights");

            migrationBuilder.UpdateData(
                table: "SubPackages",
                keyColumn: "SubPackageId",
                keyValue: 9,
                column: "DaysNights",
                value: "5 Days / 4 Nights");

            migrationBuilder.UpdateData(
                table: "SubPackages",
                keyColumn: "SubPackageId",
                keyValue: 10,
                column: "DaysNights",
                value: "4 Days / 3 Nights");

            migrationBuilder.UpdateData(
                table: "SubPackages",
                keyColumn: "SubPackageId",
                keyValue: 11,
                column: "DaysNights",
                value: "5 Days / 4 Nights");

            migrationBuilder.UpdateData(
                table: "SubPackages",
                keyColumn: "SubPackageId",
                keyValue: 12,
                column: "DaysNights",
                value: "3 Days / 2 Nights");

            migrationBuilder.UpdateData(
                table: "SubPackages",
                keyColumn: "SubPackageId",
                keyValue: 13,
                column: "DaysNights",
                value: "4 Days / 3 Nights");

            migrationBuilder.UpdateData(
                table: "SubPackages",
                keyColumn: "SubPackageId",
                keyValue: 14,
                column: "DaysNights",
                value: "4 Days / 3 Nights");

            migrationBuilder.UpdateData(
                table: "SubPackages",
                keyColumn: "SubPackageId",
                keyValue: 15,
                column: "DaysNights",
                value: "3 Days / 2 Nights");

            migrationBuilder.UpdateData(
                table: "SubPackages",
                keyColumn: "SubPackageId",
                keyValue: 16,
                column: "DaysNights",
                value: "4 Days / 3 Nights");

            migrationBuilder.UpdateData(
                table: "SubPackages",
                keyColumn: "SubPackageId",
                keyValue: 17,
                column: "DaysNights",
                value: "5 Days / 4 Nights");

            migrationBuilder.UpdateData(
                table: "SubPackages",
                keyColumn: "SubPackageId",
                keyValue: 18,
                column: "DaysNights",
                value: "6 Days / 5 Nights");
        }
    }
}
