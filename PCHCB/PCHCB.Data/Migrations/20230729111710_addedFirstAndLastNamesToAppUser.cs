using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PCHCB.Data.Migrations
{
    public partial class addedFirstAndLastNamesToAppUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Cases",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedOn",
                value: new DateTime(2023, 7, 29, 11, 17, 9, 818, DateTimeKind.Utc).AddTicks(9044));

            migrationBuilder.UpdateData(
                table: "Cases",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedOn",
                value: new DateTime(2023, 7, 29, 11, 17, 9, 818, DateTimeKind.Utc).AddTicks(9075));

            migrationBuilder.UpdateData(
                table: "Cases",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddedOn",
                value: new DateTime(2023, 7, 29, 11, 17, 9, 818, DateTimeKind.Utc).AddTicks(9078));

            migrationBuilder.UpdateData(
                table: "Cases",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddedOn",
                value: new DateTime(2023, 7, 29, 11, 17, 9, 818, DateTimeKind.Utc).AddTicks(9081));

            migrationBuilder.UpdateData(
                table: "Cases",
                keyColumn: "Id",
                keyValue: 5,
                column: "AddedOn",
                value: new DateTime(2023, 7, 29, 11, 17, 9, 818, DateTimeKind.Utc).AddTicks(9087));

            migrationBuilder.UpdateData(
                table: "Coolers",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedOn",
                value: new DateTime(2023, 7, 29, 11, 17, 9, 820, DateTimeKind.Utc).AddTicks(1713));

            migrationBuilder.UpdateData(
                table: "Coolers",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedOn",
                value: new DateTime(2023, 7, 29, 11, 17, 9, 820, DateTimeKind.Utc).AddTicks(1728));

            migrationBuilder.UpdateData(
                table: "Coolers",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddedOn",
                value: new DateTime(2023, 7, 29, 11, 17, 9, 820, DateTimeKind.Utc).AddTicks(1730));

            migrationBuilder.UpdateData(
                table: "Coolers",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddedOn",
                value: new DateTime(2023, 7, 29, 11, 17, 9, 820, DateTimeKind.Utc).AddTicks(1733));

            migrationBuilder.UpdateData(
                table: "Coolers",
                keyColumn: "Id",
                keyValue: 5,
                column: "AddedOn",
                value: new DateTime(2023, 7, 29, 11, 17, 9, 820, DateTimeKind.Utc).AddTicks(1738));

            migrationBuilder.UpdateData(
                table: "Coolers",
                keyColumn: "Id",
                keyValue: 6,
                column: "AddedOn",
                value: new DateTime(2023, 7, 29, 11, 17, 9, 820, DateTimeKind.Utc).AddTicks(1741));

            migrationBuilder.UpdateData(
                table: "Coolers",
                keyColumn: "Id",
                keyValue: 7,
                column: "AddedOn",
                value: new DateTime(2023, 7, 29, 11, 17, 9, 820, DateTimeKind.Utc).AddTicks(1744));

            migrationBuilder.UpdateData(
                table: "Coolers",
                keyColumn: "Id",
                keyValue: 8,
                column: "AddedOn",
                value: new DateTime(2023, 7, 29, 11, 17, 9, 820, DateTimeKind.Utc).AddTicks(1746));

            migrationBuilder.UpdateData(
                table: "Coolers",
                keyColumn: "Id",
                keyValue: 9,
                column: "AddedOn",
                value: new DateTime(2023, 7, 29, 11, 17, 9, 820, DateTimeKind.Utc).AddTicks(1750));

            migrationBuilder.UpdateData(
                table: "Coolers",
                keyColumn: "Id",
                keyValue: 10,
                column: "AddedOn",
                value: new DateTime(2023, 7, 29, 11, 17, 9, 820, DateTimeKind.Utc).AddTicks(1752));

            migrationBuilder.UpdateData(
                table: "Cpus",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedOn",
                value: new DateTime(2023, 7, 29, 11, 17, 9, 820, DateTimeKind.Utc).AddTicks(2572));

            migrationBuilder.UpdateData(
                table: "Cpus",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedOn",
                value: new DateTime(2023, 7, 29, 11, 17, 9, 820, DateTimeKind.Utc).AddTicks(2627));

            migrationBuilder.UpdateData(
                table: "Cpus",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddedOn",
                value: new DateTime(2023, 7, 29, 11, 17, 9, 820, DateTimeKind.Utc).AddTicks(2630));

            migrationBuilder.UpdateData(
                table: "Cpus",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddedOn",
                value: new DateTime(2023, 7, 29, 11, 17, 9, 820, DateTimeKind.Utc).AddTicks(2633));

            migrationBuilder.UpdateData(
                table: "Cpus",
                keyColumn: "Id",
                keyValue: 5,
                column: "AddedOn",
                value: new DateTime(2023, 7, 29, 11, 17, 9, 820, DateTimeKind.Utc).AddTicks(2635));

            migrationBuilder.UpdateData(
                table: "Cpus",
                keyColumn: "Id",
                keyValue: 6,
                column: "AddedOn",
                value: new DateTime(2023, 7, 29, 11, 17, 9, 820, DateTimeKind.Utc).AddTicks(2639));

            migrationBuilder.UpdateData(
                table: "Cpus",
                keyColumn: "Id",
                keyValue: 7,
                column: "AddedOn",
                value: new DateTime(2023, 7, 29, 11, 17, 9, 820, DateTimeKind.Utc).AddTicks(2641));

            migrationBuilder.UpdateData(
                table: "Gpus",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedOn",
                value: new DateTime(2023, 7, 29, 11, 17, 9, 820, DateTimeKind.Utc).AddTicks(3504));

            migrationBuilder.UpdateData(
                table: "Gpus",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedOn",
                value: new DateTime(2023, 7, 29, 11, 17, 9, 820, DateTimeKind.Utc).AddTicks(3511));

            migrationBuilder.UpdateData(
                table: "Gpus",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddedOn",
                value: new DateTime(2023, 7, 29, 11, 17, 9, 820, DateTimeKind.Utc).AddTicks(3514));

            migrationBuilder.UpdateData(
                table: "Gpus",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddedOn",
                value: new DateTime(2023, 7, 29, 11, 17, 9, 820, DateTimeKind.Utc).AddTicks(3516));

            migrationBuilder.UpdateData(
                table: "Gpus",
                keyColumn: "Id",
                keyValue: 5,
                column: "AddedOn",
                value: new DateTime(2023, 7, 29, 11, 17, 9, 820, DateTimeKind.Utc).AddTicks(3520));

            migrationBuilder.UpdateData(
                table: "Gpus",
                keyColumn: "Id",
                keyValue: 6,
                column: "AddedOn",
                value: new DateTime(2023, 7, 29, 11, 17, 9, 820, DateTimeKind.Utc).AddTicks(3523));

            migrationBuilder.UpdateData(
                table: "Gpus",
                keyColumn: "Id",
                keyValue: 7,
                column: "AddedOn",
                value: new DateTime(2023, 7, 29, 11, 17, 9, 820, DateTimeKind.Utc).AddTicks(3525));

            migrationBuilder.UpdateData(
                table: "Gpus",
                keyColumn: "Id",
                keyValue: 8,
                column: "AddedOn",
                value: new DateTime(2023, 7, 29, 11, 17, 9, 820, DateTimeKind.Utc).AddTicks(3527));

            migrationBuilder.UpdateData(
                table: "Motherboards",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedOn",
                value: new DateTime(2023, 7, 29, 11, 17, 9, 820, DateTimeKind.Utc).AddTicks(4298));

            migrationBuilder.UpdateData(
                table: "Motherboards",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedOn",
                value: new DateTime(2023, 7, 29, 11, 17, 9, 820, DateTimeKind.Utc).AddTicks(4305));

            migrationBuilder.UpdateData(
                table: "Motherboards",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddedOn",
                value: new DateTime(2023, 7, 29, 11, 17, 9, 820, DateTimeKind.Utc).AddTicks(4308));

            migrationBuilder.UpdateData(
                table: "Motherboards",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddedOn",
                value: new DateTime(2023, 7, 29, 11, 17, 9, 820, DateTimeKind.Utc).AddTicks(4310));

            migrationBuilder.UpdateData(
                table: "Motherboards",
                keyColumn: "Id",
                keyValue: 5,
                column: "AddedOn",
                value: new DateTime(2023, 7, 29, 11, 17, 9, 820, DateTimeKind.Utc).AddTicks(4313));

            migrationBuilder.UpdateData(
                table: "Motherboards",
                keyColumn: "Id",
                keyValue: 6,
                column: "AddedOn",
                value: new DateTime(2023, 7, 29, 11, 17, 9, 820, DateTimeKind.Utc).AddTicks(4316));

            migrationBuilder.UpdateData(
                table: "Motherboards",
                keyColumn: "Id",
                keyValue: 7,
                column: "AddedOn",
                value: new DateTime(2023, 7, 29, 11, 17, 9, 820, DateTimeKind.Utc).AddTicks(4318));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedOn",
                value: new DateTime(2023, 7, 29, 11, 17, 9, 820, DateTimeKind.Utc).AddTicks(5103));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedOn",
                value: new DateTime(2023, 7, 29, 11, 17, 9, 820, DateTimeKind.Utc).AddTicks(5110));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddedOn",
                value: new DateTime(2023, 7, 29, 11, 17, 9, 820, DateTimeKind.Utc).AddTicks(5112));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddedOn",
                value: new DateTime(2023, 7, 29, 11, 17, 9, 820, DateTimeKind.Utc).AddTicks(5114));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 5,
                column: "AddedOn",
                value: new DateTime(2023, 7, 29, 11, 17, 9, 820, DateTimeKind.Utc).AddTicks(5119));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 6,
                column: "AddedOn",
                value: new DateTime(2023, 7, 29, 11, 17, 9, 820, DateTimeKind.Utc).AddTicks(5121));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 7,
                column: "AddedOn",
                value: new DateTime(2023, 7, 29, 11, 17, 9, 820, DateTimeKind.Utc).AddTicks(5168));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 8,
                column: "AddedOn",
                value: new DateTime(2023, 7, 29, 11, 17, 9, 820, DateTimeKind.Utc).AddTicks(5171));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 9,
                column: "AddedOn",
                value: new DateTime(2023, 7, 29, 11, 17, 9, 820, DateTimeKind.Utc).AddTicks(5175));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 10,
                column: "AddedOn",
                value: new DateTime(2023, 7, 29, 11, 17, 9, 820, DateTimeKind.Utc).AddTicks(5177));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 11,
                column: "AddedOn",
                value: new DateTime(2023, 7, 29, 11, 17, 9, 820, DateTimeKind.Utc).AddTicks(5180));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 12,
                column: "AddedOn",
                value: new DateTime(2023, 7, 29, 11, 17, 9, 820, DateTimeKind.Utc).AddTicks(5182));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 13,
                column: "AddedOn",
                value: new DateTime(2023, 7, 29, 11, 17, 9, 820, DateTimeKind.Utc).AddTicks(5184));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedOn",
                value: new DateTime(2023, 7, 29, 11, 17, 9, 820, DateTimeKind.Utc).AddTicks(5951));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedOn",
                value: new DateTime(2023, 7, 29, 11, 17, 9, 820, DateTimeKind.Utc).AddTicks(5958));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddedOn",
                value: new DateTime(2023, 7, 29, 11, 17, 9, 820, DateTimeKind.Utc).AddTicks(5961));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddedOn",
                value: new DateTime(2023, 7, 29, 11, 17, 9, 820, DateTimeKind.Utc).AddTicks(5964));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 5,
                column: "AddedOn",
                value: new DateTime(2023, 7, 29, 11, 17, 9, 820, DateTimeKind.Utc).AddTicks(5969));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 6,
                column: "AddedOn",
                value: new DateTime(2023, 7, 29, 11, 17, 9, 820, DateTimeKind.Utc).AddTicks(5971));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 7,
                column: "AddedOn",
                value: new DateTime(2023, 7, 29, 11, 17, 9, 820, DateTimeKind.Utc).AddTicks(5973));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 8,
                column: "AddedOn",
                value: new DateTime(2023, 7, 29, 11, 17, 9, 820, DateTimeKind.Utc).AddTicks(5976));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 9,
                column: "AddedOn",
                value: new DateTime(2023, 7, 29, 11, 17, 9, 820, DateTimeKind.Utc).AddTicks(5979));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 10,
                column: "AddedOn",
                value: new DateTime(2023, 7, 29, 11, 17, 9, 820, DateTimeKind.Utc).AddTicks(5982));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 11,
                column: "AddedOn",
                value: new DateTime(2023, 7, 29, 11, 17, 9, 820, DateTimeKind.Utc).AddTicks(5984));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 12,
                column: "AddedOn",
                value: new DateTime(2023, 7, 29, 11, 17, 9, 820, DateTimeKind.Utc).AddTicks(5987));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 13,
                column: "AddedOn",
                value: new DateTime(2023, 7, 29, 11, 17, 9, 820, DateTimeKind.Utc).AddTicks(5989));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 14,
                column: "AddedOn",
                value: new DateTime(2023, 7, 29, 11, 17, 9, 820, DateTimeKind.Utc).AddTicks(5991));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 15,
                column: "AddedOn",
                value: new DateTime(2023, 7, 29, 11, 17, 9, 820, DateTimeKind.Utc).AddTicks(5994));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 16,
                column: "AddedOn",
                value: new DateTime(2023, 7, 29, 11, 17, 9, 820, DateTimeKind.Utc).AddTicks(5996));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 17,
                column: "AddedOn",
                value: new DateTime(2023, 7, 29, 11, 17, 9, 820, DateTimeKind.Utc).AddTicks(5999));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 18,
                column: "AddedOn",
                value: new DateTime(2023, 7, 29, 11, 17, 9, 820, DateTimeKind.Utc).AddTicks(6001));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 19,
                column: "AddedOn",
                value: new DateTime(2023, 7, 29, 11, 17, 9, 820, DateTimeKind.Utc).AddTicks(6005));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 20,
                column: "AddedOn",
                value: new DateTime(2023, 7, 29, 11, 17, 9, 820, DateTimeKind.Utc).AddTicks(6008));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedOn",
                value: new DateTime(2023, 7, 29, 11, 17, 9, 820, DateTimeKind.Utc).AddTicks(6823));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedOn",
                value: new DateTime(2023, 7, 29, 11, 17, 9, 820, DateTimeKind.Utc).AddTicks(6831));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddedOn",
                value: new DateTime(2023, 7, 29, 11, 17, 9, 820, DateTimeKind.Utc).AddTicks(6833));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddedOn",
                value: new DateTime(2023, 7, 29, 11, 17, 9, 820, DateTimeKind.Utc).AddTicks(6836));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 5,
                column: "AddedOn",
                value: new DateTime(2023, 7, 29, 11, 17, 9, 820, DateTimeKind.Utc).AddTicks(6840));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 6,
                column: "AddedOn",
                value: new DateTime(2023, 7, 29, 11, 17, 9, 820, DateTimeKind.Utc).AddTicks(6842));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 7,
                column: "AddedOn",
                value: new DateTime(2023, 7, 29, 11, 17, 9, 820, DateTimeKind.Utc).AddTicks(6844));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 8,
                column: "AddedOn",
                value: new DateTime(2023, 7, 29, 11, 17, 9, 820, DateTimeKind.Utc).AddTicks(6847));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 9,
                column: "AddedOn",
                value: new DateTime(2023, 7, 29, 11, 17, 9, 820, DateTimeKind.Utc).AddTicks(6850));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 10,
                column: "AddedOn",
                value: new DateTime(2023, 7, 29, 11, 17, 9, 820, DateTimeKind.Utc).AddTicks(6852));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 11,
                column: "AddedOn",
                value: new DateTime(2023, 7, 29, 11, 17, 9, 820, DateTimeKind.Utc).AddTicks(6854));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 12,
                column: "AddedOn",
                value: new DateTime(2023, 7, 29, 11, 17, 9, 820, DateTimeKind.Utc).AddTicks(6857));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 13,
                column: "AddedOn",
                value: new DateTime(2023, 7, 29, 11, 17, 9, 820, DateTimeKind.Utc).AddTicks(6859));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 14,
                column: "AddedOn",
                value: new DateTime(2023, 7, 29, 11, 17, 9, 820, DateTimeKind.Utc).AddTicks(6862));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 15,
                column: "AddedOn",
                value: new DateTime(2023, 7, 29, 11, 17, 9, 820, DateTimeKind.Utc).AddTicks(6864));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 16,
                column: "AddedOn",
                value: new DateTime(2023, 7, 29, 11, 17, 9, 820, DateTimeKind.Utc).AddTicks(6866));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 17,
                column: "AddedOn",
                value: new DateTime(2023, 7, 29, 11, 17, 9, 820, DateTimeKind.Utc).AddTicks(6869));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 18,
                column: "AddedOn",
                value: new DateTime(2023, 7, 29, 11, 17, 9, 820, DateTimeKind.Utc).AddTicks(6872));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "Cases",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedOn",
                value: new DateTime(2023, 7, 22, 19, 16, 47, 546, DateTimeKind.Utc).AddTicks(7153));

            migrationBuilder.UpdateData(
                table: "Cases",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedOn",
                value: new DateTime(2023, 7, 22, 19, 16, 47, 546, DateTimeKind.Utc).AddTicks(7187));

            migrationBuilder.UpdateData(
                table: "Cases",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddedOn",
                value: new DateTime(2023, 7, 22, 19, 16, 47, 546, DateTimeKind.Utc).AddTicks(7190));

            migrationBuilder.UpdateData(
                table: "Cases",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddedOn",
                value: new DateTime(2023, 7, 22, 19, 16, 47, 546, DateTimeKind.Utc).AddTicks(7193));

            migrationBuilder.UpdateData(
                table: "Cases",
                keyColumn: "Id",
                keyValue: 5,
                column: "AddedOn",
                value: new DateTime(2023, 7, 22, 19, 16, 47, 546, DateTimeKind.Utc).AddTicks(7200));

            migrationBuilder.UpdateData(
                table: "Coolers",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedOn",
                value: new DateTime(2023, 7, 22, 19, 16, 47, 547, DateTimeKind.Utc).AddTicks(9862));

            migrationBuilder.UpdateData(
                table: "Coolers",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedOn",
                value: new DateTime(2023, 7, 22, 19, 16, 47, 547, DateTimeKind.Utc).AddTicks(9877));

            migrationBuilder.UpdateData(
                table: "Coolers",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddedOn",
                value: new DateTime(2023, 7, 22, 19, 16, 47, 547, DateTimeKind.Utc).AddTicks(9880));

            migrationBuilder.UpdateData(
                table: "Coolers",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddedOn",
                value: new DateTime(2023, 7, 22, 19, 16, 47, 547, DateTimeKind.Utc).AddTicks(9883));

            migrationBuilder.UpdateData(
                table: "Coolers",
                keyColumn: "Id",
                keyValue: 5,
                column: "AddedOn",
                value: new DateTime(2023, 7, 22, 19, 16, 47, 547, DateTimeKind.Utc).AddTicks(9889));

            migrationBuilder.UpdateData(
                table: "Coolers",
                keyColumn: "Id",
                keyValue: 6,
                column: "AddedOn",
                value: new DateTime(2023, 7, 22, 19, 16, 47, 547, DateTimeKind.Utc).AddTicks(9892));

            migrationBuilder.UpdateData(
                table: "Coolers",
                keyColumn: "Id",
                keyValue: 7,
                column: "AddedOn",
                value: new DateTime(2023, 7, 22, 19, 16, 47, 547, DateTimeKind.Utc).AddTicks(9895));

            migrationBuilder.UpdateData(
                table: "Coolers",
                keyColumn: "Id",
                keyValue: 8,
                column: "AddedOn",
                value: new DateTime(2023, 7, 22, 19, 16, 47, 547, DateTimeKind.Utc).AddTicks(9897));

            migrationBuilder.UpdateData(
                table: "Coolers",
                keyColumn: "Id",
                keyValue: 9,
                column: "AddedOn",
                value: new DateTime(2023, 7, 22, 19, 16, 47, 547, DateTimeKind.Utc).AddTicks(9901));

            migrationBuilder.UpdateData(
                table: "Coolers",
                keyColumn: "Id",
                keyValue: 10,
                column: "AddedOn",
                value: new DateTime(2023, 7, 22, 19, 16, 47, 547, DateTimeKind.Utc).AddTicks(9903));

            migrationBuilder.UpdateData(
                table: "Cpus",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedOn",
                value: new DateTime(2023, 7, 22, 19, 16, 47, 548, DateTimeKind.Utc).AddTicks(646));

            migrationBuilder.UpdateData(
                table: "Cpus",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedOn",
                value: new DateTime(2023, 7, 22, 19, 16, 47, 548, DateTimeKind.Utc).AddTicks(653));

            migrationBuilder.UpdateData(
                table: "Cpus",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddedOn",
                value: new DateTime(2023, 7, 22, 19, 16, 47, 548, DateTimeKind.Utc).AddTicks(706));

            migrationBuilder.UpdateData(
                table: "Cpus",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddedOn",
                value: new DateTime(2023, 7, 22, 19, 16, 47, 548, DateTimeKind.Utc).AddTicks(708));

            migrationBuilder.UpdateData(
                table: "Cpus",
                keyColumn: "Id",
                keyValue: 5,
                column: "AddedOn",
                value: new DateTime(2023, 7, 22, 19, 16, 47, 548, DateTimeKind.Utc).AddTicks(711));

            migrationBuilder.UpdateData(
                table: "Cpus",
                keyColumn: "Id",
                keyValue: 6,
                column: "AddedOn",
                value: new DateTime(2023, 7, 22, 19, 16, 47, 548, DateTimeKind.Utc).AddTicks(714));

            migrationBuilder.UpdateData(
                table: "Cpus",
                keyColumn: "Id",
                keyValue: 7,
                column: "AddedOn",
                value: new DateTime(2023, 7, 22, 19, 16, 47, 548, DateTimeKind.Utc).AddTicks(717));

            migrationBuilder.UpdateData(
                table: "Gpus",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedOn",
                value: new DateTime(2023, 7, 22, 19, 16, 47, 548, DateTimeKind.Utc).AddTicks(1528));

            migrationBuilder.UpdateData(
                table: "Gpus",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedOn",
                value: new DateTime(2023, 7, 22, 19, 16, 47, 548, DateTimeKind.Utc).AddTicks(1536));

            migrationBuilder.UpdateData(
                table: "Gpus",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddedOn",
                value: new DateTime(2023, 7, 22, 19, 16, 47, 548, DateTimeKind.Utc).AddTicks(1539));

            migrationBuilder.UpdateData(
                table: "Gpus",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddedOn",
                value: new DateTime(2023, 7, 22, 19, 16, 47, 548, DateTimeKind.Utc).AddTicks(1541));

            migrationBuilder.UpdateData(
                table: "Gpus",
                keyColumn: "Id",
                keyValue: 5,
                column: "AddedOn",
                value: new DateTime(2023, 7, 22, 19, 16, 47, 548, DateTimeKind.Utc).AddTicks(1546));

            migrationBuilder.UpdateData(
                table: "Gpus",
                keyColumn: "Id",
                keyValue: 6,
                column: "AddedOn",
                value: new DateTime(2023, 7, 22, 19, 16, 47, 548, DateTimeKind.Utc).AddTicks(1549));

            migrationBuilder.UpdateData(
                table: "Gpus",
                keyColumn: "Id",
                keyValue: 7,
                column: "AddedOn",
                value: new DateTime(2023, 7, 22, 19, 16, 47, 548, DateTimeKind.Utc).AddTicks(1552));

            migrationBuilder.UpdateData(
                table: "Gpus",
                keyColumn: "Id",
                keyValue: 8,
                column: "AddedOn",
                value: new DateTime(2023, 7, 22, 19, 16, 47, 548, DateTimeKind.Utc).AddTicks(1554));

            migrationBuilder.UpdateData(
                table: "Motherboards",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedOn",
                value: new DateTime(2023, 7, 22, 19, 16, 47, 548, DateTimeKind.Utc).AddTicks(2326));

            migrationBuilder.UpdateData(
                table: "Motherboards",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedOn",
                value: new DateTime(2023, 7, 22, 19, 16, 47, 548, DateTimeKind.Utc).AddTicks(2332));

            migrationBuilder.UpdateData(
                table: "Motherboards",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddedOn",
                value: new DateTime(2023, 7, 22, 19, 16, 47, 548, DateTimeKind.Utc).AddTicks(2334));

            migrationBuilder.UpdateData(
                table: "Motherboards",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddedOn",
                value: new DateTime(2023, 7, 22, 19, 16, 47, 548, DateTimeKind.Utc).AddTicks(2336));

            migrationBuilder.UpdateData(
                table: "Motherboards",
                keyColumn: "Id",
                keyValue: 5,
                column: "AddedOn",
                value: new DateTime(2023, 7, 22, 19, 16, 47, 548, DateTimeKind.Utc).AddTicks(2339));

            migrationBuilder.UpdateData(
                table: "Motherboards",
                keyColumn: "Id",
                keyValue: 6,
                column: "AddedOn",
                value: new DateTime(2023, 7, 22, 19, 16, 47, 548, DateTimeKind.Utc).AddTicks(2342));

            migrationBuilder.UpdateData(
                table: "Motherboards",
                keyColumn: "Id",
                keyValue: 7,
                column: "AddedOn",
                value: new DateTime(2023, 7, 22, 19, 16, 47, 548, DateTimeKind.Utc).AddTicks(2345));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedOn",
                value: new DateTime(2023, 7, 22, 19, 16, 47, 548, DateTimeKind.Utc).AddTicks(3085));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedOn",
                value: new DateTime(2023, 7, 22, 19, 16, 47, 548, DateTimeKind.Utc).AddTicks(3091));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddedOn",
                value: new DateTime(2023, 7, 22, 19, 16, 47, 548, DateTimeKind.Utc).AddTicks(3094));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddedOn",
                value: new DateTime(2023, 7, 22, 19, 16, 47, 548, DateTimeKind.Utc).AddTicks(3096));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 5,
                column: "AddedOn",
                value: new DateTime(2023, 7, 22, 19, 16, 47, 548, DateTimeKind.Utc).AddTicks(3101));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 6,
                column: "AddedOn",
                value: new DateTime(2023, 7, 22, 19, 16, 47, 548, DateTimeKind.Utc).AddTicks(3103));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 7,
                column: "AddedOn",
                value: new DateTime(2023, 7, 22, 19, 16, 47, 548, DateTimeKind.Utc).AddTicks(3106));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 8,
                column: "AddedOn",
                value: new DateTime(2023, 7, 22, 19, 16, 47, 548, DateTimeKind.Utc).AddTicks(3108));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 9,
                column: "AddedOn",
                value: new DateTime(2023, 7, 22, 19, 16, 47, 548, DateTimeKind.Utc).AddTicks(3111));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 10,
                column: "AddedOn",
                value: new DateTime(2023, 7, 22, 19, 16, 47, 548, DateTimeKind.Utc).AddTicks(3114));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 11,
                column: "AddedOn",
                value: new DateTime(2023, 7, 22, 19, 16, 47, 548, DateTimeKind.Utc).AddTicks(3116));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 12,
                column: "AddedOn",
                value: new DateTime(2023, 7, 22, 19, 16, 47, 548, DateTimeKind.Utc).AddTicks(3118));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 13,
                column: "AddedOn",
                value: new DateTime(2023, 7, 22, 19, 16, 47, 548, DateTimeKind.Utc).AddTicks(3120));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedOn",
                value: new DateTime(2023, 7, 22, 19, 16, 47, 548, DateTimeKind.Utc).AddTicks(3851));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedOn",
                value: new DateTime(2023, 7, 22, 19, 16, 47, 548, DateTimeKind.Utc).AddTicks(3857));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddedOn",
                value: new DateTime(2023, 7, 22, 19, 16, 47, 548, DateTimeKind.Utc).AddTicks(3861));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddedOn",
                value: new DateTime(2023, 7, 22, 19, 16, 47, 548, DateTimeKind.Utc).AddTicks(3892));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 5,
                column: "AddedOn",
                value: new DateTime(2023, 7, 22, 19, 16, 47, 548, DateTimeKind.Utc).AddTicks(3897));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 6,
                column: "AddedOn",
                value: new DateTime(2023, 7, 22, 19, 16, 47, 548, DateTimeKind.Utc).AddTicks(3899));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 7,
                column: "AddedOn",
                value: new DateTime(2023, 7, 22, 19, 16, 47, 548, DateTimeKind.Utc).AddTicks(3902));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 8,
                column: "AddedOn",
                value: new DateTime(2023, 7, 22, 19, 16, 47, 548, DateTimeKind.Utc).AddTicks(3905));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 9,
                column: "AddedOn",
                value: new DateTime(2023, 7, 22, 19, 16, 47, 548, DateTimeKind.Utc).AddTicks(3909));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 10,
                column: "AddedOn",
                value: new DateTime(2023, 7, 22, 19, 16, 47, 548, DateTimeKind.Utc).AddTicks(3911));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 11,
                column: "AddedOn",
                value: new DateTime(2023, 7, 22, 19, 16, 47, 548, DateTimeKind.Utc).AddTicks(3914));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 12,
                column: "AddedOn",
                value: new DateTime(2023, 7, 22, 19, 16, 47, 548, DateTimeKind.Utc).AddTicks(3916));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 13,
                column: "AddedOn",
                value: new DateTime(2023, 7, 22, 19, 16, 47, 548, DateTimeKind.Utc).AddTicks(3919));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 14,
                column: "AddedOn",
                value: new DateTime(2023, 7, 22, 19, 16, 47, 548, DateTimeKind.Utc).AddTicks(3922));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 15,
                column: "AddedOn",
                value: new DateTime(2023, 7, 22, 19, 16, 47, 548, DateTimeKind.Utc).AddTicks(3929));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 16,
                column: "AddedOn",
                value: new DateTime(2023, 7, 22, 19, 16, 47, 548, DateTimeKind.Utc).AddTicks(3931));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 17,
                column: "AddedOn",
                value: new DateTime(2023, 7, 22, 19, 16, 47, 548, DateTimeKind.Utc).AddTicks(3934));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 18,
                column: "AddedOn",
                value: new DateTime(2023, 7, 22, 19, 16, 47, 548, DateTimeKind.Utc).AddTicks(3936));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 19,
                column: "AddedOn",
                value: new DateTime(2023, 7, 22, 19, 16, 47, 548, DateTimeKind.Utc).AddTicks(3940));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 20,
                column: "AddedOn",
                value: new DateTime(2023, 7, 22, 19, 16, 47, 548, DateTimeKind.Utc).AddTicks(3943));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedOn",
                value: new DateTime(2023, 7, 22, 19, 16, 47, 548, DateTimeKind.Utc).AddTicks(4663));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedOn",
                value: new DateTime(2023, 7, 22, 19, 16, 47, 548, DateTimeKind.Utc).AddTicks(4670));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddedOn",
                value: new DateTime(2023, 7, 22, 19, 16, 47, 548, DateTimeKind.Utc).AddTicks(4672));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddedOn",
                value: new DateTime(2023, 7, 22, 19, 16, 47, 548, DateTimeKind.Utc).AddTicks(4674));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 5,
                column: "AddedOn",
                value: new DateTime(2023, 7, 22, 19, 16, 47, 548, DateTimeKind.Utc).AddTicks(4678));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 6,
                column: "AddedOn",
                value: new DateTime(2023, 7, 22, 19, 16, 47, 548, DateTimeKind.Utc).AddTicks(4681));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 7,
                column: "AddedOn",
                value: new DateTime(2023, 7, 22, 19, 16, 47, 548, DateTimeKind.Utc).AddTicks(4683));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 8,
                column: "AddedOn",
                value: new DateTime(2023, 7, 22, 19, 16, 47, 548, DateTimeKind.Utc).AddTicks(4685));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 9,
                column: "AddedOn",
                value: new DateTime(2023, 7, 22, 19, 16, 47, 548, DateTimeKind.Utc).AddTicks(4688));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 10,
                column: "AddedOn",
                value: new DateTime(2023, 7, 22, 19, 16, 47, 548, DateTimeKind.Utc).AddTicks(4690));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 11,
                column: "AddedOn",
                value: new DateTime(2023, 7, 22, 19, 16, 47, 548, DateTimeKind.Utc).AddTicks(4693));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 12,
                column: "AddedOn",
                value: new DateTime(2023, 7, 22, 19, 16, 47, 548, DateTimeKind.Utc).AddTicks(4723));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 13,
                column: "AddedOn",
                value: new DateTime(2023, 7, 22, 19, 16, 47, 548, DateTimeKind.Utc).AddTicks(4728));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 14,
                column: "AddedOn",
                value: new DateTime(2023, 7, 22, 19, 16, 47, 548, DateTimeKind.Utc).AddTicks(4730));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 15,
                column: "AddedOn",
                value: new DateTime(2023, 7, 22, 19, 16, 47, 548, DateTimeKind.Utc).AddTicks(4732));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 16,
                column: "AddedOn",
                value: new DateTime(2023, 7, 22, 19, 16, 47, 548, DateTimeKind.Utc).AddTicks(4735));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 17,
                column: "AddedOn",
                value: new DateTime(2023, 7, 22, 19, 16, 47, 548, DateTimeKind.Utc).AddTicks(4737));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 18,
                column: "AddedOn",
                value: new DateTime(2023, 7, 22, 19, 16, 47, 548, DateTimeKind.Utc).AddTicks(4739));
        }
    }
}
