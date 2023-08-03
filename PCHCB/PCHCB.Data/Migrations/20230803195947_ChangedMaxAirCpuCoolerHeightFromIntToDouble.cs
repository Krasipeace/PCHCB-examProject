using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PCHCB.Data.Migrations
{
    public partial class ChangedMaxAirCpuCoolerHeightFromIntToDouble : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "MaxAirCpuCoolerHeight",
                table: "Cases",
                type: "float",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("73df6910-cc0d-4f98-90a0-748c29bbd618"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c3151b89-13ef-4a77-909a-d7db0c88c818", "AQAAAAEAACcQAAAAEKafBHcwWiljCZwKgAll2m2OOWHb8Z/LSBaRRSwmuHmnTniwnk/zckvpJaLUSlJSFw==" });

            migrationBuilder.UpdateData(
                table: "Cases",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AddedOn", "MaxAirCpuCoolerHeight" },
                values: new object[] { new DateTime(2023, 8, 3, 19, 59, 46, 109, DateTimeKind.Utc).AddTicks(3803), 160.0 });

            migrationBuilder.UpdateData(
                table: "Cases",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AddedOn", "MaxAirCpuCoolerHeight" },
                values: new object[] { new DateTime(2023, 8, 3, 19, 59, 46, 109, DateTimeKind.Utc).AddTicks(3831), 170.0 });

            migrationBuilder.UpdateData(
                table: "Cases",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AddedOn", "MaxAirCpuCoolerHeight" },
                values: new object[] { new DateTime(2023, 8, 3, 19, 59, 46, 109, DateTimeKind.Utc).AddTicks(3834), 165.0 });

            migrationBuilder.UpdateData(
                table: "Cases",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AddedOn", "MaxAirCpuCoolerHeight" },
                values: new object[] { new DateTime(2023, 8, 3, 19, 59, 46, 109, DateTimeKind.Utc).AddTicks(3837), 155.0 });

            migrationBuilder.UpdateData(
                table: "Cases",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AddedOn", "MaxAirCpuCoolerHeight" },
                values: new object[] { new DateTime(2023, 8, 3, 19, 59, 46, 109, DateTimeKind.Utc).AddTicks(3842), 190.0 });

            migrationBuilder.UpdateData(
                table: "Coolers",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedOn",
                value: new DateTime(2023, 8, 3, 19, 59, 46, 111, DateTimeKind.Utc).AddTicks(2514));

            migrationBuilder.UpdateData(
                table: "Coolers",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedOn",
                value: new DateTime(2023, 8, 3, 19, 59, 46, 111, DateTimeKind.Utc).AddTicks(2532));

            migrationBuilder.UpdateData(
                table: "Coolers",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddedOn",
                value: new DateTime(2023, 8, 3, 19, 59, 46, 111, DateTimeKind.Utc).AddTicks(2535));

            migrationBuilder.UpdateData(
                table: "Coolers",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddedOn",
                value: new DateTime(2023, 8, 3, 19, 59, 46, 111, DateTimeKind.Utc).AddTicks(2537));

            migrationBuilder.UpdateData(
                table: "Coolers",
                keyColumn: "Id",
                keyValue: 5,
                column: "AddedOn",
                value: new DateTime(2023, 8, 3, 19, 59, 46, 111, DateTimeKind.Utc).AddTicks(2543));

            migrationBuilder.UpdateData(
                table: "Coolers",
                keyColumn: "Id",
                keyValue: 6,
                column: "AddedOn",
                value: new DateTime(2023, 8, 3, 19, 59, 46, 111, DateTimeKind.Utc).AddTicks(2545));

            migrationBuilder.UpdateData(
                table: "Coolers",
                keyColumn: "Id",
                keyValue: 7,
                column: "AddedOn",
                value: new DateTime(2023, 8, 3, 19, 59, 46, 111, DateTimeKind.Utc).AddTicks(2548));

            migrationBuilder.UpdateData(
                table: "Coolers",
                keyColumn: "Id",
                keyValue: 8,
                column: "AddedOn",
                value: new DateTime(2023, 8, 3, 19, 59, 46, 111, DateTimeKind.Utc).AddTicks(2551));

            migrationBuilder.UpdateData(
                table: "Coolers",
                keyColumn: "Id",
                keyValue: 9,
                column: "AddedOn",
                value: new DateTime(2023, 8, 3, 19, 59, 46, 111, DateTimeKind.Utc).AddTicks(2555));

            migrationBuilder.UpdateData(
                table: "Coolers",
                keyColumn: "Id",
                keyValue: 10,
                column: "AddedOn",
                value: new DateTime(2023, 8, 3, 19, 59, 46, 111, DateTimeKind.Utc).AddTicks(2557));

            migrationBuilder.UpdateData(
                table: "Cpus",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedOn",
                value: new DateTime(2023, 8, 3, 19, 59, 46, 111, DateTimeKind.Utc).AddTicks(3380));

            migrationBuilder.UpdateData(
                table: "Cpus",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedOn",
                value: new DateTime(2023, 8, 3, 19, 59, 46, 111, DateTimeKind.Utc).AddTicks(3389));

            migrationBuilder.UpdateData(
                table: "Cpus",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddedOn",
                value: new DateTime(2023, 8, 3, 19, 59, 46, 111, DateTimeKind.Utc).AddTicks(3392));

            migrationBuilder.UpdateData(
                table: "Cpus",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddedOn",
                value: new DateTime(2023, 8, 3, 19, 59, 46, 111, DateTimeKind.Utc).AddTicks(3394));

            migrationBuilder.UpdateData(
                table: "Cpus",
                keyColumn: "Id",
                keyValue: 5,
                column: "AddedOn",
                value: new DateTime(2023, 8, 3, 19, 59, 46, 111, DateTimeKind.Utc).AddTicks(3397));

            migrationBuilder.UpdateData(
                table: "Cpus",
                keyColumn: "Id",
                keyValue: 6,
                column: "AddedOn",
                value: new DateTime(2023, 8, 3, 19, 59, 46, 111, DateTimeKind.Utc).AddTicks(3400));

            migrationBuilder.UpdateData(
                table: "Cpus",
                keyColumn: "Id",
                keyValue: 7,
                column: "AddedOn",
                value: new DateTime(2023, 8, 3, 19, 59, 46, 111, DateTimeKind.Utc).AddTicks(3403));

            migrationBuilder.UpdateData(
                table: "Gpus",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedOn",
                value: new DateTime(2023, 8, 3, 19, 59, 46, 111, DateTimeKind.Utc).AddTicks(4266));

            migrationBuilder.UpdateData(
                table: "Gpus",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedOn",
                value: new DateTime(2023, 8, 3, 19, 59, 46, 111, DateTimeKind.Utc).AddTicks(4274));

            migrationBuilder.UpdateData(
                table: "Gpus",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddedOn",
                value: new DateTime(2023, 8, 3, 19, 59, 46, 111, DateTimeKind.Utc).AddTicks(4277));

            migrationBuilder.UpdateData(
                table: "Gpus",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddedOn",
                value: new DateTime(2023, 8, 3, 19, 59, 46, 111, DateTimeKind.Utc).AddTicks(4280));

            migrationBuilder.UpdateData(
                table: "Gpus",
                keyColumn: "Id",
                keyValue: 5,
                column: "AddedOn",
                value: new DateTime(2023, 8, 3, 19, 59, 46, 111, DateTimeKind.Utc).AddTicks(4284));

            migrationBuilder.UpdateData(
                table: "Gpus",
                keyColumn: "Id",
                keyValue: 6,
                column: "AddedOn",
                value: new DateTime(2023, 8, 3, 19, 59, 46, 111, DateTimeKind.Utc).AddTicks(4287));

            migrationBuilder.UpdateData(
                table: "Gpus",
                keyColumn: "Id",
                keyValue: 7,
                column: "AddedOn",
                value: new DateTime(2023, 8, 3, 19, 59, 46, 111, DateTimeKind.Utc).AddTicks(4289));

            migrationBuilder.UpdateData(
                table: "Gpus",
                keyColumn: "Id",
                keyValue: 8,
                column: "AddedOn",
                value: new DateTime(2023, 8, 3, 19, 59, 46, 111, DateTimeKind.Utc).AddTicks(4292));

            migrationBuilder.UpdateData(
                table: "Motherboards",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedOn",
                value: new DateTime(2023, 8, 3, 19, 59, 46, 111, DateTimeKind.Utc).AddTicks(5088));

            migrationBuilder.UpdateData(
                table: "Motherboards",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedOn",
                value: new DateTime(2023, 8, 3, 19, 59, 46, 111, DateTimeKind.Utc).AddTicks(5095));

            migrationBuilder.UpdateData(
                table: "Motherboards",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddedOn",
                value: new DateTime(2023, 8, 3, 19, 59, 46, 111, DateTimeKind.Utc).AddTicks(5098));

            migrationBuilder.UpdateData(
                table: "Motherboards",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddedOn",
                value: new DateTime(2023, 8, 3, 19, 59, 46, 111, DateTimeKind.Utc).AddTicks(5100));

            migrationBuilder.UpdateData(
                table: "Motherboards",
                keyColumn: "Id",
                keyValue: 5,
                column: "AddedOn",
                value: new DateTime(2023, 8, 3, 19, 59, 46, 111, DateTimeKind.Utc).AddTicks(5102));

            migrationBuilder.UpdateData(
                table: "Motherboards",
                keyColumn: "Id",
                keyValue: 6,
                column: "AddedOn",
                value: new DateTime(2023, 8, 3, 19, 59, 46, 111, DateTimeKind.Utc).AddTicks(5106));

            migrationBuilder.UpdateData(
                table: "Motherboards",
                keyColumn: "Id",
                keyValue: 7,
                column: "AddedOn",
                value: new DateTime(2023, 8, 3, 19, 59, 46, 111, DateTimeKind.Utc).AddTicks(5108));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedOn",
                value: new DateTime(2023, 8, 3, 19, 59, 46, 111, DateTimeKind.Utc).AddTicks(5871));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedOn",
                value: new DateTime(2023, 8, 3, 19, 59, 46, 111, DateTimeKind.Utc).AddTicks(5879));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddedOn",
                value: new DateTime(2023, 8, 3, 19, 59, 46, 111, DateTimeKind.Utc).AddTicks(5881));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddedOn",
                value: new DateTime(2023, 8, 3, 19, 59, 46, 111, DateTimeKind.Utc).AddTicks(5884));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 5,
                column: "AddedOn",
                value: new DateTime(2023, 8, 3, 19, 59, 46, 111, DateTimeKind.Utc).AddTicks(5888));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 6,
                column: "AddedOn",
                value: new DateTime(2023, 8, 3, 19, 59, 46, 111, DateTimeKind.Utc).AddTicks(5890));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 7,
                column: "AddedOn",
                value: new DateTime(2023, 8, 3, 19, 59, 46, 111, DateTimeKind.Utc).AddTicks(5893));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 8,
                column: "AddedOn",
                value: new DateTime(2023, 8, 3, 19, 59, 46, 111, DateTimeKind.Utc).AddTicks(5895));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 9,
                column: "AddedOn",
                value: new DateTime(2023, 8, 3, 19, 59, 46, 111, DateTimeKind.Utc).AddTicks(5898));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 10,
                column: "AddedOn",
                value: new DateTime(2023, 8, 3, 19, 59, 46, 111, DateTimeKind.Utc).AddTicks(5901));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 11,
                column: "AddedOn",
                value: new DateTime(2023, 8, 3, 19, 59, 46, 111, DateTimeKind.Utc).AddTicks(5903));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 12,
                column: "AddedOn",
                value: new DateTime(2023, 8, 3, 19, 59, 46, 111, DateTimeKind.Utc).AddTicks(5905));

            migrationBuilder.UpdateData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 13,
                column: "AddedOn",
                value: new DateTime(2023, 8, 3, 19, 59, 46, 111, DateTimeKind.Utc).AddTicks(5907));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedOn",
                value: new DateTime(2023, 8, 3, 19, 59, 46, 111, DateTimeKind.Utc).AddTicks(6663));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedOn",
                value: new DateTime(2023, 8, 3, 19, 59, 46, 111, DateTimeKind.Utc).AddTicks(6674));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddedOn",
                value: new DateTime(2023, 8, 3, 19, 59, 46, 111, DateTimeKind.Utc).AddTicks(6677));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddedOn",
                value: new DateTime(2023, 8, 3, 19, 59, 46, 111, DateTimeKind.Utc).AddTicks(6679));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 5,
                column: "AddedOn",
                value: new DateTime(2023, 8, 3, 19, 59, 46, 111, DateTimeKind.Utc).AddTicks(6684));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 6,
                column: "AddedOn",
                value: new DateTime(2023, 8, 3, 19, 59, 46, 111, DateTimeKind.Utc).AddTicks(6686));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 7,
                column: "AddedOn",
                value: new DateTime(2023, 8, 3, 19, 59, 46, 111, DateTimeKind.Utc).AddTicks(6688));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 8,
                column: "AddedOn",
                value: new DateTime(2023, 8, 3, 19, 59, 46, 111, DateTimeKind.Utc).AddTicks(6691));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 9,
                column: "AddedOn",
                value: new DateTime(2023, 8, 3, 19, 59, 46, 111, DateTimeKind.Utc).AddTicks(6695));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 10,
                column: "AddedOn",
                value: new DateTime(2023, 8, 3, 19, 59, 46, 111, DateTimeKind.Utc).AddTicks(6697));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 11,
                column: "AddedOn",
                value: new DateTime(2023, 8, 3, 19, 59, 46, 111, DateTimeKind.Utc).AddTicks(6699));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 12,
                column: "AddedOn",
                value: new DateTime(2023, 8, 3, 19, 59, 46, 111, DateTimeKind.Utc).AddTicks(6734));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 13,
                column: "AddedOn",
                value: new DateTime(2023, 8, 3, 19, 59, 46, 111, DateTimeKind.Utc).AddTicks(6737));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 14,
                column: "AddedOn",
                value: new DateTime(2023, 8, 3, 19, 59, 46, 111, DateTimeKind.Utc).AddTicks(6739));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 15,
                column: "AddedOn",
                value: new DateTime(2023, 8, 3, 19, 59, 46, 111, DateTimeKind.Utc).AddTicks(6742));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 16,
                column: "AddedOn",
                value: new DateTime(2023, 8, 3, 19, 59, 46, 111, DateTimeKind.Utc).AddTicks(6744));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 17,
                column: "AddedOn",
                value: new DateTime(2023, 8, 3, 19, 59, 46, 111, DateTimeKind.Utc).AddTicks(6747));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 18,
                column: "AddedOn",
                value: new DateTime(2023, 8, 3, 19, 59, 46, 111, DateTimeKind.Utc).AddTicks(6749));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 19,
                column: "AddedOn",
                value: new DateTime(2023, 8, 3, 19, 59, 46, 111, DateTimeKind.Utc).AddTicks(6754));

            migrationBuilder.UpdateData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 20,
                column: "AddedOn",
                value: new DateTime(2023, 8, 3, 19, 59, 46, 111, DateTimeKind.Utc).AddTicks(6756));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedOn",
                value: new DateTime(2023, 8, 3, 19, 59, 46, 111, DateTimeKind.Utc).AddTicks(7530));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedOn",
                value: new DateTime(2023, 8, 3, 19, 59, 46, 111, DateTimeKind.Utc).AddTicks(7537));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddedOn",
                value: new DateTime(2023, 8, 3, 19, 59, 46, 111, DateTimeKind.Utc).AddTicks(7540));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddedOn",
                value: new DateTime(2023, 8, 3, 19, 59, 46, 111, DateTimeKind.Utc).AddTicks(7542));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 5,
                column: "AddedOn",
                value: new DateTime(2023, 8, 3, 19, 59, 46, 111, DateTimeKind.Utc).AddTicks(7546));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 6,
                column: "AddedOn",
                value: new DateTime(2023, 8, 3, 19, 59, 46, 111, DateTimeKind.Utc).AddTicks(7548));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 7,
                column: "AddedOn",
                value: new DateTime(2023, 8, 3, 19, 59, 46, 111, DateTimeKind.Utc).AddTicks(7551));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 8,
                column: "AddedOn",
                value: new DateTime(2023, 8, 3, 19, 59, 46, 111, DateTimeKind.Utc).AddTicks(7553));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 9,
                column: "AddedOn",
                value: new DateTime(2023, 8, 3, 19, 59, 46, 111, DateTimeKind.Utc).AddTicks(7556));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 10,
                column: "AddedOn",
                value: new DateTime(2023, 8, 3, 19, 59, 46, 111, DateTimeKind.Utc).AddTicks(7559));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 11,
                column: "AddedOn",
                value: new DateTime(2023, 8, 3, 19, 59, 46, 111, DateTimeKind.Utc).AddTicks(7561));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 12,
                column: "AddedOn",
                value: new DateTime(2023, 8, 3, 19, 59, 46, 111, DateTimeKind.Utc).AddTicks(7567));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 13,
                column: "AddedOn",
                value: new DateTime(2023, 8, 3, 19, 59, 46, 111, DateTimeKind.Utc).AddTicks(7569));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 14,
                column: "AddedOn",
                value: new DateTime(2023, 8, 3, 19, 59, 46, 111, DateTimeKind.Utc).AddTicks(7572));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 15,
                column: "AddedOn",
                value: new DateTime(2023, 8, 3, 19, 59, 46, 111, DateTimeKind.Utc).AddTicks(7574));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 16,
                column: "AddedOn",
                value: new DateTime(2023, 8, 3, 19, 59, 46, 111, DateTimeKind.Utc).AddTicks(7576));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 17,
                column: "AddedOn",
                value: new DateTime(2023, 8, 3, 19, 59, 46, 111, DateTimeKind.Utc).AddTicks(7579));

            migrationBuilder.UpdateData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 18,
                column: "AddedOn",
                value: new DateTime(2023, 8, 3, 19, 59, 46, 111, DateTimeKind.Utc).AddTicks(7581));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "MaxAirCpuCoolerHeight",
                table: "Cases",
                type: "int",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("73df6910-cc0d-4f98-90a0-748c29bbd618"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8629b812-1fa5-43ad-9e76-9c00f1496a49", "AQAAAAEAACcQAAAAELCBwYy+fkkphTIrLPjSYEJEAHxjs5k855XlKxVFgerDcSMDLMn7QnwROu2ve4FD9g==" });

            migrationBuilder.UpdateData(
                table: "Cases",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AddedOn", "MaxAirCpuCoolerHeight" },
                values: new object[] { new DateTime(2023, 8, 1, 18, 52, 56, 686, DateTimeKind.Utc).AddTicks(2672), 160 });

            migrationBuilder.UpdateData(
                table: "Cases",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AddedOn", "MaxAirCpuCoolerHeight" },
                values: new object[] { new DateTime(2023, 8, 1, 18, 52, 56, 686, DateTimeKind.Utc).AddTicks(2700), 170 });

            migrationBuilder.UpdateData(
                table: "Cases",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AddedOn", "MaxAirCpuCoolerHeight" },
                values: new object[] { new DateTime(2023, 8, 1, 18, 52, 56, 686, DateTimeKind.Utc).AddTicks(2703), 165 });

            migrationBuilder.UpdateData(
                table: "Cases",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AddedOn", "MaxAirCpuCoolerHeight" },
                values: new object[] { new DateTime(2023, 8, 1, 18, 52, 56, 686, DateTimeKind.Utc).AddTicks(2705), 155 });

            migrationBuilder.UpdateData(
                table: "Cases",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AddedOn", "MaxAirCpuCoolerHeight" },
                values: new object[] { new DateTime(2023, 8, 1, 18, 52, 56, 686, DateTimeKind.Utc).AddTicks(2711), 190 });

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
    }
}
