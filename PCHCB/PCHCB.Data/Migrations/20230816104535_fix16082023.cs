using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PCHCB.Data.Migrations
{
    public partial class fix16082023 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("73df6910-cc0d-4f98-90a0-748c29bbd618"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3973b74f-b092-4069-8161-1a551140d246", "AQAAAAEAACcQAAAAEMft08k0z8ql+c2QH7It1HOML/kl2PnijnvCtLGAaYpYN5MPxfl396/PixElylVFWA==" });

            migrationBuilder.UpdateData(
                table: "Cases",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedOn",
                value: new DateTime(2023, 8, 16, 10, 45, 34, 933, DateTimeKind.Utc).AddTicks(1540));

            migrationBuilder.UpdateData(
                table: "Cases",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedOn",
                value: new DateTime(2023, 8, 16, 10, 45, 34, 933, DateTimeKind.Utc).AddTicks(1568));

            migrationBuilder.UpdateData(
                table: "Cases",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddedOn",
                value: new DateTime(2023, 8, 16, 10, 45, 34, 933, DateTimeKind.Utc).AddTicks(1571));

            migrationBuilder.UpdateData(
                table: "Cases",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddedOn",
                value: new DateTime(2023, 8, 16, 10, 45, 34, 933, DateTimeKind.Utc).AddTicks(1574));

            migrationBuilder.UpdateData(
                table: "Cases",
                keyColumn: "Id",
                keyValue: 5,
                column: "AddedOn",
                value: new DateTime(2023, 8, 16, 10, 45, 34, 933, DateTimeKind.Utc).AddTicks(1579));

            migrationBuilder.UpdateData(
                table: "Coolers",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedOn",
                value: new DateTime(2023, 8, 16, 10, 45, 34, 934, DateTimeKind.Utc).AddTicks(7213));

            migrationBuilder.UpdateData(
                table: "Coolers",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedOn",
                value: new DateTime(2023, 8, 16, 10, 45, 34, 934, DateTimeKind.Utc).AddTicks(7231));

            migrationBuilder.UpdateData(
                table: "Coolers",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddedOn",
                value: new DateTime(2023, 8, 16, 10, 45, 34, 934, DateTimeKind.Utc).AddTicks(7234));

            migrationBuilder.UpdateData(
                table: "Coolers",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddedOn",
                value: new DateTime(2023, 8, 16, 10, 45, 34, 934, DateTimeKind.Utc).AddTicks(7236));

            migrationBuilder.UpdateData(
                table: "Coolers",
                keyColumn: "Id",
                keyValue: 5,
                column: "AddedOn",
                value: new DateTime(2023, 8, 16, 10, 45, 34, 934, DateTimeKind.Utc).AddTicks(7243));

            migrationBuilder.UpdateData(
                table: "Coolers",
                keyColumn: "Id",
                keyValue: 6,
                column: "AddedOn",
                value: new DateTime(2023, 8, 16, 10, 45, 34, 934, DateTimeKind.Utc).AddTicks(7245));

            migrationBuilder.UpdateData(
                table: "Coolers",
                keyColumn: "Id",
                keyValue: 7,
                column: "AddedOn",
                value: new DateTime(2023, 8, 16, 10, 45, 34, 934, DateTimeKind.Utc).AddTicks(7248));

            migrationBuilder.UpdateData(
                table: "Coolers",
                keyColumn: "Id",
                keyValue: 8,
                column: "AddedOn",
                value: new DateTime(2023, 8, 16, 10, 45, 34, 934, DateTimeKind.Utc).AddTicks(7250));

            migrationBuilder.UpdateData(
                table: "Coolers",
                keyColumn: "Id",
                keyValue: 9,
                column: "AddedOn",
                value: new DateTime(2023, 8, 16, 10, 45, 34, 934, DateTimeKind.Utc).AddTicks(7254));

            migrationBuilder.UpdateData(
                table: "Coolers",
                keyColumn: "Id",
                keyValue: 10,
                column: "AddedOn",
                value: new DateTime(2023, 8, 16, 10, 45, 34, 934, DateTimeKind.Utc).AddTicks(7257));

            migrationBuilder.UpdateData(
                table: "Cpus",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedOn",
                value: new DateTime(2023, 8, 16, 10, 45, 34, 934, DateTimeKind.Utc).AddTicks(8079));

            migrationBuilder.UpdateData(
                table: "Cpus",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedOn",
                value: new DateTime(2023, 8, 16, 10, 45, 34, 934, DateTimeKind.Utc).AddTicks(8086));

            migrationBuilder.UpdateData(
                table: "Cpus",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddedOn",
                value: new DateTime(2023, 8, 16, 10, 45, 34, 934, DateTimeKind.Utc).AddTicks(8089));

            migrationBuilder.UpdateData(
                table: "Cpus",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddedOn",
                value: new DateTime(2023, 8, 16, 10, 45, 34, 934, DateTimeKind.Utc).AddTicks(8091));

            migrationBuilder.UpdateData(
                table: "Cpus",
                keyColumn: "Id",
                keyValue: 5,
                column: "AddedOn",
                value: new DateTime(2023, 8, 16, 10, 45, 34, 934, DateTimeKind.Utc).AddTicks(8094));

            migrationBuilder.UpdateData(
                table: "Cpus",
                keyColumn: "Id",
                keyValue: 6,
                column: "AddedOn",
                value: new DateTime(2023, 8, 16, 10, 45, 34, 934, DateTimeKind.Utc).AddTicks(8097));

            migrationBuilder.UpdateData(
                table: "Cpus",
                keyColumn: "Id",
                keyValue: 7,
                column: "AddedOn",
                value: new DateTime(2023, 8, 16, 10, 45, 34, 934, DateTimeKind.Utc).AddTicks(8099));

            migrationBuilder.UpdateData(
                table: "Gpus",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedOn",
                value: new DateTime(2023, 8, 16, 10, 45, 34, 934, DateTimeKind.Utc).AddTicks(8902));

            migrationBuilder.UpdateData(
                table: "Gpus",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedOn",
                value: new DateTime(2023, 8, 16, 10, 45, 34, 934, DateTimeKind.Utc).AddTicks(8910));

            migrationBuilder.UpdateData(
                table: "Gpus",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddedOn",
                value: new DateTime(2023, 8, 16, 10, 45, 34, 934, DateTimeKind.Utc).AddTicks(8912));

            migrationBuilder.UpdateData(
                table: "Gpus",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddedOn",
                value: new DateTime(2023, 8, 16, 10, 45, 34, 934, DateTimeKind.Utc).AddTicks(8915));

            migrationBuilder.UpdateData(
                table: "Gpus",
                keyColumn: "Id",
                keyValue: 5,
                column: "AddedOn",
                value: new DateTime(2023, 8, 16, 10, 45, 34, 934, DateTimeKind.Utc).AddTicks(8920));

            migrationBuilder.UpdateData(
                table: "Gpus",
                keyColumn: "Id",
                keyValue: 6,
                column: "AddedOn",
                value: new DateTime(2023, 8, 16, 10, 45, 34, 934, DateTimeKind.Utc).AddTicks(8922));

            migrationBuilder.UpdateData(
                table: "Gpus",
                keyColumn: "Id",
                keyValue: 7,
                column: "AddedOn",
                value: new DateTime(2023, 8, 16, 10, 45, 34, 934, DateTimeKind.Utc).AddTicks(8925));

            migrationBuilder.UpdateData(
                table: "Gpus",
                keyColumn: "Id",
                keyValue: 8,
                column: "AddedOn",
                value: new DateTime(2023, 8, 16, 10, 45, 34, 934, DateTimeKind.Utc).AddTicks(8927));

            migrationBuilder.UpdateData(
                table: "Motherboards",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedOn",
                value: new DateTime(2023, 8, 16, 10, 45, 34, 935, DateTimeKind.Utc).AddTicks(25));

            migrationBuilder.UpdateData(
                table: "Motherboards",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedOn",
                value: new DateTime(2023, 8, 16, 10, 45, 34, 935, DateTimeKind.Utc).AddTicks(37));

            migrationBuilder.UpdateData(
                table: "Motherboards",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddedOn",
                value: new DateTime(2023, 8, 16, 10, 45, 34, 935, DateTimeKind.Utc).AddTicks(40));

            migrationBuilder.UpdateData(
                table: "Motherboards",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddedOn",
                value: new DateTime(2023, 8, 16, 10, 45, 34, 935, DateTimeKind.Utc).AddTicks(43));

            migrationBuilder.UpdateData(
                table: "Motherboards",
                keyColumn: "Id",
                keyValue: 5,
                column: "AddedOn",
                value: new DateTime(2023, 8, 16, 10, 45, 34, 935, DateTimeKind.Utc).AddTicks(47));

            migrationBuilder.UpdateData(
                table: "Motherboards",
                keyColumn: "Id",
                keyValue: 6,
                column: "AddedOn",
                value: new DateTime(2023, 8, 16, 10, 45, 34, 935, DateTimeKind.Utc).AddTicks(53));

            migrationBuilder.UpdateData(
                table: "Motherboards",
                keyColumn: "Id",
                keyValue: 7,
                column: "AddedOn",
                value: new DateTime(2023, 8, 16, 10, 45, 34, 935, DateTimeKind.Utc).AddTicks(56));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedOn",
                value: new DateTime(2023, 8, 16, 10, 45, 34, 935, DateTimeKind.Utc).AddTicks(1743));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedOn",
                value: new DateTime(2023, 8, 16, 10, 45, 34, 935, DateTimeKind.Utc).AddTicks(1752));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddedOn",
                value: new DateTime(2023, 8, 16, 10, 45, 34, 935, DateTimeKind.Utc).AddTicks(1754));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddedOn",
                value: new DateTime(2023, 8, 16, 10, 45, 34, 935, DateTimeKind.Utc).AddTicks(1756));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 5,
                column: "AddedOn",
                value: new DateTime(2023, 8, 16, 10, 45, 34, 935, DateTimeKind.Utc).AddTicks(1761));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 6,
                column: "AddedOn",
                value: new DateTime(2023, 8, 16, 10, 45, 34, 935, DateTimeKind.Utc).AddTicks(1763));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 7,
                column: "AddedOn",
                value: new DateTime(2023, 8, 16, 10, 45, 34, 935, DateTimeKind.Utc).AddTicks(1765));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 8,
                column: "AddedOn",
                value: new DateTime(2023, 8, 16, 10, 45, 34, 935, DateTimeKind.Utc).AddTicks(1768));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 9,
                column: "AddedOn",
                value: new DateTime(2023, 8, 16, 10, 45, 34, 935, DateTimeKind.Utc).AddTicks(1771));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 10,
                column: "AddedOn",
                value: new DateTime(2023, 8, 16, 10, 45, 34, 935, DateTimeKind.Utc).AddTicks(1773));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 11,
                column: "AddedOn",
                value: new DateTime(2023, 8, 16, 10, 45, 34, 935, DateTimeKind.Utc).AddTicks(1775));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 12,
                column: "AddedOn",
                value: new DateTime(2023, 8, 16, 10, 45, 34, 935, DateTimeKind.Utc).AddTicks(1778));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 13,
                column: "AddedOn",
                value: new DateTime(2023, 8, 16, 10, 45, 34, 935, DateTimeKind.Utc).AddTicks(1780));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedOn",
                value: new DateTime(2023, 8, 16, 10, 45, 34, 935, DateTimeKind.Utc).AddTicks(2571));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedOn",
                value: new DateTime(2023, 8, 16, 10, 45, 34, 935, DateTimeKind.Utc).AddTicks(2579));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddedOn",
                value: new DateTime(2023, 8, 16, 10, 45, 34, 935, DateTimeKind.Utc).AddTicks(2581));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddedOn",
                value: new DateTime(2023, 8, 16, 10, 45, 34, 935, DateTimeKind.Utc).AddTicks(2583));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 5,
                column: "AddedOn",
                value: new DateTime(2023, 8, 16, 10, 45, 34, 935, DateTimeKind.Utc).AddTicks(2588));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 6,
                column: "AddedOn",
                value: new DateTime(2023, 8, 16, 10, 45, 34, 935, DateTimeKind.Utc).AddTicks(2590));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 7,
                column: "AddedOn",
                value: new DateTime(2023, 8, 16, 10, 45, 34, 935, DateTimeKind.Utc).AddTicks(2593));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 8,
                column: "AddedOn",
                value: new DateTime(2023, 8, 16, 10, 45, 34, 935, DateTimeKind.Utc).AddTicks(2595));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 9,
                column: "AddedOn",
                value: new DateTime(2023, 8, 16, 10, 45, 34, 935, DateTimeKind.Utc).AddTicks(2599));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 10,
                column: "AddedOn",
                value: new DateTime(2023, 8, 16, 10, 45, 34, 935, DateTimeKind.Utc).AddTicks(2601));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 11,
                column: "AddedOn",
                value: new DateTime(2023, 8, 16, 10, 45, 34, 935, DateTimeKind.Utc).AddTicks(2604));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 12,
                column: "AddedOn",
                value: new DateTime(2023, 8, 16, 10, 45, 34, 935, DateTimeKind.Utc).AddTicks(2641));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 13,
                column: "AddedOn",
                value: new DateTime(2023, 8, 16, 10, 45, 34, 935, DateTimeKind.Utc).AddTicks(2644));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 14,
                column: "AddedOn",
                value: new DateTime(2023, 8, 16, 10, 45, 34, 935, DateTimeKind.Utc).AddTicks(2647));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 15,
                column: "AddedOn",
                value: new DateTime(2023, 8, 16, 10, 45, 34, 935, DateTimeKind.Utc).AddTicks(2649));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 16,
                column: "AddedOn",
                value: new DateTime(2023, 8, 16, 10, 45, 34, 935, DateTimeKind.Utc).AddTicks(2651));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 17,
                column: "AddedOn",
                value: new DateTime(2023, 8, 16, 10, 45, 34, 935, DateTimeKind.Utc).AddTicks(2654));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 18,
                column: "AddedOn",
                value: new DateTime(2023, 8, 16, 10, 45, 34, 935, DateTimeKind.Utc).AddTicks(2656));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 19,
                column: "AddedOn",
                value: new DateTime(2023, 8, 16, 10, 45, 34, 935, DateTimeKind.Utc).AddTicks(2661));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 20,
                column: "AddedOn",
                value: new DateTime(2023, 8, 16, 10, 45, 34, 935, DateTimeKind.Utc).AddTicks(2663));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedOn",
                value: new DateTime(2023, 8, 16, 10, 45, 34, 935, DateTimeKind.Utc).AddTicks(3790));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedOn",
                value: new DateTime(2023, 8, 16, 10, 45, 34, 935, DateTimeKind.Utc).AddTicks(3801));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddedOn",
                value: new DateTime(2023, 8, 16, 10, 45, 34, 935, DateTimeKind.Utc).AddTicks(3804));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddedOn",
                value: new DateTime(2023, 8, 16, 10, 45, 34, 935, DateTimeKind.Utc).AddTicks(3806));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 5,
                column: "AddedOn",
                value: new DateTime(2023, 8, 16, 10, 45, 34, 935, DateTimeKind.Utc).AddTicks(3810));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 6,
                column: "AddedOn",
                value: new DateTime(2023, 8, 16, 10, 45, 34, 935, DateTimeKind.Utc).AddTicks(3813));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 7,
                column: "AddedOn",
                value: new DateTime(2023, 8, 16, 10, 45, 34, 935, DateTimeKind.Utc).AddTicks(3815));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 8,
                column: "AddedOn",
                value: new DateTime(2023, 8, 16, 10, 45, 34, 935, DateTimeKind.Utc).AddTicks(3818));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 9,
                column: "AddedOn",
                value: new DateTime(2023, 8, 16, 10, 45, 34, 935, DateTimeKind.Utc).AddTicks(3821));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 10,
                column: "AddedOn",
                value: new DateTime(2023, 8, 16, 10, 45, 34, 935, DateTimeKind.Utc).AddTicks(3823));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 11,
                column: "AddedOn",
                value: new DateTime(2023, 8, 16, 10, 45, 34, 935, DateTimeKind.Utc).AddTicks(3826));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 12,
                column: "AddedOn",
                value: new DateTime(2023, 8, 16, 10, 45, 34, 935, DateTimeKind.Utc).AddTicks(3830));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 13,
                column: "AddedOn",
                value: new DateTime(2023, 8, 16, 10, 45, 34, 935, DateTimeKind.Utc).AddTicks(3833));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 14,
                column: "AddedOn",
                value: new DateTime(2023, 8, 16, 10, 45, 34, 935, DateTimeKind.Utc).AddTicks(3835));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 15,
                column: "AddedOn",
                value: new DateTime(2023, 8, 16, 10, 45, 34, 935, DateTimeKind.Utc).AddTicks(3837));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 16,
                column: "AddedOn",
                value: new DateTime(2023, 8, 16, 10, 45, 34, 935, DateTimeKind.Utc).AddTicks(3840));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 17,
                column: "AddedOn",
                value: new DateTime(2023, 8, 16, 10, 45, 34, 935, DateTimeKind.Utc).AddTicks(3842));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 18,
                column: "AddedOn",
                value: new DateTime(2023, 8, 16, 10, 45, 34, 935, DateTimeKind.Utc).AddTicks(3844));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
