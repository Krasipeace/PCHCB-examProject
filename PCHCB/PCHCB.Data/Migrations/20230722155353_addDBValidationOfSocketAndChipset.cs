using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PCHCB.Data.Migrations
{
    public partial class addDBValidationOfSocketAndChipset : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Socket",
                table: "Motherboards",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Chipset",
                table: "Motherboards",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "Cases",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedOn",
                value: new DateTime(2023, 7, 22, 15, 53, 52, 427, DateTimeKind.Utc).AddTicks(4730));

            migrationBuilder.UpdateData(
                table: "Cases",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedOn",
                value: new DateTime(2023, 7, 22, 15, 53, 52, 427, DateTimeKind.Utc).AddTicks(4757));

            migrationBuilder.UpdateData(
                table: "Cases",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddedOn",
                value: new DateTime(2023, 7, 22, 15, 53, 52, 427, DateTimeKind.Utc).AddTicks(4760));

            migrationBuilder.UpdateData(
                table: "Cases",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddedOn",
                value: new DateTime(2023, 7, 22, 15, 53, 52, 427, DateTimeKind.Utc).AddTicks(4763));

            migrationBuilder.UpdateData(
                table: "Cases",
                keyColumn: "Id",
                keyValue: 5,
                column: "AddedOn",
                value: new DateTime(2023, 7, 22, 15, 53, 52, 427, DateTimeKind.Utc).AddTicks(4768));

            migrationBuilder.UpdateData(
                table: "Coolers",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedOn",
                value: new DateTime(2023, 7, 22, 15, 53, 52, 428, DateTimeKind.Utc).AddTicks(7109));

            migrationBuilder.UpdateData(
                table: "Coolers",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedOn",
                value: new DateTime(2023, 7, 22, 15, 53, 52, 428, DateTimeKind.Utc).AddTicks(7120));

            migrationBuilder.UpdateData(
                table: "Coolers",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddedOn",
                value: new DateTime(2023, 7, 22, 15, 53, 52, 428, DateTimeKind.Utc).AddTicks(7122));

            migrationBuilder.UpdateData(
                table: "Coolers",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddedOn",
                value: new DateTime(2023, 7, 22, 15, 53, 52, 428, DateTimeKind.Utc).AddTicks(7125));

            migrationBuilder.UpdateData(
                table: "Coolers",
                keyColumn: "Id",
                keyValue: 5,
                column: "AddedOn",
                value: new DateTime(2023, 7, 22, 15, 53, 52, 428, DateTimeKind.Utc).AddTicks(7130));

            migrationBuilder.UpdateData(
                table: "Coolers",
                keyColumn: "Id",
                keyValue: 6,
                column: "AddedOn",
                value: new DateTime(2023, 7, 22, 15, 53, 52, 428, DateTimeKind.Utc).AddTicks(7133));

            migrationBuilder.UpdateData(
                table: "Coolers",
                keyColumn: "Id",
                keyValue: 7,
                column: "AddedOn",
                value: new DateTime(2023, 7, 22, 15, 53, 52, 428, DateTimeKind.Utc).AddTicks(7135));

            migrationBuilder.UpdateData(
                table: "Coolers",
                keyColumn: "Id",
                keyValue: 8,
                column: "AddedOn",
                value: new DateTime(2023, 7, 22, 15, 53, 52, 428, DateTimeKind.Utc).AddTicks(7138));

            migrationBuilder.UpdateData(
                table: "Coolers",
                keyColumn: "Id",
                keyValue: 9,
                column: "AddedOn",
                value: new DateTime(2023, 7, 22, 15, 53, 52, 428, DateTimeKind.Utc).AddTicks(7142));

            migrationBuilder.UpdateData(
                table: "Coolers",
                keyColumn: "Id",
                keyValue: 10,
                column: "AddedOn",
                value: new DateTime(2023, 7, 22, 15, 53, 52, 428, DateTimeKind.Utc).AddTicks(7144));

            migrationBuilder.UpdateData(
                table: "Cpus",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedOn",
                value: new DateTime(2023, 7, 22, 15, 53, 52, 428, DateTimeKind.Utc).AddTicks(7883));

            migrationBuilder.UpdateData(
                table: "Cpus",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedOn",
                value: new DateTime(2023, 7, 22, 15, 53, 52, 428, DateTimeKind.Utc).AddTicks(7889));

            migrationBuilder.UpdateData(
                table: "Cpus",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddedOn",
                value: new DateTime(2023, 7, 22, 15, 53, 52, 428, DateTimeKind.Utc).AddTicks(7891));

            migrationBuilder.UpdateData(
                table: "Cpus",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddedOn",
                value: new DateTime(2023, 7, 22, 15, 53, 52, 428, DateTimeKind.Utc).AddTicks(7894));

            migrationBuilder.UpdateData(
                table: "Cpus",
                keyColumn: "Id",
                keyValue: 5,
                column: "AddedOn",
                value: new DateTime(2023, 7, 22, 15, 53, 52, 428, DateTimeKind.Utc).AddTicks(7896));

            migrationBuilder.UpdateData(
                table: "Cpus",
                keyColumn: "Id",
                keyValue: 6,
                column: "AddedOn",
                value: new DateTime(2023, 7, 22, 15, 53, 52, 428, DateTimeKind.Utc).AddTicks(7899));

            migrationBuilder.UpdateData(
                table: "Cpus",
                keyColumn: "Id",
                keyValue: 7,
                column: "AddedOn",
                value: new DateTime(2023, 7, 22, 15, 53, 52, 428, DateTimeKind.Utc).AddTicks(7901));

            migrationBuilder.UpdateData(
                table: "Gpus",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedOn",
                value: new DateTime(2023, 7, 22, 15, 53, 52, 428, DateTimeKind.Utc).AddTicks(8660));

            migrationBuilder.UpdateData(
                table: "Gpus",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedOn",
                value: new DateTime(2023, 7, 22, 15, 53, 52, 428, DateTimeKind.Utc).AddTicks(8669));

            migrationBuilder.UpdateData(
                table: "Gpus",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddedOn",
                value: new DateTime(2023, 7, 22, 15, 53, 52, 428, DateTimeKind.Utc).AddTicks(8671));

            migrationBuilder.UpdateData(
                table: "Gpus",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddedOn",
                value: new DateTime(2023, 7, 22, 15, 53, 52, 428, DateTimeKind.Utc).AddTicks(8674));

            migrationBuilder.UpdateData(
                table: "Gpus",
                keyColumn: "Id",
                keyValue: 5,
                column: "AddedOn",
                value: new DateTime(2023, 7, 22, 15, 53, 52, 428, DateTimeKind.Utc).AddTicks(8678));

            migrationBuilder.UpdateData(
                table: "Gpus",
                keyColumn: "Id",
                keyValue: 6,
                column: "AddedOn",
                value: new DateTime(2023, 7, 22, 15, 53, 52, 428, DateTimeKind.Utc).AddTicks(8680));

            migrationBuilder.UpdateData(
                table: "Gpus",
                keyColumn: "Id",
                keyValue: 7,
                column: "AddedOn",
                value: new DateTime(2023, 7, 22, 15, 53, 52, 428, DateTimeKind.Utc).AddTicks(8683));

            migrationBuilder.UpdateData(
                table: "Gpus",
                keyColumn: "Id",
                keyValue: 8,
                column: "AddedOn",
                value: new DateTime(2023, 7, 22, 15, 53, 52, 428, DateTimeKind.Utc).AddTicks(8685));

            migrationBuilder.UpdateData(
                table: "Motherboards",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedOn",
                value: new DateTime(2023, 7, 22, 15, 53, 52, 428, DateTimeKind.Utc).AddTicks(9466));

            migrationBuilder.UpdateData(
                table: "Motherboards",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedOn",
                value: new DateTime(2023, 7, 22, 15, 53, 52, 428, DateTimeKind.Utc).AddTicks(9472));

            migrationBuilder.UpdateData(
                table: "Motherboards",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddedOn",
                value: new DateTime(2023, 7, 22, 15, 53, 52, 428, DateTimeKind.Utc).AddTicks(9475));

            migrationBuilder.UpdateData(
                table: "Motherboards",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddedOn",
                value: new DateTime(2023, 7, 22, 15, 53, 52, 428, DateTimeKind.Utc).AddTicks(9477));

            migrationBuilder.UpdateData(
                table: "Motherboards",
                keyColumn: "Id",
                keyValue: 5,
                column: "AddedOn",
                value: new DateTime(2023, 7, 22, 15, 53, 52, 428, DateTimeKind.Utc).AddTicks(9479));

            migrationBuilder.UpdateData(
                table: "Motherboards",
                keyColumn: "Id",
                keyValue: 6,
                column: "AddedOn",
                value: new DateTime(2023, 7, 22, 15, 53, 52, 428, DateTimeKind.Utc).AddTicks(9483));

            migrationBuilder.UpdateData(
                table: "Motherboards",
                keyColumn: "Id",
                keyValue: 7,
                column: "AddedOn",
                value: new DateTime(2023, 7, 22, 15, 53, 52, 428, DateTimeKind.Utc).AddTicks(9486));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedOn",
                value: new DateTime(2023, 7, 22, 15, 53, 52, 429, DateTimeKind.Utc).AddTicks(212));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedOn",
                value: new DateTime(2023, 7, 22, 15, 53, 52, 429, DateTimeKind.Utc).AddTicks(220));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddedOn",
                value: new DateTime(2023, 7, 22, 15, 53, 52, 429, DateTimeKind.Utc).AddTicks(222));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddedOn",
                value: new DateTime(2023, 7, 22, 15, 53, 52, 429, DateTimeKind.Utc).AddTicks(225));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 5,
                column: "AddedOn",
                value: new DateTime(2023, 7, 22, 15, 53, 52, 429, DateTimeKind.Utc).AddTicks(229));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 6,
                column: "AddedOn",
                value: new DateTime(2023, 7, 22, 15, 53, 52, 429, DateTimeKind.Utc).AddTicks(231));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 7,
                column: "AddedOn",
                value: new DateTime(2023, 7, 22, 15, 53, 52, 429, DateTimeKind.Utc).AddTicks(234));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 8,
                column: "AddedOn",
                value: new DateTime(2023, 7, 22, 15, 53, 52, 429, DateTimeKind.Utc).AddTicks(236));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 9,
                column: "AddedOn",
                value: new DateTime(2023, 7, 22, 15, 53, 52, 429, DateTimeKind.Utc).AddTicks(239));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 10,
                column: "AddedOn",
                value: new DateTime(2023, 7, 22, 15, 53, 52, 429, DateTimeKind.Utc).AddTicks(241));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 11,
                column: "AddedOn",
                value: new DateTime(2023, 7, 22, 15, 53, 52, 429, DateTimeKind.Utc).AddTicks(244));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 12,
                column: "AddedOn",
                value: new DateTime(2023, 7, 22, 15, 53, 52, 429, DateTimeKind.Utc).AddTicks(246));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 13,
                column: "AddedOn",
                value: new DateTime(2023, 7, 22, 15, 53, 52, 429, DateTimeKind.Utc).AddTicks(248));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedOn",
                value: new DateTime(2023, 7, 22, 15, 53, 52, 429, DateTimeKind.Utc).AddTicks(1018));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedOn",
                value: new DateTime(2023, 7, 22, 15, 53, 52, 429, DateTimeKind.Utc).AddTicks(1024));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddedOn",
                value: new DateTime(2023, 7, 22, 15, 53, 52, 429, DateTimeKind.Utc).AddTicks(1027));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddedOn",
                value: new DateTime(2023, 7, 22, 15, 53, 52, 429, DateTimeKind.Utc).AddTicks(1029));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 5,
                column: "AddedOn",
                value: new DateTime(2023, 7, 22, 15, 53, 52, 429, DateTimeKind.Utc).AddTicks(1034));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 6,
                column: "AddedOn",
                value: new DateTime(2023, 7, 22, 15, 53, 52, 429, DateTimeKind.Utc).AddTicks(1036));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 7,
                column: "AddedOn",
                value: new DateTime(2023, 7, 22, 15, 53, 52, 429, DateTimeKind.Utc).AddTicks(1039));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 8,
                column: "AddedOn",
                value: new DateTime(2023, 7, 22, 15, 53, 52, 429, DateTimeKind.Utc).AddTicks(1041));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 9,
                column: "AddedOn",
                value: new DateTime(2023, 7, 22, 15, 53, 52, 429, DateTimeKind.Utc).AddTicks(1045));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 10,
                column: "AddedOn",
                value: new DateTime(2023, 7, 22, 15, 53, 52, 429, DateTimeKind.Utc).AddTicks(1047));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 11,
                column: "AddedOn",
                value: new DateTime(2023, 7, 22, 15, 53, 52, 429, DateTimeKind.Utc).AddTicks(1049));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 12,
                column: "AddedOn",
                value: new DateTime(2023, 7, 22, 15, 53, 52, 429, DateTimeKind.Utc).AddTicks(1078));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 13,
                column: "AddedOn",
                value: new DateTime(2023, 7, 22, 15, 53, 52, 429, DateTimeKind.Utc).AddTicks(1081));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 14,
                column: "AddedOn",
                value: new DateTime(2023, 7, 22, 15, 53, 52, 429, DateTimeKind.Utc).AddTicks(1084));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 15,
                column: "AddedOn",
                value: new DateTime(2023, 7, 22, 15, 53, 52, 429, DateTimeKind.Utc).AddTicks(1086));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 16,
                column: "AddedOn",
                value: new DateTime(2023, 7, 22, 15, 53, 52, 429, DateTimeKind.Utc).AddTicks(1089));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 17,
                column: "AddedOn",
                value: new DateTime(2023, 7, 22, 15, 53, 52, 429, DateTimeKind.Utc).AddTicks(1091));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 18,
                column: "AddedOn",
                value: new DateTime(2023, 7, 22, 15, 53, 52, 429, DateTimeKind.Utc).AddTicks(1093));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 19,
                column: "AddedOn",
                value: new DateTime(2023, 7, 22, 15, 53, 52, 429, DateTimeKind.Utc).AddTicks(1098));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 20,
                column: "AddedOn",
                value: new DateTime(2023, 7, 22, 15, 53, 52, 429, DateTimeKind.Utc).AddTicks(1100));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedOn",
                value: new DateTime(2023, 7, 22, 15, 53, 52, 429, DateTimeKind.Utc).AddTicks(1851));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedOn",
                value: new DateTime(2023, 7, 22, 15, 53, 52, 429, DateTimeKind.Utc).AddTicks(1860));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddedOn",
                value: new DateTime(2023, 7, 22, 15, 53, 52, 429, DateTimeKind.Utc).AddTicks(1862));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddedOn",
                value: new DateTime(2023, 7, 22, 15, 53, 52, 429, DateTimeKind.Utc).AddTicks(1864));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 5,
                column: "AddedOn",
                value: new DateTime(2023, 7, 22, 15, 53, 52, 429, DateTimeKind.Utc).AddTicks(1868));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 6,
                column: "AddedOn",
                value: new DateTime(2023, 7, 22, 15, 53, 52, 429, DateTimeKind.Utc).AddTicks(1871));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 7,
                column: "AddedOn",
                value: new DateTime(2023, 7, 22, 15, 53, 52, 429, DateTimeKind.Utc).AddTicks(1873));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 8,
                column: "AddedOn",
                value: new DateTime(2023, 7, 22, 15, 53, 52, 429, DateTimeKind.Utc).AddTicks(1875));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 9,
                column: "AddedOn",
                value: new DateTime(2023, 7, 22, 15, 53, 52, 429, DateTimeKind.Utc).AddTicks(1879));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 10,
                column: "AddedOn",
                value: new DateTime(2023, 7, 22, 15, 53, 52, 429, DateTimeKind.Utc).AddTicks(1881));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 11,
                column: "AddedOn",
                value: new DateTime(2023, 7, 22, 15, 53, 52, 429, DateTimeKind.Utc).AddTicks(1883));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 12,
                column: "AddedOn",
                value: new DateTime(2023, 7, 22, 15, 53, 52, 429, DateTimeKind.Utc).AddTicks(1886));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 13,
                column: "AddedOn",
                value: new DateTime(2023, 7, 22, 15, 53, 52, 429, DateTimeKind.Utc).AddTicks(1891));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 14,
                column: "AddedOn",
                value: new DateTime(2023, 7, 22, 15, 53, 52, 429, DateTimeKind.Utc).AddTicks(1893));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 15,
                column: "AddedOn",
                value: new DateTime(2023, 7, 22, 15, 53, 52, 429, DateTimeKind.Utc).AddTicks(1895));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 16,
                column: "AddedOn",
                value: new DateTime(2023, 7, 22, 15, 53, 52, 429, DateTimeKind.Utc).AddTicks(1898));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 17,
                column: "AddedOn",
                value: new DateTime(2023, 7, 22, 15, 53, 52, 429, DateTimeKind.Utc).AddTicks(1901));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 18,
                column: "AddedOn",
                value: new DateTime(2023, 7, 22, 15, 53, 52, 429, DateTimeKind.Utc).AddTicks(1903));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Socket",
                table: "Motherboards",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "Chipset",
                table: "Motherboards",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.UpdateData(
                table: "Cases",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedOn",
                value: new DateTime(2023, 7, 19, 15, 41, 50, 750, DateTimeKind.Utc).AddTicks(1989));

            migrationBuilder.UpdateData(
                table: "Cases",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedOn",
                value: new DateTime(2023, 7, 19, 15, 41, 50, 750, DateTimeKind.Utc).AddTicks(2021));

            migrationBuilder.UpdateData(
                table: "Cases",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddedOn",
                value: new DateTime(2023, 7, 19, 15, 41, 50, 750, DateTimeKind.Utc).AddTicks(2024));

            migrationBuilder.UpdateData(
                table: "Cases",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddedOn",
                value: new DateTime(2023, 7, 19, 15, 41, 50, 750, DateTimeKind.Utc).AddTicks(2027));

            migrationBuilder.UpdateData(
                table: "Cases",
                keyColumn: "Id",
                keyValue: 5,
                column: "AddedOn",
                value: new DateTime(2023, 7, 19, 15, 41, 50, 750, DateTimeKind.Utc).AddTicks(2033));

            migrationBuilder.UpdateData(
                table: "Coolers",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedOn",
                value: new DateTime(2023, 7, 19, 15, 41, 50, 751, DateTimeKind.Utc).AddTicks(4454));

            migrationBuilder.UpdateData(
                table: "Coolers",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedOn",
                value: new DateTime(2023, 7, 19, 15, 41, 50, 751, DateTimeKind.Utc).AddTicks(4498));

            migrationBuilder.UpdateData(
                table: "Coolers",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddedOn",
                value: new DateTime(2023, 7, 19, 15, 41, 50, 751, DateTimeKind.Utc).AddTicks(4501));

            migrationBuilder.UpdateData(
                table: "Coolers",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddedOn",
                value: new DateTime(2023, 7, 19, 15, 41, 50, 751, DateTimeKind.Utc).AddTicks(4503));

            migrationBuilder.UpdateData(
                table: "Coolers",
                keyColumn: "Id",
                keyValue: 5,
                column: "AddedOn",
                value: new DateTime(2023, 7, 19, 15, 41, 50, 751, DateTimeKind.Utc).AddTicks(4509));

            migrationBuilder.UpdateData(
                table: "Coolers",
                keyColumn: "Id",
                keyValue: 6,
                column: "AddedOn",
                value: new DateTime(2023, 7, 19, 15, 41, 50, 751, DateTimeKind.Utc).AddTicks(4512));

            migrationBuilder.UpdateData(
                table: "Coolers",
                keyColumn: "Id",
                keyValue: 7,
                column: "AddedOn",
                value: new DateTime(2023, 7, 19, 15, 41, 50, 751, DateTimeKind.Utc).AddTicks(4514));

            migrationBuilder.UpdateData(
                table: "Coolers",
                keyColumn: "Id",
                keyValue: 8,
                column: "AddedOn",
                value: new DateTime(2023, 7, 19, 15, 41, 50, 751, DateTimeKind.Utc).AddTicks(4517));

            migrationBuilder.UpdateData(
                table: "Coolers",
                keyColumn: "Id",
                keyValue: 9,
                column: "AddedOn",
                value: new DateTime(2023, 7, 19, 15, 41, 50, 751, DateTimeKind.Utc).AddTicks(4521));

            migrationBuilder.UpdateData(
                table: "Coolers",
                keyColumn: "Id",
                keyValue: 10,
                column: "AddedOn",
                value: new DateTime(2023, 7, 19, 15, 41, 50, 751, DateTimeKind.Utc).AddTicks(4523));

            migrationBuilder.UpdateData(
                table: "Cpus",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedOn",
                value: new DateTime(2023, 7, 19, 15, 41, 50, 751, DateTimeKind.Utc).AddTicks(5277));

            migrationBuilder.UpdateData(
                table: "Cpus",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedOn",
                value: new DateTime(2023, 7, 19, 15, 41, 50, 751, DateTimeKind.Utc).AddTicks(5284));

            migrationBuilder.UpdateData(
                table: "Cpus",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddedOn",
                value: new DateTime(2023, 7, 19, 15, 41, 50, 751, DateTimeKind.Utc).AddTicks(5286));

            migrationBuilder.UpdateData(
                table: "Cpus",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddedOn",
                value: new DateTime(2023, 7, 19, 15, 41, 50, 751, DateTimeKind.Utc).AddTicks(5289));

            migrationBuilder.UpdateData(
                table: "Cpus",
                keyColumn: "Id",
                keyValue: 5,
                column: "AddedOn",
                value: new DateTime(2023, 7, 19, 15, 41, 50, 751, DateTimeKind.Utc).AddTicks(5291));

            migrationBuilder.UpdateData(
                table: "Cpus",
                keyColumn: "Id",
                keyValue: 6,
                column: "AddedOn",
                value: new DateTime(2023, 7, 19, 15, 41, 50, 751, DateTimeKind.Utc).AddTicks(5294));

            migrationBuilder.UpdateData(
                table: "Cpus",
                keyColumn: "Id",
                keyValue: 7,
                column: "AddedOn",
                value: new DateTime(2023, 7, 19, 15, 41, 50, 751, DateTimeKind.Utc).AddTicks(5297));

            migrationBuilder.UpdateData(
                table: "Gpus",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedOn",
                value: new DateTime(2023, 7, 19, 15, 41, 50, 751, DateTimeKind.Utc).AddTicks(6063));

            migrationBuilder.UpdateData(
                table: "Gpus",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedOn",
                value: new DateTime(2023, 7, 19, 15, 41, 50, 751, DateTimeKind.Utc).AddTicks(6071));

            migrationBuilder.UpdateData(
                table: "Gpus",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddedOn",
                value: new DateTime(2023, 7, 19, 15, 41, 50, 751, DateTimeKind.Utc).AddTicks(6074));

            migrationBuilder.UpdateData(
                table: "Gpus",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddedOn",
                value: new DateTime(2023, 7, 19, 15, 41, 50, 751, DateTimeKind.Utc).AddTicks(6077));

            migrationBuilder.UpdateData(
                table: "Gpus",
                keyColumn: "Id",
                keyValue: 5,
                column: "AddedOn",
                value: new DateTime(2023, 7, 19, 15, 41, 50, 751, DateTimeKind.Utc).AddTicks(6081));

            migrationBuilder.UpdateData(
                table: "Gpus",
                keyColumn: "Id",
                keyValue: 6,
                column: "AddedOn",
                value: new DateTime(2023, 7, 19, 15, 41, 50, 751, DateTimeKind.Utc).AddTicks(6083));

            migrationBuilder.UpdateData(
                table: "Gpus",
                keyColumn: "Id",
                keyValue: 7,
                column: "AddedOn",
                value: new DateTime(2023, 7, 19, 15, 41, 50, 751, DateTimeKind.Utc).AddTicks(6086));

            migrationBuilder.UpdateData(
                table: "Gpus",
                keyColumn: "Id",
                keyValue: 8,
                column: "AddedOn",
                value: new DateTime(2023, 7, 19, 15, 41, 50, 751, DateTimeKind.Utc).AddTicks(6088));

            migrationBuilder.UpdateData(
                table: "Motherboards",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedOn",
                value: new DateTime(2023, 7, 19, 15, 41, 50, 751, DateTimeKind.Utc).AddTicks(6897));

            migrationBuilder.UpdateData(
                table: "Motherboards",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedOn",
                value: new DateTime(2023, 7, 19, 15, 41, 50, 751, DateTimeKind.Utc).AddTicks(6904));

            migrationBuilder.UpdateData(
                table: "Motherboards",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddedOn",
                value: new DateTime(2023, 7, 19, 15, 41, 50, 751, DateTimeKind.Utc).AddTicks(6907));

            migrationBuilder.UpdateData(
                table: "Motherboards",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddedOn",
                value: new DateTime(2023, 7, 19, 15, 41, 50, 751, DateTimeKind.Utc).AddTicks(6909));

            migrationBuilder.UpdateData(
                table: "Motherboards",
                keyColumn: "Id",
                keyValue: 5,
                column: "AddedOn",
                value: new DateTime(2023, 7, 19, 15, 41, 50, 751, DateTimeKind.Utc).AddTicks(6938));

            migrationBuilder.UpdateData(
                table: "Motherboards",
                keyColumn: "Id",
                keyValue: 6,
                column: "AddedOn",
                value: new DateTime(2023, 7, 19, 15, 41, 50, 751, DateTimeKind.Utc).AddTicks(6942));

            migrationBuilder.UpdateData(
                table: "Motherboards",
                keyColumn: "Id",
                keyValue: 7,
                column: "AddedOn",
                value: new DateTime(2023, 7, 19, 15, 41, 50, 751, DateTimeKind.Utc).AddTicks(6944));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedOn",
                value: new DateTime(2023, 7, 19, 15, 41, 50, 751, DateTimeKind.Utc).AddTicks(7751));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedOn",
                value: new DateTime(2023, 7, 19, 15, 41, 50, 751, DateTimeKind.Utc).AddTicks(7757));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddedOn",
                value: new DateTime(2023, 7, 19, 15, 41, 50, 751, DateTimeKind.Utc).AddTicks(7760));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddedOn",
                value: new DateTime(2023, 7, 19, 15, 41, 50, 751, DateTimeKind.Utc).AddTicks(7762));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 5,
                column: "AddedOn",
                value: new DateTime(2023, 7, 19, 15, 41, 50, 751, DateTimeKind.Utc).AddTicks(7766));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 6,
                column: "AddedOn",
                value: new DateTime(2023, 7, 19, 15, 41, 50, 751, DateTimeKind.Utc).AddTicks(7769));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 7,
                column: "AddedOn",
                value: new DateTime(2023, 7, 19, 15, 41, 50, 751, DateTimeKind.Utc).AddTicks(7771));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 8,
                column: "AddedOn",
                value: new DateTime(2023, 7, 19, 15, 41, 50, 751, DateTimeKind.Utc).AddTicks(7774));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 9,
                column: "AddedOn",
                value: new DateTime(2023, 7, 19, 15, 41, 50, 751, DateTimeKind.Utc).AddTicks(7777));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 10,
                column: "AddedOn",
                value: new DateTime(2023, 7, 19, 15, 41, 50, 751, DateTimeKind.Utc).AddTicks(7780));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 11,
                column: "AddedOn",
                value: new DateTime(2023, 7, 19, 15, 41, 50, 751, DateTimeKind.Utc).AddTicks(7782));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 12,
                column: "AddedOn",
                value: new DateTime(2023, 7, 19, 15, 41, 50, 751, DateTimeKind.Utc).AddTicks(7784));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 13,
                column: "AddedOn",
                value: new DateTime(2023, 7, 19, 15, 41, 50, 751, DateTimeKind.Utc).AddTicks(7787));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedOn",
                value: new DateTime(2023, 7, 19, 15, 41, 50, 751, DateTimeKind.Utc).AddTicks(8531));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedOn",
                value: new DateTime(2023, 7, 19, 15, 41, 50, 751, DateTimeKind.Utc).AddTicks(8540));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddedOn",
                value: new DateTime(2023, 7, 19, 15, 41, 50, 751, DateTimeKind.Utc).AddTicks(8542));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddedOn",
                value: new DateTime(2023, 7, 19, 15, 41, 50, 751, DateTimeKind.Utc).AddTicks(8545));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 5,
                column: "AddedOn",
                value: new DateTime(2023, 7, 19, 15, 41, 50, 751, DateTimeKind.Utc).AddTicks(8549));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 6,
                column: "AddedOn",
                value: new DateTime(2023, 7, 19, 15, 41, 50, 751, DateTimeKind.Utc).AddTicks(8551));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 7,
                column: "AddedOn",
                value: new DateTime(2023, 7, 19, 15, 41, 50, 751, DateTimeKind.Utc).AddTicks(8554));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 8,
                column: "AddedOn",
                value: new DateTime(2023, 7, 19, 15, 41, 50, 751, DateTimeKind.Utc).AddTicks(8556));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 9,
                column: "AddedOn",
                value: new DateTime(2023, 7, 19, 15, 41, 50, 751, DateTimeKind.Utc).AddTicks(8560));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 10,
                column: "AddedOn",
                value: new DateTime(2023, 7, 19, 15, 41, 50, 751, DateTimeKind.Utc).AddTicks(8562));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 11,
                column: "AddedOn",
                value: new DateTime(2023, 7, 19, 15, 41, 50, 751, DateTimeKind.Utc).AddTicks(8565));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 12,
                column: "AddedOn",
                value: new DateTime(2023, 7, 19, 15, 41, 50, 751, DateTimeKind.Utc).AddTicks(8567));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 13,
                column: "AddedOn",
                value: new DateTime(2023, 7, 19, 15, 41, 50, 751, DateTimeKind.Utc).AddTicks(8570));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 14,
                column: "AddedOn",
                value: new DateTime(2023, 7, 19, 15, 41, 50, 751, DateTimeKind.Utc).AddTicks(8572));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 15,
                column: "AddedOn",
                value: new DateTime(2023, 7, 19, 15, 41, 50, 751, DateTimeKind.Utc).AddTicks(8575));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 16,
                column: "AddedOn",
                value: new DateTime(2023, 7, 19, 15, 41, 50, 751, DateTimeKind.Utc).AddTicks(8577));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 17,
                column: "AddedOn",
                value: new DateTime(2023, 7, 19, 15, 41, 50, 751, DateTimeKind.Utc).AddTicks(8580));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 18,
                column: "AddedOn",
                value: new DateTime(2023, 7, 19, 15, 41, 50, 751, DateTimeKind.Utc).AddTicks(8582));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 19,
                column: "AddedOn",
                value: new DateTime(2023, 7, 19, 15, 41, 50, 751, DateTimeKind.Utc).AddTicks(8610));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 20,
                column: "AddedOn",
                value: new DateTime(2023, 7, 19, 15, 41, 50, 751, DateTimeKind.Utc).AddTicks(8612));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedOn",
                value: new DateTime(2023, 7, 19, 15, 41, 50, 751, DateTimeKind.Utc).AddTicks(9376));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedOn",
                value: new DateTime(2023, 7, 19, 15, 41, 50, 751, DateTimeKind.Utc).AddTicks(9384));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddedOn",
                value: new DateTime(2023, 7, 19, 15, 41, 50, 751, DateTimeKind.Utc).AddTicks(9386));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddedOn",
                value: new DateTime(2023, 7, 19, 15, 41, 50, 751, DateTimeKind.Utc).AddTicks(9389));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 5,
                column: "AddedOn",
                value: new DateTime(2023, 7, 19, 15, 41, 50, 751, DateTimeKind.Utc).AddTicks(9392));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 6,
                column: "AddedOn",
                value: new DateTime(2023, 7, 19, 15, 41, 50, 751, DateTimeKind.Utc).AddTicks(9395));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 7,
                column: "AddedOn",
                value: new DateTime(2023, 7, 19, 15, 41, 50, 751, DateTimeKind.Utc).AddTicks(9397));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 8,
                column: "AddedOn",
                value: new DateTime(2023, 7, 19, 15, 41, 50, 751, DateTimeKind.Utc).AddTicks(9399));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 9,
                column: "AddedOn",
                value: new DateTime(2023, 7, 19, 15, 41, 50, 751, DateTimeKind.Utc).AddTicks(9402));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 10,
                column: "AddedOn",
                value: new DateTime(2023, 7, 19, 15, 41, 50, 751, DateTimeKind.Utc).AddTicks(9405));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 11,
                column: "AddedOn",
                value: new DateTime(2023, 7, 19, 15, 41, 50, 751, DateTimeKind.Utc).AddTicks(9407));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 12,
                column: "AddedOn",
                value: new DateTime(2023, 7, 19, 15, 41, 50, 751, DateTimeKind.Utc).AddTicks(9409));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 13,
                column: "AddedOn",
                value: new DateTime(2023, 7, 19, 15, 41, 50, 751, DateTimeKind.Utc).AddTicks(9412));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 14,
                column: "AddedOn",
                value: new DateTime(2023, 7, 19, 15, 41, 50, 751, DateTimeKind.Utc).AddTicks(9415));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 15,
                column: "AddedOn",
                value: new DateTime(2023, 7, 19, 15, 41, 50, 751, DateTimeKind.Utc).AddTicks(9417));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 16,
                column: "AddedOn",
                value: new DateTime(2023, 7, 19, 15, 41, 50, 751, DateTimeKind.Utc).AddTicks(9419));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 17,
                column: "AddedOn",
                value: new DateTime(2023, 7, 19, 15, 41, 50, 751, DateTimeKind.Utc).AddTicks(9422));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 18,
                column: "AddedOn",
                value: new DateTime(2023, 7, 19, 15, 41, 50, 751, DateTimeKind.Utc).AddTicks(9424));
        }
    }
}
