using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PCHCB.Data.Migrations
{
    public partial class addBuilderInfoToPcConfiguration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PcConfigurations_AspNetUsers_ApplicationUserId",
                table: "PcConfigurations");

            migrationBuilder.RenameColumn(
                name: "ApplicationUserId",
                table: "PcConfigurations",
                newName: "BuilderId");

            migrationBuilder.RenameIndex(
                name: "IX_PcConfigurations_ApplicationUserId",
                table: "PcConfigurations",
                newName: "IX_PcConfigurations_BuilderId");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("73df6910-cc0d-4f98-90a0-748c29bbd618"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2806c611-8ede-4f9a-911f-3695bfd87141", "AQAAAAEAACcQAAAAEMuT6jVwnq1QFKFT78p8hsacwOEaaLHy7Am0bP61V99EtHhee7yzwvUueQTU1Hq2uA==" });

            migrationBuilder.UpdateData(
                table: "Cases",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedOn",
                value: new DateTime(2023, 8, 8, 21, 49, 2, 740, DateTimeKind.Utc).AddTicks(4100));

            migrationBuilder.UpdateData(
                table: "Cases",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedOn",
                value: new DateTime(2023, 8, 8, 21, 49, 2, 740, DateTimeKind.Utc).AddTicks(4123));

            migrationBuilder.UpdateData(
                table: "Cases",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddedOn",
                value: new DateTime(2023, 8, 8, 21, 49, 2, 740, DateTimeKind.Utc).AddTicks(4161));

            migrationBuilder.UpdateData(
                table: "Cases",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddedOn",
                value: new DateTime(2023, 8, 8, 21, 49, 2, 740, DateTimeKind.Utc).AddTicks(4164));

            migrationBuilder.UpdateData(
                table: "Cases",
                keyColumn: "Id",
                keyValue: 5,
                column: "AddedOn",
                value: new DateTime(2023, 8, 8, 21, 49, 2, 740, DateTimeKind.Utc).AddTicks(4170));

            migrationBuilder.UpdateData(
                table: "Coolers",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedOn",
                value: new DateTime(2023, 8, 8, 21, 49, 2, 741, DateTimeKind.Utc).AddTicks(7102));

            migrationBuilder.UpdateData(
                table: "Coolers",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedOn",
                value: new DateTime(2023, 8, 8, 21, 49, 2, 741, DateTimeKind.Utc).AddTicks(7145));

            migrationBuilder.UpdateData(
                table: "Coolers",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddedOn",
                value: new DateTime(2023, 8, 8, 21, 49, 2, 741, DateTimeKind.Utc).AddTicks(7148));

            migrationBuilder.UpdateData(
                table: "Coolers",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddedOn",
                value: new DateTime(2023, 8, 8, 21, 49, 2, 741, DateTimeKind.Utc).AddTicks(7150));

            migrationBuilder.UpdateData(
                table: "Coolers",
                keyColumn: "Id",
                keyValue: 5,
                column: "AddedOn",
                value: new DateTime(2023, 8, 8, 21, 49, 2, 741, DateTimeKind.Utc).AddTicks(7155));

            migrationBuilder.UpdateData(
                table: "Coolers",
                keyColumn: "Id",
                keyValue: 6,
                column: "AddedOn",
                value: new DateTime(2023, 8, 8, 21, 49, 2, 741, DateTimeKind.Utc).AddTicks(7158));

            migrationBuilder.UpdateData(
                table: "Coolers",
                keyColumn: "Id",
                keyValue: 7,
                column: "AddedOn",
                value: new DateTime(2023, 8, 8, 21, 49, 2, 741, DateTimeKind.Utc).AddTicks(7160));

            migrationBuilder.UpdateData(
                table: "Coolers",
                keyColumn: "Id",
                keyValue: 8,
                column: "AddedOn",
                value: new DateTime(2023, 8, 8, 21, 49, 2, 741, DateTimeKind.Utc).AddTicks(7163));

            migrationBuilder.UpdateData(
                table: "Coolers",
                keyColumn: "Id",
                keyValue: 9,
                column: "AddedOn",
                value: new DateTime(2023, 8, 8, 21, 49, 2, 741, DateTimeKind.Utc).AddTicks(7166));

            migrationBuilder.UpdateData(
                table: "Coolers",
                keyColumn: "Id",
                keyValue: 10,
                column: "AddedOn",
                value: new DateTime(2023, 8, 8, 21, 49, 2, 741, DateTimeKind.Utc).AddTicks(7169));

            migrationBuilder.UpdateData(
                table: "Cpus",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedOn",
                value: new DateTime(2023, 8, 8, 21, 49, 2, 741, DateTimeKind.Utc).AddTicks(7940));

            migrationBuilder.UpdateData(
                table: "Cpus",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedOn",
                value: new DateTime(2023, 8, 8, 21, 49, 2, 741, DateTimeKind.Utc).AddTicks(7946));

            migrationBuilder.UpdateData(
                table: "Cpus",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddedOn",
                value: new DateTime(2023, 8, 8, 21, 49, 2, 741, DateTimeKind.Utc).AddTicks(7948));

            migrationBuilder.UpdateData(
                table: "Cpus",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddedOn",
                value: new DateTime(2023, 8, 8, 21, 49, 2, 741, DateTimeKind.Utc).AddTicks(7950));

            migrationBuilder.UpdateData(
                table: "Cpus",
                keyColumn: "Id",
                keyValue: 5,
                column: "AddedOn",
                value: new DateTime(2023, 8, 8, 21, 49, 2, 741, DateTimeKind.Utc).AddTicks(7953));

            migrationBuilder.UpdateData(
                table: "Cpus",
                keyColumn: "Id",
                keyValue: 6,
                column: "AddedOn",
                value: new DateTime(2023, 8, 8, 21, 49, 2, 741, DateTimeKind.Utc).AddTicks(7956));

            migrationBuilder.UpdateData(
                table: "Cpus",
                keyColumn: "Id",
                keyValue: 7,
                column: "AddedOn",
                value: new DateTime(2023, 8, 8, 21, 49, 2, 741, DateTimeKind.Utc).AddTicks(7959));

            migrationBuilder.UpdateData(
                table: "Gpus",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedOn",
                value: new DateTime(2023, 8, 8, 21, 49, 2, 741, DateTimeKind.Utc).AddTicks(8709));

            migrationBuilder.UpdateData(
                table: "Gpus",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedOn",
                value: new DateTime(2023, 8, 8, 21, 49, 2, 741, DateTimeKind.Utc).AddTicks(8717));

            migrationBuilder.UpdateData(
                table: "Gpus",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddedOn",
                value: new DateTime(2023, 8, 8, 21, 49, 2, 741, DateTimeKind.Utc).AddTicks(8720));

            migrationBuilder.UpdateData(
                table: "Gpus",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddedOn",
                value: new DateTime(2023, 8, 8, 21, 49, 2, 741, DateTimeKind.Utc).AddTicks(8723));

            migrationBuilder.UpdateData(
                table: "Gpus",
                keyColumn: "Id",
                keyValue: 5,
                column: "AddedOn",
                value: new DateTime(2023, 8, 8, 21, 49, 2, 741, DateTimeKind.Utc).AddTicks(8727));

            migrationBuilder.UpdateData(
                table: "Gpus",
                keyColumn: "Id",
                keyValue: 6,
                column: "AddedOn",
                value: new DateTime(2023, 8, 8, 21, 49, 2, 741, DateTimeKind.Utc).AddTicks(8730));

            migrationBuilder.UpdateData(
                table: "Gpus",
                keyColumn: "Id",
                keyValue: 7,
                column: "AddedOn",
                value: new DateTime(2023, 8, 8, 21, 49, 2, 741, DateTimeKind.Utc).AddTicks(8732));

            migrationBuilder.UpdateData(
                table: "Gpus",
                keyColumn: "Id",
                keyValue: 8,
                column: "AddedOn",
                value: new DateTime(2023, 8, 8, 21, 49, 2, 741, DateTimeKind.Utc).AddTicks(8735));

            migrationBuilder.UpdateData(
                table: "Motherboards",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedOn",
                value: new DateTime(2023, 8, 8, 21, 49, 2, 741, DateTimeKind.Utc).AddTicks(9513));

            migrationBuilder.UpdateData(
                table: "Motherboards",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedOn",
                value: new DateTime(2023, 8, 8, 21, 49, 2, 741, DateTimeKind.Utc).AddTicks(9520));

            migrationBuilder.UpdateData(
                table: "Motherboards",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddedOn",
                value: new DateTime(2023, 8, 8, 21, 49, 2, 741, DateTimeKind.Utc).AddTicks(9522));

            migrationBuilder.UpdateData(
                table: "Motherboards",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddedOn",
                value: new DateTime(2023, 8, 8, 21, 49, 2, 741, DateTimeKind.Utc).AddTicks(9525));

            migrationBuilder.UpdateData(
                table: "Motherboards",
                keyColumn: "Id",
                keyValue: 5,
                column: "AddedOn",
                value: new DateTime(2023, 8, 8, 21, 49, 2, 741, DateTimeKind.Utc).AddTicks(9556));

            migrationBuilder.UpdateData(
                table: "Motherboards",
                keyColumn: "Id",
                keyValue: 6,
                column: "AddedOn",
                value: new DateTime(2023, 8, 8, 21, 49, 2, 741, DateTimeKind.Utc).AddTicks(9559));

            migrationBuilder.UpdateData(
                table: "Motherboards",
                keyColumn: "Id",
                keyValue: 7,
                column: "AddedOn",
                value: new DateTime(2023, 8, 8, 21, 49, 2, 741, DateTimeKind.Utc).AddTicks(9562));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedOn",
                value: new DateTime(2023, 8, 8, 21, 49, 2, 742, DateTimeKind.Utc).AddTicks(285));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedOn",
                value: new DateTime(2023, 8, 8, 21, 49, 2, 742, DateTimeKind.Utc).AddTicks(294));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddedOn",
                value: new DateTime(2023, 8, 8, 21, 49, 2, 742, DateTimeKind.Utc).AddTicks(296));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddedOn",
                value: new DateTime(2023, 8, 8, 21, 49, 2, 742, DateTimeKind.Utc).AddTicks(299));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 5,
                column: "AddedOn",
                value: new DateTime(2023, 8, 8, 21, 49, 2, 742, DateTimeKind.Utc).AddTicks(303));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 6,
                column: "AddedOn",
                value: new DateTime(2023, 8, 8, 21, 49, 2, 742, DateTimeKind.Utc).AddTicks(305));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 7,
                column: "AddedOn",
                value: new DateTime(2023, 8, 8, 21, 49, 2, 742, DateTimeKind.Utc).AddTicks(308));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 8,
                column: "AddedOn",
                value: new DateTime(2023, 8, 8, 21, 49, 2, 742, DateTimeKind.Utc).AddTicks(310));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 9,
                column: "AddedOn",
                value: new DateTime(2023, 8, 8, 21, 49, 2, 742, DateTimeKind.Utc).AddTicks(313));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 10,
                column: "AddedOn",
                value: new DateTime(2023, 8, 8, 21, 49, 2, 742, DateTimeKind.Utc).AddTicks(316));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 11,
                column: "AddedOn",
                value: new DateTime(2023, 8, 8, 21, 49, 2, 742, DateTimeKind.Utc).AddTicks(318));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 12,
                column: "AddedOn",
                value: new DateTime(2023, 8, 8, 21, 49, 2, 742, DateTimeKind.Utc).AddTicks(320));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 13,
                column: "AddedOn",
                value: new DateTime(2023, 8, 8, 21, 49, 2, 742, DateTimeKind.Utc).AddTicks(323));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedOn",
                value: new DateTime(2023, 8, 8, 21, 49, 2, 742, DateTimeKind.Utc).AddTicks(1099));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedOn",
                value: new DateTime(2023, 8, 8, 21, 49, 2, 742, DateTimeKind.Utc).AddTicks(1106));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddedOn",
                value: new DateTime(2023, 8, 8, 21, 49, 2, 742, DateTimeKind.Utc).AddTicks(1109));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddedOn",
                value: new DateTime(2023, 8, 8, 21, 49, 2, 742, DateTimeKind.Utc).AddTicks(1113));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 5,
                column: "AddedOn",
                value: new DateTime(2023, 8, 8, 21, 49, 2, 742, DateTimeKind.Utc).AddTicks(1118));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 6,
                column: "AddedOn",
                value: new DateTime(2023, 8, 8, 21, 49, 2, 742, DateTimeKind.Utc).AddTicks(1121));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 7,
                column: "AddedOn",
                value: new DateTime(2023, 8, 8, 21, 49, 2, 742, DateTimeKind.Utc).AddTicks(1124));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 8,
                column: "AddedOn",
                value: new DateTime(2023, 8, 8, 21, 49, 2, 742, DateTimeKind.Utc).AddTicks(1127));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 9,
                column: "AddedOn",
                value: new DateTime(2023, 8, 8, 21, 49, 2, 742, DateTimeKind.Utc).AddTicks(1131));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 10,
                column: "AddedOn",
                value: new DateTime(2023, 8, 8, 21, 49, 2, 742, DateTimeKind.Utc).AddTicks(1134));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 11,
                column: "AddedOn",
                value: new DateTime(2023, 8, 8, 21, 49, 2, 742, DateTimeKind.Utc).AddTicks(1137));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 12,
                column: "AddedOn",
                value: new DateTime(2023, 8, 8, 21, 49, 2, 742, DateTimeKind.Utc).AddTicks(1140));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 13,
                column: "AddedOn",
                value: new DateTime(2023, 8, 8, 21, 49, 2, 742, DateTimeKind.Utc).AddTicks(1143));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 14,
                column: "AddedOn",
                value: new DateTime(2023, 8, 8, 21, 49, 2, 742, DateTimeKind.Utc).AddTicks(1146));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 15,
                column: "AddedOn",
                value: new DateTime(2023, 8, 8, 21, 49, 2, 742, DateTimeKind.Utc).AddTicks(1149));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 16,
                column: "AddedOn",
                value: new DateTime(2023, 8, 8, 21, 49, 2, 742, DateTimeKind.Utc).AddTicks(1186));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 17,
                column: "AddedOn",
                value: new DateTime(2023, 8, 8, 21, 49, 2, 742, DateTimeKind.Utc).AddTicks(1189));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 18,
                column: "AddedOn",
                value: new DateTime(2023, 8, 8, 21, 49, 2, 742, DateTimeKind.Utc).AddTicks(1191));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 19,
                column: "AddedOn",
                value: new DateTime(2023, 8, 8, 21, 49, 2, 742, DateTimeKind.Utc).AddTicks(1195));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 20,
                column: "AddedOn",
                value: new DateTime(2023, 8, 8, 21, 49, 2, 742, DateTimeKind.Utc).AddTicks(1198));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedOn",
                value: new DateTime(2023, 8, 8, 21, 49, 2, 742, DateTimeKind.Utc).AddTicks(1947));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedOn",
                value: new DateTime(2023, 8, 8, 21, 49, 2, 742, DateTimeKind.Utc).AddTicks(1953));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddedOn",
                value: new DateTime(2023, 8, 8, 21, 49, 2, 742, DateTimeKind.Utc).AddTicks(1955));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddedOn",
                value: new DateTime(2023, 8, 8, 21, 49, 2, 742, DateTimeKind.Utc).AddTicks(1958));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 5,
                column: "AddedOn",
                value: new DateTime(2023, 8, 8, 21, 49, 2, 742, DateTimeKind.Utc).AddTicks(1962));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 6,
                column: "AddedOn",
                value: new DateTime(2023, 8, 8, 21, 49, 2, 742, DateTimeKind.Utc).AddTicks(1964));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 7,
                column: "AddedOn",
                value: new DateTime(2023, 8, 8, 21, 49, 2, 742, DateTimeKind.Utc).AddTicks(1967));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 8,
                column: "AddedOn",
                value: new DateTime(2023, 8, 8, 21, 49, 2, 742, DateTimeKind.Utc).AddTicks(1969));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 9,
                column: "AddedOn",
                value: new DateTime(2023, 8, 8, 21, 49, 2, 742, DateTimeKind.Utc).AddTicks(1972));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 10,
                column: "AddedOn",
                value: new DateTime(2023, 8, 8, 21, 49, 2, 742, DateTimeKind.Utc).AddTicks(1975));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 11,
                column: "AddedOn",
                value: new DateTime(2023, 8, 8, 21, 49, 2, 742, DateTimeKind.Utc).AddTicks(1977));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 12,
                column: "AddedOn",
                value: new DateTime(2023, 8, 8, 21, 49, 2, 742, DateTimeKind.Utc).AddTicks(1984));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 13,
                column: "AddedOn",
                value: new DateTime(2023, 8, 8, 21, 49, 2, 742, DateTimeKind.Utc).AddTicks(1986));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 14,
                column: "AddedOn",
                value: new DateTime(2023, 8, 8, 21, 49, 2, 742, DateTimeKind.Utc).AddTicks(1989));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 15,
                column: "AddedOn",
                value: new DateTime(2023, 8, 8, 21, 49, 2, 742, DateTimeKind.Utc).AddTicks(1991));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 16,
                column: "AddedOn",
                value: new DateTime(2023, 8, 8, 21, 49, 2, 742, DateTimeKind.Utc).AddTicks(1993));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 17,
                column: "AddedOn",
                value: new DateTime(2023, 8, 8, 21, 49, 2, 742, DateTimeKind.Utc).AddTicks(1996));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 18,
                column: "AddedOn",
                value: new DateTime(2023, 8, 8, 21, 49, 2, 742, DateTimeKind.Utc).AddTicks(1998));

            migrationBuilder.AddForeignKey(
                name: "FK_PcConfigurations_AspNetUsers_BuilderId",
                table: "PcConfigurations",
                column: "BuilderId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PcConfigurations_AspNetUsers_BuilderId",
                table: "PcConfigurations");

            migrationBuilder.RenameColumn(
                name: "BuilderId",
                table: "PcConfigurations",
                newName: "ApplicationUserId");

            migrationBuilder.RenameIndex(
                name: "IX_PcConfigurations_BuilderId",
                table: "PcConfigurations",
                newName: "IX_PcConfigurations_ApplicationUserId");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("73df6910-cc0d-4f98-90a0-748c29bbd618"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1d1f47f4-765d-486c-8047-db4e1e92dd26", "AQAAAAEAACcQAAAAEOSqZvM+YJGkIyP+nNwWrz4wr8dyhHfSN563hKdDDXYVLGrfmsAsSCU47UVgqtki0A==" });

            migrationBuilder.UpdateData(
                table: "Cases",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedOn",
                value: new DateTime(2023, 8, 8, 12, 23, 36, 957, DateTimeKind.Utc).AddTicks(1859));

            migrationBuilder.UpdateData(
                table: "Cases",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedOn",
                value: new DateTime(2023, 8, 8, 12, 23, 36, 957, DateTimeKind.Utc).AddTicks(1888));

            migrationBuilder.UpdateData(
                table: "Cases",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddedOn",
                value: new DateTime(2023, 8, 8, 12, 23, 36, 957, DateTimeKind.Utc).AddTicks(1891));

            migrationBuilder.UpdateData(
                table: "Cases",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddedOn",
                value: new DateTime(2023, 8, 8, 12, 23, 36, 957, DateTimeKind.Utc).AddTicks(1894));

            migrationBuilder.UpdateData(
                table: "Cases",
                keyColumn: "Id",
                keyValue: 5,
                column: "AddedOn",
                value: new DateTime(2023, 8, 8, 12, 23, 36, 957, DateTimeKind.Utc).AddTicks(1900));

            migrationBuilder.UpdateData(
                table: "Coolers",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedOn",
                value: new DateTime(2023, 8, 8, 12, 23, 36, 958, DateTimeKind.Utc).AddTicks(5117));

            migrationBuilder.UpdateData(
                table: "Coolers",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedOn",
                value: new DateTime(2023, 8, 8, 12, 23, 36, 958, DateTimeKind.Utc).AddTicks(5128));

            migrationBuilder.UpdateData(
                table: "Coolers",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddedOn",
                value: new DateTime(2023, 8, 8, 12, 23, 36, 958, DateTimeKind.Utc).AddTicks(5131));

            migrationBuilder.UpdateData(
                table: "Coolers",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddedOn",
                value: new DateTime(2023, 8, 8, 12, 23, 36, 958, DateTimeKind.Utc).AddTicks(5133));

            migrationBuilder.UpdateData(
                table: "Coolers",
                keyColumn: "Id",
                keyValue: 5,
                column: "AddedOn",
                value: new DateTime(2023, 8, 8, 12, 23, 36, 958, DateTimeKind.Utc).AddTicks(5138));

            migrationBuilder.UpdateData(
                table: "Coolers",
                keyColumn: "Id",
                keyValue: 6,
                column: "AddedOn",
                value: new DateTime(2023, 8, 8, 12, 23, 36, 958, DateTimeKind.Utc).AddTicks(5141));

            migrationBuilder.UpdateData(
                table: "Coolers",
                keyColumn: "Id",
                keyValue: 7,
                column: "AddedOn",
                value: new DateTime(2023, 8, 8, 12, 23, 36, 958, DateTimeKind.Utc).AddTicks(5143));

            migrationBuilder.UpdateData(
                table: "Coolers",
                keyColumn: "Id",
                keyValue: 8,
                column: "AddedOn",
                value: new DateTime(2023, 8, 8, 12, 23, 36, 958, DateTimeKind.Utc).AddTicks(5146));

            migrationBuilder.UpdateData(
                table: "Coolers",
                keyColumn: "Id",
                keyValue: 9,
                column: "AddedOn",
                value: new DateTime(2023, 8, 8, 12, 23, 36, 958, DateTimeKind.Utc).AddTicks(5150));

            migrationBuilder.UpdateData(
                table: "Coolers",
                keyColumn: "Id",
                keyValue: 10,
                column: "AddedOn",
                value: new DateTime(2023, 8, 8, 12, 23, 36, 958, DateTimeKind.Utc).AddTicks(5152));

            migrationBuilder.UpdateData(
                table: "Cpus",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedOn",
                value: new DateTime(2023, 8, 8, 12, 23, 36, 958, DateTimeKind.Utc).AddTicks(5906));

            migrationBuilder.UpdateData(
                table: "Cpus",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedOn",
                value: new DateTime(2023, 8, 8, 12, 23, 36, 958, DateTimeKind.Utc).AddTicks(5913));

            migrationBuilder.UpdateData(
                table: "Cpus",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddedOn",
                value: new DateTime(2023, 8, 8, 12, 23, 36, 958, DateTimeKind.Utc).AddTicks(5915));

            migrationBuilder.UpdateData(
                table: "Cpus",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddedOn",
                value: new DateTime(2023, 8, 8, 12, 23, 36, 958, DateTimeKind.Utc).AddTicks(5918));

            migrationBuilder.UpdateData(
                table: "Cpus",
                keyColumn: "Id",
                keyValue: 5,
                column: "AddedOn",
                value: new DateTime(2023, 8, 8, 12, 23, 36, 958, DateTimeKind.Utc).AddTicks(5920));

            migrationBuilder.UpdateData(
                table: "Cpus",
                keyColumn: "Id",
                keyValue: 6,
                column: "AddedOn",
                value: new DateTime(2023, 8, 8, 12, 23, 36, 958, DateTimeKind.Utc).AddTicks(5924));

            migrationBuilder.UpdateData(
                table: "Cpus",
                keyColumn: "Id",
                keyValue: 7,
                column: "AddedOn",
                value: new DateTime(2023, 8, 8, 12, 23, 36, 958, DateTimeKind.Utc).AddTicks(5926));

            migrationBuilder.UpdateData(
                table: "Gpus",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedOn",
                value: new DateTime(2023, 8, 8, 12, 23, 36, 958, DateTimeKind.Utc).AddTicks(6698));

            migrationBuilder.UpdateData(
                table: "Gpus",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedOn",
                value: new DateTime(2023, 8, 8, 12, 23, 36, 958, DateTimeKind.Utc).AddTicks(6706));

            migrationBuilder.UpdateData(
                table: "Gpus",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddedOn",
                value: new DateTime(2023, 8, 8, 12, 23, 36, 958, DateTimeKind.Utc).AddTicks(6709));

            migrationBuilder.UpdateData(
                table: "Gpus",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddedOn",
                value: new DateTime(2023, 8, 8, 12, 23, 36, 958, DateTimeKind.Utc).AddTicks(6711));

            migrationBuilder.UpdateData(
                table: "Gpus",
                keyColumn: "Id",
                keyValue: 5,
                column: "AddedOn",
                value: new DateTime(2023, 8, 8, 12, 23, 36, 958, DateTimeKind.Utc).AddTicks(6716));

            migrationBuilder.UpdateData(
                table: "Gpus",
                keyColumn: "Id",
                keyValue: 6,
                column: "AddedOn",
                value: new DateTime(2023, 8, 8, 12, 23, 36, 958, DateTimeKind.Utc).AddTicks(6718));

            migrationBuilder.UpdateData(
                table: "Gpus",
                keyColumn: "Id",
                keyValue: 7,
                column: "AddedOn",
                value: new DateTime(2023, 8, 8, 12, 23, 36, 958, DateTimeKind.Utc).AddTicks(6721));

            migrationBuilder.UpdateData(
                table: "Gpus",
                keyColumn: "Id",
                keyValue: 8,
                column: "AddedOn",
                value: new DateTime(2023, 8, 8, 12, 23, 36, 958, DateTimeKind.Utc).AddTicks(6723));

            migrationBuilder.UpdateData(
                table: "Motherboards",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedOn",
                value: new DateTime(2023, 8, 8, 12, 23, 36, 958, DateTimeKind.Utc).AddTicks(7500));

            migrationBuilder.UpdateData(
                table: "Motherboards",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedOn",
                value: new DateTime(2023, 8, 8, 12, 23, 36, 958, DateTimeKind.Utc).AddTicks(7508));

            migrationBuilder.UpdateData(
                table: "Motherboards",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddedOn",
                value: new DateTime(2023, 8, 8, 12, 23, 36, 958, DateTimeKind.Utc).AddTicks(7510));

            migrationBuilder.UpdateData(
                table: "Motherboards",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddedOn",
                value: new DateTime(2023, 8, 8, 12, 23, 36, 958, DateTimeKind.Utc).AddTicks(7513));

            migrationBuilder.UpdateData(
                table: "Motherboards",
                keyColumn: "Id",
                keyValue: 5,
                column: "AddedOn",
                value: new DateTime(2023, 8, 8, 12, 23, 36, 958, DateTimeKind.Utc).AddTicks(7515));

            migrationBuilder.UpdateData(
                table: "Motherboards",
                keyColumn: "Id",
                keyValue: 6,
                column: "AddedOn",
                value: new DateTime(2023, 8, 8, 12, 23, 36, 958, DateTimeKind.Utc).AddTicks(7518));

            migrationBuilder.UpdateData(
                table: "Motherboards",
                keyColumn: "Id",
                keyValue: 7,
                column: "AddedOn",
                value: new DateTime(2023, 8, 8, 12, 23, 36, 958, DateTimeKind.Utc).AddTicks(7521));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedOn",
                value: new DateTime(2023, 8, 8, 12, 23, 36, 958, DateTimeKind.Utc).AddTicks(8250));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedOn",
                value: new DateTime(2023, 8, 8, 12, 23, 36, 958, DateTimeKind.Utc).AddTicks(8258));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddedOn",
                value: new DateTime(2023, 8, 8, 12, 23, 36, 958, DateTimeKind.Utc).AddTicks(8261));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddedOn",
                value: new DateTime(2023, 8, 8, 12, 23, 36, 958, DateTimeKind.Utc).AddTicks(8263));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 5,
                column: "AddedOn",
                value: new DateTime(2023, 8, 8, 12, 23, 36, 958, DateTimeKind.Utc).AddTicks(8268));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 6,
                column: "AddedOn",
                value: new DateTime(2023, 8, 8, 12, 23, 36, 958, DateTimeKind.Utc).AddTicks(8270));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 7,
                column: "AddedOn",
                value: new DateTime(2023, 8, 8, 12, 23, 36, 958, DateTimeKind.Utc).AddTicks(8272));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 8,
                column: "AddedOn",
                value: new DateTime(2023, 8, 8, 12, 23, 36, 958, DateTimeKind.Utc).AddTicks(8274));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 9,
                column: "AddedOn",
                value: new DateTime(2023, 8, 8, 12, 23, 36, 958, DateTimeKind.Utc).AddTicks(8278));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 10,
                column: "AddedOn",
                value: new DateTime(2023, 8, 8, 12, 23, 36, 958, DateTimeKind.Utc).AddTicks(8280));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 11,
                column: "AddedOn",
                value: new DateTime(2023, 8, 8, 12, 23, 36, 958, DateTimeKind.Utc).AddTicks(8282));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 12,
                column: "AddedOn",
                value: new DateTime(2023, 8, 8, 12, 23, 36, 958, DateTimeKind.Utc).AddTicks(8285));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 13,
                column: "AddedOn",
                value: new DateTime(2023, 8, 8, 12, 23, 36, 958, DateTimeKind.Utc).AddTicks(8287));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedOn",
                value: new DateTime(2023, 8, 8, 12, 23, 36, 958, DateTimeKind.Utc).AddTicks(9100));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedOn",
                value: new DateTime(2023, 8, 8, 12, 23, 36, 958, DateTimeKind.Utc).AddTicks(9112));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddedOn",
                value: new DateTime(2023, 8, 8, 12, 23, 36, 958, DateTimeKind.Utc).AddTicks(9114));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddedOn",
                value: new DateTime(2023, 8, 8, 12, 23, 36, 958, DateTimeKind.Utc).AddTicks(9116));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 5,
                column: "AddedOn",
                value: new DateTime(2023, 8, 8, 12, 23, 36, 958, DateTimeKind.Utc).AddTicks(9121));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 6,
                column: "AddedOn",
                value: new DateTime(2023, 8, 8, 12, 23, 36, 958, DateTimeKind.Utc).AddTicks(9123));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 7,
                column: "AddedOn",
                value: new DateTime(2023, 8, 8, 12, 23, 36, 958, DateTimeKind.Utc).AddTicks(9126));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 8,
                column: "AddedOn",
                value: new DateTime(2023, 8, 8, 12, 23, 36, 958, DateTimeKind.Utc).AddTicks(9128));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 9,
                column: "AddedOn",
                value: new DateTime(2023, 8, 8, 12, 23, 36, 958, DateTimeKind.Utc).AddTicks(9132));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 10,
                column: "AddedOn",
                value: new DateTime(2023, 8, 8, 12, 23, 36, 958, DateTimeKind.Utc).AddTicks(9134));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 11,
                column: "AddedOn",
                value: new DateTime(2023, 8, 8, 12, 23, 36, 958, DateTimeKind.Utc).AddTicks(9136));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 12,
                column: "AddedOn",
                value: new DateTime(2023, 8, 8, 12, 23, 36, 958, DateTimeKind.Utc).AddTicks(9164));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 13,
                column: "AddedOn",
                value: new DateTime(2023, 8, 8, 12, 23, 36, 958, DateTimeKind.Utc).AddTicks(9167));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 14,
                column: "AddedOn",
                value: new DateTime(2023, 8, 8, 12, 23, 36, 958, DateTimeKind.Utc).AddTicks(9169));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 15,
                column: "AddedOn",
                value: new DateTime(2023, 8, 8, 12, 23, 36, 958, DateTimeKind.Utc).AddTicks(9172));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 16,
                column: "AddedOn",
                value: new DateTime(2023, 8, 8, 12, 23, 36, 958, DateTimeKind.Utc).AddTicks(9174));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 17,
                column: "AddedOn",
                value: new DateTime(2023, 8, 8, 12, 23, 36, 958, DateTimeKind.Utc).AddTicks(9177));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 18,
                column: "AddedOn",
                value: new DateTime(2023, 8, 8, 12, 23, 36, 958, DateTimeKind.Utc).AddTicks(9179));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 19,
                column: "AddedOn",
                value: new DateTime(2023, 8, 8, 12, 23, 36, 958, DateTimeKind.Utc).AddTicks(9183));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 20,
                column: "AddedOn",
                value: new DateTime(2023, 8, 8, 12, 23, 36, 958, DateTimeKind.Utc).AddTicks(9185));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedOn",
                value: new DateTime(2023, 8, 8, 12, 23, 36, 958, DateTimeKind.Utc).AddTicks(9939));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedOn",
                value: new DateTime(2023, 8, 8, 12, 23, 36, 958, DateTimeKind.Utc).AddTicks(9947));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddedOn",
                value: new DateTime(2023, 8, 8, 12, 23, 36, 958, DateTimeKind.Utc).AddTicks(9949));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddedOn",
                value: new DateTime(2023, 8, 8, 12, 23, 36, 958, DateTimeKind.Utc).AddTicks(9951));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 5,
                column: "AddedOn",
                value: new DateTime(2023, 8, 8, 12, 23, 36, 958, DateTimeKind.Utc).AddTicks(9955));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 6,
                column: "AddedOn",
                value: new DateTime(2023, 8, 8, 12, 23, 36, 958, DateTimeKind.Utc).AddTicks(9957));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 7,
                column: "AddedOn",
                value: new DateTime(2023, 8, 8, 12, 23, 36, 958, DateTimeKind.Utc).AddTicks(9960));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 8,
                column: "AddedOn",
                value: new DateTime(2023, 8, 8, 12, 23, 36, 958, DateTimeKind.Utc).AddTicks(9962));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 9,
                column: "AddedOn",
                value: new DateTime(2023, 8, 8, 12, 23, 36, 958, DateTimeKind.Utc).AddTicks(9966));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 10,
                column: "AddedOn",
                value: new DateTime(2023, 8, 8, 12, 23, 36, 958, DateTimeKind.Utc).AddTicks(9968));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 11,
                column: "AddedOn",
                value: new DateTime(2023, 8, 8, 12, 23, 36, 958, DateTimeKind.Utc).AddTicks(9970));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 12,
                column: "AddedOn",
                value: new DateTime(2023, 8, 8, 12, 23, 36, 958, DateTimeKind.Utc).AddTicks(9978));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 13,
                column: "AddedOn",
                value: new DateTime(2023, 8, 8, 12, 23, 36, 958, DateTimeKind.Utc).AddTicks(9980));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 14,
                column: "AddedOn",
                value: new DateTime(2023, 8, 8, 12, 23, 36, 958, DateTimeKind.Utc).AddTicks(9982));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 15,
                column: "AddedOn",
                value: new DateTime(2023, 8, 8, 12, 23, 36, 958, DateTimeKind.Utc).AddTicks(9985));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 16,
                column: "AddedOn",
                value: new DateTime(2023, 8, 8, 12, 23, 36, 958, DateTimeKind.Utc).AddTicks(9987));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 17,
                column: "AddedOn",
                value: new DateTime(2023, 8, 8, 12, 23, 36, 958, DateTimeKind.Utc).AddTicks(9989));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 18,
                column: "AddedOn",
                value: new DateTime(2023, 8, 8, 12, 23, 36, 958, DateTimeKind.Utc).AddTicks(9992));

            migrationBuilder.AddForeignKey(
                name: "FK_PcConfigurations_AspNetUsers_ApplicationUserId",
                table: "PcConfigurations",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
