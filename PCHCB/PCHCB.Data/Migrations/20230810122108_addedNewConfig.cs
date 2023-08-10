using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PCHCB.Data.Migrations
{
    public partial class addedNewConfig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PcConfigurations_AspNetUsers_BuilderId",
                table: "PcConfigurations");

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

            migrationBuilder.AddForeignKey(
                name: "FK_PcConfigurations_AspNetUsers_BuilderId",
                table: "PcConfigurations",
                column: "BuilderId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PcConfigurations_AspNetUsers_BuilderId",
                table: "PcConfigurations");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("73df6910-cc0d-4f98-90a0-748c29bbd618"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "14cecb3a-a02b-432f-93b6-f09f314eb0c6", "AQAAAAEAACcQAAAAEKcUC1pFR/cgPyvNjP2l7QT2yP5cSFtSLEqrhcNXSw57ebxwfXG3XkJrzWQXqu4DWg==" });

            migrationBuilder.UpdateData(
                table: "Cases",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedOn",
                value: new DateTime(2023, 8, 9, 7, 5, 6, 106, DateTimeKind.Utc).AddTicks(5053));

            migrationBuilder.UpdateData(
                table: "Cases",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedOn",
                value: new DateTime(2023, 8, 9, 7, 5, 6, 106, DateTimeKind.Utc).AddTicks(5076));

            migrationBuilder.UpdateData(
                table: "Cases",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddedOn",
                value: new DateTime(2023, 8, 9, 7, 5, 6, 106, DateTimeKind.Utc).AddTicks(5079));

            migrationBuilder.UpdateData(
                table: "Cases",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddedOn",
                value: new DateTime(2023, 8, 9, 7, 5, 6, 106, DateTimeKind.Utc).AddTicks(5082));

            migrationBuilder.UpdateData(
                table: "Cases",
                keyColumn: "Id",
                keyValue: 5,
                column: "AddedOn",
                value: new DateTime(2023, 8, 9, 7, 5, 6, 106, DateTimeKind.Utc).AddTicks(5088));

            migrationBuilder.UpdateData(
                table: "Coolers",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedOn",
                value: new DateTime(2023, 8, 9, 7, 5, 6, 107, DateTimeKind.Utc).AddTicks(7677));

            migrationBuilder.UpdateData(
                table: "Coolers",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedOn",
                value: new DateTime(2023, 8, 9, 7, 5, 6, 107, DateTimeKind.Utc).AddTicks(7689));

            migrationBuilder.UpdateData(
                table: "Coolers",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddedOn",
                value: new DateTime(2023, 8, 9, 7, 5, 6, 107, DateTimeKind.Utc).AddTicks(7692));

            migrationBuilder.UpdateData(
                table: "Coolers",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddedOn",
                value: new DateTime(2023, 8, 9, 7, 5, 6, 107, DateTimeKind.Utc).AddTicks(7695));

            migrationBuilder.UpdateData(
                table: "Coolers",
                keyColumn: "Id",
                keyValue: 5,
                column: "AddedOn",
                value: new DateTime(2023, 8, 9, 7, 5, 6, 107, DateTimeKind.Utc).AddTicks(7701));

            migrationBuilder.UpdateData(
                table: "Coolers",
                keyColumn: "Id",
                keyValue: 6,
                column: "AddedOn",
                value: new DateTime(2023, 8, 9, 7, 5, 6, 107, DateTimeKind.Utc).AddTicks(7704));

            migrationBuilder.UpdateData(
                table: "Coolers",
                keyColumn: "Id",
                keyValue: 7,
                column: "AddedOn",
                value: new DateTime(2023, 8, 9, 7, 5, 6, 107, DateTimeKind.Utc).AddTicks(7707));

            migrationBuilder.UpdateData(
                table: "Coolers",
                keyColumn: "Id",
                keyValue: 8,
                column: "AddedOn",
                value: new DateTime(2023, 8, 9, 7, 5, 6, 107, DateTimeKind.Utc).AddTicks(7709));

            migrationBuilder.UpdateData(
                table: "Coolers",
                keyColumn: "Id",
                keyValue: 9,
                column: "AddedOn",
                value: new DateTime(2023, 8, 9, 7, 5, 6, 107, DateTimeKind.Utc).AddTicks(7713));

            migrationBuilder.UpdateData(
                table: "Coolers",
                keyColumn: "Id",
                keyValue: 10,
                column: "AddedOn",
                value: new DateTime(2023, 8, 9, 7, 5, 6, 107, DateTimeKind.Utc).AddTicks(7716));

            migrationBuilder.UpdateData(
                table: "Cpus",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedOn",
                value: new DateTime(2023, 8, 9, 7, 5, 6, 107, DateTimeKind.Utc).AddTicks(8464));

            migrationBuilder.UpdateData(
                table: "Cpus",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedOn",
                value: new DateTime(2023, 8, 9, 7, 5, 6, 107, DateTimeKind.Utc).AddTicks(8471));

            migrationBuilder.UpdateData(
                table: "Cpus",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddedOn",
                value: new DateTime(2023, 8, 9, 7, 5, 6, 107, DateTimeKind.Utc).AddTicks(8473));

            migrationBuilder.UpdateData(
                table: "Cpus",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddedOn",
                value: new DateTime(2023, 8, 9, 7, 5, 6, 107, DateTimeKind.Utc).AddTicks(8476));

            migrationBuilder.UpdateData(
                table: "Cpus",
                keyColumn: "Id",
                keyValue: 5,
                column: "AddedOn",
                value: new DateTime(2023, 8, 9, 7, 5, 6, 107, DateTimeKind.Utc).AddTicks(8478));

            migrationBuilder.UpdateData(
                table: "Cpus",
                keyColumn: "Id",
                keyValue: 6,
                column: "AddedOn",
                value: new DateTime(2023, 8, 9, 7, 5, 6, 107, DateTimeKind.Utc).AddTicks(8481));

            migrationBuilder.UpdateData(
                table: "Cpus",
                keyColumn: "Id",
                keyValue: 7,
                column: "AddedOn",
                value: new DateTime(2023, 8, 9, 7, 5, 6, 107, DateTimeKind.Utc).AddTicks(8483));

            migrationBuilder.UpdateData(
                table: "Gpus",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedOn",
                value: new DateTime(2023, 8, 9, 7, 5, 6, 107, DateTimeKind.Utc).AddTicks(9327));

            migrationBuilder.UpdateData(
                table: "Gpus",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedOn",
                value: new DateTime(2023, 8, 9, 7, 5, 6, 107, DateTimeKind.Utc).AddTicks(9337));

            migrationBuilder.UpdateData(
                table: "Gpus",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddedOn",
                value: new DateTime(2023, 8, 9, 7, 5, 6, 107, DateTimeKind.Utc).AddTicks(9340));

            migrationBuilder.UpdateData(
                table: "Gpus",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddedOn",
                value: new DateTime(2023, 8, 9, 7, 5, 6, 107, DateTimeKind.Utc).AddTicks(9344));

            migrationBuilder.UpdateData(
                table: "Gpus",
                keyColumn: "Id",
                keyValue: 5,
                column: "AddedOn",
                value: new DateTime(2023, 8, 9, 7, 5, 6, 107, DateTimeKind.Utc).AddTicks(9349));

            migrationBuilder.UpdateData(
                table: "Gpus",
                keyColumn: "Id",
                keyValue: 6,
                column: "AddedOn",
                value: new DateTime(2023, 8, 9, 7, 5, 6, 107, DateTimeKind.Utc).AddTicks(9353));

            migrationBuilder.UpdateData(
                table: "Gpus",
                keyColumn: "Id",
                keyValue: 7,
                column: "AddedOn",
                value: new DateTime(2023, 8, 9, 7, 5, 6, 107, DateTimeKind.Utc).AddTicks(9356));

            migrationBuilder.UpdateData(
                table: "Gpus",
                keyColumn: "Id",
                keyValue: 8,
                column: "AddedOn",
                value: new DateTime(2023, 8, 9, 7, 5, 6, 107, DateTimeKind.Utc).AddTicks(9392));

            migrationBuilder.UpdateData(
                table: "Motherboards",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedOn",
                value: new DateTime(2023, 8, 9, 7, 5, 6, 108, DateTimeKind.Utc).AddTicks(373));

            migrationBuilder.UpdateData(
                table: "Motherboards",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedOn",
                value: new DateTime(2023, 8, 9, 7, 5, 6, 108, DateTimeKind.Utc).AddTicks(381));

            migrationBuilder.UpdateData(
                table: "Motherboards",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddedOn",
                value: new DateTime(2023, 8, 9, 7, 5, 6, 108, DateTimeKind.Utc).AddTicks(384));

            migrationBuilder.UpdateData(
                table: "Motherboards",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddedOn",
                value: new DateTime(2023, 8, 9, 7, 5, 6, 108, DateTimeKind.Utc).AddTicks(387));

            migrationBuilder.UpdateData(
                table: "Motherboards",
                keyColumn: "Id",
                keyValue: 5,
                column: "AddedOn",
                value: new DateTime(2023, 8, 9, 7, 5, 6, 108, DateTimeKind.Utc).AddTicks(390));

            migrationBuilder.UpdateData(
                table: "Motherboards",
                keyColumn: "Id",
                keyValue: 6,
                column: "AddedOn",
                value: new DateTime(2023, 8, 9, 7, 5, 6, 108, DateTimeKind.Utc).AddTicks(394));

            migrationBuilder.UpdateData(
                table: "Motherboards",
                keyColumn: "Id",
                keyValue: 7,
                column: "AddedOn",
                value: new DateTime(2023, 8, 9, 7, 5, 6, 108, DateTimeKind.Utc).AddTicks(397));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedOn",
                value: new DateTime(2023, 8, 9, 7, 5, 6, 108, DateTimeKind.Utc).AddTicks(1368));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedOn",
                value: new DateTime(2023, 8, 9, 7, 5, 6, 108, DateTimeKind.Utc).AddTicks(1379));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddedOn",
                value: new DateTime(2023, 8, 9, 7, 5, 6, 108, DateTimeKind.Utc).AddTicks(1384));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddedOn",
                value: new DateTime(2023, 8, 9, 7, 5, 6, 108, DateTimeKind.Utc).AddTicks(1387));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 5,
                column: "AddedOn",
                value: new DateTime(2023, 8, 9, 7, 5, 6, 108, DateTimeKind.Utc).AddTicks(1391));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 6,
                column: "AddedOn",
                value: new DateTime(2023, 8, 9, 7, 5, 6, 108, DateTimeKind.Utc).AddTicks(1394));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 7,
                column: "AddedOn",
                value: new DateTime(2023, 8, 9, 7, 5, 6, 108, DateTimeKind.Utc).AddTicks(1396));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 8,
                column: "AddedOn",
                value: new DateTime(2023, 8, 9, 7, 5, 6, 108, DateTimeKind.Utc).AddTicks(1399));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 9,
                column: "AddedOn",
                value: new DateTime(2023, 8, 9, 7, 5, 6, 108, DateTimeKind.Utc).AddTicks(1403));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 10,
                column: "AddedOn",
                value: new DateTime(2023, 8, 9, 7, 5, 6, 108, DateTimeKind.Utc).AddTicks(1405));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 11,
                column: "AddedOn",
                value: new DateTime(2023, 8, 9, 7, 5, 6, 108, DateTimeKind.Utc).AddTicks(1407));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 12,
                column: "AddedOn",
                value: new DateTime(2023, 8, 9, 7, 5, 6, 108, DateTimeKind.Utc).AddTicks(1409));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 13,
                column: "AddedOn",
                value: new DateTime(2023, 8, 9, 7, 5, 6, 108, DateTimeKind.Utc).AddTicks(1412));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedOn",
                value: new DateTime(2023, 8, 9, 7, 5, 6, 108, DateTimeKind.Utc).AddTicks(2223));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedOn",
                value: new DateTime(2023, 8, 9, 7, 5, 6, 108, DateTimeKind.Utc).AddTicks(2230));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddedOn",
                value: new DateTime(2023, 8, 9, 7, 5, 6, 108, DateTimeKind.Utc).AddTicks(2233));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddedOn",
                value: new DateTime(2023, 8, 9, 7, 5, 6, 108, DateTimeKind.Utc).AddTicks(2235));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 5,
                column: "AddedOn",
                value: new DateTime(2023, 8, 9, 7, 5, 6, 108, DateTimeKind.Utc).AddTicks(2240));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 6,
                column: "AddedOn",
                value: new DateTime(2023, 8, 9, 7, 5, 6, 108, DateTimeKind.Utc).AddTicks(2242));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 7,
                column: "AddedOn",
                value: new DateTime(2023, 8, 9, 7, 5, 6, 108, DateTimeKind.Utc).AddTicks(2245));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 8,
                column: "AddedOn",
                value: new DateTime(2023, 8, 9, 7, 5, 6, 108, DateTimeKind.Utc).AddTicks(2247));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 9,
                column: "AddedOn",
                value: new DateTime(2023, 8, 9, 7, 5, 6, 108, DateTimeKind.Utc).AddTicks(2281));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 10,
                column: "AddedOn",
                value: new DateTime(2023, 8, 9, 7, 5, 6, 108, DateTimeKind.Utc).AddTicks(2284));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 11,
                column: "AddedOn",
                value: new DateTime(2023, 8, 9, 7, 5, 6, 108, DateTimeKind.Utc).AddTicks(2286));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 12,
                column: "AddedOn",
                value: new DateTime(2023, 8, 9, 7, 5, 6, 108, DateTimeKind.Utc).AddTicks(2288));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 13,
                column: "AddedOn",
                value: new DateTime(2023, 8, 9, 7, 5, 6, 108, DateTimeKind.Utc).AddTicks(2291));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 14,
                column: "AddedOn",
                value: new DateTime(2023, 8, 9, 7, 5, 6, 108, DateTimeKind.Utc).AddTicks(2293));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 15,
                column: "AddedOn",
                value: new DateTime(2023, 8, 9, 7, 5, 6, 108, DateTimeKind.Utc).AddTicks(2296));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 16,
                column: "AddedOn",
                value: new DateTime(2023, 8, 9, 7, 5, 6, 108, DateTimeKind.Utc).AddTicks(2298));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 17,
                column: "AddedOn",
                value: new DateTime(2023, 8, 9, 7, 5, 6, 108, DateTimeKind.Utc).AddTicks(2301));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 18,
                column: "AddedOn",
                value: new DateTime(2023, 8, 9, 7, 5, 6, 108, DateTimeKind.Utc).AddTicks(2303));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 19,
                column: "AddedOn",
                value: new DateTime(2023, 8, 9, 7, 5, 6, 108, DateTimeKind.Utc).AddTicks(2307));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 20,
                column: "AddedOn",
                value: new DateTime(2023, 8, 9, 7, 5, 6, 108, DateTimeKind.Utc).AddTicks(2310));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedOn",
                value: new DateTime(2023, 8, 9, 7, 5, 6, 108, DateTimeKind.Utc).AddTicks(3118));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedOn",
                value: new DateTime(2023, 8, 9, 7, 5, 6, 108, DateTimeKind.Utc).AddTicks(3128));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddedOn",
                value: new DateTime(2023, 8, 9, 7, 5, 6, 108, DateTimeKind.Utc).AddTicks(3130));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddedOn",
                value: new DateTime(2023, 8, 9, 7, 5, 6, 108, DateTimeKind.Utc).AddTicks(3132));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 5,
                column: "AddedOn",
                value: new DateTime(2023, 8, 9, 7, 5, 6, 108, DateTimeKind.Utc).AddTicks(3137));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 6,
                column: "AddedOn",
                value: new DateTime(2023, 8, 9, 7, 5, 6, 108, DateTimeKind.Utc).AddTicks(3139));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 7,
                column: "AddedOn",
                value: new DateTime(2023, 8, 9, 7, 5, 6, 108, DateTimeKind.Utc).AddTicks(3141));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 8,
                column: "AddedOn",
                value: new DateTime(2023, 8, 9, 7, 5, 6, 108, DateTimeKind.Utc).AddTicks(3144));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 9,
                column: "AddedOn",
                value: new DateTime(2023, 8, 9, 7, 5, 6, 108, DateTimeKind.Utc).AddTicks(3147));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 10,
                column: "AddedOn",
                value: new DateTime(2023, 8, 9, 7, 5, 6, 108, DateTimeKind.Utc).AddTicks(3149));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 11,
                column: "AddedOn",
                value: new DateTime(2023, 8, 9, 7, 5, 6, 108, DateTimeKind.Utc).AddTicks(3151));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 12,
                column: "AddedOn",
                value: new DateTime(2023, 8, 9, 7, 5, 6, 108, DateTimeKind.Utc).AddTicks(3156));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 13,
                column: "AddedOn",
                value: new DateTime(2023, 8, 9, 7, 5, 6, 108, DateTimeKind.Utc).AddTicks(3158));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 14,
                column: "AddedOn",
                value: new DateTime(2023, 8, 9, 7, 5, 6, 108, DateTimeKind.Utc).AddTicks(3160));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 15,
                column: "AddedOn",
                value: new DateTime(2023, 8, 9, 7, 5, 6, 108, DateTimeKind.Utc).AddTicks(3162));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 16,
                column: "AddedOn",
                value: new DateTime(2023, 8, 9, 7, 5, 6, 108, DateTimeKind.Utc).AddTicks(3165));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 17,
                column: "AddedOn",
                value: new DateTime(2023, 8, 9, 7, 5, 6, 108, DateTimeKind.Utc).AddTicks(3167));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 18,
                column: "AddedOn",
                value: new DateTime(2023, 8, 9, 7, 5, 6, 108, DateTimeKind.Utc).AddTicks(3169));

            migrationBuilder.AddForeignKey(
                name: "FK_PcConfigurations_AspNetUsers_BuilderId",
                table: "PcConfigurations",
                column: "BuilderId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
