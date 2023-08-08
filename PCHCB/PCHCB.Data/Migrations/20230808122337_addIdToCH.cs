using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PCHCB.Data.Migrations
{
    public partial class addIdToCH : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateIndex(
                name: "IX_ConfigurationHardwares_PcConfigurationId",
                table: "ConfigurationHardwares",
                column: "PcConfigurationId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { "c3151b89-13ef-4a77-909a-d7db0c88c818", "AQAAAAEAACcQAAAAEKafBHcwWiljCZwKgAll2m2OOWHb8Z/LSBaRRSwmuHmnTniwnk/zckvpJaLUSlJSFw==" });

            migrationBuilder.UpdateData(
                table: "Cases",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedOn",
                value: new DateTime(2023, 8, 3, 19, 59, 46, 109, DateTimeKind.Utc).AddTicks(3803));

            migrationBuilder.UpdateData(
                table: "Cases",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedOn",
                value: new DateTime(2023, 8, 3, 19, 59, 46, 109, DateTimeKind.Utc).AddTicks(3831));

            migrationBuilder.UpdateData(
                table: "Cases",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddedOn",
                value: new DateTime(2023, 8, 3, 19, 59, 46, 109, DateTimeKind.Utc).AddTicks(3834));

            migrationBuilder.UpdateData(
                table: "Cases",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddedOn",
                value: new DateTime(2023, 8, 3, 19, 59, 46, 109, DateTimeKind.Utc).AddTicks(3837));

            migrationBuilder.UpdateData(
                table: "Cases",
                keyColumn: "Id",
                keyValue: 5,
                column: "AddedOn",
                value: new DateTime(2023, 8, 3, 19, 59, 46, 109, DateTimeKind.Utc).AddTicks(3842));

            migrationBuilder.UpdateData(
                table: "Coolers",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedOn",
                value: new DateTime(2023, 8, 3, 19, 59, 46, 111, DateTimeKind.Utc).AddTicks(2514));

            migrationBuilder.UpdateData(
                table: "Coolers",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedOn",
                value: new DateTime(2023, 8, 3, 19, 59, 46, 111, DateTimeKind.Utc).AddTicks(2532));

            migrationBuilder.UpdateData(
                table: "Coolers",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddedOn",
                value: new DateTime(2023, 8, 3, 19, 59, 46, 111, DateTimeKind.Utc).AddTicks(2535));

            migrationBuilder.UpdateData(
                table: "Coolers",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddedOn",
                value: new DateTime(2023, 8, 3, 19, 59, 46, 111, DateTimeKind.Utc).AddTicks(2537));

            migrationBuilder.UpdateData(
                table: "Coolers",
                keyColumn: "Id",
                keyValue: 5,
                column: "AddedOn",
                value: new DateTime(2023, 8, 3, 19, 59, 46, 111, DateTimeKind.Utc).AddTicks(2543));

            migrationBuilder.UpdateData(
                table: "Coolers",
                keyColumn: "Id",
                keyValue: 6,
                column: "AddedOn",
                value: new DateTime(2023, 8, 3, 19, 59, 46, 111, DateTimeKind.Utc).AddTicks(2545));

            migrationBuilder.UpdateData(
                table: "Coolers",
                keyColumn: "Id",
                keyValue: 7,
                column: "AddedOn",
                value: new DateTime(2023, 8, 3, 19, 59, 46, 111, DateTimeKind.Utc).AddTicks(2548));

            migrationBuilder.UpdateData(
                table: "Coolers",
                keyColumn: "Id",
                keyValue: 8,
                column: "AddedOn",
                value: new DateTime(2023, 8, 3, 19, 59, 46, 111, DateTimeKind.Utc).AddTicks(2551));

            migrationBuilder.UpdateData(
                table: "Coolers",
                keyColumn: "Id",
                keyValue: 9,
                column: "AddedOn",
                value: new DateTime(2023, 8, 3, 19, 59, 46, 111, DateTimeKind.Utc).AddTicks(2555));

            migrationBuilder.UpdateData(
                table: "Coolers",
                keyColumn: "Id",
                keyValue: 10,
                column: "AddedOn",
                value: new DateTime(2023, 8, 3, 19, 59, 46, 111, DateTimeKind.Utc).AddTicks(2557));

            migrationBuilder.UpdateData(
                table: "Cpus",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedOn",
                value: new DateTime(2023, 8, 3, 19, 59, 46, 111, DateTimeKind.Utc).AddTicks(3380));

            migrationBuilder.UpdateData(
                table: "Cpus",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedOn",
                value: new DateTime(2023, 8, 3, 19, 59, 46, 111, DateTimeKind.Utc).AddTicks(3389));

            migrationBuilder.UpdateData(
                table: "Cpus",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddedOn",
                value: new DateTime(2023, 8, 3, 19, 59, 46, 111, DateTimeKind.Utc).AddTicks(3392));

            migrationBuilder.UpdateData(
                table: "Cpus",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddedOn",
                value: new DateTime(2023, 8, 3, 19, 59, 46, 111, DateTimeKind.Utc).AddTicks(3394));

            migrationBuilder.UpdateData(
                table: "Cpus",
                keyColumn: "Id",
                keyValue: 5,
                column: "AddedOn",
                value: new DateTime(2023, 8, 3, 19, 59, 46, 111, DateTimeKind.Utc).AddTicks(3397));

            migrationBuilder.UpdateData(
                table: "Cpus",
                keyColumn: "Id",
                keyValue: 6,
                column: "AddedOn",
                value: new DateTime(2023, 8, 3, 19, 59, 46, 111, DateTimeKind.Utc).AddTicks(3400));

            migrationBuilder.UpdateData(
                table: "Cpus",
                keyColumn: "Id",
                keyValue: 7,
                column: "AddedOn",
                value: new DateTime(2023, 8, 3, 19, 59, 46, 111, DateTimeKind.Utc).AddTicks(3403));

            migrationBuilder.UpdateData(
                table: "Gpus",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedOn",
                value: new DateTime(2023, 8, 3, 19, 59, 46, 111, DateTimeKind.Utc).AddTicks(4266));

            migrationBuilder.UpdateData(
                table: "Gpus",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedOn",
                value: new DateTime(2023, 8, 3, 19, 59, 46, 111, DateTimeKind.Utc).AddTicks(4274));

            migrationBuilder.UpdateData(
                table: "Gpus",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddedOn",
                value: new DateTime(2023, 8, 3, 19, 59, 46, 111, DateTimeKind.Utc).AddTicks(4277));

            migrationBuilder.UpdateData(
                table: "Gpus",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddedOn",
                value: new DateTime(2023, 8, 3, 19, 59, 46, 111, DateTimeKind.Utc).AddTicks(4280));

            migrationBuilder.UpdateData(
                table: "Gpus",
                keyColumn: "Id",
                keyValue: 5,
                column: "AddedOn",
                value: new DateTime(2023, 8, 3, 19, 59, 46, 111, DateTimeKind.Utc).AddTicks(4284));

            migrationBuilder.UpdateData(
                table: "Gpus",
                keyColumn: "Id",
                keyValue: 6,
                column: "AddedOn",
                value: new DateTime(2023, 8, 3, 19, 59, 46, 111, DateTimeKind.Utc).AddTicks(4287));

            migrationBuilder.UpdateData(
                table: "Gpus",
                keyColumn: "Id",
                keyValue: 7,
                column: "AddedOn",
                value: new DateTime(2023, 8, 3, 19, 59, 46, 111, DateTimeKind.Utc).AddTicks(4289));

            migrationBuilder.UpdateData(
                table: "Gpus",
                keyColumn: "Id",
                keyValue: 8,
                column: "AddedOn",
                value: new DateTime(2023, 8, 3, 19, 59, 46, 111, DateTimeKind.Utc).AddTicks(4292));

            migrationBuilder.UpdateData(
                table: "Motherboards",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedOn",
                value: new DateTime(2023, 8, 3, 19, 59, 46, 111, DateTimeKind.Utc).AddTicks(5088));

            migrationBuilder.UpdateData(
                table: "Motherboards",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedOn",
                value: new DateTime(2023, 8, 3, 19, 59, 46, 111, DateTimeKind.Utc).AddTicks(5095));

            migrationBuilder.UpdateData(
                table: "Motherboards",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddedOn",
                value: new DateTime(2023, 8, 3, 19, 59, 46, 111, DateTimeKind.Utc).AddTicks(5098));

            migrationBuilder.UpdateData(
                table: "Motherboards",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddedOn",
                value: new DateTime(2023, 8, 3, 19, 59, 46, 111, DateTimeKind.Utc).AddTicks(5100));

            migrationBuilder.UpdateData(
                table: "Motherboards",
                keyColumn: "Id",
                keyValue: 5,
                column: "AddedOn",
                value: new DateTime(2023, 8, 3, 19, 59, 46, 111, DateTimeKind.Utc).AddTicks(5102));

            migrationBuilder.UpdateData(
                table: "Motherboards",
                keyColumn: "Id",
                keyValue: 6,
                column: "AddedOn",
                value: new DateTime(2023, 8, 3, 19, 59, 46, 111, DateTimeKind.Utc).AddTicks(5106));

            migrationBuilder.UpdateData(
                table: "Motherboards",
                keyColumn: "Id",
                keyValue: 7,
                column: "AddedOn",
                value: new DateTime(2023, 8, 3, 19, 59, 46, 111, DateTimeKind.Utc).AddTicks(5108));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedOn",
                value: new DateTime(2023, 8, 3, 19, 59, 46, 111, DateTimeKind.Utc).AddTicks(5871));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedOn",
                value: new DateTime(2023, 8, 3, 19, 59, 46, 111, DateTimeKind.Utc).AddTicks(5879));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddedOn",
                value: new DateTime(2023, 8, 3, 19, 59, 46, 111, DateTimeKind.Utc).AddTicks(5881));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddedOn",
                value: new DateTime(2023, 8, 3, 19, 59, 46, 111, DateTimeKind.Utc).AddTicks(5884));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 5,
                column: "AddedOn",
                value: new DateTime(2023, 8, 3, 19, 59, 46, 111, DateTimeKind.Utc).AddTicks(5888));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 6,
                column: "AddedOn",
                value: new DateTime(2023, 8, 3, 19, 59, 46, 111, DateTimeKind.Utc).AddTicks(5890));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 7,
                column: "AddedOn",
                value: new DateTime(2023, 8, 3, 19, 59, 46, 111, DateTimeKind.Utc).AddTicks(5893));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 8,
                column: "AddedOn",
                value: new DateTime(2023, 8, 3, 19, 59, 46, 111, DateTimeKind.Utc).AddTicks(5895));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 9,
                column: "AddedOn",
                value: new DateTime(2023, 8, 3, 19, 59, 46, 111, DateTimeKind.Utc).AddTicks(5898));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 10,
                column: "AddedOn",
                value: new DateTime(2023, 8, 3, 19, 59, 46, 111, DateTimeKind.Utc).AddTicks(5901));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 11,
                column: "AddedOn",
                value: new DateTime(2023, 8, 3, 19, 59, 46, 111, DateTimeKind.Utc).AddTicks(5903));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 12,
                column: "AddedOn",
                value: new DateTime(2023, 8, 3, 19, 59, 46, 111, DateTimeKind.Utc).AddTicks(5905));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 13,
                column: "AddedOn",
                value: new DateTime(2023, 8, 3, 19, 59, 46, 111, DateTimeKind.Utc).AddTicks(5907));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedOn",
                value: new DateTime(2023, 8, 3, 19, 59, 46, 111, DateTimeKind.Utc).AddTicks(6663));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedOn",
                value: new DateTime(2023, 8, 3, 19, 59, 46, 111, DateTimeKind.Utc).AddTicks(6674));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddedOn",
                value: new DateTime(2023, 8, 3, 19, 59, 46, 111, DateTimeKind.Utc).AddTicks(6677));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddedOn",
                value: new DateTime(2023, 8, 3, 19, 59, 46, 111, DateTimeKind.Utc).AddTicks(6679));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 5,
                column: "AddedOn",
                value: new DateTime(2023, 8, 3, 19, 59, 46, 111, DateTimeKind.Utc).AddTicks(6684));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 6,
                column: "AddedOn",
                value: new DateTime(2023, 8, 3, 19, 59, 46, 111, DateTimeKind.Utc).AddTicks(6686));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 7,
                column: "AddedOn",
                value: new DateTime(2023, 8, 3, 19, 59, 46, 111, DateTimeKind.Utc).AddTicks(6688));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 8,
                column: "AddedOn",
                value: new DateTime(2023, 8, 3, 19, 59, 46, 111, DateTimeKind.Utc).AddTicks(6691));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 9,
                column: "AddedOn",
                value: new DateTime(2023, 8, 3, 19, 59, 46, 111, DateTimeKind.Utc).AddTicks(6695));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 10,
                column: "AddedOn",
                value: new DateTime(2023, 8, 3, 19, 59, 46, 111, DateTimeKind.Utc).AddTicks(6697));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 11,
                column: "AddedOn",
                value: new DateTime(2023, 8, 3, 19, 59, 46, 111, DateTimeKind.Utc).AddTicks(6699));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 12,
                column: "AddedOn",
                value: new DateTime(2023, 8, 3, 19, 59, 46, 111, DateTimeKind.Utc).AddTicks(6734));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 13,
                column: "AddedOn",
                value: new DateTime(2023, 8, 3, 19, 59, 46, 111, DateTimeKind.Utc).AddTicks(6737));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 14,
                column: "AddedOn",
                value: new DateTime(2023, 8, 3, 19, 59, 46, 111, DateTimeKind.Utc).AddTicks(6739));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 15,
                column: "AddedOn",
                value: new DateTime(2023, 8, 3, 19, 59, 46, 111, DateTimeKind.Utc).AddTicks(6742));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 16,
                column: "AddedOn",
                value: new DateTime(2023, 8, 3, 19, 59, 46, 111, DateTimeKind.Utc).AddTicks(6744));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 17,
                column: "AddedOn",
                value: new DateTime(2023, 8, 3, 19, 59, 46, 111, DateTimeKind.Utc).AddTicks(6747));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 18,
                column: "AddedOn",
                value: new DateTime(2023, 8, 3, 19, 59, 46, 111, DateTimeKind.Utc).AddTicks(6749));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 19,
                column: "AddedOn",
                value: new DateTime(2023, 8, 3, 19, 59, 46, 111, DateTimeKind.Utc).AddTicks(6754));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 20,
                column: "AddedOn",
                value: new DateTime(2023, 8, 3, 19, 59, 46, 111, DateTimeKind.Utc).AddTicks(6756));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedOn",
                value: new DateTime(2023, 8, 3, 19, 59, 46, 111, DateTimeKind.Utc).AddTicks(7530));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedOn",
                value: new DateTime(2023, 8, 3, 19, 59, 46, 111, DateTimeKind.Utc).AddTicks(7537));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddedOn",
                value: new DateTime(2023, 8, 3, 19, 59, 46, 111, DateTimeKind.Utc).AddTicks(7540));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddedOn",
                value: new DateTime(2023, 8, 3, 19, 59, 46, 111, DateTimeKind.Utc).AddTicks(7542));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 5,
                column: "AddedOn",
                value: new DateTime(2023, 8, 3, 19, 59, 46, 111, DateTimeKind.Utc).AddTicks(7546));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 6,
                column: "AddedOn",
                value: new DateTime(2023, 8, 3, 19, 59, 46, 111, DateTimeKind.Utc).AddTicks(7548));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 7,
                column: "AddedOn",
                value: new DateTime(2023, 8, 3, 19, 59, 46, 111, DateTimeKind.Utc).AddTicks(7551));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 8,
                column: "AddedOn",
                value: new DateTime(2023, 8, 3, 19, 59, 46, 111, DateTimeKind.Utc).AddTicks(7553));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 9,
                column: "AddedOn",
                value: new DateTime(2023, 8, 3, 19, 59, 46, 111, DateTimeKind.Utc).AddTicks(7556));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 10,
                column: "AddedOn",
                value: new DateTime(2023, 8, 3, 19, 59, 46, 111, DateTimeKind.Utc).AddTicks(7559));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 11,
                column: "AddedOn",
                value: new DateTime(2023, 8, 3, 19, 59, 46, 111, DateTimeKind.Utc).AddTicks(7561));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 12,
                column: "AddedOn",
                value: new DateTime(2023, 8, 3, 19, 59, 46, 111, DateTimeKind.Utc).AddTicks(7567));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 13,
                column: "AddedOn",
                value: new DateTime(2023, 8, 3, 19, 59, 46, 111, DateTimeKind.Utc).AddTicks(7569));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 14,
                column: "AddedOn",
                value: new DateTime(2023, 8, 3, 19, 59, 46, 111, DateTimeKind.Utc).AddTicks(7572));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 15,
                column: "AddedOn",
                value: new DateTime(2023, 8, 3, 19, 59, 46, 111, DateTimeKind.Utc).AddTicks(7574));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 16,
                column: "AddedOn",
                value: new DateTime(2023, 8, 3, 19, 59, 46, 111, DateTimeKind.Utc).AddTicks(7576));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 17,
                column: "AddedOn",
                value: new DateTime(2023, 8, 3, 19, 59, 46, 111, DateTimeKind.Utc).AddTicks(7579));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 18,
                column: "AddedOn",
                value: new DateTime(2023, 8, 3, 19, 59, 46, 111, DateTimeKind.Utc).AddTicks(7581));
        }
    }
}
