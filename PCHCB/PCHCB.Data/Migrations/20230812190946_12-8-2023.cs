using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PCHCB.Data.Migrations
{
    public partial class _1282023 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("73df6910-cc0d-4f98-90a0-748c29bbd618"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "6328feab-4aec-497f-b1cb-d4398bb673ac", "AQAAAAEAACcQAAAAEHSzSze0FozVD/77F4OkmGofMdIJ09TjVirgGdUgRv0aS2CyROgo5qETRjFWRO7fmQ==" });

            migrationBuilder.UpdateData(
                table: "Cases",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedOn",
                value: new DateTime(2023, 8, 12, 19, 9, 45, 541, DateTimeKind.Utc).AddTicks(401));

            migrationBuilder.UpdateData(
                table: "Cases",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedOn",
                value: new DateTime(2023, 8, 12, 19, 9, 45, 541, DateTimeKind.Utc).AddTicks(427));

            migrationBuilder.UpdateData(
                table: "Cases",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddedOn",
                value: new DateTime(2023, 8, 12, 19, 9, 45, 541, DateTimeKind.Utc).AddTicks(430));

            migrationBuilder.UpdateData(
                table: "Cases",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddedOn",
                value: new DateTime(2023, 8, 12, 19, 9, 45, 541, DateTimeKind.Utc).AddTicks(433));

            migrationBuilder.UpdateData(
                table: "Cases",
                keyColumn: "Id",
                keyValue: 5,
                column: "AddedOn",
                value: new DateTime(2023, 8, 12, 19, 9, 45, 541, DateTimeKind.Utc).AddTicks(466));

            migrationBuilder.UpdateData(
                table: "Coolers",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedOn",
                value: new DateTime(2023, 8, 12, 19, 9, 45, 542, DateTimeKind.Utc).AddTicks(2832));

            migrationBuilder.UpdateData(
                table: "Coolers",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedOn",
                value: new DateTime(2023, 8, 12, 19, 9, 45, 542, DateTimeKind.Utc).AddTicks(2845));

            migrationBuilder.UpdateData(
                table: "Coolers",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddedOn",
                value: new DateTime(2023, 8, 12, 19, 9, 45, 542, DateTimeKind.Utc).AddTicks(2848));

            migrationBuilder.UpdateData(
                table: "Coolers",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddedOn",
                value: new DateTime(2023, 8, 12, 19, 9, 45, 542, DateTimeKind.Utc).AddTicks(2851));

            migrationBuilder.UpdateData(
                table: "Coolers",
                keyColumn: "Id",
                keyValue: 5,
                column: "AddedOn",
                value: new DateTime(2023, 8, 12, 19, 9, 45, 542, DateTimeKind.Utc).AddTicks(2856));

            migrationBuilder.UpdateData(
                table: "Coolers",
                keyColumn: "Id",
                keyValue: 6,
                column: "AddedOn",
                value: new DateTime(2023, 8, 12, 19, 9, 45, 542, DateTimeKind.Utc).AddTicks(2858));

            migrationBuilder.UpdateData(
                table: "Coolers",
                keyColumn: "Id",
                keyValue: 7,
                column: "AddedOn",
                value: new DateTime(2023, 8, 12, 19, 9, 45, 542, DateTimeKind.Utc).AddTicks(2861));

            migrationBuilder.UpdateData(
                table: "Coolers",
                keyColumn: "Id",
                keyValue: 8,
                column: "AddedOn",
                value: new DateTime(2023, 8, 12, 19, 9, 45, 542, DateTimeKind.Utc).AddTicks(2863));

            migrationBuilder.UpdateData(
                table: "Coolers",
                keyColumn: "Id",
                keyValue: 9,
                column: "AddedOn",
                value: new DateTime(2023, 8, 12, 19, 9, 45, 542, DateTimeKind.Utc).AddTicks(2894));

            migrationBuilder.UpdateData(
                table: "Coolers",
                keyColumn: "Id",
                keyValue: 10,
                column: "AddedOn",
                value: new DateTime(2023, 8, 12, 19, 9, 45, 542, DateTimeKind.Utc).AddTicks(2897));

            migrationBuilder.UpdateData(
                table: "Cpus",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedOn",
                value: new DateTime(2023, 8, 12, 19, 9, 45, 542, DateTimeKind.Utc).AddTicks(3704));

            migrationBuilder.UpdateData(
                table: "Cpus",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedOn",
                value: new DateTime(2023, 8, 12, 19, 9, 45, 542, DateTimeKind.Utc).AddTicks(3710));

            migrationBuilder.UpdateData(
                table: "Cpus",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddedOn",
                value: new DateTime(2023, 8, 12, 19, 9, 45, 542, DateTimeKind.Utc).AddTicks(3713));

            migrationBuilder.UpdateData(
                table: "Cpus",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddedOn",
                value: new DateTime(2023, 8, 12, 19, 9, 45, 542, DateTimeKind.Utc).AddTicks(3715));

            migrationBuilder.UpdateData(
                table: "Cpus",
                keyColumn: "Id",
                keyValue: 5,
                column: "AddedOn",
                value: new DateTime(2023, 8, 12, 19, 9, 45, 542, DateTimeKind.Utc).AddTicks(3718));

            migrationBuilder.UpdateData(
                table: "Cpus",
                keyColumn: "Id",
                keyValue: 6,
                column: "AddedOn",
                value: new DateTime(2023, 8, 12, 19, 9, 45, 542, DateTimeKind.Utc).AddTicks(3721));

            migrationBuilder.UpdateData(
                table: "Cpus",
                keyColumn: "Id",
                keyValue: 7,
                column: "AddedOn",
                value: new DateTime(2023, 8, 12, 19, 9, 45, 542, DateTimeKind.Utc).AddTicks(3723));

            migrationBuilder.UpdateData(
                table: "Gpus",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedOn",
                value: new DateTime(2023, 8, 12, 19, 9, 45, 542, DateTimeKind.Utc).AddTicks(4497));

            migrationBuilder.UpdateData(
                table: "Gpus",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedOn",
                value: new DateTime(2023, 8, 12, 19, 9, 45, 542, DateTimeKind.Utc).AddTicks(4509));

            migrationBuilder.UpdateData(
                table: "Gpus",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddedOn",
                value: new DateTime(2023, 8, 12, 19, 9, 45, 542, DateTimeKind.Utc).AddTicks(4511));

            migrationBuilder.UpdateData(
                table: "Gpus",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddedOn",
                value: new DateTime(2023, 8, 12, 19, 9, 45, 542, DateTimeKind.Utc).AddTicks(4514));

            migrationBuilder.UpdateData(
                table: "Gpus",
                keyColumn: "Id",
                keyValue: 5,
                column: "AddedOn",
                value: new DateTime(2023, 8, 12, 19, 9, 45, 542, DateTimeKind.Utc).AddTicks(4518));

            migrationBuilder.UpdateData(
                table: "Gpus",
                keyColumn: "Id",
                keyValue: 6,
                column: "AddedOn",
                value: new DateTime(2023, 8, 12, 19, 9, 45, 542, DateTimeKind.Utc).AddTicks(4521));

            migrationBuilder.UpdateData(
                table: "Gpus",
                keyColumn: "Id",
                keyValue: 7,
                column: "AddedOn",
                value: new DateTime(2023, 8, 12, 19, 9, 45, 542, DateTimeKind.Utc).AddTicks(4523));

            migrationBuilder.UpdateData(
                table: "Gpus",
                keyColumn: "Id",
                keyValue: 8,
                column: "AddedOn",
                value: new DateTime(2023, 8, 12, 19, 9, 45, 542, DateTimeKind.Utc).AddTicks(4526));

            migrationBuilder.UpdateData(
                table: "Motherboards",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedOn",
                value: new DateTime(2023, 8, 12, 19, 9, 45, 542, DateTimeKind.Utc).AddTicks(5340));

            migrationBuilder.UpdateData(
                table: "Motherboards",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedOn",
                value: new DateTime(2023, 8, 12, 19, 9, 45, 542, DateTimeKind.Utc).AddTicks(5347));

            migrationBuilder.UpdateData(
                table: "Motherboards",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddedOn",
                value: new DateTime(2023, 8, 12, 19, 9, 45, 542, DateTimeKind.Utc).AddTicks(5349));

            migrationBuilder.UpdateData(
                table: "Motherboards",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddedOn",
                value: new DateTime(2023, 8, 12, 19, 9, 45, 542, DateTimeKind.Utc).AddTicks(5352));

            migrationBuilder.UpdateData(
                table: "Motherboards",
                keyColumn: "Id",
                keyValue: 5,
                column: "AddedOn",
                value: new DateTime(2023, 8, 12, 19, 9, 45, 542, DateTimeKind.Utc).AddTicks(5354));

            migrationBuilder.UpdateData(
                table: "Motherboards",
                keyColumn: "Id",
                keyValue: 6,
                column: "AddedOn",
                value: new DateTime(2023, 8, 12, 19, 9, 45, 542, DateTimeKind.Utc).AddTicks(5358));

            migrationBuilder.UpdateData(
                table: "Motherboards",
                keyColumn: "Id",
                keyValue: 7,
                column: "AddedOn",
                value: new DateTime(2023, 8, 12, 19, 9, 45, 542, DateTimeKind.Utc).AddTicks(5360));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedOn",
                value: new DateTime(2023, 8, 12, 19, 9, 45, 542, DateTimeKind.Utc).AddTicks(6881));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedOn",
                value: new DateTime(2023, 8, 12, 19, 9, 45, 542, DateTimeKind.Utc).AddTicks(6892));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddedOn",
                value: new DateTime(2023, 8, 12, 19, 9, 45, 542, DateTimeKind.Utc).AddTicks(6894));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddedOn",
                value: new DateTime(2023, 8, 12, 19, 9, 45, 542, DateTimeKind.Utc).AddTicks(6897));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 5,
                column: "AddedOn",
                value: new DateTime(2023, 8, 12, 19, 9, 45, 542, DateTimeKind.Utc).AddTicks(6930));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 6,
                column: "AddedOn",
                value: new DateTime(2023, 8, 12, 19, 9, 45, 542, DateTimeKind.Utc).AddTicks(6932));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 7,
                column: "AddedOn",
                value: new DateTime(2023, 8, 12, 19, 9, 45, 542, DateTimeKind.Utc).AddTicks(6935));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 8,
                column: "AddedOn",
                value: new DateTime(2023, 8, 12, 19, 9, 45, 542, DateTimeKind.Utc).AddTicks(6937));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 9,
                column: "AddedOn",
                value: new DateTime(2023, 8, 12, 19, 9, 45, 542, DateTimeKind.Utc).AddTicks(6941));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 10,
                column: "AddedOn",
                value: new DateTime(2023, 8, 12, 19, 9, 45, 542, DateTimeKind.Utc).AddTicks(6943));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 11,
                column: "AddedOn",
                value: new DateTime(2023, 8, 12, 19, 9, 45, 542, DateTimeKind.Utc).AddTicks(6945));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 12,
                column: "AddedOn",
                value: new DateTime(2023, 8, 12, 19, 9, 45, 542, DateTimeKind.Utc).AddTicks(6948));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 13,
                column: "AddedOn",
                value: new DateTime(2023, 8, 12, 19, 9, 45, 542, DateTimeKind.Utc).AddTicks(6950));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedOn",
                value: new DateTime(2023, 8, 12, 19, 9, 45, 542, DateTimeKind.Utc).AddTicks(7724));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedOn",
                value: new DateTime(2023, 8, 12, 19, 9, 45, 542, DateTimeKind.Utc).AddTicks(7732));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddedOn",
                value: new DateTime(2023, 8, 12, 19, 9, 45, 542, DateTimeKind.Utc).AddTicks(7735));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddedOn",
                value: new DateTime(2023, 8, 12, 19, 9, 45, 542, DateTimeKind.Utc).AddTicks(7737));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 5,
                column: "AddedOn",
                value: new DateTime(2023, 8, 12, 19, 9, 45, 542, DateTimeKind.Utc).AddTicks(7742));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 6,
                column: "AddedOn",
                value: new DateTime(2023, 8, 12, 19, 9, 45, 542, DateTimeKind.Utc).AddTicks(7744));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 7,
                column: "AddedOn",
                value: new DateTime(2023, 8, 12, 19, 9, 45, 542, DateTimeKind.Utc).AddTicks(7747));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 8,
                column: "AddedOn",
                value: new DateTime(2023, 8, 12, 19, 9, 45, 542, DateTimeKind.Utc).AddTicks(7749));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 9,
                column: "AddedOn",
                value: new DateTime(2023, 8, 12, 19, 9, 45, 542, DateTimeKind.Utc).AddTicks(7753));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 10,
                column: "AddedOn",
                value: new DateTime(2023, 8, 12, 19, 9, 45, 542, DateTimeKind.Utc).AddTicks(7755));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 11,
                column: "AddedOn",
                value: new DateTime(2023, 8, 12, 19, 9, 45, 542, DateTimeKind.Utc).AddTicks(7758));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 12,
                column: "AddedOn",
                value: new DateTime(2023, 8, 12, 19, 9, 45, 542, DateTimeKind.Utc).AddTicks(7760));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 13,
                column: "AddedOn",
                value: new DateTime(2023, 8, 12, 19, 9, 45, 542, DateTimeKind.Utc).AddTicks(7763));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 14,
                column: "AddedOn",
                value: new DateTime(2023, 8, 12, 19, 9, 45, 542, DateTimeKind.Utc).AddTicks(7766));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 15,
                column: "AddedOn",
                value: new DateTime(2023, 8, 12, 19, 9, 45, 542, DateTimeKind.Utc).AddTicks(7768));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 16,
                column: "AddedOn",
                value: new DateTime(2023, 8, 12, 19, 9, 45, 542, DateTimeKind.Utc).AddTicks(7770));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 17,
                column: "AddedOn",
                value: new DateTime(2023, 8, 12, 19, 9, 45, 542, DateTimeKind.Utc).AddTicks(7773));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 18,
                column: "AddedOn",
                value: new DateTime(2023, 8, 12, 19, 9, 45, 542, DateTimeKind.Utc).AddTicks(7775));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 19,
                column: "AddedOn",
                value: new DateTime(2023, 8, 12, 19, 9, 45, 542, DateTimeKind.Utc).AddTicks(7780));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 20,
                column: "AddedOn",
                value: new DateTime(2023, 8, 12, 19, 9, 45, 542, DateTimeKind.Utc).AddTicks(7783));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedOn",
                value: new DateTime(2023, 8, 12, 19, 9, 45, 542, DateTimeKind.Utc).AddTicks(8643));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedOn",
                value: new DateTime(2023, 8, 12, 19, 9, 45, 542, DateTimeKind.Utc).AddTicks(8652));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddedOn",
                value: new DateTime(2023, 8, 12, 19, 9, 45, 542, DateTimeKind.Utc).AddTicks(8655));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddedOn",
                value: new DateTime(2023, 8, 12, 19, 9, 45, 542, DateTimeKind.Utc).AddTicks(8657));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 5,
                column: "AddedOn",
                value: new DateTime(2023, 8, 12, 19, 9, 45, 542, DateTimeKind.Utc).AddTicks(8661));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 6,
                column: "AddedOn",
                value: new DateTime(2023, 8, 12, 19, 9, 45, 542, DateTimeKind.Utc).AddTicks(8663));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 7,
                column: "AddedOn",
                value: new DateTime(2023, 8, 12, 19, 9, 45, 542, DateTimeKind.Utc).AddTicks(8666));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 8,
                column: "AddedOn",
                value: new DateTime(2023, 8, 12, 19, 9, 45, 542, DateTimeKind.Utc).AddTicks(8668));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 9,
                column: "AddedOn",
                value: new DateTime(2023, 8, 12, 19, 9, 45, 542, DateTimeKind.Utc).AddTicks(8671));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 10,
                column: "AddedOn",
                value: new DateTime(2023, 8, 12, 19, 9, 45, 542, DateTimeKind.Utc).AddTicks(8674));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 11,
                column: "AddedOn",
                value: new DateTime(2023, 8, 12, 19, 9, 45, 542, DateTimeKind.Utc).AddTicks(8677));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 12,
                column: "AddedOn",
                value: new DateTime(2023, 8, 12, 19, 9, 45, 542, DateTimeKind.Utc).AddTicks(8685));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 13,
                column: "AddedOn",
                value: new DateTime(2023, 8, 12, 19, 9, 45, 542, DateTimeKind.Utc).AddTicks(8687));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 14,
                column: "AddedOn",
                value: new DateTime(2023, 8, 12, 19, 9, 45, 542, DateTimeKind.Utc).AddTicks(8689));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 15,
                column: "AddedOn",
                value: new DateTime(2023, 8, 12, 19, 9, 45, 542, DateTimeKind.Utc).AddTicks(8691));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 16,
                column: "AddedOn",
                value: new DateTime(2023, 8, 12, 19, 9, 45, 542, DateTimeKind.Utc).AddTicks(8694));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 17,
                column: "AddedOn",
                value: new DateTime(2023, 8, 12, 19, 9, 45, 542, DateTimeKind.Utc).AddTicks(8696));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 18,
                column: "AddedOn",
                value: new DateTime(2023, 8, 12, 19, 9, 45, 542, DateTimeKind.Utc).AddTicks(8698));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("73df6910-cc0d-4f98-90a0-748c29bbd618"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "72b3c206-cc1f-4e9a-8369-3fe77f921169", "AQAAAAEAACcQAAAAEK/Ii+NaG+ilLbHM6PkdLnjzUIks6eCEv92rfCc2/27EAqjXn4HiNN0tFVDjgq/hSQ==" });

            migrationBuilder.UpdateData(
                table: "Cases",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedOn",
                value: new DateTime(2023, 8, 10, 12, 21, 7, 185, DateTimeKind.Utc).AddTicks(4565));

            migrationBuilder.UpdateData(
                table: "Cases",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedOn",
                value: new DateTime(2023, 8, 10, 12, 21, 7, 185, DateTimeKind.Utc).AddTicks(4608));

            migrationBuilder.UpdateData(
                table: "Cases",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddedOn",
                value: new DateTime(2023, 8, 10, 12, 21, 7, 185, DateTimeKind.Utc).AddTicks(4611));

            migrationBuilder.UpdateData(
                table: "Cases",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddedOn",
                value: new DateTime(2023, 8, 10, 12, 21, 7, 185, DateTimeKind.Utc).AddTicks(4614));

            migrationBuilder.UpdateData(
                table: "Cases",
                keyColumn: "Id",
                keyValue: 5,
                column: "AddedOn",
                value: new DateTime(2023, 8, 10, 12, 21, 7, 185, DateTimeKind.Utc).AddTicks(4620));

            migrationBuilder.UpdateData(
                table: "Coolers",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedOn",
                value: new DateTime(2023, 8, 10, 12, 21, 7, 187, DateTimeKind.Utc).AddTicks(3192));

            migrationBuilder.UpdateData(
                table: "Coolers",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedOn",
                value: new DateTime(2023, 8, 10, 12, 21, 7, 187, DateTimeKind.Utc).AddTicks(3220));

            migrationBuilder.UpdateData(
                table: "Coolers",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddedOn",
                value: new DateTime(2023, 8, 10, 12, 21, 7, 187, DateTimeKind.Utc).AddTicks(3224));

            migrationBuilder.UpdateData(
                table: "Coolers",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddedOn",
                value: new DateTime(2023, 8, 10, 12, 21, 7, 187, DateTimeKind.Utc).AddTicks(3228));

            migrationBuilder.UpdateData(
                table: "Coolers",
                keyColumn: "Id",
                keyValue: 5,
                column: "AddedOn",
                value: new DateTime(2023, 8, 10, 12, 21, 7, 187, DateTimeKind.Utc).AddTicks(3236));

            migrationBuilder.UpdateData(
                table: "Coolers",
                keyColumn: "Id",
                keyValue: 6,
                column: "AddedOn",
                value: new DateTime(2023, 8, 10, 12, 21, 7, 187, DateTimeKind.Utc).AddTicks(3240));

            migrationBuilder.UpdateData(
                table: "Coolers",
                keyColumn: "Id",
                keyValue: 7,
                column: "AddedOn",
                value: new DateTime(2023, 8, 10, 12, 21, 7, 187, DateTimeKind.Utc).AddTicks(3244));

            migrationBuilder.UpdateData(
                table: "Coolers",
                keyColumn: "Id",
                keyValue: 8,
                column: "AddedOn",
                value: new DateTime(2023, 8, 10, 12, 21, 7, 187, DateTimeKind.Utc).AddTicks(3248));

            migrationBuilder.UpdateData(
                table: "Coolers",
                keyColumn: "Id",
                keyValue: 9,
                column: "AddedOn",
                value: new DateTime(2023, 8, 10, 12, 21, 7, 187, DateTimeKind.Utc).AddTicks(3253));

            migrationBuilder.UpdateData(
                table: "Coolers",
                keyColumn: "Id",
                keyValue: 10,
                column: "AddedOn",
                value: new DateTime(2023, 8, 10, 12, 21, 7, 187, DateTimeKind.Utc).AddTicks(3257));

            migrationBuilder.UpdateData(
                table: "Cpus",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedOn",
                value: new DateTime(2023, 8, 10, 12, 21, 7, 187, DateTimeKind.Utc).AddTicks(4523));

            migrationBuilder.UpdateData(
                table: "Cpus",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedOn",
                value: new DateTime(2023, 8, 10, 12, 21, 7, 187, DateTimeKind.Utc).AddTicks(4533));

            migrationBuilder.UpdateData(
                table: "Cpus",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddedOn",
                value: new DateTime(2023, 8, 10, 12, 21, 7, 187, DateTimeKind.Utc).AddTicks(4537));

            migrationBuilder.UpdateData(
                table: "Cpus",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddedOn",
                value: new DateTime(2023, 8, 10, 12, 21, 7, 187, DateTimeKind.Utc).AddTicks(4541));

            migrationBuilder.UpdateData(
                table: "Cpus",
                keyColumn: "Id",
                keyValue: 5,
                column: "AddedOn",
                value: new DateTime(2023, 8, 10, 12, 21, 7, 187, DateTimeKind.Utc).AddTicks(4544));

            migrationBuilder.UpdateData(
                table: "Cpus",
                keyColumn: "Id",
                keyValue: 6,
                column: "AddedOn",
                value: new DateTime(2023, 8, 10, 12, 21, 7, 187, DateTimeKind.Utc).AddTicks(4549));

            migrationBuilder.UpdateData(
                table: "Cpus",
                keyColumn: "Id",
                keyValue: 7,
                column: "AddedOn",
                value: new DateTime(2023, 8, 10, 12, 21, 7, 187, DateTimeKind.Utc).AddTicks(4553));

            migrationBuilder.UpdateData(
                table: "Gpus",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedOn",
                value: new DateTime(2023, 8, 10, 12, 21, 7, 187, DateTimeKind.Utc).AddTicks(5713));

            migrationBuilder.UpdateData(
                table: "Gpus",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedOn",
                value: new DateTime(2023, 8, 10, 12, 21, 7, 187, DateTimeKind.Utc).AddTicks(5725));

            migrationBuilder.UpdateData(
                table: "Gpus",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddedOn",
                value: new DateTime(2023, 8, 10, 12, 21, 7, 187, DateTimeKind.Utc).AddTicks(5730));

            migrationBuilder.UpdateData(
                table: "Gpus",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddedOn",
                value: new DateTime(2023, 8, 10, 12, 21, 7, 187, DateTimeKind.Utc).AddTicks(5735));

            migrationBuilder.UpdateData(
                table: "Gpus",
                keyColumn: "Id",
                keyValue: 5,
                column: "AddedOn",
                value: new DateTime(2023, 8, 10, 12, 21, 7, 187, DateTimeKind.Utc).AddTicks(5747));

            migrationBuilder.UpdateData(
                table: "Gpus",
                keyColumn: "Id",
                keyValue: 6,
                column: "AddedOn",
                value: new DateTime(2023, 8, 10, 12, 21, 7, 187, DateTimeKind.Utc).AddTicks(5823));

            migrationBuilder.UpdateData(
                table: "Gpus",
                keyColumn: "Id",
                keyValue: 7,
                column: "AddedOn",
                value: new DateTime(2023, 8, 10, 12, 21, 7, 187, DateTimeKind.Utc).AddTicks(5828));

            migrationBuilder.UpdateData(
                table: "Gpus",
                keyColumn: "Id",
                keyValue: 8,
                column: "AddedOn",
                value: new DateTime(2023, 8, 10, 12, 21, 7, 187, DateTimeKind.Utc).AddTicks(5833));

            migrationBuilder.UpdateData(
                table: "Motherboards",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedOn",
                value: new DateTime(2023, 8, 10, 12, 21, 7, 187, DateTimeKind.Utc).AddTicks(7314));

            migrationBuilder.UpdateData(
                table: "Motherboards",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedOn",
                value: new DateTime(2023, 8, 10, 12, 21, 7, 187, DateTimeKind.Utc).AddTicks(7323));

            migrationBuilder.UpdateData(
                table: "Motherboards",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddedOn",
                value: new DateTime(2023, 8, 10, 12, 21, 7, 187, DateTimeKind.Utc).AddTicks(7326));

            migrationBuilder.UpdateData(
                table: "Motherboards",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddedOn",
                value: new DateTime(2023, 8, 10, 12, 21, 7, 187, DateTimeKind.Utc).AddTicks(7328));

            migrationBuilder.UpdateData(
                table: "Motherboards",
                keyColumn: "Id",
                keyValue: 5,
                column: "AddedOn",
                value: new DateTime(2023, 8, 10, 12, 21, 7, 187, DateTimeKind.Utc).AddTicks(7330));

            migrationBuilder.UpdateData(
                table: "Motherboards",
                keyColumn: "Id",
                keyValue: 6,
                column: "AddedOn",
                value: new DateTime(2023, 8, 10, 12, 21, 7, 187, DateTimeKind.Utc).AddTicks(7334));

            migrationBuilder.UpdateData(
                table: "Motherboards",
                keyColumn: "Id",
                keyValue: 7,
                column: "AddedOn",
                value: new DateTime(2023, 8, 10, 12, 21, 7, 187, DateTimeKind.Utc).AddTicks(7337));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedOn",
                value: new DateTime(2023, 8, 10, 12, 21, 7, 187, DateTimeKind.Utc).AddTicks(9228));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedOn",
                value: new DateTime(2023, 8, 10, 12, 21, 7, 187, DateTimeKind.Utc).AddTicks(9235));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddedOn",
                value: new DateTime(2023, 8, 10, 12, 21, 7, 187, DateTimeKind.Utc).AddTicks(9237));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddedOn",
                value: new DateTime(2023, 8, 10, 12, 21, 7, 187, DateTimeKind.Utc).AddTicks(9240));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 5,
                column: "AddedOn",
                value: new DateTime(2023, 8, 10, 12, 21, 7, 187, DateTimeKind.Utc).AddTicks(9246));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 6,
                column: "AddedOn",
                value: new DateTime(2023, 8, 10, 12, 21, 7, 187, DateTimeKind.Utc).AddTicks(9248));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 7,
                column: "AddedOn",
                value: new DateTime(2023, 8, 10, 12, 21, 7, 187, DateTimeKind.Utc).AddTicks(9250));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 8,
                column: "AddedOn",
                value: new DateTime(2023, 8, 10, 12, 21, 7, 187, DateTimeKind.Utc).AddTicks(9253));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 9,
                column: "AddedOn",
                value: new DateTime(2023, 8, 10, 12, 21, 7, 187, DateTimeKind.Utc).AddTicks(9256));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 10,
                column: "AddedOn",
                value: new DateTime(2023, 8, 10, 12, 21, 7, 187, DateTimeKind.Utc).AddTicks(9259));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 11,
                column: "AddedOn",
                value: new DateTime(2023, 8, 10, 12, 21, 7, 187, DateTimeKind.Utc).AddTicks(9261));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 12,
                column: "AddedOn",
                value: new DateTime(2023, 8, 10, 12, 21, 7, 187, DateTimeKind.Utc).AddTicks(9263));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 13,
                column: "AddedOn",
                value: new DateTime(2023, 8, 10, 12, 21, 7, 187, DateTimeKind.Utc).AddTicks(9266));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedOn",
                value: new DateTime(2023, 8, 10, 12, 21, 7, 188, DateTimeKind.Utc).AddTicks(81));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedOn",
                value: new DateTime(2023, 8, 10, 12, 21, 7, 188, DateTimeKind.Utc).AddTicks(88));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddedOn",
                value: new DateTime(2023, 8, 10, 12, 21, 7, 188, DateTimeKind.Utc).AddTicks(91));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddedOn",
                value: new DateTime(2023, 8, 10, 12, 21, 7, 188, DateTimeKind.Utc).AddTicks(93));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 5,
                column: "AddedOn",
                value: new DateTime(2023, 8, 10, 12, 21, 7, 188, DateTimeKind.Utc).AddTicks(98));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 6,
                column: "AddedOn",
                value: new DateTime(2023, 8, 10, 12, 21, 7, 188, DateTimeKind.Utc).AddTicks(101));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 7,
                column: "AddedOn",
                value: new DateTime(2023, 8, 10, 12, 21, 7, 188, DateTimeKind.Utc).AddTicks(103));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 8,
                column: "AddedOn",
                value: new DateTime(2023, 8, 10, 12, 21, 7, 188, DateTimeKind.Utc).AddTicks(106));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 9,
                column: "AddedOn",
                value: new DateTime(2023, 8, 10, 12, 21, 7, 188, DateTimeKind.Utc).AddTicks(227));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 10,
                column: "AddedOn",
                value: new DateTime(2023, 8, 10, 12, 21, 7, 188, DateTimeKind.Utc).AddTicks(230));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 11,
                column: "AddedOn",
                value: new DateTime(2023, 8, 10, 12, 21, 7, 188, DateTimeKind.Utc).AddTicks(233));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 12,
                column: "AddedOn",
                value: new DateTime(2023, 8, 10, 12, 21, 7, 188, DateTimeKind.Utc).AddTicks(235));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 13,
                column: "AddedOn",
                value: new DateTime(2023, 8, 10, 12, 21, 7, 188, DateTimeKind.Utc).AddTicks(238));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 14,
                column: "AddedOn",
                value: new DateTime(2023, 8, 10, 12, 21, 7, 188, DateTimeKind.Utc).AddTicks(240));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 15,
                column: "AddedOn",
                value: new DateTime(2023, 8, 10, 12, 21, 7, 188, DateTimeKind.Utc).AddTicks(243));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 16,
                column: "AddedOn",
                value: new DateTime(2023, 8, 10, 12, 21, 7, 188, DateTimeKind.Utc).AddTicks(245));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 17,
                column: "AddedOn",
                value: new DateTime(2023, 8, 10, 12, 21, 7, 188, DateTimeKind.Utc).AddTicks(248));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 18,
                column: "AddedOn",
                value: new DateTime(2023, 8, 10, 12, 21, 7, 188, DateTimeKind.Utc).AddTicks(250));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 19,
                column: "AddedOn",
                value: new DateTime(2023, 8, 10, 12, 21, 7, 188, DateTimeKind.Utc).AddTicks(255));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 20,
                column: "AddedOn",
                value: new DateTime(2023, 8, 10, 12, 21, 7, 188, DateTimeKind.Utc).AddTicks(258));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedOn",
                value: new DateTime(2023, 8, 10, 12, 21, 7, 188, DateTimeKind.Utc).AddTicks(1051));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedOn",
                value: new DateTime(2023, 8, 10, 12, 21, 7, 188, DateTimeKind.Utc).AddTicks(1058));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddedOn",
                value: new DateTime(2023, 8, 10, 12, 21, 7, 188, DateTimeKind.Utc).AddTicks(1060));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddedOn",
                value: new DateTime(2023, 8, 10, 12, 21, 7, 188, DateTimeKind.Utc).AddTicks(1063));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 5,
                column: "AddedOn",
                value: new DateTime(2023, 8, 10, 12, 21, 7, 188, DateTimeKind.Utc).AddTicks(1067));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 6,
                column: "AddedOn",
                value: new DateTime(2023, 8, 10, 12, 21, 7, 188, DateTimeKind.Utc).AddTicks(1070));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 7,
                column: "AddedOn",
                value: new DateTime(2023, 8, 10, 12, 21, 7, 188, DateTimeKind.Utc).AddTicks(1072));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 8,
                column: "AddedOn",
                value: new DateTime(2023, 8, 10, 12, 21, 7, 188, DateTimeKind.Utc).AddTicks(1075));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 9,
                column: "AddedOn",
                value: new DateTime(2023, 8, 10, 12, 21, 7, 188, DateTimeKind.Utc).AddTicks(1080));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 10,
                column: "AddedOn",
                value: new DateTime(2023, 8, 10, 12, 21, 7, 188, DateTimeKind.Utc).AddTicks(1082));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 11,
                column: "AddedOn",
                value: new DateTime(2023, 8, 10, 12, 21, 7, 188, DateTimeKind.Utc).AddTicks(1085));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 12,
                column: "AddedOn",
                value: new DateTime(2023, 8, 10, 12, 21, 7, 188, DateTimeKind.Utc).AddTicks(1088));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 13,
                column: "AddedOn",
                value: new DateTime(2023, 8, 10, 12, 21, 7, 188, DateTimeKind.Utc).AddTicks(1091));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 14,
                column: "AddedOn",
                value: new DateTime(2023, 8, 10, 12, 21, 7, 188, DateTimeKind.Utc).AddTicks(1093));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 15,
                column: "AddedOn",
                value: new DateTime(2023, 8, 10, 12, 21, 7, 188, DateTimeKind.Utc).AddTicks(1096));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 16,
                column: "AddedOn",
                value: new DateTime(2023, 8, 10, 12, 21, 7, 188, DateTimeKind.Utc).AddTicks(1098));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 17,
                column: "AddedOn",
                value: new DateTime(2023, 8, 10, 12, 21, 7, 188, DateTimeKind.Utc).AddTicks(1100));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 18,
                column: "AddedOn",
                value: new DateTime(2023, 8, 10, 12, 21, 7, 188, DateTimeKind.Utc).AddTicks(1103));
        }
    }
}
