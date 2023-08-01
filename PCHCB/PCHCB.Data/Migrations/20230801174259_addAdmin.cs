using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PCHCB.Data.Migrations
{
    public partial class addAdmin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("73df6910-cc0d-4f98-90a0-748c29bbd618"), 0, "3daa9475-382d-40c7-aa2c-e85819b5c52d", "admin@pchcb.com", true, "", "Admin", false, null, "ADMIN@PCHCB.COM", "ADMIN@PCHCB.COM", "AQAAAAEAACcQAAAAEDeTLDHCmIyge0z1mVgC6hztszBkV3AE/vmmUjIKhURPSxOQ+J09PPFyyjTWnQxszw==", null, false, null, false, "admin@pchcb.com" });

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

            migrationBuilder.InsertData(
                table: "Providers",
                columns: new[] { "Id", "Description", "LogoUrl", "PhoneNumber", "UserId", "WebPage" },
                values: new object[] { new Guid("028f3802-11ca-4f64-90d8-7bba2e3a74d5"), "This is Administrator account of pchcb app.", "https://www.pchcb.com/images/logo.png", "+359123456789", new Guid("73df6910-cc0d-4f98-90a0-748c29bbd618"), "https://www.pchcb.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Providers",
                keyColumn: "Id",
                keyValue: new Guid("028f3802-11ca-4f64-90d8-7bba2e3a74d5"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("73df6910-cc0d-4f98-90a0-748c29bbd618"));

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
    }
}
