using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PCHCB.Data.Migrations
{
    public partial class addedCpuSocketValidation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Socket",
                table: "Cpus",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Socket",
                table: "Cpus",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

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
    }
}
