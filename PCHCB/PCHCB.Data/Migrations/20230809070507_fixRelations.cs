using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PCHCB.Data.Migrations
{
    public partial class fixRelations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ConfigurationHardwares",
                table: "ConfigurationHardwares");

            migrationBuilder.DropIndex(
                name: "IX_ConfigurationHardwares_PcConfigurationId",
                table: "ConfigurationHardwares");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "ConfigurationHardwares");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ConfigurationHardwares",
                table: "ConfigurationHardwares",
                columns: new[] { "PcConfigurationId", "CaseId", "CoolerId", "CpuId", "GpuId", "MotherboardId", "PsuId", "RamId", "StorageId" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("73df6910-cc0d-4f98-90a0-748c29bbd618"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "14cecb3a-a02b-432f-93b6-f09f314eb0c6", "AQAAAAEAACcQAAAAEKcUC1pFR/cgPyvNjP2l7QT2yP5cSFtSLEqrhcNXSw57ebxwfXG3XkJrzWQXqu4DWg==" });

            migrationBuilder.UpdateData(
                table: "Cases",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedOn",
                value: new DateTime(2023, 8, 9, 7, 5, 6, 106, DateTimeKind.Utc).AddTicks(5053));

            migrationBuilder.UpdateData(
                table: "Cases",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedOn",
                value: new DateTime(2023, 8, 9, 7, 5, 6, 106, DateTimeKind.Utc).AddTicks(5076));

            migrationBuilder.UpdateData(
                table: "Cases",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddedOn",
                value: new DateTime(2023, 8, 9, 7, 5, 6, 106, DateTimeKind.Utc).AddTicks(5079));

            migrationBuilder.UpdateData(
                table: "Cases",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddedOn",
                value: new DateTime(2023, 8, 9, 7, 5, 6, 106, DateTimeKind.Utc).AddTicks(5082));

            migrationBuilder.UpdateData(
                table: "Cases",
                keyColumn: "Id",
                keyValue: 5,
                column: "AddedOn",
                value: new DateTime(2023, 8, 9, 7, 5, 6, 106, DateTimeKind.Utc).AddTicks(5088));

            migrationBuilder.UpdateData(
                table: "Coolers",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedOn",
                value: new DateTime(2023, 8, 9, 7, 5, 6, 107, DateTimeKind.Utc).AddTicks(7677));

            migrationBuilder.UpdateData(
                table: "Coolers",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedOn",
                value: new DateTime(2023, 8, 9, 7, 5, 6, 107, DateTimeKind.Utc).AddTicks(7689));

            migrationBuilder.UpdateData(
                table: "Coolers",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddedOn",
                value: new DateTime(2023, 8, 9, 7, 5, 6, 107, DateTimeKind.Utc).AddTicks(7692));

            migrationBuilder.UpdateData(
                table: "Coolers",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddedOn",
                value: new DateTime(2023, 8, 9, 7, 5, 6, 107, DateTimeKind.Utc).AddTicks(7695));

            migrationBuilder.UpdateData(
                table: "Coolers",
                keyColumn: "Id",
                keyValue: 5,
                column: "AddedOn",
                value: new DateTime(2023, 8, 9, 7, 5, 6, 107, DateTimeKind.Utc).AddTicks(7701));

            migrationBuilder.UpdateData(
                table: "Coolers",
                keyColumn: "Id",
                keyValue: 6,
                column: "AddedOn",
                value: new DateTime(2023, 8, 9, 7, 5, 6, 107, DateTimeKind.Utc).AddTicks(7704));

            migrationBuilder.UpdateData(
                table: "Coolers",
                keyColumn: "Id",
                keyValue: 7,
                column: "AddedOn",
                value: new DateTime(2023, 8, 9, 7, 5, 6, 107, DateTimeKind.Utc).AddTicks(7707));

            migrationBuilder.UpdateData(
                table: "Coolers",
                keyColumn: "Id",
                keyValue: 8,
                column: "AddedOn",
                value: new DateTime(2023, 8, 9, 7, 5, 6, 107, DateTimeKind.Utc).AddTicks(7709));

            migrationBuilder.UpdateData(
                table: "Coolers",
                keyColumn: "Id",
                keyValue: 9,
                column: "AddedOn",
                value: new DateTime(2023, 8, 9, 7, 5, 6, 107, DateTimeKind.Utc).AddTicks(7713));

            migrationBuilder.UpdateData(
                table: "Coolers",
                keyColumn: "Id",
                keyValue: 10,
                column: "AddedOn",
                value: new DateTime(2023, 8, 9, 7, 5, 6, 107, DateTimeKind.Utc).AddTicks(7716));

            migrationBuilder.UpdateData(
                table: "Cpus",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedOn",
                value: new DateTime(2023, 8, 9, 7, 5, 6, 107, DateTimeKind.Utc).AddTicks(8464));

            migrationBuilder.UpdateData(
                table: "Cpus",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedOn",
                value: new DateTime(2023, 8, 9, 7, 5, 6, 107, DateTimeKind.Utc).AddTicks(8471));

            migrationBuilder.UpdateData(
                table: "Cpus",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddedOn",
                value: new DateTime(2023, 8, 9, 7, 5, 6, 107, DateTimeKind.Utc).AddTicks(8473));

            migrationBuilder.UpdateData(
                table: "Cpus",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddedOn",
                value: new DateTime(2023, 8, 9, 7, 5, 6, 107, DateTimeKind.Utc).AddTicks(8476));

            migrationBuilder.UpdateData(
                table: "Cpus",
                keyColumn: "Id",
                keyValue: 5,
                column: "AddedOn",
                value: new DateTime(2023, 8, 9, 7, 5, 6, 107, DateTimeKind.Utc).AddTicks(8478));

            migrationBuilder.UpdateData(
                table: "Cpus",
                keyColumn: "Id",
                keyValue: 6,
                column: "AddedOn",
                value: new DateTime(2023, 8, 9, 7, 5, 6, 107, DateTimeKind.Utc).AddTicks(8481));

            migrationBuilder.UpdateData(
                table: "Cpus",
                keyColumn: "Id",
                keyValue: 7,
                column: "AddedOn",
                value: new DateTime(2023, 8, 9, 7, 5, 6, 107, DateTimeKind.Utc).AddTicks(8483));

            migrationBuilder.UpdateData(
                table: "Gpus",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedOn",
                value: new DateTime(2023, 8, 9, 7, 5, 6, 107, DateTimeKind.Utc).AddTicks(9327));

            migrationBuilder.UpdateData(
                table: "Gpus",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedOn",
                value: new DateTime(2023, 8, 9, 7, 5, 6, 107, DateTimeKind.Utc).AddTicks(9337));

            migrationBuilder.UpdateData(
                table: "Gpus",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddedOn",
                value: new DateTime(2023, 8, 9, 7, 5, 6, 107, DateTimeKind.Utc).AddTicks(9340));

            migrationBuilder.UpdateData(
                table: "Gpus",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddedOn",
                value: new DateTime(2023, 8, 9, 7, 5, 6, 107, DateTimeKind.Utc).AddTicks(9344));

            migrationBuilder.UpdateData(
                table: "Gpus",
                keyColumn: "Id",
                keyValue: 5,
                column: "AddedOn",
                value: new DateTime(2023, 8, 9, 7, 5, 6, 107, DateTimeKind.Utc).AddTicks(9349));

            migrationBuilder.UpdateData(
                table: "Gpus",
                keyColumn: "Id",
                keyValue: 6,
                column: "AddedOn",
                value: new DateTime(2023, 8, 9, 7, 5, 6, 107, DateTimeKind.Utc).AddTicks(9353));

            migrationBuilder.UpdateData(
                table: "Gpus",
                keyColumn: "Id",
                keyValue: 7,
                column: "AddedOn",
                value: new DateTime(2023, 8, 9, 7, 5, 6, 107, DateTimeKind.Utc).AddTicks(9356));

            migrationBuilder.UpdateData(
                table: "Gpus",
                keyColumn: "Id",
                keyValue: 8,
                column: "AddedOn",
                value: new DateTime(2023, 8, 9, 7, 5, 6, 107, DateTimeKind.Utc).AddTicks(9392));

            migrationBuilder.UpdateData(
                table: "Motherboards",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedOn",
                value: new DateTime(2023, 8, 9, 7, 5, 6, 108, DateTimeKind.Utc).AddTicks(373));

            migrationBuilder.UpdateData(
                table: "Motherboards",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedOn",
                value: new DateTime(2023, 8, 9, 7, 5, 6, 108, DateTimeKind.Utc).AddTicks(381));

            migrationBuilder.UpdateData(
                table: "Motherboards",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddedOn",
                value: new DateTime(2023, 8, 9, 7, 5, 6, 108, DateTimeKind.Utc).AddTicks(384));

            migrationBuilder.UpdateData(
                table: "Motherboards",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddedOn",
                value: new DateTime(2023, 8, 9, 7, 5, 6, 108, DateTimeKind.Utc).AddTicks(387));

            migrationBuilder.UpdateData(
                table: "Motherboards",
                keyColumn: "Id",
                keyValue: 5,
                column: "AddedOn",
                value: new DateTime(2023, 8, 9, 7, 5, 6, 108, DateTimeKind.Utc).AddTicks(390));

            migrationBuilder.UpdateData(
                table: "Motherboards",
                keyColumn: "Id",
                keyValue: 6,
                column: "AddedOn",
                value: new DateTime(2023, 8, 9, 7, 5, 6, 108, DateTimeKind.Utc).AddTicks(394));

            migrationBuilder.UpdateData(
                table: "Motherboards",
                keyColumn: "Id",
                keyValue: 7,
                column: "AddedOn",
                value: new DateTime(2023, 8, 9, 7, 5, 6, 108, DateTimeKind.Utc).AddTicks(397));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedOn",
                value: new DateTime(2023, 8, 9, 7, 5, 6, 108, DateTimeKind.Utc).AddTicks(1368));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedOn",
                value: new DateTime(2023, 8, 9, 7, 5, 6, 108, DateTimeKind.Utc).AddTicks(1379));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddedOn",
                value: new DateTime(2023, 8, 9, 7, 5, 6, 108, DateTimeKind.Utc).AddTicks(1384));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddedOn",
                value: new DateTime(2023, 8, 9, 7, 5, 6, 108, DateTimeKind.Utc).AddTicks(1387));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 5,
                column: "AddedOn",
                value: new DateTime(2023, 8, 9, 7, 5, 6, 108, DateTimeKind.Utc).AddTicks(1391));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 6,
                column: "AddedOn",
                value: new DateTime(2023, 8, 9, 7, 5, 6, 108, DateTimeKind.Utc).AddTicks(1394));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 7,
                column: "AddedOn",
                value: new DateTime(2023, 8, 9, 7, 5, 6, 108, DateTimeKind.Utc).AddTicks(1396));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 8,
                column: "AddedOn",
                value: new DateTime(2023, 8, 9, 7, 5, 6, 108, DateTimeKind.Utc).AddTicks(1399));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 9,
                column: "AddedOn",
                value: new DateTime(2023, 8, 9, 7, 5, 6, 108, DateTimeKind.Utc).AddTicks(1403));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 10,
                column: "AddedOn",
                value: new DateTime(2023, 8, 9, 7, 5, 6, 108, DateTimeKind.Utc).AddTicks(1405));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 11,
                column: "AddedOn",
                value: new DateTime(2023, 8, 9, 7, 5, 6, 108, DateTimeKind.Utc).AddTicks(1407));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 12,
                column: "AddedOn",
                value: new DateTime(2023, 8, 9, 7, 5, 6, 108, DateTimeKind.Utc).AddTicks(1409));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 13,
                column: "AddedOn",
                value: new DateTime(2023, 8, 9, 7, 5, 6, 108, DateTimeKind.Utc).AddTicks(1412));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedOn",
                value: new DateTime(2023, 8, 9, 7, 5, 6, 108, DateTimeKind.Utc).AddTicks(2223));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedOn",
                value: new DateTime(2023, 8, 9, 7, 5, 6, 108, DateTimeKind.Utc).AddTicks(2230));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddedOn",
                value: new DateTime(2023, 8, 9, 7, 5, 6, 108, DateTimeKind.Utc).AddTicks(2233));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddedOn",
                value: new DateTime(2023, 8, 9, 7, 5, 6, 108, DateTimeKind.Utc).AddTicks(2235));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 5,
                column: "AddedOn",
                value: new DateTime(2023, 8, 9, 7, 5, 6, 108, DateTimeKind.Utc).AddTicks(2240));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 6,
                column: "AddedOn",
                value: new DateTime(2023, 8, 9, 7, 5, 6, 108, DateTimeKind.Utc).AddTicks(2242));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 7,
                column: "AddedOn",
                value: new DateTime(2023, 8, 9, 7, 5, 6, 108, DateTimeKind.Utc).AddTicks(2245));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 8,
                column: "AddedOn",
                value: new DateTime(2023, 8, 9, 7, 5, 6, 108, DateTimeKind.Utc).AddTicks(2247));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 9,
                column: "AddedOn",
                value: new DateTime(2023, 8, 9, 7, 5, 6, 108, DateTimeKind.Utc).AddTicks(2281));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 10,
                column: "AddedOn",
                value: new DateTime(2023, 8, 9, 7, 5, 6, 108, DateTimeKind.Utc).AddTicks(2284));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 11,
                column: "AddedOn",
                value: new DateTime(2023, 8, 9, 7, 5, 6, 108, DateTimeKind.Utc).AddTicks(2286));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 12,
                column: "AddedOn",
                value: new DateTime(2023, 8, 9, 7, 5, 6, 108, DateTimeKind.Utc).AddTicks(2288));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 13,
                column: "AddedOn",
                value: new DateTime(2023, 8, 9, 7, 5, 6, 108, DateTimeKind.Utc).AddTicks(2291));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 14,
                column: "AddedOn",
                value: new DateTime(2023, 8, 9, 7, 5, 6, 108, DateTimeKind.Utc).AddTicks(2293));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 15,
                column: "AddedOn",
                value: new DateTime(2023, 8, 9, 7, 5, 6, 108, DateTimeKind.Utc).AddTicks(2296));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 16,
                column: "AddedOn",
                value: new DateTime(2023, 8, 9, 7, 5, 6, 108, DateTimeKind.Utc).AddTicks(2298));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 17,
                column: "AddedOn",
                value: new DateTime(2023, 8, 9, 7, 5, 6, 108, DateTimeKind.Utc).AddTicks(2301));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 18,
                column: "AddedOn",
                value: new DateTime(2023, 8, 9, 7, 5, 6, 108, DateTimeKind.Utc).AddTicks(2303));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 19,
                column: "AddedOn",
                value: new DateTime(2023, 8, 9, 7, 5, 6, 108, DateTimeKind.Utc).AddTicks(2307));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 20,
                column: "AddedOn",
                value: new DateTime(2023, 8, 9, 7, 5, 6, 108, DateTimeKind.Utc).AddTicks(2310));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedOn",
                value: new DateTime(2023, 8, 9, 7, 5, 6, 108, DateTimeKind.Utc).AddTicks(3118));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedOn",
                value: new DateTime(2023, 8, 9, 7, 5, 6, 108, DateTimeKind.Utc).AddTicks(3128));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddedOn",
                value: new DateTime(2023, 8, 9, 7, 5, 6, 108, DateTimeKind.Utc).AddTicks(3130));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddedOn",
                value: new DateTime(2023, 8, 9, 7, 5, 6, 108, DateTimeKind.Utc).AddTicks(3132));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 5,
                column: "AddedOn",
                value: new DateTime(2023, 8, 9, 7, 5, 6, 108, DateTimeKind.Utc).AddTicks(3137));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 6,
                column: "AddedOn",
                value: new DateTime(2023, 8, 9, 7, 5, 6, 108, DateTimeKind.Utc).AddTicks(3139));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 7,
                column: "AddedOn",
                value: new DateTime(2023, 8, 9, 7, 5, 6, 108, DateTimeKind.Utc).AddTicks(3141));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 8,
                column: "AddedOn",
                value: new DateTime(2023, 8, 9, 7, 5, 6, 108, DateTimeKind.Utc).AddTicks(3144));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 9,
                column: "AddedOn",
                value: new DateTime(2023, 8, 9, 7, 5, 6, 108, DateTimeKind.Utc).AddTicks(3147));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 10,
                column: "AddedOn",
                value: new DateTime(2023, 8, 9, 7, 5, 6, 108, DateTimeKind.Utc).AddTicks(3149));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 11,
                column: "AddedOn",
                value: new DateTime(2023, 8, 9, 7, 5, 6, 108, DateTimeKind.Utc).AddTicks(3151));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 12,
                column: "AddedOn",
                value: new DateTime(2023, 8, 9, 7, 5, 6, 108, DateTimeKind.Utc).AddTicks(3156));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 13,
                column: "AddedOn",
                value: new DateTime(2023, 8, 9, 7, 5, 6, 108, DateTimeKind.Utc).AddTicks(3158));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 14,
                column: "AddedOn",
                value: new DateTime(2023, 8, 9, 7, 5, 6, 108, DateTimeKind.Utc).AddTicks(3160));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 15,
                column: "AddedOn",
                value: new DateTime(2023, 8, 9, 7, 5, 6, 108, DateTimeKind.Utc).AddTicks(3162));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 16,
                column: "AddedOn",
                value: new DateTime(2023, 8, 9, 7, 5, 6, 108, DateTimeKind.Utc).AddTicks(3165));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 17,
                column: "AddedOn",
                value: new DateTime(2023, 8, 9, 7, 5, 6, 108, DateTimeKind.Utc).AddTicks(3167));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 18,
                column: "AddedOn",
                value: new DateTime(2023, 8, 9, 7, 5, 6, 108, DateTimeKind.Utc).AddTicks(3169));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ConfigurationHardwares",
                table: "ConfigurationHardwares");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "ConfigurationHardwares",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ConfigurationHardwares",
                table: "ConfigurationHardwares",
                columns: new[] { "Id", "PcConfigurationId", "CaseId", "CoolerId", "CpuId", "GpuId", "MotherboardId", "PsuId", "RamId", "StorageId" });

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

            migrationBuilder.CreateIndex(
                name: "IX_ConfigurationHardwares_PcConfigurationId",
                table: "ConfigurationHardwares",
                column: "PcConfigurationId");
        }
    }
}
