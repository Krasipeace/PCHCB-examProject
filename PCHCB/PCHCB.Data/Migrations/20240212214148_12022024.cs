using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PCHCB.Data.Migrations
{
    public partial class _12022024 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("73df6910-cc0d-4f98-90a0-748c29bbd618"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e1806bf9-a3f0-424c-bf07-67fd0a101b23", "AQAAAAEAACcQAAAAELMLshPOyHImNNmVFSfV+C1ARNJn5ZM7QQmrTNLXtkqIfKUDWOjFiG0wqbZv82zFDQ==" });

            migrationBuilder.UpdateData(
                table: "Cases",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedOn",
                value: new DateTime(2024, 2, 12, 21, 41, 47, 326, DateTimeKind.Utc).AddTicks(4879));

            migrationBuilder.UpdateData(
                table: "Cases",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedOn",
                value: new DateTime(2024, 2, 12, 21, 41, 47, 326, DateTimeKind.Utc).AddTicks(4904));

            migrationBuilder.UpdateData(
                table: "Cases",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddedOn",
                value: new DateTime(2024, 2, 12, 21, 41, 47, 326, DateTimeKind.Utc).AddTicks(4907));

            migrationBuilder.UpdateData(
                table: "Cases",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddedOn",
                value: new DateTime(2024, 2, 12, 21, 41, 47, 326, DateTimeKind.Utc).AddTicks(4910));

            migrationBuilder.UpdateData(
                table: "Cases",
                keyColumn: "Id",
                keyValue: 5,
                column: "AddedOn",
                value: new DateTime(2024, 2, 12, 21, 41, 47, 326, DateTimeKind.Utc).AddTicks(4915));

            migrationBuilder.UpdateData(
                table: "Coolers",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedOn",
                value: new DateTime(2024, 2, 12, 21, 41, 47, 327, DateTimeKind.Utc).AddTicks(7096));

            migrationBuilder.UpdateData(
                table: "Coolers",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedOn",
                value: new DateTime(2024, 2, 12, 21, 41, 47, 327, DateTimeKind.Utc).AddTicks(7106));

            migrationBuilder.UpdateData(
                table: "Coolers",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddedOn",
                value: new DateTime(2024, 2, 12, 21, 41, 47, 327, DateTimeKind.Utc).AddTicks(7109));

            migrationBuilder.UpdateData(
                table: "Coolers",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddedOn",
                value: new DateTime(2024, 2, 12, 21, 41, 47, 327, DateTimeKind.Utc).AddTicks(7112));

            migrationBuilder.UpdateData(
                table: "Coolers",
                keyColumn: "Id",
                keyValue: 5,
                column: "AddedOn",
                value: new DateTime(2024, 2, 12, 21, 41, 47, 327, DateTimeKind.Utc).AddTicks(7116));

            migrationBuilder.UpdateData(
                table: "Coolers",
                keyColumn: "Id",
                keyValue: 6,
                column: "AddedOn",
                value: new DateTime(2024, 2, 12, 21, 41, 47, 327, DateTimeKind.Utc).AddTicks(7119));

            migrationBuilder.UpdateData(
                table: "Coolers",
                keyColumn: "Id",
                keyValue: 7,
                column: "AddedOn",
                value: new DateTime(2024, 2, 12, 21, 41, 47, 327, DateTimeKind.Utc).AddTicks(7121));

            migrationBuilder.UpdateData(
                table: "Coolers",
                keyColumn: "Id",
                keyValue: 8,
                column: "AddedOn",
                value: new DateTime(2024, 2, 12, 21, 41, 47, 327, DateTimeKind.Utc).AddTicks(7124));

            migrationBuilder.UpdateData(
                table: "Coolers",
                keyColumn: "Id",
                keyValue: 9,
                column: "AddedOn",
                value: new DateTime(2024, 2, 12, 21, 41, 47, 327, DateTimeKind.Utc).AddTicks(7128));

            migrationBuilder.UpdateData(
                table: "Coolers",
                keyColumn: "Id",
                keyValue: 10,
                column: "AddedOn",
                value: new DateTime(2024, 2, 12, 21, 41, 47, 327, DateTimeKind.Utc).AddTicks(7130));

            migrationBuilder.UpdateData(
                table: "Cpus",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedOn",
                value: new DateTime(2024, 2, 12, 21, 41, 47, 327, DateTimeKind.Utc).AddTicks(7882));

            migrationBuilder.UpdateData(
                table: "Cpus",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedOn",
                value: new DateTime(2024, 2, 12, 21, 41, 47, 327, DateTimeKind.Utc).AddTicks(7888));

            migrationBuilder.UpdateData(
                table: "Cpus",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddedOn",
                value: new DateTime(2024, 2, 12, 21, 41, 47, 327, DateTimeKind.Utc).AddTicks(7891));

            migrationBuilder.UpdateData(
                table: "Cpus",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddedOn",
                value: new DateTime(2024, 2, 12, 21, 41, 47, 327, DateTimeKind.Utc).AddTicks(7893));

            migrationBuilder.UpdateData(
                table: "Cpus",
                keyColumn: "Id",
                keyValue: 5,
                column: "AddedOn",
                value: new DateTime(2024, 2, 12, 21, 41, 47, 327, DateTimeKind.Utc).AddTicks(7896));

            migrationBuilder.UpdateData(
                table: "Cpus",
                keyColumn: "Id",
                keyValue: 6,
                column: "AddedOn",
                value: new DateTime(2024, 2, 12, 21, 41, 47, 327, DateTimeKind.Utc).AddTicks(7899));

            migrationBuilder.UpdateData(
                table: "Cpus",
                keyColumn: "Id",
                keyValue: 7,
                column: "AddedOn",
                value: new DateTime(2024, 2, 12, 21, 41, 47, 327, DateTimeKind.Utc).AddTicks(7902));

            migrationBuilder.UpdateData(
                table: "Gpus",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedOn",
                value: new DateTime(2024, 2, 12, 21, 41, 47, 327, DateTimeKind.Utc).AddTicks(8653));

            migrationBuilder.UpdateData(
                table: "Gpus",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedOn",
                value: new DateTime(2024, 2, 12, 21, 41, 47, 327, DateTimeKind.Utc).AddTicks(8660));

            migrationBuilder.UpdateData(
                table: "Gpus",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddedOn",
                value: new DateTime(2024, 2, 12, 21, 41, 47, 327, DateTimeKind.Utc).AddTicks(8663));

            migrationBuilder.UpdateData(
                table: "Gpus",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddedOn",
                value: new DateTime(2024, 2, 12, 21, 41, 47, 327, DateTimeKind.Utc).AddTicks(8665));

            migrationBuilder.UpdateData(
                table: "Gpus",
                keyColumn: "Id",
                keyValue: 5,
                column: "AddedOn",
                value: new DateTime(2024, 2, 12, 21, 41, 47, 327, DateTimeKind.Utc).AddTicks(8712));

            migrationBuilder.UpdateData(
                table: "Gpus",
                keyColumn: "Id",
                keyValue: 6,
                column: "AddedOn",
                value: new DateTime(2024, 2, 12, 21, 41, 47, 327, DateTimeKind.Utc).AddTicks(8715));

            migrationBuilder.UpdateData(
                table: "Gpus",
                keyColumn: "Id",
                keyValue: 7,
                column: "AddedOn",
                value: new DateTime(2024, 2, 12, 21, 41, 47, 327, DateTimeKind.Utc).AddTicks(8718));

            migrationBuilder.UpdateData(
                table: "Gpus",
                keyColumn: "Id",
                keyValue: 8,
                column: "AddedOn",
                value: new DateTime(2024, 2, 12, 21, 41, 47, 327, DateTimeKind.Utc).AddTicks(8720));

            migrationBuilder.UpdateData(
                table: "Motherboards",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedOn",
                value: new DateTime(2024, 2, 12, 21, 41, 47, 327, DateTimeKind.Utc).AddTicks(9496));

            migrationBuilder.UpdateData(
                table: "Motherboards",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedOn",
                value: new DateTime(2024, 2, 12, 21, 41, 47, 327, DateTimeKind.Utc).AddTicks(9504));

            migrationBuilder.UpdateData(
                table: "Motherboards",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddedOn",
                value: new DateTime(2024, 2, 12, 21, 41, 47, 327, DateTimeKind.Utc).AddTicks(9508));

            migrationBuilder.UpdateData(
                table: "Motherboards",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddedOn",
                value: new DateTime(2024, 2, 12, 21, 41, 47, 327, DateTimeKind.Utc).AddTicks(9511));

            migrationBuilder.UpdateData(
                table: "Motherboards",
                keyColumn: "Id",
                keyValue: 5,
                column: "AddedOn",
                value: new DateTime(2024, 2, 12, 21, 41, 47, 327, DateTimeKind.Utc).AddTicks(9514));

            migrationBuilder.UpdateData(
                table: "Motherboards",
                keyColumn: "Id",
                keyValue: 6,
                column: "AddedOn",
                value: new DateTime(2024, 2, 12, 21, 41, 47, 327, DateTimeKind.Utc).AddTicks(9519));

            migrationBuilder.UpdateData(
                table: "Motherboards",
                keyColumn: "Id",
                keyValue: 7,
                column: "AddedOn",
                value: new DateTime(2024, 2, 12, 21, 41, 47, 327, DateTimeKind.Utc).AddTicks(9522));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedOn",
                value: new DateTime(2024, 2, 12, 21, 41, 47, 328, DateTimeKind.Utc).AddTicks(1121));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedOn",
                value: new DateTime(2024, 2, 12, 21, 41, 47, 328, DateTimeKind.Utc).AddTicks(1129));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddedOn",
                value: new DateTime(2024, 2, 12, 21, 41, 47, 328, DateTimeKind.Utc).AddTicks(1132));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddedOn",
                value: new DateTime(2024, 2, 12, 21, 41, 47, 328, DateTimeKind.Utc).AddTicks(1134));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 5,
                column: "AddedOn",
                value: new DateTime(2024, 2, 12, 21, 41, 47, 328, DateTimeKind.Utc).AddTicks(1138));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 6,
                column: "AddedOn",
                value: new DateTime(2024, 2, 12, 21, 41, 47, 328, DateTimeKind.Utc).AddTicks(1141));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 7,
                column: "AddedOn",
                value: new DateTime(2024, 2, 12, 21, 41, 47, 328, DateTimeKind.Utc).AddTicks(1143));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 8,
                column: "AddedOn",
                value: new DateTime(2024, 2, 12, 21, 41, 47, 328, DateTimeKind.Utc).AddTicks(1145));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 9,
                column: "AddedOn",
                value: new DateTime(2024, 2, 12, 21, 41, 47, 328, DateTimeKind.Utc).AddTicks(1149));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 10,
                column: "AddedOn",
                value: new DateTime(2024, 2, 12, 21, 41, 47, 328, DateTimeKind.Utc).AddTicks(1152));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 11,
                column: "AddedOn",
                value: new DateTime(2024, 2, 12, 21, 41, 47, 328, DateTimeKind.Utc).AddTicks(1154));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 12,
                column: "AddedOn",
                value: new DateTime(2024, 2, 12, 21, 41, 47, 328, DateTimeKind.Utc).AddTicks(1156));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 13,
                column: "AddedOn",
                value: new DateTime(2024, 2, 12, 21, 41, 47, 328, DateTimeKind.Utc).AddTicks(1159));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedOn",
                value: new DateTime(2024, 2, 12, 21, 41, 47, 328, DateTimeKind.Utc).AddTicks(1918));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedOn",
                value: new DateTime(2024, 2, 12, 21, 41, 47, 328, DateTimeKind.Utc).AddTicks(1927));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddedOn",
                value: new DateTime(2024, 2, 12, 21, 41, 47, 328, DateTimeKind.Utc).AddTicks(1930));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddedOn",
                value: new DateTime(2024, 2, 12, 21, 41, 47, 328, DateTimeKind.Utc).AddTicks(1932));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 5,
                column: "AddedOn",
                value: new DateTime(2024, 2, 12, 21, 41, 47, 328, DateTimeKind.Utc).AddTicks(1936));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 6,
                column: "AddedOn",
                value: new DateTime(2024, 2, 12, 21, 41, 47, 328, DateTimeKind.Utc).AddTicks(1939));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 7,
                column: "AddedOn",
                value: new DateTime(2024, 2, 12, 21, 41, 47, 328, DateTimeKind.Utc).AddTicks(1970));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 8,
                column: "AddedOn",
                value: new DateTime(2024, 2, 12, 21, 41, 47, 328, DateTimeKind.Utc).AddTicks(1973));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 9,
                column: "AddedOn",
                value: new DateTime(2024, 2, 12, 21, 41, 47, 328, DateTimeKind.Utc).AddTicks(1977));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 10,
                column: "AddedOn",
                value: new DateTime(2024, 2, 12, 21, 41, 47, 328, DateTimeKind.Utc).AddTicks(1979));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 11,
                column: "AddedOn",
                value: new DateTime(2024, 2, 12, 21, 41, 47, 328, DateTimeKind.Utc).AddTicks(1982));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 12,
                column: "AddedOn",
                value: new DateTime(2024, 2, 12, 21, 41, 47, 328, DateTimeKind.Utc).AddTicks(1984));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 13,
                column: "AddedOn",
                value: new DateTime(2024, 2, 12, 21, 41, 47, 328, DateTimeKind.Utc).AddTicks(1987));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 14,
                column: "AddedOn",
                value: new DateTime(2024, 2, 12, 21, 41, 47, 328, DateTimeKind.Utc).AddTicks(1989));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 15,
                column: "AddedOn",
                value: new DateTime(2024, 2, 12, 21, 41, 47, 328, DateTimeKind.Utc).AddTicks(1991));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 16,
                column: "AddedOn",
                value: new DateTime(2024, 2, 12, 21, 41, 47, 328, DateTimeKind.Utc).AddTicks(1994));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 17,
                column: "AddedOn",
                value: new DateTime(2024, 2, 12, 21, 41, 47, 328, DateTimeKind.Utc).AddTicks(1997));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 18,
                column: "AddedOn",
                value: new DateTime(2024, 2, 12, 21, 41, 47, 328, DateTimeKind.Utc).AddTicks(1999));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 19,
                column: "AddedOn",
                value: new DateTime(2024, 2, 12, 21, 41, 47, 328, DateTimeKind.Utc).AddTicks(2003));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 20,
                column: "AddedOn",
                value: new DateTime(2024, 2, 12, 21, 41, 47, 328, DateTimeKind.Utc).AddTicks(2006));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedOn",
                value: new DateTime(2024, 2, 12, 21, 41, 47, 328, DateTimeKind.Utc).AddTicks(2765));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedOn",
                value: new DateTime(2024, 2, 12, 21, 41, 47, 328, DateTimeKind.Utc).AddTicks(2773));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddedOn",
                value: new DateTime(2024, 2, 12, 21, 41, 47, 328, DateTimeKind.Utc).AddTicks(2775));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddedOn",
                value: new DateTime(2024, 2, 12, 21, 41, 47, 328, DateTimeKind.Utc).AddTicks(2777));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 5,
                column: "AddedOn",
                value: new DateTime(2024, 2, 12, 21, 41, 47, 328, DateTimeKind.Utc).AddTicks(2781));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 6,
                column: "AddedOn",
                value: new DateTime(2024, 2, 12, 21, 41, 47, 328, DateTimeKind.Utc).AddTicks(2784));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 7,
                column: "AddedOn",
                value: new DateTime(2024, 2, 12, 21, 41, 47, 328, DateTimeKind.Utc).AddTicks(2786));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 8,
                column: "AddedOn",
                value: new DateTime(2024, 2, 12, 21, 41, 47, 328, DateTimeKind.Utc).AddTicks(2788));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 9,
                column: "AddedOn",
                value: new DateTime(2024, 2, 12, 21, 41, 47, 328, DateTimeKind.Utc).AddTicks(2792));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 10,
                column: "AddedOn",
                value: new DateTime(2024, 2, 12, 21, 41, 47, 328, DateTimeKind.Utc).AddTicks(2794));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 11,
                column: "AddedOn",
                value: new DateTime(2024, 2, 12, 21, 41, 47, 328, DateTimeKind.Utc).AddTicks(2796));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 12,
                column: "AddedOn",
                value: new DateTime(2024, 2, 12, 21, 41, 47, 328, DateTimeKind.Utc).AddTicks(2799));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 13,
                column: "AddedOn",
                value: new DateTime(2024, 2, 12, 21, 41, 47, 328, DateTimeKind.Utc).AddTicks(2801));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 14,
                column: "AddedOn",
                value: new DateTime(2024, 2, 12, 21, 41, 47, 328, DateTimeKind.Utc).AddTicks(2804));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 15,
                column: "AddedOn",
                value: new DateTime(2024, 2, 12, 21, 41, 47, 328, DateTimeKind.Utc).AddTicks(2806));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 16,
                column: "AddedOn",
                value: new DateTime(2024, 2, 12, 21, 41, 47, 328, DateTimeKind.Utc).AddTicks(2808));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 17,
                column: "AddedOn",
                value: new DateTime(2024, 2, 12, 21, 41, 47, 328, DateTimeKind.Utc).AddTicks(2810));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 18,
                column: "AddedOn",
                value: new DateTime(2024, 2, 12, 21, 41, 47, 328, DateTimeKind.Utc).AddTicks(2842));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
