using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PCHCB.Data.Migrations
{
    public partial class addedMoreValidationsInModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Cases",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedOn",
                value: new DateTime(2023, 7, 16, 8, 57, 7, 951, DateTimeKind.Utc).AddTicks(8085));

            migrationBuilder.UpdateData(
                table: "Cases",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedOn",
                value: new DateTime(2023, 7, 16, 8, 57, 7, 951, DateTimeKind.Utc).AddTicks(8109));

            migrationBuilder.UpdateData(
                table: "Cases",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddedOn",
                value: new DateTime(2023, 7, 16, 8, 57, 7, 951, DateTimeKind.Utc).AddTicks(8112));

            migrationBuilder.UpdateData(
                table: "Cases",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddedOn",
                value: new DateTime(2023, 7, 16, 8, 57, 7, 951, DateTimeKind.Utc).AddTicks(8115));

            migrationBuilder.UpdateData(
                table: "Cases",
                keyColumn: "Id",
                keyValue: 5,
                column: "AddedOn",
                value: new DateTime(2023, 7, 16, 8, 57, 7, 951, DateTimeKind.Utc).AddTicks(8121));

            migrationBuilder.UpdateData(
                table: "Coolers",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedOn",
                value: new DateTime(2023, 7, 16, 8, 57, 7, 953, DateTimeKind.Utc).AddTicks(1248));

            migrationBuilder.UpdateData(
                table: "Coolers",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedOn",
                value: new DateTime(2023, 7, 16, 8, 57, 7, 953, DateTimeKind.Utc).AddTicks(1264));

            migrationBuilder.UpdateData(
                table: "Coolers",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddedOn",
                value: new DateTime(2023, 7, 16, 8, 57, 7, 953, DateTimeKind.Utc).AddTicks(1266));

            migrationBuilder.UpdateData(
                table: "Coolers",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddedOn",
                value: new DateTime(2023, 7, 16, 8, 57, 7, 953, DateTimeKind.Utc).AddTicks(1269));

            migrationBuilder.UpdateData(
                table: "Coolers",
                keyColumn: "Id",
                keyValue: 5,
                column: "AddedOn",
                value: new DateTime(2023, 7, 16, 8, 57, 7, 953, DateTimeKind.Utc).AddTicks(1278));

            migrationBuilder.UpdateData(
                table: "Coolers",
                keyColumn: "Id",
                keyValue: 6,
                column: "AddedOn",
                value: new DateTime(2023, 7, 16, 8, 57, 7, 953, DateTimeKind.Utc).AddTicks(1280));

            migrationBuilder.UpdateData(
                table: "Coolers",
                keyColumn: "Id",
                keyValue: 7,
                column: "AddedOn",
                value: new DateTime(2023, 7, 16, 8, 57, 7, 953, DateTimeKind.Utc).AddTicks(1283));

            migrationBuilder.UpdateData(
                table: "Coolers",
                keyColumn: "Id",
                keyValue: 8,
                column: "AddedOn",
                value: new DateTime(2023, 7, 16, 8, 57, 7, 953, DateTimeKind.Utc).AddTicks(1285));

            migrationBuilder.UpdateData(
                table: "Coolers",
                keyColumn: "Id",
                keyValue: 9,
                column: "AddedOn",
                value: new DateTime(2023, 7, 16, 8, 57, 7, 953, DateTimeKind.Utc).AddTicks(1289));

            migrationBuilder.UpdateData(
                table: "Coolers",
                keyColumn: "Id",
                keyValue: 10,
                column: "AddedOn",
                value: new DateTime(2023, 7, 16, 8, 57, 7, 953, DateTimeKind.Utc).AddTicks(1291));

            migrationBuilder.UpdateData(
                table: "Cpus",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedOn",
                value: new DateTime(2023, 7, 16, 8, 57, 7, 953, DateTimeKind.Utc).AddTicks(2112));

            migrationBuilder.UpdateData(
                table: "Cpus",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedOn",
                value: new DateTime(2023, 7, 16, 8, 57, 7, 953, DateTimeKind.Utc).AddTicks(2118));

            migrationBuilder.UpdateData(
                table: "Cpus",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddedOn",
                value: new DateTime(2023, 7, 16, 8, 57, 7, 953, DateTimeKind.Utc).AddTicks(2210));

            migrationBuilder.UpdateData(
                table: "Cpus",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddedOn",
                value: new DateTime(2023, 7, 16, 8, 57, 7, 953, DateTimeKind.Utc).AddTicks(2213));

            migrationBuilder.UpdateData(
                table: "Cpus",
                keyColumn: "Id",
                keyValue: 5,
                column: "AddedOn",
                value: new DateTime(2023, 7, 16, 8, 57, 7, 953, DateTimeKind.Utc).AddTicks(2215));

            migrationBuilder.UpdateData(
                table: "Cpus",
                keyColumn: "Id",
                keyValue: 6,
                column: "AddedOn",
                value: new DateTime(2023, 7, 16, 8, 57, 7, 953, DateTimeKind.Utc).AddTicks(2219));

            migrationBuilder.UpdateData(
                table: "Cpus",
                keyColumn: "Id",
                keyValue: 7,
                column: "AddedOn",
                value: new DateTime(2023, 7, 16, 8, 57, 7, 953, DateTimeKind.Utc).AddTicks(2221));

            migrationBuilder.UpdateData(
                table: "Gpus",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedOn",
                value: new DateTime(2023, 7, 16, 8, 57, 7, 953, DateTimeKind.Utc).AddTicks(3011));

            migrationBuilder.UpdateData(
                table: "Gpus",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedOn",
                value: new DateTime(2023, 7, 16, 8, 57, 7, 953, DateTimeKind.Utc).AddTicks(3020));

            migrationBuilder.UpdateData(
                table: "Gpus",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddedOn",
                value: new DateTime(2023, 7, 16, 8, 57, 7, 953, DateTimeKind.Utc).AddTicks(3022));

            migrationBuilder.UpdateData(
                table: "Gpus",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddedOn",
                value: new DateTime(2023, 7, 16, 8, 57, 7, 953, DateTimeKind.Utc).AddTicks(3025));

            migrationBuilder.UpdateData(
                table: "Gpus",
                keyColumn: "Id",
                keyValue: 5,
                column: "AddedOn",
                value: new DateTime(2023, 7, 16, 8, 57, 7, 953, DateTimeKind.Utc).AddTicks(3029));

            migrationBuilder.UpdateData(
                table: "Gpus",
                keyColumn: "Id",
                keyValue: 6,
                column: "AddedOn",
                value: new DateTime(2023, 7, 16, 8, 57, 7, 953, DateTimeKind.Utc).AddTicks(3032));

            migrationBuilder.UpdateData(
                table: "Gpus",
                keyColumn: "Id",
                keyValue: 7,
                column: "AddedOn",
                value: new DateTime(2023, 7, 16, 8, 57, 7, 953, DateTimeKind.Utc).AddTicks(3034));

            migrationBuilder.UpdateData(
                table: "Gpus",
                keyColumn: "Id",
                keyValue: 8,
                column: "AddedOn",
                value: new DateTime(2023, 7, 16, 8, 57, 7, 953, DateTimeKind.Utc).AddTicks(3037));

            migrationBuilder.UpdateData(
                table: "Motherboards",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedOn",
                value: new DateTime(2023, 7, 16, 8, 57, 7, 953, DateTimeKind.Utc).AddTicks(3837));

            migrationBuilder.UpdateData(
                table: "Motherboards",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedOn",
                value: new DateTime(2023, 7, 16, 8, 57, 7, 953, DateTimeKind.Utc).AddTicks(3844));

            migrationBuilder.UpdateData(
                table: "Motherboards",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddedOn",
                value: new DateTime(2023, 7, 16, 8, 57, 7, 953, DateTimeKind.Utc).AddTicks(3847));

            migrationBuilder.UpdateData(
                table: "Motherboards",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddedOn",
                value: new DateTime(2023, 7, 16, 8, 57, 7, 953, DateTimeKind.Utc).AddTicks(3849));

            migrationBuilder.UpdateData(
                table: "Motherboards",
                keyColumn: "Id",
                keyValue: 5,
                column: "AddedOn",
                value: new DateTime(2023, 7, 16, 8, 57, 7, 953, DateTimeKind.Utc).AddTicks(3852));

            migrationBuilder.UpdateData(
                table: "Motherboards",
                keyColumn: "Id",
                keyValue: 6,
                column: "AddedOn",
                value: new DateTime(2023, 7, 16, 8, 57, 7, 953, DateTimeKind.Utc).AddTicks(3856));

            migrationBuilder.UpdateData(
                table: "Motherboards",
                keyColumn: "Id",
                keyValue: 7,
                column: "AddedOn",
                value: new DateTime(2023, 7, 16, 8, 57, 7, 953, DateTimeKind.Utc).AddTicks(3859));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedOn",
                value: new DateTime(2023, 7, 16, 8, 57, 7, 953, DateTimeKind.Utc).AddTicks(4624));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedOn",
                value: new DateTime(2023, 7, 16, 8, 57, 7, 953, DateTimeKind.Utc).AddTicks(4630));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddedOn",
                value: new DateTime(2023, 7, 16, 8, 57, 7, 953, DateTimeKind.Utc).AddTicks(4632));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddedOn",
                value: new DateTime(2023, 7, 16, 8, 57, 7, 953, DateTimeKind.Utc).AddTicks(4635));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 5,
                column: "AddedOn",
                value: new DateTime(2023, 7, 16, 8, 57, 7, 953, DateTimeKind.Utc).AddTicks(4639));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 6,
                column: "AddedOn",
                value: new DateTime(2023, 7, 16, 8, 57, 7, 953, DateTimeKind.Utc).AddTicks(4642));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 7,
                column: "AddedOn",
                value: new DateTime(2023, 7, 16, 8, 57, 7, 953, DateTimeKind.Utc).AddTicks(4644));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 8,
                column: "AddedOn",
                value: new DateTime(2023, 7, 16, 8, 57, 7, 953, DateTimeKind.Utc).AddTicks(4646));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 9,
                column: "AddedOn",
                value: new DateTime(2023, 7, 16, 8, 57, 7, 953, DateTimeKind.Utc).AddTicks(4650));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 10,
                column: "AddedOn",
                value: new DateTime(2023, 7, 16, 8, 57, 7, 953, DateTimeKind.Utc).AddTicks(4652));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 11,
                column: "AddedOn",
                value: new DateTime(2023, 7, 16, 8, 57, 7, 953, DateTimeKind.Utc).AddTicks(4654));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 12,
                column: "AddedOn",
                value: new DateTime(2023, 7, 16, 8, 57, 7, 953, DateTimeKind.Utc).AddTicks(4702));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 13,
                column: "AddedOn",
                value: new DateTime(2023, 7, 16, 8, 57, 7, 953, DateTimeKind.Utc).AddTicks(4704));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedOn",
                value: new DateTime(2023, 7, 16, 8, 57, 7, 953, DateTimeKind.Utc).AddTicks(5479));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedOn",
                value: new DateTime(2023, 7, 16, 8, 57, 7, 953, DateTimeKind.Utc).AddTicks(5486));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddedOn",
                value: new DateTime(2023, 7, 16, 8, 57, 7, 953, DateTimeKind.Utc).AddTicks(5489));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddedOn",
                value: new DateTime(2023, 7, 16, 8, 57, 7, 953, DateTimeKind.Utc).AddTicks(5491));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 5,
                column: "AddedOn",
                value: new DateTime(2023, 7, 16, 8, 57, 7, 953, DateTimeKind.Utc).AddTicks(5495));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 6,
                column: "AddedOn",
                value: new DateTime(2023, 7, 16, 8, 57, 7, 953, DateTimeKind.Utc).AddTicks(5497));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 7,
                column: "AddedOn",
                value: new DateTime(2023, 7, 16, 8, 57, 7, 953, DateTimeKind.Utc).AddTicks(5501));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 8,
                column: "AddedOn",
                value: new DateTime(2023, 7, 16, 8, 57, 7, 953, DateTimeKind.Utc).AddTicks(5503));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 9,
                column: "AddedOn",
                value: new DateTime(2023, 7, 16, 8, 57, 7, 953, DateTimeKind.Utc).AddTicks(5506));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 10,
                column: "AddedOn",
                value: new DateTime(2023, 7, 16, 8, 57, 7, 953, DateTimeKind.Utc).AddTicks(5509));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 11,
                column: "AddedOn",
                value: new DateTime(2023, 7, 16, 8, 57, 7, 953, DateTimeKind.Utc).AddTicks(5511));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 12,
                column: "AddedOn",
                value: new DateTime(2023, 7, 16, 8, 57, 7, 953, DateTimeKind.Utc).AddTicks(5514));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 13,
                column: "AddedOn",
                value: new DateTime(2023, 7, 16, 8, 57, 7, 953, DateTimeKind.Utc).AddTicks(5516));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 14,
                column: "AddedOn",
                value: new DateTime(2023, 7, 16, 8, 57, 7, 953, DateTimeKind.Utc).AddTicks(5518));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 15,
                column: "AddedOn",
                value: new DateTime(2023, 7, 16, 8, 57, 7, 953, DateTimeKind.Utc).AddTicks(5521));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 16,
                column: "AddedOn",
                value: new DateTime(2023, 7, 16, 8, 57, 7, 953, DateTimeKind.Utc).AddTicks(5523));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 17,
                column: "AddedOn",
                value: new DateTime(2023, 7, 16, 8, 57, 7, 953, DateTimeKind.Utc).AddTicks(5526));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 18,
                column: "AddedOn",
                value: new DateTime(2023, 7, 16, 8, 57, 7, 953, DateTimeKind.Utc).AddTicks(5528));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 19,
                column: "AddedOn",
                value: new DateTime(2023, 7, 16, 8, 57, 7, 953, DateTimeKind.Utc).AddTicks(5532));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 20,
                column: "AddedOn",
                value: new DateTime(2023, 7, 16, 8, 57, 7, 953, DateTimeKind.Utc).AddTicks(5535));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedOn",
                value: new DateTime(2023, 7, 16, 8, 57, 7, 953, DateTimeKind.Utc).AddTicks(6329));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedOn",
                value: new DateTime(2023, 7, 16, 8, 57, 7, 953, DateTimeKind.Utc).AddTicks(6337));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddedOn",
                value: new DateTime(2023, 7, 16, 8, 57, 7, 953, DateTimeKind.Utc).AddTicks(6339));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddedOn",
                value: new DateTime(2023, 7, 16, 8, 57, 7, 953, DateTimeKind.Utc).AddTicks(6342));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 5,
                column: "AddedOn",
                value: new DateTime(2023, 7, 16, 8, 57, 7, 953, DateTimeKind.Utc).AddTicks(6346));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 6,
                column: "AddedOn",
                value: new DateTime(2023, 7, 16, 8, 57, 7, 953, DateTimeKind.Utc).AddTicks(6376));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 7,
                column: "AddedOn",
                value: new DateTime(2023, 7, 16, 8, 57, 7, 953, DateTimeKind.Utc).AddTicks(6379));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 8,
                column: "AddedOn",
                value: new DateTime(2023, 7, 16, 8, 57, 7, 953, DateTimeKind.Utc).AddTicks(6382));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 9,
                column: "AddedOn",
                value: new DateTime(2023, 7, 16, 8, 57, 7, 953, DateTimeKind.Utc).AddTicks(6385));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 10,
                column: "AddedOn",
                value: new DateTime(2023, 7, 16, 8, 57, 7, 953, DateTimeKind.Utc).AddTicks(6387));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 11,
                column: "AddedOn",
                value: new DateTime(2023, 7, 16, 8, 57, 7, 953, DateTimeKind.Utc).AddTicks(6389));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 12,
                column: "AddedOn",
                value: new DateTime(2023, 7, 16, 8, 57, 7, 953, DateTimeKind.Utc).AddTicks(6392));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 13,
                column: "AddedOn",
                value: new DateTime(2023, 7, 16, 8, 57, 7, 953, DateTimeKind.Utc).AddTicks(6397));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 14,
                column: "AddedOn",
                value: new DateTime(2023, 7, 16, 8, 57, 7, 953, DateTimeKind.Utc).AddTicks(6399));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 15,
                column: "AddedOn",
                value: new DateTime(2023, 7, 16, 8, 57, 7, 953, DateTimeKind.Utc).AddTicks(6401));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 16,
                column: "AddedOn",
                value: new DateTime(2023, 7, 16, 8, 57, 7, 953, DateTimeKind.Utc).AddTicks(6404));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 17,
                column: "AddedOn",
                value: new DateTime(2023, 7, 16, 8, 57, 7, 953, DateTimeKind.Utc).AddTicks(6406));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 18,
                column: "AddedOn",
                value: new DateTime(2023, 7, 16, 8, 57, 7, 953, DateTimeKind.Utc).AddTicks(6409));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Cases",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedOn",
                value: new DateTime(2023, 7, 16, 7, 56, 36, 649, DateTimeKind.Utc).AddTicks(7448));

            migrationBuilder.UpdateData(
                table: "Cases",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedOn",
                value: new DateTime(2023, 7, 16, 7, 56, 36, 649, DateTimeKind.Utc).AddTicks(7473));

            migrationBuilder.UpdateData(
                table: "Cases",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddedOn",
                value: new DateTime(2023, 7, 16, 7, 56, 36, 649, DateTimeKind.Utc).AddTicks(7476));

            migrationBuilder.UpdateData(
                table: "Cases",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddedOn",
                value: new DateTime(2023, 7, 16, 7, 56, 36, 649, DateTimeKind.Utc).AddTicks(7478));

            migrationBuilder.UpdateData(
                table: "Cases",
                keyColumn: "Id",
                keyValue: 5,
                column: "AddedOn",
                value: new DateTime(2023, 7, 16, 7, 56, 36, 649, DateTimeKind.Utc).AddTicks(7484));

            migrationBuilder.UpdateData(
                table: "Coolers",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedOn",
                value: new DateTime(2023, 7, 16, 7, 56, 36, 651, DateTimeKind.Utc).AddTicks(241));

            migrationBuilder.UpdateData(
                table: "Coolers",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedOn",
                value: new DateTime(2023, 7, 16, 7, 56, 36, 651, DateTimeKind.Utc).AddTicks(252));

            migrationBuilder.UpdateData(
                table: "Coolers",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddedOn",
                value: new DateTime(2023, 7, 16, 7, 56, 36, 651, DateTimeKind.Utc).AddTicks(254));

            migrationBuilder.UpdateData(
                table: "Coolers",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddedOn",
                value: new DateTime(2023, 7, 16, 7, 56, 36, 651, DateTimeKind.Utc).AddTicks(257));

            migrationBuilder.UpdateData(
                table: "Coolers",
                keyColumn: "Id",
                keyValue: 5,
                column: "AddedOn",
                value: new DateTime(2023, 7, 16, 7, 56, 36, 651, DateTimeKind.Utc).AddTicks(262));

            migrationBuilder.UpdateData(
                table: "Coolers",
                keyColumn: "Id",
                keyValue: 6,
                column: "AddedOn",
                value: new DateTime(2023, 7, 16, 7, 56, 36, 651, DateTimeKind.Utc).AddTicks(265));

            migrationBuilder.UpdateData(
                table: "Coolers",
                keyColumn: "Id",
                keyValue: 7,
                column: "AddedOn",
                value: new DateTime(2023, 7, 16, 7, 56, 36, 651, DateTimeKind.Utc).AddTicks(267));

            migrationBuilder.UpdateData(
                table: "Coolers",
                keyColumn: "Id",
                keyValue: 8,
                column: "AddedOn",
                value: new DateTime(2023, 7, 16, 7, 56, 36, 651, DateTimeKind.Utc).AddTicks(270));

            migrationBuilder.UpdateData(
                table: "Coolers",
                keyColumn: "Id",
                keyValue: 9,
                column: "AddedOn",
                value: new DateTime(2023, 7, 16, 7, 56, 36, 651, DateTimeKind.Utc).AddTicks(274));

            migrationBuilder.UpdateData(
                table: "Coolers",
                keyColumn: "Id",
                keyValue: 10,
                column: "AddedOn",
                value: new DateTime(2023, 7, 16, 7, 56, 36, 651, DateTimeKind.Utc).AddTicks(276));

            migrationBuilder.UpdateData(
                table: "Cpus",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedOn",
                value: new DateTime(2023, 7, 16, 7, 56, 36, 651, DateTimeKind.Utc).AddTicks(1019));

            migrationBuilder.UpdateData(
                table: "Cpus",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedOn",
                value: new DateTime(2023, 7, 16, 7, 56, 36, 651, DateTimeKind.Utc).AddTicks(1025));

            migrationBuilder.UpdateData(
                table: "Cpus",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddedOn",
                value: new DateTime(2023, 7, 16, 7, 56, 36, 651, DateTimeKind.Utc).AddTicks(1028));

            migrationBuilder.UpdateData(
                table: "Cpus",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddedOn",
                value: new DateTime(2023, 7, 16, 7, 56, 36, 651, DateTimeKind.Utc).AddTicks(1032));

            migrationBuilder.UpdateData(
                table: "Cpus",
                keyColumn: "Id",
                keyValue: 5,
                column: "AddedOn",
                value: new DateTime(2023, 7, 16, 7, 56, 36, 651, DateTimeKind.Utc).AddTicks(1035));

            migrationBuilder.UpdateData(
                table: "Cpus",
                keyColumn: "Id",
                keyValue: 6,
                column: "AddedOn",
                value: new DateTime(2023, 7, 16, 7, 56, 36, 651, DateTimeKind.Utc).AddTicks(1038));

            migrationBuilder.UpdateData(
                table: "Cpus",
                keyColumn: "Id",
                keyValue: 7,
                column: "AddedOn",
                value: new DateTime(2023, 7, 16, 7, 56, 36, 651, DateTimeKind.Utc).AddTicks(1040));

            migrationBuilder.UpdateData(
                table: "Gpus",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedOn",
                value: new DateTime(2023, 7, 16, 7, 56, 36, 651, DateTimeKind.Utc).AddTicks(1828));

            migrationBuilder.UpdateData(
                table: "Gpus",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedOn",
                value: new DateTime(2023, 7, 16, 7, 56, 36, 651, DateTimeKind.Utc).AddTicks(1835));

            migrationBuilder.UpdateData(
                table: "Gpus",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddedOn",
                value: new DateTime(2023, 7, 16, 7, 56, 36, 651, DateTimeKind.Utc).AddTicks(1838));

            migrationBuilder.UpdateData(
                table: "Gpus",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddedOn",
                value: new DateTime(2023, 7, 16, 7, 56, 36, 651, DateTimeKind.Utc).AddTicks(1840));

            migrationBuilder.UpdateData(
                table: "Gpus",
                keyColumn: "Id",
                keyValue: 5,
                column: "AddedOn",
                value: new DateTime(2023, 7, 16, 7, 56, 36, 651, DateTimeKind.Utc).AddTicks(1844));

            migrationBuilder.UpdateData(
                table: "Gpus",
                keyColumn: "Id",
                keyValue: 6,
                column: "AddedOn",
                value: new DateTime(2023, 7, 16, 7, 56, 36, 651, DateTimeKind.Utc).AddTicks(1847));

            migrationBuilder.UpdateData(
                table: "Gpus",
                keyColumn: "Id",
                keyValue: 7,
                column: "AddedOn",
                value: new DateTime(2023, 7, 16, 7, 56, 36, 651, DateTimeKind.Utc).AddTicks(1850));

            migrationBuilder.UpdateData(
                table: "Gpus",
                keyColumn: "Id",
                keyValue: 8,
                column: "AddedOn",
                value: new DateTime(2023, 7, 16, 7, 56, 36, 651, DateTimeKind.Utc).AddTicks(1852));

            migrationBuilder.UpdateData(
                table: "Motherboards",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedOn",
                value: new DateTime(2023, 7, 16, 7, 56, 36, 651, DateTimeKind.Utc).AddTicks(2607));

            migrationBuilder.UpdateData(
                table: "Motherboards",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedOn",
                value: new DateTime(2023, 7, 16, 7, 56, 36, 651, DateTimeKind.Utc).AddTicks(2617));

            migrationBuilder.UpdateData(
                table: "Motherboards",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddedOn",
                value: new DateTime(2023, 7, 16, 7, 56, 36, 651, DateTimeKind.Utc).AddTicks(2619));

            migrationBuilder.UpdateData(
                table: "Motherboards",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddedOn",
                value: new DateTime(2023, 7, 16, 7, 56, 36, 651, DateTimeKind.Utc).AddTicks(2622));

            migrationBuilder.UpdateData(
                table: "Motherboards",
                keyColumn: "Id",
                keyValue: 5,
                column: "AddedOn",
                value: new DateTime(2023, 7, 16, 7, 56, 36, 651, DateTimeKind.Utc).AddTicks(2624));

            migrationBuilder.UpdateData(
                table: "Motherboards",
                keyColumn: "Id",
                keyValue: 6,
                column: "AddedOn",
                value: new DateTime(2023, 7, 16, 7, 56, 36, 651, DateTimeKind.Utc).AddTicks(2628));

            migrationBuilder.UpdateData(
                table: "Motherboards",
                keyColumn: "Id",
                keyValue: 7,
                column: "AddedOn",
                value: new DateTime(2023, 7, 16, 7, 56, 36, 651, DateTimeKind.Utc).AddTicks(2632));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedOn",
                value: new DateTime(2023, 7, 16, 7, 56, 36, 651, DateTimeKind.Utc).AddTicks(3369));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedOn",
                value: new DateTime(2023, 7, 16, 7, 56, 36, 651, DateTimeKind.Utc).AddTicks(3376));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddedOn",
                value: new DateTime(2023, 7, 16, 7, 56, 36, 651, DateTimeKind.Utc).AddTicks(3379));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddedOn",
                value: new DateTime(2023, 7, 16, 7, 56, 36, 651, DateTimeKind.Utc).AddTicks(3381));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 5,
                column: "AddedOn",
                value: new DateTime(2023, 7, 16, 7, 56, 36, 651, DateTimeKind.Utc).AddTicks(3385));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 6,
                column: "AddedOn",
                value: new DateTime(2023, 7, 16, 7, 56, 36, 651, DateTimeKind.Utc).AddTicks(3388));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 7,
                column: "AddedOn",
                value: new DateTime(2023, 7, 16, 7, 56, 36, 651, DateTimeKind.Utc).AddTicks(3390));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 8,
                column: "AddedOn",
                value: new DateTime(2023, 7, 16, 7, 56, 36, 651, DateTimeKind.Utc).AddTicks(3392));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 9,
                column: "AddedOn",
                value: new DateTime(2023, 7, 16, 7, 56, 36, 651, DateTimeKind.Utc).AddTicks(3396));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 10,
                column: "AddedOn",
                value: new DateTime(2023, 7, 16, 7, 56, 36, 651, DateTimeKind.Utc).AddTicks(3398));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 11,
                column: "AddedOn",
                value: new DateTime(2023, 7, 16, 7, 56, 36, 651, DateTimeKind.Utc).AddTicks(3401));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 12,
                column: "AddedOn",
                value: new DateTime(2023, 7, 16, 7, 56, 36, 651, DateTimeKind.Utc).AddTicks(3403));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 13,
                column: "AddedOn",
                value: new DateTime(2023, 7, 16, 7, 56, 36, 651, DateTimeKind.Utc).AddTicks(3405));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedOn",
                value: new DateTime(2023, 7, 16, 7, 56, 36, 651, DateTimeKind.Utc).AddTicks(4185));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedOn",
                value: new DateTime(2023, 7, 16, 7, 56, 36, 651, DateTimeKind.Utc).AddTicks(4226));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddedOn",
                value: new DateTime(2023, 7, 16, 7, 56, 36, 651, DateTimeKind.Utc).AddTicks(4228));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddedOn",
                value: new DateTime(2023, 7, 16, 7, 56, 36, 651, DateTimeKind.Utc).AddTicks(4231));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 5,
                column: "AddedOn",
                value: new DateTime(2023, 7, 16, 7, 56, 36, 651, DateTimeKind.Utc).AddTicks(4235));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 6,
                column: "AddedOn",
                value: new DateTime(2023, 7, 16, 7, 56, 36, 651, DateTimeKind.Utc).AddTicks(4238));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 7,
                column: "AddedOn",
                value: new DateTime(2023, 7, 16, 7, 56, 36, 651, DateTimeKind.Utc).AddTicks(4240));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 8,
                column: "AddedOn",
                value: new DateTime(2023, 7, 16, 7, 56, 36, 651, DateTimeKind.Utc).AddTicks(4243));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 9,
                column: "AddedOn",
                value: new DateTime(2023, 7, 16, 7, 56, 36, 651, DateTimeKind.Utc).AddTicks(4247));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 10,
                column: "AddedOn",
                value: new DateTime(2023, 7, 16, 7, 56, 36, 651, DateTimeKind.Utc).AddTicks(4249));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 11,
                column: "AddedOn",
                value: new DateTime(2023, 7, 16, 7, 56, 36, 651, DateTimeKind.Utc).AddTicks(4252));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 12,
                column: "AddedOn",
                value: new DateTime(2023, 7, 16, 7, 56, 36, 651, DateTimeKind.Utc).AddTicks(4254));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 13,
                column: "AddedOn",
                value: new DateTime(2023, 7, 16, 7, 56, 36, 651, DateTimeKind.Utc).AddTicks(4257));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 14,
                column: "AddedOn",
                value: new DateTime(2023, 7, 16, 7, 56, 36, 651, DateTimeKind.Utc).AddTicks(4259));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 15,
                column: "AddedOn",
                value: new DateTime(2023, 7, 16, 7, 56, 36, 651, DateTimeKind.Utc).AddTicks(4262));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 16,
                column: "AddedOn",
                value: new DateTime(2023, 7, 16, 7, 56, 36, 651, DateTimeKind.Utc).AddTicks(4264));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 17,
                column: "AddedOn",
                value: new DateTime(2023, 7, 16, 7, 56, 36, 651, DateTimeKind.Utc).AddTicks(4267));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 18,
                column: "AddedOn",
                value: new DateTime(2023, 7, 16, 7, 56, 36, 651, DateTimeKind.Utc).AddTicks(4269));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 19,
                column: "AddedOn",
                value: new DateTime(2023, 7, 16, 7, 56, 36, 651, DateTimeKind.Utc).AddTicks(4273));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 20,
                column: "AddedOn",
                value: new DateTime(2023, 7, 16, 7, 56, 36, 651, DateTimeKind.Utc).AddTicks(4276));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedOn",
                value: new DateTime(2023, 7, 16, 7, 56, 36, 651, DateTimeKind.Utc).AddTicks(5101));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedOn",
                value: new DateTime(2023, 7, 16, 7, 56, 36, 651, DateTimeKind.Utc).AddTicks(5109));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddedOn",
                value: new DateTime(2023, 7, 16, 7, 56, 36, 651, DateTimeKind.Utc).AddTicks(5111));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddedOn",
                value: new DateTime(2023, 7, 16, 7, 56, 36, 651, DateTimeKind.Utc).AddTicks(5113));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 5,
                column: "AddedOn",
                value: new DateTime(2023, 7, 16, 7, 56, 36, 651, DateTimeKind.Utc).AddTicks(5118));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 6,
                column: "AddedOn",
                value: new DateTime(2023, 7, 16, 7, 56, 36, 651, DateTimeKind.Utc).AddTicks(5120));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 7,
                column: "AddedOn",
                value: new DateTime(2023, 7, 16, 7, 56, 36, 651, DateTimeKind.Utc).AddTicks(5122));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 8,
                column: "AddedOn",
                value: new DateTime(2023, 7, 16, 7, 56, 36, 651, DateTimeKind.Utc).AddTicks(5125));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 9,
                column: "AddedOn",
                value: new DateTime(2023, 7, 16, 7, 56, 36, 651, DateTimeKind.Utc).AddTicks(5128));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 10,
                column: "AddedOn",
                value: new DateTime(2023, 7, 16, 7, 56, 36, 651, DateTimeKind.Utc).AddTicks(5161));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 11,
                column: "AddedOn",
                value: new DateTime(2023, 7, 16, 7, 56, 36, 651, DateTimeKind.Utc).AddTicks(5164));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 12,
                column: "AddedOn",
                value: new DateTime(2023, 7, 16, 7, 56, 36, 651, DateTimeKind.Utc).AddTicks(5166));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 13,
                column: "AddedOn",
                value: new DateTime(2023, 7, 16, 7, 56, 36, 651, DateTimeKind.Utc).AddTicks(5170));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 14,
                column: "AddedOn",
                value: new DateTime(2023, 7, 16, 7, 56, 36, 651, DateTimeKind.Utc).AddTicks(5172));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 15,
                column: "AddedOn",
                value: new DateTime(2023, 7, 16, 7, 56, 36, 651, DateTimeKind.Utc).AddTicks(5174));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 16,
                column: "AddedOn",
                value: new DateTime(2023, 7, 16, 7, 56, 36, 651, DateTimeKind.Utc).AddTicks(5176));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 17,
                column: "AddedOn",
                value: new DateTime(2023, 7, 16, 7, 56, 36, 651, DateTimeKind.Utc).AddTicks(5179));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 18,
                column: "AddedOn",
                value: new DateTime(2023, 7, 16, 7, 56, 36, 651, DateTimeKind.Utc).AddTicks(5182));
        }
    }
}
