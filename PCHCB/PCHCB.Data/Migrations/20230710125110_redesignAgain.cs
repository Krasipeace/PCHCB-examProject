using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PCHCB.Data.Migrations
{
    public partial class redesignAgain : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cases_PcConfigurations_PcConfigurationId",
                table: "Cases");

            migrationBuilder.DropForeignKey(
                name: "FK_Coolers_PcConfigurations_PcConfigurationId",
                table: "Coolers");

            migrationBuilder.DropForeignKey(
                name: "FK_Cpus_PcConfigurations_PcConfigurationId",
                table: "Cpus");

            migrationBuilder.DropForeignKey(
                name: "FK_Gpus_PcConfigurations_PcConfigurationId",
                table: "Gpus");

            migrationBuilder.DropForeignKey(
                name: "FK_Motherboards_PcConfigurations_PcConfigurationId",
                table: "Motherboards");

            migrationBuilder.DropForeignKey(
                name: "FK_Psus_PcConfigurations_PcConfigurationId",
                table: "Psus");

            migrationBuilder.DropForeignKey(
                name: "FK_Rams_PcConfigurations_PcConfigurationId",
                table: "Rams");

            migrationBuilder.DropForeignKey(
                name: "FK_Storages_PcConfigurations_PcConfigurationId",
                table: "Storages");

            migrationBuilder.DropIndex(
                name: "IX_Storages_PcConfigurationId",
                table: "Storages");

            migrationBuilder.DropIndex(
                name: "IX_Rams_PcConfigurationId",
                table: "Rams");

            migrationBuilder.DropIndex(
                name: "IX_Psus_PcConfigurationId",
                table: "Psus");

            migrationBuilder.DropIndex(
                name: "IX_Motherboards_PcConfigurationId",
                table: "Motherboards");

            migrationBuilder.DropIndex(
                name: "IX_Gpus_PcConfigurationId",
                table: "Gpus");

            migrationBuilder.DropIndex(
                name: "IX_Cpus_PcConfigurationId",
                table: "Cpus");

            migrationBuilder.DropIndex(
                name: "IX_Coolers_PcConfigurationId",
                table: "Coolers");

            migrationBuilder.DropIndex(
                name: "IX_Cases_PcConfigurationId",
                table: "Cases");

            migrationBuilder.DropColumn(
                name: "PcConfigurationId",
                table: "Storages");

            migrationBuilder.DropColumn(
                name: "PcConfigurationId",
                table: "Rams");

            migrationBuilder.DropColumn(
                name: "PcConfigurationId",
                table: "Psus");

            migrationBuilder.DropColumn(
                name: "PcConfigurationId",
                table: "Motherboards");

            migrationBuilder.DropColumn(
                name: "PcConfigurationId",
                table: "Gpus");

            migrationBuilder.DropColumn(
                name: "PcConfigurationId",
                table: "Cpus");

            migrationBuilder.DropColumn(
                name: "PcConfigurationId",
                table: "Coolers");

            migrationBuilder.DropColumn(
                name: "PcConfigurationId",
                table: "Cases");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PcConfigurationId",
                table: "Storages",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PcConfigurationId",
                table: "Rams",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PcConfigurationId",
                table: "Psus",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PcConfigurationId",
                table: "Motherboards",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PcConfigurationId",
                table: "Gpus",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PcConfigurationId",
                table: "Cpus",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PcConfigurationId",
                table: "Coolers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PcConfigurationId",
                table: "Cases",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Storages_PcConfigurationId",
                table: "Storages",
                column: "PcConfigurationId");

            migrationBuilder.CreateIndex(
                name: "IX_Rams_PcConfigurationId",
                table: "Rams",
                column: "PcConfigurationId");

            migrationBuilder.CreateIndex(
                name: "IX_Psus_PcConfigurationId",
                table: "Psus",
                column: "PcConfigurationId");

            migrationBuilder.CreateIndex(
                name: "IX_Motherboards_PcConfigurationId",
                table: "Motherboards",
                column: "PcConfigurationId");

            migrationBuilder.CreateIndex(
                name: "IX_Gpus_PcConfigurationId",
                table: "Gpus",
                column: "PcConfigurationId");

            migrationBuilder.CreateIndex(
                name: "IX_Cpus_PcConfigurationId",
                table: "Cpus",
                column: "PcConfigurationId");

            migrationBuilder.CreateIndex(
                name: "IX_Coolers_PcConfigurationId",
                table: "Coolers",
                column: "PcConfigurationId");

            migrationBuilder.CreateIndex(
                name: "IX_Cases_PcConfigurationId",
                table: "Cases",
                column: "PcConfigurationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cases_PcConfigurations_PcConfigurationId",
                table: "Cases",
                column: "PcConfigurationId",
                principalTable: "PcConfigurations",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Coolers_PcConfigurations_PcConfigurationId",
                table: "Coolers",
                column: "PcConfigurationId",
                principalTable: "PcConfigurations",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Cpus_PcConfigurations_PcConfigurationId",
                table: "Cpus",
                column: "PcConfigurationId",
                principalTable: "PcConfigurations",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Gpus_PcConfigurations_PcConfigurationId",
                table: "Gpus",
                column: "PcConfigurationId",
                principalTable: "PcConfigurations",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Motherboards_PcConfigurations_PcConfigurationId",
                table: "Motherboards",
                column: "PcConfigurationId",
                principalTable: "PcConfigurations",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Psus_PcConfigurations_PcConfigurationId",
                table: "Psus",
                column: "PcConfigurationId",
                principalTable: "PcConfigurations",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Rams_PcConfigurations_PcConfigurationId",
                table: "Rams",
                column: "PcConfigurationId",
                principalTable: "PcConfigurations",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Storages_PcConfigurations_PcConfigurationId",
                table: "Storages",
                column: "PcConfigurationId",
                principalTable: "PcConfigurations",
                principalColumn: "Id");
        }
    }
}
