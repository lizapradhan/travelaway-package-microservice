using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PackageMicroservice.Core.API.Migrations
{
    /// <inheritdoc />
    public partial class addedcolumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsAccomodationAvailable",
                table: "SubPackages",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsInternationalPackage",
                table: "Packages",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Packages",
                keyColumn: "PackageId",
                keyValue: 1,
                column: "IsInternationalPackage",
                value: false);

            migrationBuilder.UpdateData(
                table: "Packages",
                keyColumn: "PackageId",
                keyValue: 2,
                column: "IsInternationalPackage",
                value: false);

            migrationBuilder.UpdateData(
                table: "Packages",
                keyColumn: "PackageId",
                keyValue: 3,
                column: "IsInternationalPackage",
                value: false);

            migrationBuilder.UpdateData(
                table: "Packages",
                keyColumn: "PackageId",
                keyValue: 4,
                column: "IsInternationalPackage",
                value: false);

            migrationBuilder.UpdateData(
                table: "Packages",
                keyColumn: "PackageId",
                keyValue: 5,
                column: "IsInternationalPackage",
                value: false);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsAccomodationAvailable",
                table: "SubPackages");

            migrationBuilder.DropColumn(
                name: "IsInternationalPackage",
                table: "Packages");
        }
    }
}
