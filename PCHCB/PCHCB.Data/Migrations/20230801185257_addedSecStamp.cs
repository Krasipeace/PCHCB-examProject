using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PCHCB.Data.Migrations
{
    public partial class addedSecStamp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("73df6910-cc0d-4f98-90a0-748c29bbd618"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8629b812-1fa5-43ad-9e76-9c00f1496a49", "AQAAAAEAACcQAAAAELCBwYy+fkkphTIrLPjSYEJEAHxjs5k855XlKxVFgerDcSMDLMn7QnwROu2ve4FD9g==", "6789486A-AC97-43BF-BB19-A9928C1F1A54" });

            migrationBuilder.UpdateData(
                table: "Cases",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedOn",
                value: new DateTime(2023, 8, 1, 18, 52, 56, 686, DateTimeKind.Utc).AddTicks(2672));

            migrationBuilder.UpdateData(
                table: "Cases",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedOn",
                value: new DateTime(2023, 8, 1, 18, 52, 56, 686, DateTimeKind.Utc).AddTicks(2700));

            migrationBuilder.UpdateData(
                table: "Cases",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddedOn",
                value: new DateTime(2023, 8, 1, 18, 52, 56, 686, DateTimeKind.Utc).AddTicks(2703));

            migrationBuilder.UpdateData(
                table: "Cases",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddedOn",
                value: new DateTime(2023, 8, 1, 18, 52, 56, 686, DateTimeKind.Utc).AddTicks(2705));

            migrationBuilder.UpdateData(
                table: "Cases",
                keyColumn: "Id",
                keyValue: 5,
                column: "AddedOn",
                value: new DateTime(2023, 8, 1, 18, 52, 56, 686, DateTimeKind.Utc).AddTicks(2711));

            migrationBuilder.UpdateData(
                table: "Coolers",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedOn",
                value: new DateTime(2023, 8, 1, 18, 52, 56, 687, DateTimeKind.Utc).AddTicks(5149));

            migrationBuilder.UpdateData(
                table: "Coolers",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedOn",
                value: new DateTime(2023, 8, 1, 18, 52, 56, 687, DateTimeKind.Utc).AddTicks(5161));

            migrationBuilder.UpdateData(
                table: "Coolers",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddedOn",
                value: new DateTime(2023, 8, 1, 18, 52, 56, 687, DateTimeKind.Utc).AddTicks(5164));

            migrationBuilder.UpdateData(
                table: "Coolers",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddedOn",
                value: new DateTime(2023, 8, 1, 18, 52, 56, 687, DateTimeKind.Utc).AddTicks(5166));

            migrationBuilder.UpdateData(
                table: "Coolers",
                keyColumn: "Id",
                keyValue: 5,
                column: "AddedOn",
                value: new DateTime(2023, 8, 1, 18, 52, 56, 687, DateTimeKind.Utc).AddTicks(5171));

            migrationBuilder.UpdateData(
                table: "Coolers",
                keyColumn: "Id",
                keyValue: 6,
                column: "AddedOn",
                value: new DateTime(2023, 8, 1, 18, 52, 56, 687, DateTimeKind.Utc).AddTicks(5173));

            migrationBuilder.UpdateData(
                table: "Coolers",
                keyColumn: "Id",
                keyValue: 7,
                column: "AddedOn",
                value: new DateTime(2023, 8, 1, 18, 52, 56, 687, DateTimeKind.Utc).AddTicks(5176));

            migrationBuilder.UpdateData(
                table: "Coolers",
                keyColumn: "Id",
                keyValue: 8,
                column: "AddedOn",
                value: new DateTime(2023, 8, 1, 18, 52, 56, 687, DateTimeKind.Utc).AddTicks(5179));

            migrationBuilder.UpdateData(
                table: "Coolers",
                keyColumn: "Id",
                keyValue: 9,
                column: "AddedOn",
                value: new DateTime(2023, 8, 1, 18, 52, 56, 687, DateTimeKind.Utc).AddTicks(5182));

            migrationBuilder.UpdateData(
                table: "Coolers",
                keyColumn: "Id",
                keyValue: 10,
                column: "AddedOn",
                value: new DateTime(2023, 8, 1, 18, 52, 56, 687, DateTimeKind.Utc).AddTicks(5185));

            migrationBuilder.UpdateData(
                table: "Cpus",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedOn",
                value: new DateTime(2023, 8, 1, 18, 52, 56, 687, DateTimeKind.Utc).AddTicks(5976));

            migrationBuilder.UpdateData(
                table: "Cpus",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedOn",
                value: new DateTime(2023, 8, 1, 18, 52, 56, 687, DateTimeKind.Utc).AddTicks(6012));

            migrationBuilder.UpdateData(
                table: "Cpus",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddedOn",
                value: new DateTime(2023, 8, 1, 18, 52, 56, 687, DateTimeKind.Utc).AddTicks(6015));

            migrationBuilder.UpdateData(
                table: "Cpus",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddedOn",
                value: new DateTime(2023, 8, 1, 18, 52, 56, 687, DateTimeKind.Utc).AddTicks(6017));

            migrationBuilder.UpdateData(
                table: "Cpus",
                keyColumn: "Id",
                keyValue: 5,
                column: "AddedOn",
                value: new DateTime(2023, 8, 1, 18, 52, 56, 687, DateTimeKind.Utc).AddTicks(6019));

            migrationBuilder.UpdateData(
                table: "Cpus",
                keyColumn: "Id",
                keyValue: 6,
                column: "AddedOn",
                value: new DateTime(2023, 8, 1, 18, 52, 56, 687, DateTimeKind.Utc).AddTicks(6023));

            migrationBuilder.UpdateData(
                table: "Cpus",
                keyColumn: "Id",
                keyValue: 7,
                column: "AddedOn",
                value: new DateTime(2023, 8, 1, 18, 52, 56, 687, DateTimeKind.Utc).AddTicks(6026));

            migrationBuilder.UpdateData(
                table: "Gpus",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedOn",
                value: new DateTime(2023, 8, 1, 18, 52, 56, 687, DateTimeKind.Utc).AddTicks(6800));

            migrationBuilder.UpdateData(
                table: "Gpus",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedOn",
                value: new DateTime(2023, 8, 1, 18, 52, 56, 687, DateTimeKind.Utc).AddTicks(6808));

            migrationBuilder.UpdateData(
                table: "Gpus",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddedOn",
                value: new DateTime(2023, 8, 1, 18, 52, 56, 687, DateTimeKind.Utc).AddTicks(6810));

            migrationBuilder.UpdateData(
                table: "Gpus",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddedOn",
                value: new DateTime(2023, 8, 1, 18, 52, 56, 687, DateTimeKind.Utc).AddTicks(6813));

            migrationBuilder.UpdateData(
                table: "Gpus",
                keyColumn: "Id",
                keyValue: 5,
                column: "AddedOn",
                value: new DateTime(2023, 8, 1, 18, 52, 56, 687, DateTimeKind.Utc).AddTicks(6818));

            migrationBuilder.UpdateData(
                table: "Gpus",
                keyColumn: "Id",
                keyValue: 6,
                column: "AddedOn",
                value: new DateTime(2023, 8, 1, 18, 52, 56, 687, DateTimeKind.Utc).AddTicks(6821));

            migrationBuilder.UpdateData(
                table: "Gpus",
                keyColumn: "Id",
                keyValue: 7,
                column: "AddedOn",
                value: new DateTime(2023, 8, 1, 18, 52, 56, 687, DateTimeKind.Utc).AddTicks(6823));

            migrationBuilder.UpdateData(
                table: "Gpus",
                keyColumn: "Id",
                keyValue: 8,
                column: "AddedOn",
                value: new DateTime(2023, 8, 1, 18, 52, 56, 687, DateTimeKind.Utc).AddTicks(6826));

            migrationBuilder.UpdateData(
                table: "Motherboards",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedOn",
                value: new DateTime(2023, 8, 1, 18, 52, 56, 687, DateTimeKind.Utc).AddTicks(7619));

            migrationBuilder.UpdateData(
                table: "Motherboards",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedOn",
                value: new DateTime(2023, 8, 1, 18, 52, 56, 687, DateTimeKind.Utc).AddTicks(7626));

            migrationBuilder.UpdateData(
                table: "Motherboards",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddedOn",
                value: new DateTime(2023, 8, 1, 18, 52, 56, 687, DateTimeKind.Utc).AddTicks(7629));

            migrationBuilder.UpdateData(
                table: "Motherboards",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddedOn",
                value: new DateTime(2023, 8, 1, 18, 52, 56, 687, DateTimeKind.Utc).AddTicks(7631));

            migrationBuilder.UpdateData(
                table: "Motherboards",
                keyColumn: "Id",
                keyValue: 5,
                column: "AddedOn",
                value: new DateTime(2023, 8, 1, 18, 52, 56, 687, DateTimeKind.Utc).AddTicks(7634));

            migrationBuilder.UpdateData(
                table: "Motherboards",
                keyColumn: "Id",
                keyValue: 6,
                column: "AddedOn",
                value: new DateTime(2023, 8, 1, 18, 52, 56, 687, DateTimeKind.Utc).AddTicks(7637));

            migrationBuilder.UpdateData(
                table: "Motherboards",
                keyColumn: "Id",
                keyValue: 7,
                column: "AddedOn",
                value: new DateTime(2023, 8, 1, 18, 52, 56, 687, DateTimeKind.Utc).AddTicks(7640));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedOn",
                value: new DateTime(2023, 8, 1, 18, 52, 56, 687, DateTimeKind.Utc).AddTicks(8411));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedOn",
                value: new DateTime(2023, 8, 1, 18, 52, 56, 687, DateTimeKind.Utc).AddTicks(8419));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddedOn",
                value: new DateTime(2023, 8, 1, 18, 52, 56, 687, DateTimeKind.Utc).AddTicks(8421));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddedOn",
                value: new DateTime(2023, 8, 1, 18, 52, 56, 687, DateTimeKind.Utc).AddTicks(8424));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 5,
                column: "AddedOn",
                value: new DateTime(2023, 8, 1, 18, 52, 56, 687, DateTimeKind.Utc).AddTicks(8428));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 6,
                column: "AddedOn",
                value: new DateTime(2023, 8, 1, 18, 52, 56, 687, DateTimeKind.Utc).AddTicks(8430));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 7,
                column: "AddedOn",
                value: new DateTime(2023, 8, 1, 18, 52, 56, 687, DateTimeKind.Utc).AddTicks(8433));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 8,
                column: "AddedOn",
                value: new DateTime(2023, 8, 1, 18, 52, 56, 687, DateTimeKind.Utc).AddTicks(8435));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 9,
                column: "AddedOn",
                value: new DateTime(2023, 8, 1, 18, 52, 56, 687, DateTimeKind.Utc).AddTicks(8465));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 10,
                column: "AddedOn",
                value: new DateTime(2023, 8, 1, 18, 52, 56, 687, DateTimeKind.Utc).AddTicks(8468));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 11,
                column: "AddedOn",
                value: new DateTime(2023, 8, 1, 18, 52, 56, 687, DateTimeKind.Utc).AddTicks(8470));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 12,
                column: "AddedOn",
                value: new DateTime(2023, 8, 1, 18, 52, 56, 687, DateTimeKind.Utc).AddTicks(8473));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 13,
                column: "AddedOn",
                value: new DateTime(2023, 8, 1, 18, 52, 56, 687, DateTimeKind.Utc).AddTicks(8475));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedOn",
                value: new DateTime(2023, 8, 1, 18, 52, 56, 687, DateTimeKind.Utc).AddTicks(9259));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedOn",
                value: new DateTime(2023, 8, 1, 18, 52, 56, 687, DateTimeKind.Utc).AddTicks(9267));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddedOn",
                value: new DateTime(2023, 8, 1, 18, 52, 56, 687, DateTimeKind.Utc).AddTicks(9269));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddedOn",
                value: new DateTime(2023, 8, 1, 18, 52, 56, 687, DateTimeKind.Utc).AddTicks(9272));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 5,
                column: "AddedOn",
                value: new DateTime(2023, 8, 1, 18, 52, 56, 687, DateTimeKind.Utc).AddTicks(9276));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 6,
                column: "AddedOn",
                value: new DateTime(2023, 8, 1, 18, 52, 56, 687, DateTimeKind.Utc).AddTicks(9279));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 7,
                column: "AddedOn",
                value: new DateTime(2023, 8, 1, 18, 52, 56, 687, DateTimeKind.Utc).AddTicks(9281));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 8,
                column: "AddedOn",
                value: new DateTime(2023, 8, 1, 18, 52, 56, 687, DateTimeKind.Utc).AddTicks(9283));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 9,
                column: "AddedOn",
                value: new DateTime(2023, 8, 1, 18, 52, 56, 687, DateTimeKind.Utc).AddTicks(9287));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 10,
                column: "AddedOn",
                value: new DateTime(2023, 8, 1, 18, 52, 56, 687, DateTimeKind.Utc).AddTicks(9290));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 11,
                column: "AddedOn",
                value: new DateTime(2023, 8, 1, 18, 52, 56, 687, DateTimeKind.Utc).AddTicks(9292));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 12,
                column: "AddedOn",
                value: new DateTime(2023, 8, 1, 18, 52, 56, 687, DateTimeKind.Utc).AddTicks(9294));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 13,
                column: "AddedOn",
                value: new DateTime(2023, 8, 1, 18, 52, 56, 687, DateTimeKind.Utc).AddTicks(9297));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 14,
                column: "AddedOn",
                value: new DateTime(2023, 8, 1, 18, 52, 56, 687, DateTimeKind.Utc).AddTicks(9299));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 15,
                column: "AddedOn",
                value: new DateTime(2023, 8, 1, 18, 52, 56, 687, DateTimeKind.Utc).AddTicks(9302));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 16,
                column: "AddedOn",
                value: new DateTime(2023, 8, 1, 18, 52, 56, 687, DateTimeKind.Utc).AddTicks(9304));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 17,
                column: "AddedOn",
                value: new DateTime(2023, 8, 1, 18, 52, 56, 687, DateTimeKind.Utc).AddTicks(9307));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 18,
                column: "AddedOn",
                value: new DateTime(2023, 8, 1, 18, 52, 56, 687, DateTimeKind.Utc).AddTicks(9309));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 19,
                column: "AddedOn",
                value: new DateTime(2023, 8, 1, 18, 52, 56, 687, DateTimeKind.Utc).AddTicks(9313));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 20,
                column: "AddedOn",
                value: new DateTime(2023, 8, 1, 18, 52, 56, 687, DateTimeKind.Utc).AddTicks(9316));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedOn",
                value: new DateTime(2023, 8, 1, 18, 52, 56, 688, DateTimeKind.Utc).AddTicks(81));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedOn",
                value: new DateTime(2023, 8, 1, 18, 52, 56, 688, DateTimeKind.Utc).AddTicks(89));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddedOn",
                value: new DateTime(2023, 8, 1, 18, 52, 56, 688, DateTimeKind.Utc).AddTicks(91));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddedOn",
                value: new DateTime(2023, 8, 1, 18, 52, 56, 688, DateTimeKind.Utc).AddTicks(94));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 5,
                column: "AddedOn",
                value: new DateTime(2023, 8, 1, 18, 52, 56, 688, DateTimeKind.Utc).AddTicks(140));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 6,
                column: "AddedOn",
                value: new DateTime(2023, 8, 1, 18, 52, 56, 688, DateTimeKind.Utc).AddTicks(143));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 7,
                column: "AddedOn",
                value: new DateTime(2023, 8, 1, 18, 52, 56, 688, DateTimeKind.Utc).AddTicks(145));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 8,
                column: "AddedOn",
                value: new DateTime(2023, 8, 1, 18, 52, 56, 688, DateTimeKind.Utc).AddTicks(147));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 9,
                column: "AddedOn",
                value: new DateTime(2023, 8, 1, 18, 52, 56, 688, DateTimeKind.Utc).AddTicks(151));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 10,
                column: "AddedOn",
                value: new DateTime(2023, 8, 1, 18, 52, 56, 688, DateTimeKind.Utc).AddTicks(153));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 11,
                column: "AddedOn",
                value: new DateTime(2023, 8, 1, 18, 52, 56, 688, DateTimeKind.Utc).AddTicks(155));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 12,
                column: "AddedOn",
                value: new DateTime(2023, 8, 1, 18, 52, 56, 688, DateTimeKind.Utc).AddTicks(160));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 13,
                column: "AddedOn",
                value: new DateTime(2023, 8, 1, 18, 52, 56, 688, DateTimeKind.Utc).AddTicks(162));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 14,
                column: "AddedOn",
                value: new DateTime(2023, 8, 1, 18, 52, 56, 688, DateTimeKind.Utc).AddTicks(165));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 15,
                column: "AddedOn",
                value: new DateTime(2023, 8, 1, 18, 52, 56, 688, DateTimeKind.Utc).AddTicks(167));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 16,
                column: "AddedOn",
                value: new DateTime(2023, 8, 1, 18, 52, 56, 688, DateTimeKind.Utc).AddTicks(170));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 17,
                column: "AddedOn",
                value: new DateTime(2023, 8, 1, 18, 52, 56, 688, DateTimeKind.Utc).AddTicks(172));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 18,
                column: "AddedOn",
                value: new DateTime(2023, 8, 1, 18, 52, 56, 688, DateTimeKind.Utc).AddTicks(174));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("73df6910-cc0d-4f98-90a0-748c29bbd618"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3daa9475-382d-40c7-aa2c-e85819b5c52d", "AQAAAAEAACcQAAAAEDeTLDHCmIyge0z1mVgC6hztszBkV3AE/vmmUjIKhURPSxOQ+J09PPFyyjTWnQxszw==", null });

            migrationBuilder.UpdateData(
                table: "Cases",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedOn",
                value: new DateTime(2023, 8, 1, 17, 42, 58, 444, DateTimeKind.Utc).AddTicks(2547));

            migrationBuilder.UpdateData(
                table: "Cases",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedOn",
                value: new DateTime(2023, 8, 1, 17, 42, 58, 444, DateTimeKind.Utc).AddTicks(2576));

            migrationBuilder.UpdateData(
                table: "Cases",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddedOn",
                value: new DateTime(2023, 8, 1, 17, 42, 58, 444, DateTimeKind.Utc).AddTicks(2579));

            migrationBuilder.UpdateData(
                table: "Cases",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddedOn",
                value: new DateTime(2023, 8, 1, 17, 42, 58, 444, DateTimeKind.Utc).AddTicks(2582));

            migrationBuilder.UpdateData(
                table: "Cases",
                keyColumn: "Id",
                keyValue: 5,
                column: "AddedOn",
                value: new DateTime(2023, 8, 1, 17, 42, 58, 444, DateTimeKind.Utc).AddTicks(2588));

            migrationBuilder.UpdateData(
                table: "Coolers",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedOn",
                value: new DateTime(2023, 8, 1, 17, 42, 58, 445, DateTimeKind.Utc).AddTicks(5301));

            migrationBuilder.UpdateData(
                table: "Coolers",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedOn",
                value: new DateTime(2023, 8, 1, 17, 42, 58, 445, DateTimeKind.Utc).AddTicks(5317));

            migrationBuilder.UpdateData(
                table: "Coolers",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddedOn",
                value: new DateTime(2023, 8, 1, 17, 42, 58, 445, DateTimeKind.Utc).AddTicks(5320));

            migrationBuilder.UpdateData(
                table: "Coolers",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddedOn",
                value: new DateTime(2023, 8, 1, 17, 42, 58, 445, DateTimeKind.Utc).AddTicks(5322));

            migrationBuilder.UpdateData(
                table: "Coolers",
                keyColumn: "Id",
                keyValue: 5,
                column: "AddedOn",
                value: new DateTime(2023, 8, 1, 17, 42, 58, 445, DateTimeKind.Utc).AddTicks(5328));

            migrationBuilder.UpdateData(
                table: "Coolers",
                keyColumn: "Id",
                keyValue: 6,
                column: "AddedOn",
                value: new DateTime(2023, 8, 1, 17, 42, 58, 445, DateTimeKind.Utc).AddTicks(5330));

            migrationBuilder.UpdateData(
                table: "Coolers",
                keyColumn: "Id",
                keyValue: 7,
                column: "AddedOn",
                value: new DateTime(2023, 8, 1, 17, 42, 58, 445, DateTimeKind.Utc).AddTicks(5333));

            migrationBuilder.UpdateData(
                table: "Coolers",
                keyColumn: "Id",
                keyValue: 8,
                column: "AddedOn",
                value: new DateTime(2023, 8, 1, 17, 42, 58, 445, DateTimeKind.Utc).AddTicks(5336));

            migrationBuilder.UpdateData(
                table: "Coolers",
                keyColumn: "Id",
                keyValue: 9,
                column: "AddedOn",
                value: new DateTime(2023, 8, 1, 17, 42, 58, 445, DateTimeKind.Utc).AddTicks(5339));

            migrationBuilder.UpdateData(
                table: "Coolers",
                keyColumn: "Id",
                keyValue: 10,
                column: "AddedOn",
                value: new DateTime(2023, 8, 1, 17, 42, 58, 445, DateTimeKind.Utc).AddTicks(5342));

            migrationBuilder.UpdateData(
                table: "Cpus",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedOn",
                value: new DateTime(2023, 8, 1, 17, 42, 58, 445, DateTimeKind.Utc).AddTicks(6197));

            migrationBuilder.UpdateData(
                table: "Cpus",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedOn",
                value: new DateTime(2023, 8, 1, 17, 42, 58, 445, DateTimeKind.Utc).AddTicks(6204));

            migrationBuilder.UpdateData(
                table: "Cpus",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddedOn",
                value: new DateTime(2023, 8, 1, 17, 42, 58, 445, DateTimeKind.Utc).AddTicks(6207));

            migrationBuilder.UpdateData(
                table: "Cpus",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddedOn",
                value: new DateTime(2023, 8, 1, 17, 42, 58, 445, DateTimeKind.Utc).AddTicks(6209));

            migrationBuilder.UpdateData(
                table: "Cpus",
                keyColumn: "Id",
                keyValue: 5,
                column: "AddedOn",
                value: new DateTime(2023, 8, 1, 17, 42, 58, 445, DateTimeKind.Utc).AddTicks(6211));

            migrationBuilder.UpdateData(
                table: "Cpus",
                keyColumn: "Id",
                keyValue: 6,
                column: "AddedOn",
                value: new DateTime(2023, 8, 1, 17, 42, 58, 445, DateTimeKind.Utc).AddTicks(6215));

            migrationBuilder.UpdateData(
                table: "Cpus",
                keyColumn: "Id",
                keyValue: 7,
                column: "AddedOn",
                value: new DateTime(2023, 8, 1, 17, 42, 58, 445, DateTimeKind.Utc).AddTicks(6217));

            migrationBuilder.UpdateData(
                table: "Gpus",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedOn",
                value: new DateTime(2023, 8, 1, 17, 42, 58, 445, DateTimeKind.Utc).AddTicks(7068));

            migrationBuilder.UpdateData(
                table: "Gpus",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedOn",
                value: new DateTime(2023, 8, 1, 17, 42, 58, 445, DateTimeKind.Utc).AddTicks(7075));

            migrationBuilder.UpdateData(
                table: "Gpus",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddedOn",
                value: new DateTime(2023, 8, 1, 17, 42, 58, 445, DateTimeKind.Utc).AddTicks(7078));

            migrationBuilder.UpdateData(
                table: "Gpus",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddedOn",
                value: new DateTime(2023, 8, 1, 17, 42, 58, 445, DateTimeKind.Utc).AddTicks(7080));

            migrationBuilder.UpdateData(
                table: "Gpus",
                keyColumn: "Id",
                keyValue: 5,
                column: "AddedOn",
                value: new DateTime(2023, 8, 1, 17, 42, 58, 445, DateTimeKind.Utc).AddTicks(7085));

            migrationBuilder.UpdateData(
                table: "Gpus",
                keyColumn: "Id",
                keyValue: 6,
                column: "AddedOn",
                value: new DateTime(2023, 8, 1, 17, 42, 58, 445, DateTimeKind.Utc).AddTicks(7087));

            migrationBuilder.UpdateData(
                table: "Gpus",
                keyColumn: "Id",
                keyValue: 7,
                column: "AddedOn",
                value: new DateTime(2023, 8, 1, 17, 42, 58, 445, DateTimeKind.Utc).AddTicks(7090));

            migrationBuilder.UpdateData(
                table: "Gpus",
                keyColumn: "Id",
                keyValue: 8,
                column: "AddedOn",
                value: new DateTime(2023, 8, 1, 17, 42, 58, 445, DateTimeKind.Utc).AddTicks(7092));

            migrationBuilder.UpdateData(
                table: "Motherboards",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedOn",
                value: new DateTime(2023, 8, 1, 17, 42, 58, 445, DateTimeKind.Utc).AddTicks(7876));

            migrationBuilder.UpdateData(
                table: "Motherboards",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedOn",
                value: new DateTime(2023, 8, 1, 17, 42, 58, 445, DateTimeKind.Utc).AddTicks(7883));

            migrationBuilder.UpdateData(
                table: "Motherboards",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddedOn",
                value: new DateTime(2023, 8, 1, 17, 42, 58, 445, DateTimeKind.Utc).AddTicks(7885));

            migrationBuilder.UpdateData(
                table: "Motherboards",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddedOn",
                value: new DateTime(2023, 8, 1, 17, 42, 58, 445, DateTimeKind.Utc).AddTicks(7888));

            migrationBuilder.UpdateData(
                table: "Motherboards",
                keyColumn: "Id",
                keyValue: 5,
                column: "AddedOn",
                value: new DateTime(2023, 8, 1, 17, 42, 58, 445, DateTimeKind.Utc).AddTicks(7890));

            migrationBuilder.UpdateData(
                table: "Motherboards",
                keyColumn: "Id",
                keyValue: 6,
                column: "AddedOn",
                value: new DateTime(2023, 8, 1, 17, 42, 58, 445, DateTimeKind.Utc).AddTicks(7894));

            migrationBuilder.UpdateData(
                table: "Motherboards",
                keyColumn: "Id",
                keyValue: 7,
                column: "AddedOn",
                value: new DateTime(2023, 8, 1, 17, 42, 58, 445, DateTimeKind.Utc).AddTicks(7896));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedOn",
                value: new DateTime(2023, 8, 1, 17, 42, 58, 445, DateTimeKind.Utc).AddTicks(8742));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedOn",
                value: new DateTime(2023, 8, 1, 17, 42, 58, 445, DateTimeKind.Utc).AddTicks(8750));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddedOn",
                value: new DateTime(2023, 8, 1, 17, 42, 58, 445, DateTimeKind.Utc).AddTicks(8753));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddedOn",
                value: new DateTime(2023, 8, 1, 17, 42, 58, 445, DateTimeKind.Utc).AddTicks(8755));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 5,
                column: "AddedOn",
                value: new DateTime(2023, 8, 1, 17, 42, 58, 445, DateTimeKind.Utc).AddTicks(8758));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 6,
                column: "AddedOn",
                value: new DateTime(2023, 8, 1, 17, 42, 58, 445, DateTimeKind.Utc).AddTicks(8761));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 7,
                column: "AddedOn",
                value: new DateTime(2023, 8, 1, 17, 42, 58, 445, DateTimeKind.Utc).AddTicks(8799));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 8,
                column: "AddedOn",
                value: new DateTime(2023, 8, 1, 17, 42, 58, 445, DateTimeKind.Utc).AddTicks(8802));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 9,
                column: "AddedOn",
                value: new DateTime(2023, 8, 1, 17, 42, 58, 445, DateTimeKind.Utc).AddTicks(8806));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 10,
                column: "AddedOn",
                value: new DateTime(2023, 8, 1, 17, 42, 58, 445, DateTimeKind.Utc).AddTicks(8808));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 11,
                column: "AddedOn",
                value: new DateTime(2023, 8, 1, 17, 42, 58, 445, DateTimeKind.Utc).AddTicks(8810));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 12,
                column: "AddedOn",
                value: new DateTime(2023, 8, 1, 17, 42, 58, 445, DateTimeKind.Utc).AddTicks(8812));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 13,
                column: "AddedOn",
                value: new DateTime(2023, 8, 1, 17, 42, 58, 445, DateTimeKind.Utc).AddTicks(8815));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedOn",
                value: new DateTime(2023, 8, 1, 17, 42, 58, 445, DateTimeKind.Utc).AddTicks(9647));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedOn",
                value: new DateTime(2023, 8, 1, 17, 42, 58, 445, DateTimeKind.Utc).AddTicks(9656));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddedOn",
                value: new DateTime(2023, 8, 1, 17, 42, 58, 445, DateTimeKind.Utc).AddTicks(9658));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddedOn",
                value: new DateTime(2023, 8, 1, 17, 42, 58, 445, DateTimeKind.Utc).AddTicks(9661));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 5,
                column: "AddedOn",
                value: new DateTime(2023, 8, 1, 17, 42, 58, 445, DateTimeKind.Utc).AddTicks(9665));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 6,
                column: "AddedOn",
                value: new DateTime(2023, 8, 1, 17, 42, 58, 445, DateTimeKind.Utc).AddTicks(9667));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 7,
                column: "AddedOn",
                value: new DateTime(2023, 8, 1, 17, 42, 58, 445, DateTimeKind.Utc).AddTicks(9670));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 8,
                column: "AddedOn",
                value: new DateTime(2023, 8, 1, 17, 42, 58, 445, DateTimeKind.Utc).AddTicks(9673));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 9,
                column: "AddedOn",
                value: new DateTime(2023, 8, 1, 17, 42, 58, 445, DateTimeKind.Utc).AddTicks(9676));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 10,
                column: "AddedOn",
                value: new DateTime(2023, 8, 1, 17, 42, 58, 445, DateTimeKind.Utc).AddTicks(9679));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 11,
                column: "AddedOn",
                value: new DateTime(2023, 8, 1, 17, 42, 58, 445, DateTimeKind.Utc).AddTicks(9681));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 12,
                column: "AddedOn",
                value: new DateTime(2023, 8, 1, 17, 42, 58, 445, DateTimeKind.Utc).AddTicks(9684));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 13,
                column: "AddedOn",
                value: new DateTime(2023, 8, 1, 17, 42, 58, 445, DateTimeKind.Utc).AddTicks(9686));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 14,
                column: "AddedOn",
                value: new DateTime(2023, 8, 1, 17, 42, 58, 445, DateTimeKind.Utc).AddTicks(9689));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 15,
                column: "AddedOn",
                value: new DateTime(2023, 8, 1, 17, 42, 58, 445, DateTimeKind.Utc).AddTicks(9691));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 16,
                column: "AddedOn",
                value: new DateTime(2023, 8, 1, 17, 42, 58, 445, DateTimeKind.Utc).AddTicks(9694));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 17,
                column: "AddedOn",
                value: new DateTime(2023, 8, 1, 17, 42, 58, 445, DateTimeKind.Utc).AddTicks(9696));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 18,
                column: "AddedOn",
                value: new DateTime(2023, 8, 1, 17, 42, 58, 445, DateTimeKind.Utc).AddTicks(9699));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 19,
                column: "AddedOn",
                value: new DateTime(2023, 8, 1, 17, 42, 58, 445, DateTimeKind.Utc).AddTicks(9703));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 20,
                column: "AddedOn",
                value: new DateTime(2023, 8, 1, 17, 42, 58, 445, DateTimeKind.Utc).AddTicks(9706));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedOn",
                value: new DateTime(2023, 8, 1, 17, 42, 58, 446, DateTimeKind.Utc).AddTicks(499));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedOn",
                value: new DateTime(2023, 8, 1, 17, 42, 58, 446, DateTimeKind.Utc).AddTicks(542));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddedOn",
                value: new DateTime(2023, 8, 1, 17, 42, 58, 446, DateTimeKind.Utc).AddTicks(545));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddedOn",
                value: new DateTime(2023, 8, 1, 17, 42, 58, 446, DateTimeKind.Utc).AddTicks(547));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 5,
                column: "AddedOn",
                value: new DateTime(2023, 8, 1, 17, 42, 58, 446, DateTimeKind.Utc).AddTicks(551));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 6,
                column: "AddedOn",
                value: new DateTime(2023, 8, 1, 17, 42, 58, 446, DateTimeKind.Utc).AddTicks(554));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 7,
                column: "AddedOn",
                value: new DateTime(2023, 8, 1, 17, 42, 58, 446, DateTimeKind.Utc).AddTicks(556));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 8,
                column: "AddedOn",
                value: new DateTime(2023, 8, 1, 17, 42, 58, 446, DateTimeKind.Utc).AddTicks(558));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 9,
                column: "AddedOn",
                value: new DateTime(2023, 8, 1, 17, 42, 58, 446, DateTimeKind.Utc).AddTicks(562));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 10,
                column: "AddedOn",
                value: new DateTime(2023, 8, 1, 17, 42, 58, 446, DateTimeKind.Utc).AddTicks(564));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 11,
                column: "AddedOn",
                value: new DateTime(2023, 8, 1, 17, 42, 58, 446, DateTimeKind.Utc).AddTicks(566));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 12,
                column: "AddedOn",
                value: new DateTime(2023, 8, 1, 17, 42, 58, 446, DateTimeKind.Utc).AddTicks(569));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 13,
                column: "AddedOn",
                value: new DateTime(2023, 8, 1, 17, 42, 58, 446, DateTimeKind.Utc).AddTicks(572));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 14,
                column: "AddedOn",
                value: new DateTime(2023, 8, 1, 17, 42, 58, 446, DateTimeKind.Utc).AddTicks(574));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 15,
                column: "AddedOn",
                value: new DateTime(2023, 8, 1, 17, 42, 58, 446, DateTimeKind.Utc).AddTicks(577));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 16,
                column: "AddedOn",
                value: new DateTime(2023, 8, 1, 17, 42, 58, 446, DateTimeKind.Utc).AddTicks(579));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 17,
                column: "AddedOn",
                value: new DateTime(2023, 8, 1, 17, 42, 58, 446, DateTimeKind.Utc).AddTicks(582));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 18,
                column: "AddedOn",
                value: new DateTime(2023, 8, 1, 17, 42, 58, 446, DateTimeKind.Utc).AddTicks(584));
        }
    }
}
