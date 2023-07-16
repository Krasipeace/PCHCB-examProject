using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PCHCB.Data.Migrations
{
    public partial class addedRequiredFieldsInProvider : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Providers",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(1000)",
                oldMaxLength: 1000);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Providers",
                type: "nvarchar(1000)",
                maxLength: 1000,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500);

            migrationBuilder.UpdateData(
                table: "Cases",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedOn",
                value: new DateTime(2023, 7, 12, 22, 17, 37, 619, DateTimeKind.Utc).AddTicks(834));

            migrationBuilder.UpdateData(
                table: "Cases",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedOn",
                value: new DateTime(2023, 7, 12, 22, 17, 37, 619, DateTimeKind.Utc).AddTicks(858));

            migrationBuilder.UpdateData(
                table: "Cases",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddedOn",
                value: new DateTime(2023, 7, 12, 22, 17, 37, 619, DateTimeKind.Utc).AddTicks(861));

            migrationBuilder.UpdateData(
                table: "Cases",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddedOn",
                value: new DateTime(2023, 7, 12, 22, 17, 37, 619, DateTimeKind.Utc).AddTicks(864));

            migrationBuilder.UpdateData(
                table: "Cases",
                keyColumn: "Id",
                keyValue: 5,
                column: "AddedOn",
                value: new DateTime(2023, 7, 12, 22, 17, 37, 619, DateTimeKind.Utc).AddTicks(871));

            migrationBuilder.UpdateData(
                table: "Coolers",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedOn",
                value: new DateTime(2023, 7, 12, 22, 17, 37, 620, DateTimeKind.Utc).AddTicks(2970));

            migrationBuilder.UpdateData(
                table: "Coolers",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedOn",
                value: new DateTime(2023, 7, 12, 22, 17, 37, 620, DateTimeKind.Utc).AddTicks(2982));

            migrationBuilder.UpdateData(
                table: "Coolers",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddedOn",
                value: new DateTime(2023, 7, 12, 22, 17, 37, 620, DateTimeKind.Utc).AddTicks(2985));

            migrationBuilder.UpdateData(
                table: "Coolers",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddedOn",
                value: new DateTime(2023, 7, 12, 22, 17, 37, 620, DateTimeKind.Utc).AddTicks(3017));

            migrationBuilder.UpdateData(
                table: "Coolers",
                keyColumn: "Id",
                keyValue: 5,
                column: "AddedOn",
                value: new DateTime(2023, 7, 12, 22, 17, 37, 620, DateTimeKind.Utc).AddTicks(3022));

            migrationBuilder.UpdateData(
                table: "Coolers",
                keyColumn: "Id",
                keyValue: 6,
                column: "AddedOn",
                value: new DateTime(2023, 7, 12, 22, 17, 37, 620, DateTimeKind.Utc).AddTicks(3025));

            migrationBuilder.UpdateData(
                table: "Coolers",
                keyColumn: "Id",
                keyValue: 7,
                column: "AddedOn",
                value: new DateTime(2023, 7, 12, 22, 17, 37, 620, DateTimeKind.Utc).AddTicks(3027));

            migrationBuilder.UpdateData(
                table: "Coolers",
                keyColumn: "Id",
                keyValue: 8,
                column: "AddedOn",
                value: new DateTime(2023, 7, 12, 22, 17, 37, 620, DateTimeKind.Utc).AddTicks(3030));

            migrationBuilder.UpdateData(
                table: "Coolers",
                keyColumn: "Id",
                keyValue: 9,
                column: "AddedOn",
                value: new DateTime(2023, 7, 12, 22, 17, 37, 620, DateTimeKind.Utc).AddTicks(3034));

            migrationBuilder.UpdateData(
                table: "Coolers",
                keyColumn: "Id",
                keyValue: 10,
                column: "AddedOn",
                value: new DateTime(2023, 7, 12, 22, 17, 37, 620, DateTimeKind.Utc).AddTicks(3038));

            migrationBuilder.UpdateData(
                table: "Cpus",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedOn",
                value: new DateTime(2023, 7, 12, 22, 17, 37, 620, DateTimeKind.Utc).AddTicks(3777));

            migrationBuilder.UpdateData(
                table: "Cpus",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedOn",
                value: new DateTime(2023, 7, 12, 22, 17, 37, 620, DateTimeKind.Utc).AddTicks(3784));

            migrationBuilder.UpdateData(
                table: "Cpus",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddedOn",
                value: new DateTime(2023, 7, 12, 22, 17, 37, 620, DateTimeKind.Utc).AddTicks(3786));

            migrationBuilder.UpdateData(
                table: "Cpus",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddedOn",
                value: new DateTime(2023, 7, 12, 22, 17, 37, 620, DateTimeKind.Utc).AddTicks(3789));

            migrationBuilder.UpdateData(
                table: "Cpus",
                keyColumn: "Id",
                keyValue: 5,
                column: "AddedOn",
                value: new DateTime(2023, 7, 12, 22, 17, 37, 620, DateTimeKind.Utc).AddTicks(3791));

            migrationBuilder.UpdateData(
                table: "Cpus",
                keyColumn: "Id",
                keyValue: 6,
                column: "AddedOn",
                value: new DateTime(2023, 7, 12, 22, 17, 37, 620, DateTimeKind.Utc).AddTicks(3794));

            migrationBuilder.UpdateData(
                table: "Cpus",
                keyColumn: "Id",
                keyValue: 7,
                column: "AddedOn",
                value: new DateTime(2023, 7, 12, 22, 17, 37, 620, DateTimeKind.Utc).AddTicks(3797));

            migrationBuilder.UpdateData(
                table: "Gpus",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedOn",
                value: new DateTime(2023, 7, 12, 22, 17, 37, 620, DateTimeKind.Utc).AddTicks(4677));

            migrationBuilder.UpdateData(
                table: "Gpus",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedOn",
                value: new DateTime(2023, 7, 12, 22, 17, 37, 620, DateTimeKind.Utc).AddTicks(4691));

            migrationBuilder.UpdateData(
                table: "Gpus",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddedOn",
                value: new DateTime(2023, 7, 12, 22, 17, 37, 620, DateTimeKind.Utc).AddTicks(4695));

            migrationBuilder.UpdateData(
                table: "Gpus",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddedOn",
                value: new DateTime(2023, 7, 12, 22, 17, 37, 620, DateTimeKind.Utc).AddTicks(4698));

            migrationBuilder.UpdateData(
                table: "Gpus",
                keyColumn: "Id",
                keyValue: 5,
                column: "AddedOn",
                value: new DateTime(2023, 7, 12, 22, 17, 37, 620, DateTimeKind.Utc).AddTicks(4704));

            migrationBuilder.UpdateData(
                table: "Gpus",
                keyColumn: "Id",
                keyValue: 6,
                column: "AddedOn",
                value: new DateTime(2023, 7, 12, 22, 17, 37, 620, DateTimeKind.Utc).AddTicks(4708));

            migrationBuilder.UpdateData(
                table: "Gpus",
                keyColumn: "Id",
                keyValue: 7,
                column: "AddedOn",
                value: new DateTime(2023, 7, 12, 22, 17, 37, 620, DateTimeKind.Utc).AddTicks(4711));

            migrationBuilder.UpdateData(
                table: "Gpus",
                keyColumn: "Id",
                keyValue: 8,
                column: "AddedOn",
                value: new DateTime(2023, 7, 12, 22, 17, 37, 620, DateTimeKind.Utc).AddTicks(4714));

            migrationBuilder.UpdateData(
                table: "Motherboards",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedOn",
                value: new DateTime(2023, 7, 12, 22, 17, 37, 620, DateTimeKind.Utc).AddTicks(5536));

            migrationBuilder.UpdateData(
                table: "Motherboards",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedOn",
                value: new DateTime(2023, 7, 12, 22, 17, 37, 620, DateTimeKind.Utc).AddTicks(5542));

            migrationBuilder.UpdateData(
                table: "Motherboards",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddedOn",
                value: new DateTime(2023, 7, 12, 22, 17, 37, 620, DateTimeKind.Utc).AddTicks(5545));

            migrationBuilder.UpdateData(
                table: "Motherboards",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddedOn",
                value: new DateTime(2023, 7, 12, 22, 17, 37, 620, DateTimeKind.Utc).AddTicks(5547));

            migrationBuilder.UpdateData(
                table: "Motherboards",
                keyColumn: "Id",
                keyValue: 5,
                column: "AddedOn",
                value: new DateTime(2023, 7, 12, 22, 17, 37, 620, DateTimeKind.Utc).AddTicks(5550));

            migrationBuilder.UpdateData(
                table: "Motherboards",
                keyColumn: "Id",
                keyValue: 6,
                column: "AddedOn",
                value: new DateTime(2023, 7, 12, 22, 17, 37, 620, DateTimeKind.Utc).AddTicks(5553));

            migrationBuilder.UpdateData(
                table: "Motherboards",
                keyColumn: "Id",
                keyValue: 7,
                column: "AddedOn",
                value: new DateTime(2023, 7, 12, 22, 17, 37, 620, DateTimeKind.Utc).AddTicks(5556));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedOn",
                value: new DateTime(2023, 7, 12, 22, 17, 37, 620, DateTimeKind.Utc).AddTicks(6423));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedOn",
                value: new DateTime(2023, 7, 12, 22, 17, 37, 620, DateTimeKind.Utc).AddTicks(6430));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddedOn",
                value: new DateTime(2023, 7, 12, 22, 17, 37, 620, DateTimeKind.Utc).AddTicks(6432));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddedOn",
                value: new DateTime(2023, 7, 12, 22, 17, 37, 620, DateTimeKind.Utc).AddTicks(6435));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 5,
                column: "AddedOn",
                value: new DateTime(2023, 7, 12, 22, 17, 37, 620, DateTimeKind.Utc).AddTicks(6439));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 6,
                column: "AddedOn",
                value: new DateTime(2023, 7, 12, 22, 17, 37, 620, DateTimeKind.Utc).AddTicks(6441));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 7,
                column: "AddedOn",
                value: new DateTime(2023, 7, 12, 22, 17, 37, 620, DateTimeKind.Utc).AddTicks(6443));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 8,
                column: "AddedOn",
                value: new DateTime(2023, 7, 12, 22, 17, 37, 620, DateTimeKind.Utc).AddTicks(6446));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 9,
                column: "AddedOn",
                value: new DateTime(2023, 7, 12, 22, 17, 37, 620, DateTimeKind.Utc).AddTicks(6449));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 10,
                column: "AddedOn",
                value: new DateTime(2023, 7, 12, 22, 17, 37, 620, DateTimeKind.Utc).AddTicks(6451));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 11,
                column: "AddedOn",
                value: new DateTime(2023, 7, 12, 22, 17, 37, 620, DateTimeKind.Utc).AddTicks(6453));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 12,
                column: "AddedOn",
                value: new DateTime(2023, 7, 12, 22, 17, 37, 620, DateTimeKind.Utc).AddTicks(6456));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 13,
                column: "AddedOn",
                value: new DateTime(2023, 7, 12, 22, 17, 37, 620, DateTimeKind.Utc).AddTicks(6458));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedOn",
                value: new DateTime(2023, 7, 12, 22, 17, 37, 620, DateTimeKind.Utc).AddTicks(7235));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedOn",
                value: new DateTime(2023, 7, 12, 22, 17, 37, 620, DateTimeKind.Utc).AddTicks(7243));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddedOn",
                value: new DateTime(2023, 7, 12, 22, 17, 37, 620, DateTimeKind.Utc).AddTicks(7247));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddedOn",
                value: new DateTime(2023, 7, 12, 22, 17, 37, 620, DateTimeKind.Utc).AddTicks(7250));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 5,
                column: "AddedOn",
                value: new DateTime(2023, 7, 12, 22, 17, 37, 620, DateTimeKind.Utc).AddTicks(7256));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 6,
                column: "AddedOn",
                value: new DateTime(2023, 7, 12, 22, 17, 37, 620, DateTimeKind.Utc).AddTicks(7259));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 7,
                column: "AddedOn",
                value: new DateTime(2023, 7, 12, 22, 17, 37, 620, DateTimeKind.Utc).AddTicks(7262));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 8,
                column: "AddedOn",
                value: new DateTime(2023, 7, 12, 22, 17, 37, 620, DateTimeKind.Utc).AddTicks(7265));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 9,
                column: "AddedOn",
                value: new DateTime(2023, 7, 12, 22, 17, 37, 620, DateTimeKind.Utc).AddTicks(7268));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 10,
                column: "AddedOn",
                value: new DateTime(2023, 7, 12, 22, 17, 37, 620, DateTimeKind.Utc).AddTicks(7271));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 11,
                column: "AddedOn",
                value: new DateTime(2023, 7, 12, 22, 17, 37, 620, DateTimeKind.Utc).AddTicks(7273));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 12,
                column: "AddedOn",
                value: new DateTime(2023, 7, 12, 22, 17, 37, 620, DateTimeKind.Utc).AddTicks(7276));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 13,
                column: "AddedOn",
                value: new DateTime(2023, 7, 12, 22, 17, 37, 620, DateTimeKind.Utc).AddTicks(7279));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 14,
                column: "AddedOn",
                value: new DateTime(2023, 7, 12, 22, 17, 37, 620, DateTimeKind.Utc).AddTicks(7281));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 15,
                column: "AddedOn",
                value: new DateTime(2023, 7, 12, 22, 17, 37, 620, DateTimeKind.Utc).AddTicks(7283));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 16,
                column: "AddedOn",
                value: new DateTime(2023, 7, 12, 22, 17, 37, 620, DateTimeKind.Utc).AddTicks(7286));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 17,
                column: "AddedOn",
                value: new DateTime(2023, 7, 12, 22, 17, 37, 620, DateTimeKind.Utc).AddTicks(7288));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 18,
                column: "AddedOn",
                value: new DateTime(2023, 7, 12, 22, 17, 37, 620, DateTimeKind.Utc).AddTicks(7290));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 19,
                column: "AddedOn",
                value: new DateTime(2023, 7, 12, 22, 17, 37, 620, DateTimeKind.Utc).AddTicks(7323));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 20,
                column: "AddedOn",
                value: new DateTime(2023, 7, 12, 22, 17, 37, 620, DateTimeKind.Utc).AddTicks(7325));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedOn",
                value: new DateTime(2023, 7, 12, 22, 17, 37, 620, DateTimeKind.Utc).AddTicks(8097));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedOn",
                value: new DateTime(2023, 7, 12, 22, 17, 37, 620, DateTimeKind.Utc).AddTicks(8105));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddedOn",
                value: new DateTime(2023, 7, 12, 22, 17, 37, 620, DateTimeKind.Utc).AddTicks(8107));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddedOn",
                value: new DateTime(2023, 7, 12, 22, 17, 37, 620, DateTimeKind.Utc).AddTicks(8109));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 5,
                column: "AddedOn",
                value: new DateTime(2023, 7, 12, 22, 17, 37, 620, DateTimeKind.Utc).AddTicks(8113));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 6,
                column: "AddedOn",
                value: new DateTime(2023, 7, 12, 22, 17, 37, 620, DateTimeKind.Utc).AddTicks(8117));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 7,
                column: "AddedOn",
                value: new DateTime(2023, 7, 12, 22, 17, 37, 620, DateTimeKind.Utc).AddTicks(8119));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 8,
                column: "AddedOn",
                value: new DateTime(2023, 7, 12, 22, 17, 37, 620, DateTimeKind.Utc).AddTicks(8121));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 9,
                column: "AddedOn",
                value: new DateTime(2023, 7, 12, 22, 17, 37, 620, DateTimeKind.Utc).AddTicks(8124));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 10,
                column: "AddedOn",
                value: new DateTime(2023, 7, 12, 22, 17, 37, 620, DateTimeKind.Utc).AddTicks(8126));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 11,
                column: "AddedOn",
                value: new DateTime(2023, 7, 12, 22, 17, 37, 620, DateTimeKind.Utc).AddTicks(8128));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 12,
                column: "AddedOn",
                value: new DateTime(2023, 7, 12, 22, 17, 37, 620, DateTimeKind.Utc).AddTicks(8130));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 13,
                column: "AddedOn",
                value: new DateTime(2023, 7, 12, 22, 17, 37, 620, DateTimeKind.Utc).AddTicks(8133));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 14,
                column: "AddedOn",
                value: new DateTime(2023, 7, 12, 22, 17, 37, 620, DateTimeKind.Utc).AddTicks(8135));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 15,
                column: "AddedOn",
                value: new DateTime(2023, 7, 12, 22, 17, 37, 620, DateTimeKind.Utc).AddTicks(8139));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 16,
                column: "AddedOn",
                value: new DateTime(2023, 7, 12, 22, 17, 37, 620, DateTimeKind.Utc).AddTicks(8142));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 17,
                column: "AddedOn",
                value: new DateTime(2023, 7, 12, 22, 17, 37, 620, DateTimeKind.Utc).AddTicks(8144));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 18,
                column: "AddedOn",
                value: new DateTime(2023, 7, 12, 22, 17, 37, 620, DateTimeKind.Utc).AddTicks(8147));
        }
    }
}
