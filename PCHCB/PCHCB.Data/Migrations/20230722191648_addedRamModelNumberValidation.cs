using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PCHCB.Data.Migrations
{
    public partial class addedRamModelNumberValidation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ModelNumber",
                table: "Rams",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ModelNumber",
                table: "Rams",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);

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
    }
}
