using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PCHCB.Data.Migrations
{
    public partial class seedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cases_Providers_ProviderId",
                table: "Cases");

            migrationBuilder.DropForeignKey(
                name: "FK_Coolers_Providers_ProviderId",
                table: "Coolers");

            migrationBuilder.DropForeignKey(
                name: "FK_Cpus_Providers_ProviderId",
                table: "Cpus");

            migrationBuilder.DropForeignKey(
                name: "FK_Gpus_Providers_ProviderId",
                table: "Gpus");

            migrationBuilder.DropForeignKey(
                name: "FK_Motherboards_Providers_ProviderId",
                table: "Motherboards");

            migrationBuilder.DropForeignKey(
                name: "FK_Psus_Providers_ProviderId",
                table: "Psus");

            migrationBuilder.DropForeignKey(
                name: "FK_Rams_Providers_ProviderId",
                table: "Rams");

            migrationBuilder.DropForeignKey(
                name: "FK_Storages_Providers_ProviderId",
                table: "Storages");

            migrationBuilder.InsertData(
                table: "Cases",
                columns: new[] { "Id", "AddedOn", "CaseSize", "Description", "FormFactor", "ImageUrl", "MaxAirCpuCoolerHeight", "MaxGpuLength", "MaxRadiatorLength", "MaxStorageDevices", "Name", "Price", "ProviderId", "PsuFactor" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 7, 12, 22, 17, 37, 619, DateTimeKind.Utc).AddTicks(834), 1, "The Corsair Carbide Series 175R RGB is a mid-tower ATX case with clean lines and a minimalist design.", 0, "https://example.com/corsair-carbide-series-175r-rgb.jpg", 160, 330, 280, 4, "Corsair Carbide Series 175R RGB", 69.99m, new Guid("e92e7beb-55d6-4d18-a99d-3ed3411058f5"), 0 },
                    { 2, new DateTime(2023, 7, 12, 22, 17, 37, 619, DateTimeKind.Utc).AddTicks(858), 1, "The Fractal Design Meshify C is a mid-tower ATX case with a unique mesh front panel that provides excellent airflow.", 0, "https://example.com/fractal-design-meshify-c.jpg", 170, 315, 280, 5, "Fractal Design Meshify C", 89.99m, new Guid("e92e7beb-55d6-4d18-a99d-3ed3411058f5"), 0 },
                    { 3, new DateTime(2023, 7, 12, 22, 17, 37, 619, DateTimeKind.Utc).AddTicks(861), 1, "The NZXT H510 is a mid-tower ATX case with a sleek and modern design that looks great in any setup.", 0, "https://example.com/nzxt-h510.jpg", 165, 381, 280, 7, "NZXT H510", 69.99m, new Guid("e92e7beb-55d6-4d18-a99d-3ed3411058f5"), 0 },
                    { 4, new DateTime(2023, 7, 12, 22, 17, 37, 619, DateTimeKind.Utc).AddTicks(864), 2, "The Lian Li PC-O11 Dynamic is a full-tower ATX case with a unique dual-chamber design that provides excellent cooling performance.", 0, "https://example.com/lian-li-pc-o11-dynamic.jpg", 155, 420, 360, 6, "Lian Li PC-O11 Dynamic", 149.99m, new Guid("e92e7beb-55d6-4d18-a99d-3ed3411058f5"), 0 },
                    { 5, new DateTime(2023, 7, 12, 22, 17, 37, 619, DateTimeKind.Utc).AddTicks(871), 2, "The Phanteks Enthoo Evolv X is a full-tower ATX case with a premium build quality and a wide range of features.", 0, "https://example.com/phanteks-enthoo-evolv-x.jpg", 190, 435, 420, 10, "Phanteks Enthoo Evolv X", 199.99m, new Guid("e92e7beb-55d6-4d18-a99d-3ed3411058f5"), 0 }
                });

            migrationBuilder.InsertData(
                table: "Coolers",
                columns: new[] { "Id", "AddedOn", "Compatibility", "CoolerHeight", "Description", "FanSize", "ImageUrl", "Name", "Price", "ProviderId", "RadiatorSize", "Tdp", "Type", "Width" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 7, 12, 22, 17, 37, 620, DateTimeKind.Utc).AddTicks(2970), "Intel LGA2066, LGA2011-0 & LGA2011-3 (Square ILM), LGA1200, LGA1156, LGA1155, LGA1151, LGA1150 & AMD AM2, AM2+, AM3, AM3+, AM4, FM1, FM2, FM2+", 165.0, "The Noctua NH-D15 is a high-end air cooler with excellent cooling performance and low noise levels.", 140, "https://example.com/noctua-nh-d15.jpg", "Noctua NH-D15", 99.99m, new Guid("e92e7beb-55d6-4d18-a99d-3ed3411058f5"), 0, 220, 0, 150 },
                    { 2, new DateTime(2023, 7, 12, 22, 17, 37, 620, DateTimeKind.Utc).AddTicks(2982), "Intel 1200, 1150, 1151, 1155, 1156, 1366, 2011, 2066 & AMD AM4, sTRX4*, TR4* (*Threadripper bracket not included)", 0.0, "The Corsair H100i RGB Platinum is a high-end water cooler with customizable RGB lighting and excellent cooling performance.", 0, "https://example.com/corsair-h100i-rgb-platinum.jpg", "Corsair H100i RGB Platinum", 159.99m, new Guid("e92e7beb-55d6-4d18-a99d-3ed3411058f5"), 1, 250, 1, 0 },
                    { 3, new DateTime(2023, 7, 12, 22, 17, 37, 620, DateTimeKind.Utc).AddTicks(2985), "Intel: LGA 1150 / 1151 / 1155 / 1156 / 1366 / 2011(-3) Square ILM / 2066 & AMD: AM2(+) / AM3(+) / AM4 / FM1 / FM2(+)", 162.80000000000001, "The be quiet! Dark Rock Pro 4 is a high-end air cooler with a sleek design and excellent cooling performance.", 120, "https://example.com/be-quiet-dark-rock-pro-4.jpg", "be quiet! Dark Rock Pro 4", 89.99m, new Guid("e92e7beb-55d6-4d18-a99d-3ed3411058f5"), 0, 250, 0, 136 },
                    { 4, new DateTime(2023, 7, 12, 22, 17, 37, 620, DateTimeKind.Utc).AddTicks(3017), "Intel Socket LGA 1200, 1151, 1150, 1155, 1156, 1366, 2011, 2011-3, 2066 & AMD Socket AM4, sTRX4*, TR4* (*Threadripper bracket not included)", 0.0, "The NZXT Kraken X63 is a high-end water cooler with a customizable LCD display and excellent cooling performance.", 0, "https://example.com/nzxt-kraken-x63.jpg", "NZXT Kraken X63", 149.99m, new Guid("e92e7beb-55d6-4d18-a99d-3ed3411058f5"), 3, 250, 1, 0 },
                    { 5, new DateTime(2023, 7, 12, 22, 17, 37, 620, DateTimeKind.Utc).AddTicks(3022), "Intel LGA 2066 / 2011-v3 / 2011 / 1366 / 1151 / 1150 / 1155 / 1156 / 775 & AMD AM4 / AM3+ / AM3 / AM2+ / AM2 / FM2+ / FM2 / FM1", 159.0, "The Cooler Master Hyper 212 RGB Black Edition is a mid-range air cooler with customizable RGB lighting and good cooling performance.", 120, "https://example.com/cooler-master-hyper-212-rgb-black-edition.jpg", "Cooler Master Hyper 212 RGB Black Edition", 44.99m, new Guid("e92e7beb-55d6-4d18-a99d-3ed3411058f5"), 0, 150, 0, 120 },
                    { 6, new DateTime(2023, 7, 12, 22, 17, 37, 620, DateTimeKind.Utc).AddTicks(3025), "Intel LGA20XX/LGA1366/LGA115X & AMD AM4/AM3+/AM3/AM2+/AM2/FM2+/FM2/FM1", 0.0, "The Deepcool Castle 360EX is a high-end water cooler with a unique mirror finish and excellent cooling performance.", 0, "https://example.com/deepcool-castle-360ex.jpg", "Deepcool Castle 360EX", 149.99m, new Guid("e92e7beb-55d6-4d18-a99d-3ed3411058f5"), 2, 250, 1, 0 },
                    { 7, new DateTime(2023, 7, 12, 22, 17, 37, 620, DateTimeKind.Utc).AddTicks(3027), "Intel Socket 115x, 2011(-3), 2066 & AMD Socket AM4", 157.0, "The Arctic Freezer 34 eSports DUO is a mid-range air cooler with a dual-fan design and good cooling performance.", 120, "https://example.com/arctic-freezer-34-esports-duo.jpg", "Arctic Freezer 34 eSports DUO", 49.99m, new Guid("e92e7beb-55d6-4d18-a99d-3ed3411058f5"), 0, 210, 0, 124 },
                    { 8, new DateTime(2023, 7, 12, 22, 17, 37, 620, DateTimeKind.Utc).AddTicks(3030), "Intel LGA 2066/2011-3/2011/1366/1156/1155/1151/1150 & AMD AM4/FM2/FM1/AM3+/AM3/AM2+/AM2", 0.0, "The Thermaltake Floe Riing RGB 360 TT Premium Edition is a high-end water cooler with customizable RGB lighting and excellent cooling performance.", 0, "https://example.com/thermaltake-floe-riing-rgb-360-tt-premium-edition.jpg", "Thermaltake Floe Riing RGB 360 TT Premium Edition", 199.99m, new Guid("e92e7beb-55d6-4d18-a99d-3ed3411058f5"), 2, 250, 1, 0 },
                    { 9, new DateTime(2023, 7, 12, 22, 17, 37, 620, DateTimeKind.Utc).AddTicks(3034), "Intel LGA2066, LGA2011-v3, LGA2011, LGA1200, LGA1151, LGA1150, LGA1156, LGA1155, LGA1366 & AMD AM4, AM3+, AM3, AM2+, AM2, FM2+, FM2, FM1", 0.0, "The Cooler Master MasterLiquid ML240L RGB V2 is a mid-range water cooler with customizable RGB lighting and good cooling performance.", 0, "https://example.com/cooler-master-masterliquid-ml240l-rgb-v2.jpg", "Cooler Master MasterLiquid ML240L RGB V2", 79.99m, new Guid("e92e7beb-55d6-4d18-a99d-3ed3411058f5"), 1, 200, 1, 0 },
                    { 10, new DateTime(2023, 7, 12, 22, 17, 37, 620, DateTimeKind.Utc).AddTicks(3038), "Intel Socket LGA775, LGA1150, LGA1151, LGA1155, LGA1156, LGA1366, LGA2011(-3) Square ILM, LGA2066 & AMD Socket AM2(+), AM3(+), AM4, FM1, FM2(+)", 154.5, "The Scythe Mugen 5 Rev.B is a mid-range air cooler with a quiet fan and good cooling performance.", 120, "https://example.com/scythe-mugen-5-rev-b.jpg", "Scythe Mugen 5 Rev.B", 49.99m, new Guid("e92e7beb-55d6-4d18-a99d-3ed3411058f5"), 0, 180, 0, 130 }
                });

            migrationBuilder.InsertData(
                table: "Cpus",
                columns: new[] { "Id", "AddedOn", "Cache", "Cores", "Description", "Frequency", "ImageUrl", "Name", "Price", "ProviderId", "RamFrequency", "RamType", "Socket", "Tdp", "Threads", "TurboFrequency" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 7, 12, 22, 17, 37, 620, DateTimeKind.Utc).AddTicks(3777), 35, 6, "The AMD Ryzen 5 5600X is a powerful 6-core processor with excellent single-threaded performance.", 3700, "https://example.com/amd-ryzen-5-5600x.jpg", "AMD Ryzen 5 5600X", 299.99m, new Guid("e92e7beb-55d6-4d18-a99d-3ed3411058f5"), 3200, 1, "AM4", 65, 12, 4600 },
                    { 2, new DateTime(2023, 7, 12, 22, 17, 37, 620, DateTimeKind.Utc).AddTicks(3784), 12, 6, "The Intel Core i5-11600K is a high-performance 6-core processor with excellent gaming performance.", 3900, "https://example.com/intel-core-i5-11600k.jpg", "Intel Core i5-11600K", 269.99m, new Guid("e92e7beb-55d6-4d18-a99d-3ed3411058f5"), 3200, 1, "LGA1200", 125, 12, 4900 },
                    { 3, new DateTime(2023, 7, 12, 22, 17, 37, 620, DateTimeKind.Utc).AddTicks(3786), 36, 8, "The AMD Ryzen 7 5800X is a high-performance 8-core processor with excellent multi-threaded performance.", 3800, "https://example.com/amd-ryzen-7-5800x.jpg", "AMD Ryzen 7 5800X", 449.99m, new Guid("e92e7beb-55d6-4d18-a99d-3ed3411058f5"), 3200, 1, "AM4", 105, 16, 4700 },
                    { 4, new DateTime(2023, 7, 12, 22, 17, 37, 620, DateTimeKind.Utc).AddTicks(3789), 16, 8, "The Intel Core i9-11900K is a high-end 8-core processor with excellent gaming and multi-threaded performance.", 3500, "https://example.com/intel-core-i9-11900k.jpg", "Intel Core i9-11900K", 599.99m, new Guid("e92e7beb-55d6-4d18-a99d-3ed3411058f5"), 3200, 1, "LGA1200", 125, 16, 5300 },
                    { 5, new DateTime(2023, 7, 12, 22, 17, 37, 620, DateTimeKind.Utc).AddTicks(3791), 72, 16, "The AMD Ryzen 9 5950X is a high-end 16-core processor with excellent multi-threaded performance.", 3400, "https://example.com/amd-ryzen-9-5950x.jpg", "AMD Ryzen 9 5950X", 799.99m, new Guid("e92e7beb-55d6-4d18-a99d-3ed3411058f5"), 3200, 1, "AM4", 105, 32, 4900 },
                    { 6, new DateTime(2023, 7, 12, 22, 17, 37, 620, DateTimeKind.Utc).AddTicks(3794), 20, 10, "The Intel Core i9-10900K is a high-end 10-core processor with excellent gaming and multi-threaded performance.", 3700, "https://example.com/intel-core-i9-10900k.jpg", "Intel Core i9-10900K", 529.99m, new Guid("e92e7beb-55d6-4d18-a99d-3ed3411058f5"), 3200, 1, "LGA1200", 125, 20, 5300 },
                    { 7, new DateTime(2023, 7, 12, 22, 17, 37, 620, DateTimeKind.Utc).AddTicks(3797), 70, 12, "The AMD Ryzen 9 5900X is a high-end 12-core processor with excellent multi-threaded performance.", 3700, "https://example.com/amd-ryzen-9-5900x.jpg", "AMD Ryzen 9 5900X", 549.99m, new Guid("e92e7beb-55d6-4d18-a99d-3ed3411058f5"), 3200, 1, "AM4", 105, 24, 4800 }
                });

            migrationBuilder.InsertData(
                table: "Gpus",
                columns: new[] { "Id", "AddedOn", "Description", "ImageUrl", "Interface", "Length", "Memory", "Name", "NvidiaConnector", "PowerConsumption", "Price", "ProviderId", "SlotsRequired" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 7, 12, 22, 17, 37, 620, DateTimeKind.Utc).AddTicks(4677), "The NVIDIA GeForce RTX 3080 is a high-end graphics card with excellent gaming performance.", "https://example.com/nvidia-geforce-rtx-3080.jpg", 1, 285.0, 10, "NVIDIA GeForce RTX 3080", false, 320, 699.99m, new Guid("e92e7beb-55d6-4d18-a99d-3ed3411058f5"), 2.5 },
                    { 2, new DateTime(2023, 7, 12, 22, 17, 37, 620, DateTimeKind.Utc).AddTicks(4691), "The AMD Radeon RX 6800 XT is a high-end graphics card with excellent gaming performance.", "https://example.com/amd-radeon-rx-6800-xt.jpg", 1, 267.0, 16, "AMD Radeon RX 6800 XT", false, 300, 649.99m, new Guid("e92e7beb-55d6-4d18-a99d-3ed3411058f5"), 2.5 },
                    { 3, new DateTime(2023, 7, 12, 22, 17, 37, 620, DateTimeKind.Utc).AddTicks(4695), "The NVIDIA GeForce RTX 3070 is a high-performance graphics card with excellent gaming performance.", "https://example.com/nvidia-geforce-rtx-3070.jpg", 1, 242.0, 8, "NVIDIA GeForce RTX 3070", false, 220, 499.99m, new Guid("e92e7beb-55d6-4d18-a99d-3ed3411058f5"), 2.0 },
                    { 4, new DateTime(2023, 7, 12, 22, 17, 37, 620, DateTimeKind.Utc).AddTicks(4698), "The AMD Radeon RX 6700 XT is a high-performance graphics card with excellent gaming performance.", "https://example.com/amd-radeon-rx-6700-xt.jpg", 1, 267.0, 12, "AMD Radeon RX 6700 XT", false, 230, 479.99m, new Guid("e92e7beb-55d6-4d18-a99d-3ed3411058f5"), 2.5 },
                    { 5, new DateTime(2023, 7, 12, 22, 17, 37, 620, DateTimeKind.Utc).AddTicks(4704), "The NVIDIA GeForce RTX 3060 Ti is a high-performance graphics card with excellent gaming performance.", "https://example.com/nvidia-geforce-rtx-3060-ti.jpg", 1, 242.0, 8, "NVIDIA GeForce RTX 3060 Ti", false, 200, 399.99m, new Guid("e92e7beb-55d6-4d18-a99d-3ed3411058f5"), 2.0 },
                    { 6, new DateTime(2023, 7, 12, 22, 17, 37, 620, DateTimeKind.Utc).AddTicks(4708), "The NVIDIA GeForce RTX 3090 is a high-end graphics card with excellent gaming performance.", "https://example.com/nvidia-geforce-rtx-3090.jpg", 1, 313.0, 24, "NVIDIA GeForce RTX 3090", false, 350, 1499.99m, new Guid("e92e7beb-55d6-4d18-a99d-3ed3411058f5"), 3.0 },
                    { 7, new DateTime(2023, 7, 12, 22, 17, 37, 620, DateTimeKind.Utc).AddTicks(4711), "The AMD Radeon RX 6900 XT is a high-end graphics card with excellent gaming performance.", "https://example.com/amd-radeon-rx-6900-xt.jpg", 1, 267.0, 16, "AMD Radeon RX 6900 XT", false, 300, 999.99m, new Guid("e92e7beb-55d6-4d18-a99d-3ed3411058f5"), 2.5 },
                    { 8, new DateTime(2023, 7, 12, 22, 17, 37, 620, DateTimeKind.Utc).AddTicks(4714), "The NVIDIA GeForce RTX 4090 is a high-end graphics card with excellent gaming performance.", "https://example.com/nvidia-geforce-rtx-4090.jpg", 2, 313.0, 48, "NVIDIA GeForce RTX 4090", true, 500, 2499.99m, new Guid("e92e7beb-55d6-4d18-a99d-3ed3411058f5"), 3.0 }
                });

            migrationBuilder.InsertData(
                table: "Motherboards",
                columns: new[] { "Id", "AddedOn", "Chipset", "Description", "FormFactor", "ImageUrl", "M2Slots", "Name", "PcieSlots", "PcieType", "Price", "ProviderId", "RamCapacity", "RamSlots", "RamType", "SataSlots", "Socket" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 7, 12, 22, 17, 37, 620, DateTimeKind.Utc).AddTicks(5536), "B550", "The ASUS ROG Strix B550-F Gaming is a high-end motherboard with excellent performance and features.", 0, "https://example.com/asus-rog-strix-b550-f-gaming.jpg", 2, "ASUS ROG Strix B550-F Gaming", 2, 1, 189.99m, new Guid("e92e7beb-55d6-4d18-a99d-3ed3411058f5"), 128, 4, 1, 6, "AM4" },
                    { 2, new DateTime(2023, 7, 12, 22, 17, 37, 620, DateTimeKind.Utc).AddTicks(5542), "B450", "The GIGABYTE B450 AORUS PRO WIFI is a mid-range motherboard with good performance and features.", 0, "https://example.com/gigabyte-b450-aorus-pro-wifi.jpg", 2, "GIGABYTE B450 AORUS PRO WIFI", 2, 0, 119.99m, new Guid("e92e7beb-55d6-4d18-a99d-3ed3411058f5"), 128, 4, 1, 6, "AM4" },
                    { 3, new DateTime(2023, 7, 12, 22, 17, 37, 620, DateTimeKind.Utc).AddTicks(5545), "Z490", "The ASUS Prime Z490-A is a high-end motherboard with excellent performance and features.", 0, "https://example.com/asus-prime-z490-a.jpg", 2, "ASUS Prime Z490-A", 3, 0, 229.99m, new Guid("e92e7beb-55d6-4d18-a99d-3ed3411058f5"), 128, 4, 1, 6, "LGA1200" },
                    { 4, new DateTime(2023, 7, 12, 22, 17, 37, 620, DateTimeKind.Utc).AddTicks(5547), "B550", "The MSI MPG B550 Gaming Edge WiFi is a high-end motherboard with excellent performance and features.", 0, "https://example.com/msi-mpg-b550-gaming-edge-wifi.jpg", 2, "MSI MPG B550 Gaming Edge WiFi", 2, 1, 179.99m, new Guid("e92e7beb-55d6-4d18-a99d-3ed3411058f5"), 128, 4, 1, 6, "AM4" },
                    { 5, new DateTime(2023, 7, 12, 22, 17, 37, 620, DateTimeKind.Utc).AddTicks(5550), "B450", "The ASRock B450M PRO4 is a budget motherboard with decent performance and features.", 1, "https://example.com/asrock-b450m-pro4.jpg", 1, "ASRock B450M PRO4", 2, 0, 79.99m, new Guid("e92e7beb-55d6-4d18-a99d-3ed3411058f5"), 64, 4, 1, 4, "AM4" },
                    { 6, new DateTime(2023, 7, 12, 22, 17, 37, 620, DateTimeKind.Utc).AddTicks(5553), "X570", "The ASUS ROG Strix X570-E Gaming is a high-end motherboard with excellent performance and features.", 0, "https://example.com/asus-rog-strix-x570-e-gaming.jpg", 2, "ASUS ROG Strix X570-E Gaming", 3, 1, 299.99m, new Guid("e92e7beb-55d6-4d18-a99d-3ed3411058f5"), 128, 4, 1, 8, "AM4" },
                    { 7, new DateTime(2023, 7, 12, 22, 17, 37, 620, DateTimeKind.Utc).AddTicks(5556), "B550", "The ASUS ROG Strix B550-I Gaming is a high-end motherboard with excellent performance and features.", 2, "https://example.com/asus-rog-strix-b550-i-gaming.jpg", 2, "ASUS ROG Strix B550-I Gaming", 1, 1, 229.99m, new Guid("e92e7beb-55d6-4d18-a99d-3ed3411058f5"), 64, 2, 1, 4, "AM4" }
                });

            migrationBuilder.InsertData(
                table: "Psus",
                columns: new[] { "Id", "AddedOn", "Description", "Factor", "ImageUrl", "Name", "NvidiaConnector", "Price", "ProviderId", "Wattage" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 7, 12, 22, 17, 37, 620, DateTimeKind.Utc).AddTicks(6423), "The Corsair RM850x is a high-end power supply with excellent performance and features.", 0, "https://example.com/corsair-rm850x.jpg", "Corsair RM850x", true, 139.99m, new Guid("e92e7beb-55d6-4d18-a99d-3ed3411058f5"), 850 },
                    { 2, new DateTime(2023, 7, 12, 22, 17, 37, 620, DateTimeKind.Utc).AddTicks(6430), "The EVGA SuperNOVA 750 G5 is a high-end power supply with excellent performance and features.", 0, "https://example.com/evga-supernova-750-g5.jpg", "EVGA SuperNOVA 750 G5", true, 129.99m, new Guid("e92e7beb-55d6-4d18-a99d-3ed3411058f5"), 750 },
                    { 3, new DateTime(2023, 7, 12, 22, 17, 37, 620, DateTimeKind.Utc).AddTicks(6432), "The Seasonic FOCUS GX-650 is a mid-range power supply with good performance and features.", 0, "https://example.com/seasonic-focus-gx-650.jpg", "Seasonic FOCUS GX-650", true, 109.99m, new Guid("e92e7beb-55d6-4d18-a99d-3ed3411058f5"), 650 },
                    { 4, new DateTime(2023, 7, 12, 22, 17, 37, 620, DateTimeKind.Utc).AddTicks(6435), "The be quiet! Straight Power 11 Platinum 750W is a high-end power supply with excellent performance and features.", 0, "https://example.com/be-quiet-straight-power-11-platinum-750w.jpg", "be quiet! Straight Power 11 Platinum 750W", true, 149.99m, new Guid("e92e7beb-55d6-4d18-a99d-3ed3411058f5"), 750 },
                    { 5, new DateTime(2023, 7, 12, 22, 17, 37, 620, DateTimeKind.Utc).AddTicks(6439), "The Thermaltake Toughpower GF1 750W is a high-end power supply with excellent performance and features.", 0, "https://example.com/thermaltake-toughpower-gf1-750w.jpg", "Thermaltake Toughpower GF1 750W", true, 129.99m, new Guid("e92e7beb-55d6-4d18-a99d-3ed3411058f5"), 750 }
                });

            migrationBuilder.InsertData(
                table: "Psus",
                columns: new[] { "Id", "AddedOn", "Description", "Factor", "ImageUrl", "Name", "NvidiaConnector", "Price", "ProviderId", "Wattage" },
                values: new object[,]
                {
                    { 6, new DateTime(2023, 7, 12, 22, 17, 37, 620, DateTimeKind.Utc).AddTicks(6441), "The Corsair AX1600i is a high-end power supply with excellent performance and features.", 0, "https://example.com/corsair-ax1600i.jpg", "Corsair AX1600i", true, 499.99m, new Guid("e92e7beb-55d6-4d18-a99d-3ed3411058f5"), 1600 },
                    { 7, new DateTime(2023, 7, 12, 22, 17, 37, 620, DateTimeKind.Utc).AddTicks(6443), "The EVGA SuperNOVA 1600 T2 is a high-end power supply with excellent performance and features.", 0, "https://example.com/evga-supernova-1600-t2.jpg", "EVGA SuperNOVA 1600 T2", true, 499.99m, new Guid("e92e7beb-55d6-4d18-a99d-3ed3411058f5"), 1600 },
                    { 8, new DateTime(2023, 7, 12, 22, 17, 37, 620, DateTimeKind.Utc).AddTicks(6446), "The Seasonic PRIME TX-1600 is a high-end power supply with excellent performance and features.", 0, "https://example.com/seasonic-prime-tx-1600.jpg", "Seasonic PRIME TX-1600", true, 499.99m, new Guid("e92e7beb-55d6-4d18-a99d-3ed3411058f5"), 1600 },
                    { 9, new DateTime(2023, 7, 12, 22, 17, 37, 620, DateTimeKind.Utc).AddTicks(6449), "The Thermaltake Toughpower PF1 ARGB 1200W is a high-end power supply with excellent performance and features.", 0, "https://example.com/thermaltake-toughpower-pf1-argb-1200w.jpg", "Thermaltake Toughpower PF1 ARGB 1200W", true, 299.99m, new Guid("e92e7beb-55d6-4d18-a99d-3ed3411058f5"), 1200 },
                    { 10, new DateTime(2023, 7, 12, 22, 17, 37, 620, DateTimeKind.Utc).AddTicks(6451), "The be quiet! Dark Power Pro 12 1500W is a high-end power supply with excellent performance and features.", 0, "https://example.com/be-quiet-dark-power-pro-12-1500w.jpg", "be quiet! Dark Power Pro 12 1500W", true, 499.99m, new Guid("e92e7beb-55d6-4d18-a99d-3ed3411058f5"), 1500 },
                    { 11, new DateTime(2023, 7, 12, 22, 17, 37, 620, DateTimeKind.Utc).AddTicks(6453), "The EVGA 500 W1 is a budget power supply with decent performance and features.", 0, "https://example.com/evga-500-w1.jpg", "EVGA 500 W1", false, 49.99m, new Guid("e92e7beb-55d6-4d18-a99d-3ed3411058f5"), 500 },
                    { 12, new DateTime(2023, 7, 12, 22, 17, 37, 620, DateTimeKind.Utc).AddTicks(6456), "The Corsair CX450M is a mid-range power supply with good performance and features.", 0, "https://example.com/corsair-cx450m.jpg", "Corsair CX450M", false, 64.99m, new Guid("e92e7beb-55d6-4d18-a99d-3ed3411058f5"), 450 },
                    { 13, new DateTime(2023, 7, 12, 22, 17, 37, 620, DateTimeKind.Utc).AddTicks(6458), "The Seasonic S12III 500 SSR-500GB3 is a budget power supply with decent performance and features.", 0, "https://example.com/seasonic-s12iii-500-ssr-500gb3.jpg", "Seasonic S12III 500 SSR-500GB3", false, 59.99m, new Guid("e92e7beb-55d6-4d18-a99d-3ed3411058f5"), 500 }
                });

            migrationBuilder.InsertData(
                table: "Rams",
                columns: new[] { "Id", "AddedOn", "Capacity", "Description", "Frequency", "Height", "ImageUrl", "ModelNumber", "Name", "Price", "ProviderId", "Type" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 7, 12, 22, 17, 37, 620, DateTimeKind.Utc).AddTicks(7235), 16, "The Corsair Vengeance LPX 16GB DDR4 3200MHz C16 is a high-performance memory stick with excellent compatibility and reliability.", 3200, 31.199999999999999, "https://example.com/corsair-vengeance-lpx-16gb-ddr4-3200mhz-c16.jpg", "CMK16GX4M1D3200C16", "Corsair Vengeance LPX 16GB DDR4 3200MHz C16", 79.99m, new Guid("e92e7beb-55d6-4d18-a99d-3ed3411058f5"), 1 },
                    { 2, new DateTime(2023, 7, 12, 22, 17, 37, 620, DateTimeKind.Utc).AddTicks(7243), 16, "The G.Skill Ripjaws V 16GB DDR4 3600MHz C16 is a high-performance memory stick with excellent compatibility and reliability.", 3600, 42.0, "https://example.com/g-skill-ripjaws-v-16gb-ddr4-3600mhz-c16.jpg", "F4-3600C16D-16GVKC", "G.Skill Ripjaws V 16GB DDR4 3600MHz C16", 89.99m, new Guid("e92e7beb-55d6-4d18-a99d-3ed3411058f5"), 1 },
                    { 3, new DateTime(2023, 7, 12, 22, 17, 37, 620, DateTimeKind.Utc).AddTicks(7247), 16, "The Crucial Ballistix 16GB DDR4 3200MHz CL16 is a high-performance memory stick with excellent compatibility and reliability.", 3200, 39.170000000000002, "https://example.com/crucial-ballistix-16gb-ddr4-3200mhz-cl16.jpg", "BL2K8G32C16U4B", "Crucial Ballistix 16GB DDR4 3200MHz CL16", 74.99m, new Guid("e92e7beb-55d6-4d18-a99d-3ed3411058f5"), 1 },
                    { 4, new DateTime(2023, 7, 12, 22, 17, 37, 620, DateTimeKind.Utc).AddTicks(7250), 16, "The Kingston HyperX Fury 16GB DDR4 3200MHz CL16 is a high-performance memory stick with excellent compatibility and reliability.", 3200, 34.0, "https://example.com/kingston-hyperx-fury-16gb-ddr4-3200mhz-cl16.jpg", "HX432C16FB3/16", "Kingston HyperX Fury 16GB DDR4 3200MHz CL16", 79.99m, new Guid("e92e7beb-55d6-4d18-a99d-3ed3411058f5"), 1 },
                    { 5, new DateTime(2023, 7, 12, 22, 17, 37, 620, DateTimeKind.Utc).AddTicks(7256), 16, "The Team T-Force Vulcan Z 16GB DDR4 3200MHz CL16 is a high-performance memory stick with excellent compatibility and reliability.", 3200, 32.0, "https://example.com/team-t-force-vulcan-z-16gb-ddr4-3200mhz-cl16.jpg", "TLZGD416G3200HC16CDC01", "Team T-Force Vulcan Z 16GB DDR4 3200MHz CL16", 69.99m, new Guid("e92e7beb-55d6-4d18-a99d-3ed3411058f5"), 1 },
                    { 6, new DateTime(2023, 7, 12, 22, 17, 37, 620, DateTimeKind.Utc).AddTicks(7259), 16, "The Corsair Vengeance RGB Pro 16GB DDR4 3200MHz C16 is a high-performance memory stick with excellent compatibility and reliability.", 3200, 51.0, "https://example.com/corsair-vengeance-rgb-pro-16gb-ddr4-3200mhz-c16.jpg", "CMW16GX4M2C3200C16", "Corsair Vengeance RGB Pro 16GB DDR4 3200MHz C16", 99.99m, new Guid("e92e7beb-55d6-4d18-a99d-3ed3411058f5"), 1 },
                    { 7, new DateTime(2023, 7, 12, 22, 17, 37, 620, DateTimeKind.Utc).AddTicks(7262), 16, "The G.Skill Trident Z RGB 16GB DDR4 3200MHz C16 is a high-performance memory stick with excellent compatibility and reliability.", 3200, 44.0, "https://example.com/g-skill-trident-z-rgb-16gb-ddr4-3200mhz-c16.jpg", "F4-3200C16D-16GTZR", "G.Skill Trident Z RGB 16GB DDR4 3200MHz C16", 99.99m, new Guid("e92e7beb-55d6-4d18-a99d-3ed3411058f5"), 1 },
                    { 8, new DateTime(2023, 7, 12, 22, 17, 37, 620, DateTimeKind.Utc).AddTicks(7265), 16, "The Crucial Ballistix RGB 16GB DDR4 3200MHz CL16 is a high-performance memory stick with excellent compatibility and reliability.", 3200, 39.170000000000002, "https://example.com/crucial-ballistix-rgb-16gb-ddr4-3200mhz-cl16.jpg", "BL2K8G32C16U4BL", "Crucial Ballistix RGB 16GB DDR4 3200MHz CL16", 89.99m, new Guid("e92e7beb-55d6-4d18-a99d-3ed3411058f5"), 1 },
                    { 9, new DateTime(2023, 7, 12, 22, 17, 37, 620, DateTimeKind.Utc).AddTicks(7268), 16, "The Kingston HyperX Fury RGB 16GB DDR4 3200MHz CL16 is a high-performance memory stick with excellent compatibility and reliability.", 3200, 34.0, "https://example.com/kingston-hyperx-fury-rgb-16gb-ddr4-3200mhz-cl16.jpg", "HX432C16FB3A/16", "Kingston HyperX Fury RGB 16GB DDR4 3200MHz CL16", 89.99m, new Guid("e92e7beb-55d6-4d18-a99d-3ed3411058f5"), 1 },
                    { 10, new DateTime(2023, 7, 12, 22, 17, 37, 620, DateTimeKind.Utc).AddTicks(7271), 16, "The Team T-Force Delta RGB 16GB DDR4 3200MHz CL16 is a high-performance memory stick with excellent compatibility and reliability.", 3200, 44.0, "https://example.com/team-t-force-delta-rgb-16gb-ddr4-3200mhz-cl16.jpg", "TF3D416G3200HC16CDC01", "Team T-Force Delta RGB 16GB DDR4 3200MHz CL16", 79.99m, new Guid("e92e7beb-55d6-4d18-a99d-3ed3411058f5"), 1 },
                    { 11, new DateTime(2023, 7, 12, 22, 17, 37, 620, DateTimeKind.Utc).AddTicks(7273), 16, "The Corsair Vengeance LPX 16GB DDR5 is a high-end memory stick with excellent performance and features.", 4800, 31.199999999999999, "https://example.com/corsair-vengeance-lpx-ddr5.jpg", "CMK16GX5M1Z4800C21", "Corsair Vengeance LPX 16GB DDR5", 199.99m, new Guid("e92e7beb-55d6-4d18-a99d-3ed3411058f5"), 2 },
                    { 12, new DateTime(2023, 7, 12, 22, 17, 37, 620, DateTimeKind.Utc).AddTicks(7276), 32, "The G.Skill Trident Z Royal 32GB DDR5 is a high-end memory stick with excellent performance and features.", 4800, 44.0, "https://example.com/gskill-trident-z-royal-ddr5.jpg", "F6-4800C21D-32GTRS", "G.Skill Trident Z Royal 32GB DDR5", 399.99m, new Guid("e92e7beb-55d6-4d18-a99d-3ed3411058f5"), 2 },
                    { 13, new DateTime(2023, 7, 12, 22, 17, 37, 620, DateTimeKind.Utc).AddTicks(7279), 64, "The Kingston HyperX Predator 64GB DDR5 is a high-end memory stick with excellent performance and features.", 5200, 42.200000000000003, "https://example.com/kingston-hyperx-predator-ddr5.jpg", "HX452C21PB3K4/64", "Kingston HyperX Predator 64GB DDR5", 799.99m, new Guid("e92e7beb-55d6-4d18-a99d-3ed3411058f5"), 2 },
                    { 14, new DateTime(2023, 7, 12, 22, 17, 37, 620, DateTimeKind.Utc).AddTicks(7281), 16, "The TeamGroup T-Force Xtreem ARGB 16GB DDR5 is a high-end memory stick with excellent performance and features.", 4800, 48.700000000000003, "https://example.com/teamgroup-t-force-xtreem-argb-ddr5.jpg", "TFXAD516G4800HC21CDC01", "TeamGroup T-Force Xtreem ARGB 16GB DDR5", 199.99m, new Guid("e92e7beb-55d6-4d18-a99d-3ed3411058f5"), 2 },
                    { 15, new DateTime(2023, 7, 12, 22, 17, 37, 620, DateTimeKind.Utc).AddTicks(7283), 32, "The Crucial Ballistix MAX 32GB DDR5 is a high-end memory stick with excellent performance and features.", 4800, 40.0, "https://example.com/crucial-ballistix-max-ddr5.jpg", "BLM32G4800C21", "Crucial Ballistix MAX 32GB DDR5", 399.99m, new Guid("e92e7beb-55d6-4d18-a99d-3ed3411058f5"), 2 },
                    { 16, new DateTime(2023, 7, 12, 22, 17, 37, 620, DateTimeKind.Utc).AddTicks(7286), 16, "The Patriot Viper RGB 16GB DDR5 is a high-end memory stick with excellent performance and features.", 4800, 44.0, "https://example.com/patriot-viper-rgb-ddr5.jpg", "PVR416G480C8K", "Patriot Viper RGB 16GB DDR5", 199.99m, new Guid("e92e7beb-55d6-4d18-a99d-3ed3411058f5"), 2 },
                    { 17, new DateTime(2023, 7, 12, 22, 17, 37, 620, DateTimeKind.Utc).AddTicks(7288), 32, "The ADATA XPG Spectrix D50 32GB DDR5 is a high-end memory stick with excellent performance and features.", 4800, 44.0, "https://example.com/adata-xpg-spectrix-d50-ddr5.jpg", "AX4U480038G20A-DT50", "ADATA XPG Spectrix D50 32GB DDR5", 399.99m, new Guid("e92e7beb-55d6-4d18-a99d-3ed3411058f5"), 2 },
                    { 18, new DateTime(2023, 7, 12, 22, 17, 37, 620, DateTimeKind.Utc).AddTicks(7290), 16, "The GeIL Orion RGB 16GB DDR5 is a high-end memory stick with excellent performance and features.", 4800, 44.0, "https://example.com/geil-orion-rgb-ddr5.jpg", "GOC516GB4800C21DC", "GeIL Orion RGB 16GB DDR5", 199.99m, new Guid("e92e7beb-55d6-4d18-a99d-3ed3411058f5"), 2 },
                    { 19, new DateTime(2023, 7, 12, 22, 17, 37, 620, DateTimeKind.Utc).AddTicks(7323), 32, "The Mushkin Redline Lumina 32GB DDR5 is a high-end memory stick with excellent performance and features.", 4800, 44.0, "https://example.com/mushkin-redline-lumina-ddr5.jpg", "MR8U480038G21-DL", "Mushkin Redline Lumina 32GB DDR5", 399.99m, new Guid("e92e7beb-55d6-4d18-a99d-3ed3411058f5"), 2 },
                    { 20, new DateTime(2023, 7, 12, 22, 17, 37, 620, DateTimeKind.Utc).AddTicks(7325), 16, "The ZADAK Shield RGB 16GB DDR5 is a high-end memory stick with excellent performance and features.", 4800, 44.0, "https://example.com/zadak-shield-rgb-ddr5.jpg", "ZS-4800-16G", "ZADAK Shield RGB 16GB DDR5", 199.99m, new Guid("e92e7beb-55d6-4d18-a99d-3ed3411058f5"), 2 }
                });

            migrationBuilder.InsertData(
                table: "Storages",
                columns: new[] { "Id", "AddedOn", "Capacity", "Description", "ImageUrl", "Name", "Price", "ProviderId", "Type" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 7, 12, 22, 17, 37, 620, DateTimeKind.Utc).AddTicks(8097), 1000, "The Samsung 860 EVO 1TB SSD is a high-end storage device with excellent performance and features.", "https://example.com/samsung-860-evo-ssd.jpg", "Samsung 860 EVO 1TB SSD", 129.99m, new Guid("e92e7beb-55d6-4d18-a99d-3ed3411058f5"), 1 },
                    { 2, new DateTime(2023, 7, 12, 22, 17, 37, 620, DateTimeKind.Utc).AddTicks(8105), 500, "The Crucial MX500 500GB SSD is a high-end storage device with excellent performance and features.", "https://example.com/crucial-mx500-ssd.jpg", "Crucial MX500 500GB SSD", 69.99m, new Guid("e92e7beb-55d6-4d18-a99d-3ed3411058f5"), 1 },
                    { 3, new DateTime(2023, 7, 12, 22, 17, 37, 620, DateTimeKind.Utc).AddTicks(8107), 2000, "The Western Digital Blue 2TB SSD is a high-end storage device with excellent performance and features.", "https://example.com/western-digital-blue-ssd.jpg", "Western Digital Blue 2TB SSD", 229.99m, new Guid("e92e7beb-55d6-4d18-a99d-3ed3411058f5"), 1 },
                    { 4, new DateTime(2023, 7, 12, 22, 17, 37, 620, DateTimeKind.Utc).AddTicks(8109), 1000, "The ADATA SU800 1TB SSD is a high-end storage device with excellent performance and features.", "https://example.com/adata-su800-ssd.jpg", "ADATA SU800 1TB SSD", 99.99m, new Guid("e92e7beb-55d6-4d18-a99d-3ed3411058f5"), 1 },
                    { 5, new DateTime(2023, 7, 12, 22, 17, 37, 620, DateTimeKind.Utc).AddTicks(8113), 2000, "The SanDisk Ultra 3D 2TB SSD is a high-end storage device with excellent performance and features.", "https://example.com/sandisk-ultra-3d-ssd.jpg", "SanDisk Ultra 3D 2TB SSD", 249.99m, new Guid("e92e7beb-55d6-4d18-a99d-3ed3411058f5"), 1 },
                    { 6, new DateTime(2023, 7, 12, 22, 17, 37, 620, DateTimeKind.Utc).AddTicks(8117), 1000, "The Intel 665p 1TB SSD is a high-end storage device with excellent performance and features.", "https://example.com/intel-665p-ssd.jpg", "Intel 665p 1TB SSD", 109.99m, new Guid("e92e7beb-55d6-4d18-a99d-3ed3411058f5"), 1 },
                    { 7, new DateTime(2023, 7, 12, 22, 17, 37, 620, DateTimeKind.Utc).AddTicks(8119), 2000, "The Seagate Barracuda Q1 2TB SSD is a high-end storage device with excellent performance and features.", "https://example.com/seagate-barracuda-q1-ssd.jpg", "Seagate Barracuda Q1 2TB SSD", 219.99m, new Guid("e92e7beb-55d6-4d18-a99d-3ed3411058f5"), 1 },
                    { 8, new DateTime(2023, 7, 12, 22, 17, 37, 620, DateTimeKind.Utc).AddTicks(8121), 1000, "The SK hynix Gold S31 1TB SSD is a high-end storage device with excellent performance and features.", "https://example.com/sk-hynix-gold-s31-ssd.jpg", "SK hynix Gold S31 1TB SSD", 109.99m, new Guid("e92e7beb-55d6-4d18-a99d-3ed3411058f5"), 1 },
                    { 9, new DateTime(2023, 7, 12, 22, 17, 37, 620, DateTimeKind.Utc).AddTicks(8124), 2000, "The TeamGroup T-Force Vulcan G 2TB SSD is a high-end storage device with excellent performance and features.", "https://example.com/teamgroup-t-force-vulcan-g-ssd.jpg", "TeamGroup T-Force Vulcan G 2TB SSD", 249.99m, new Guid("e92e7beb-55d6-4d18-a99d-3ed3411058f5"), 1 },
                    { 10, new DateTime(2023, 7, 12, 22, 17, 37, 620, DateTimeKind.Utc).AddTicks(8126), 1000, "The PNY XLR8 CS3030 1TB SSD is a high-end storage device with excellent performance and features.", "https://example.com/pny-xlr8-cs3030-ssd.jpg", "PNY XLR8 CS3030 1TB SSD", 119.99m, new Guid("e92e7beb-55d6-4d18-a99d-3ed3411058f5"), 1 },
                    { 11, new DateTime(2023, 7, 12, 22, 17, 37, 620, DateTimeKind.Utc).AddTicks(8128), 1000, "The Samsung 970 EVO Plus 1TB M.2 NVMe SSD is a high-end storage device with excellent performance and features.", "https://example.com/samsung-970-evo-plus-m2.jpg", "Samsung 970 EVO Plus 1TB M.2 NVMe SSD", 149.99m, new Guid("e92e7beb-55d6-4d18-a99d-3ed3411058f5"), 2 },
                    { 12, new DateTime(2023, 7, 12, 22, 17, 37, 620, DateTimeKind.Utc).AddTicks(8130), 2000, "The Crucial P5 2TB M.2 NVMe SSD is a high-end storage device with excellent performance and features.", "https://example.com/crucial-p5-m2.jpg", "Crucial P5 2TB M.2 NVMe SSD", 299.99m, new Guid("e92e7beb-55d6-4d18-a99d-3ed3411058f5"), 2 },
                    { 13, new DateTime(2023, 7, 12, 22, 17, 37, 620, DateTimeKind.Utc).AddTicks(8133), 1000, "The Sabrent Rocket Q 1TB M.2 NVMe SSD is a high-end storage device with excellent performance and features.", "https://example.com/sabrent-rocket-q-m2.jpg", "Sabrent Rocket Q 1TB M.2 NVMe SSD", 129.99m, new Guid("e92e7beb-55d6-4d18-a99d-3ed3411058f5"), 2 },
                    { 14, new DateTime(2023, 7, 12, 22, 17, 37, 620, DateTimeKind.Utc).AddTicks(8135), 2000, "The ADATA XPG SX8200 Pro 2TB M.2 NVMe SSD is a high-end storage device with excellent performance and features.", "https://example.com/adata-xpg-sx8200-pro-m2.jpg", "ADATA XPG SX8200 Pro 2TB M.2 NVMe SSD", 299.99m, new Guid("e92e7beb-55d6-4d18-a99d-3ed3411058f5"), 2 }
                });

            migrationBuilder.InsertData(
                table: "Storages",
                columns: new[] { "Id", "AddedOn", "Capacity", "Description", "ImageUrl", "Name", "Price", "ProviderId", "Type" },
                values: new object[,]
                {
                    { 15, new DateTime(2023, 7, 12, 22, 17, 37, 620, DateTimeKind.Utc).AddTicks(8139), 1000, "The Intel 660p 1TB M.2 NVMe SSD is a high-end storage device with excellent performance and features.", "https://example.com/intel-660p-m2.jpg", "Intel 660p 1TB M.2 NVMe SSD", 119.99m, new Guid("e92e7beb-55d6-4d18-a99d-3ed3411058f5"), 2 },
                    { 16, new DateTime(2023, 7, 12, 22, 17, 37, 620, DateTimeKind.Utc).AddTicks(8142), 2000, "The Gigabyte AORUS NVMe Gen4 2TB M.2 NVMe SSD is a high-end storage device with excellent performance and features.", "https://example.com/gigabyte-aorus-nvme-gen4-m2.jpg", "Gigabyte AORUS NVMe Gen4 2TB M.2 NVMe SSD", 399.99m, new Guid("e92e7beb-55d6-4d18-a99d-3ed3411058f5"), 2 },
                    { 17, new DateTime(2023, 7, 12, 22, 17, 37, 620, DateTimeKind.Utc).AddTicks(8144), 1000, "The Seagate FireCuda 520 1TB M.2 NVMe SSD is a high-end storage device with excellent performance and features.", "https://example.com/seagate-firecuda-520-m2.jpg", "Seagate FireCuda 520 1TB M.2 NVMe SSD", 199.99m, new Guid("e92e7beb-55d6-4d18-a99d-3ed3411058f5"), 2 },
                    { 18, new DateTime(2023, 7, 12, 22, 17, 37, 620, DateTimeKind.Utc).AddTicks(8147), 1000, "The SK hynix Gold P31 1TB M.2 NVMe SSD is a high-end storage device with excellent performance and features.", "https://example.com/sk-hynix-gold-p31-m2.jpg", "SK hynix Gold P31 1TB M.2 NVMe SSD", 129.99m, new Guid("e92e7beb-55d6-4d18-a99d-3ed3411058f5"), 2 }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Cases_Providers_ProviderId",
                table: "Cases",
                column: "ProviderId",
                principalTable: "Providers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Coolers_Providers_ProviderId",
                table: "Coolers",
                column: "ProviderId",
                principalTable: "Providers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Cpus_Providers_ProviderId",
                table: "Cpus",
                column: "ProviderId",
                principalTable: "Providers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Gpus_Providers_ProviderId",
                table: "Gpus",
                column: "ProviderId",
                principalTable: "Providers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Motherboards_Providers_ProviderId",
                table: "Motherboards",
                column: "ProviderId",
                principalTable: "Providers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Psus_Providers_ProviderId",
                table: "Psus",
                column: "ProviderId",
                principalTable: "Providers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Rams_Providers_ProviderId",
                table: "Rams",
                column: "ProviderId",
                principalTable: "Providers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Storages_Providers_ProviderId",
                table: "Storages",
                column: "ProviderId",
                principalTable: "Providers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cases_Providers_ProviderId",
                table: "Cases");

            migrationBuilder.DropForeignKey(
                name: "FK_Coolers_Providers_ProviderId",
                table: "Coolers");

            migrationBuilder.DropForeignKey(
                name: "FK_Cpus_Providers_ProviderId",
                table: "Cpus");

            migrationBuilder.DropForeignKey(
                name: "FK_Gpus_Providers_ProviderId",
                table: "Gpus");

            migrationBuilder.DropForeignKey(
                name: "FK_Motherboards_Providers_ProviderId",
                table: "Motherboards");

            migrationBuilder.DropForeignKey(
                name: "FK_Psus_Providers_ProviderId",
                table: "Psus");

            migrationBuilder.DropForeignKey(
                name: "FK_Rams_Providers_ProviderId",
                table: "Rams");

            migrationBuilder.DropForeignKey(
                name: "FK_Storages_Providers_ProviderId",
                table: "Storages");

            migrationBuilder.DeleteData(
                table: "Cases",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Cases",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Cases",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Cases",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Cases",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Coolers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Coolers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Coolers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Coolers",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Coolers",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Coolers",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Coolers",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Coolers",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Coolers",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Coolers",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Cpus",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Cpus",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Cpus",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Cpus",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Cpus",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Cpus",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Cpus",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Gpus",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Gpus",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Gpus",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Gpus",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Gpus",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Gpus",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Gpus",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Gpus",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Motherboards",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Motherboards",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Motherboards",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Motherboards",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Motherboards",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Motherboards",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Motherboards",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Psus",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Storages",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.AddForeignKey(
                name: "FK_Cases_Providers_ProviderId",
                table: "Cases",
                column: "ProviderId",
                principalTable: "Providers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Coolers_Providers_ProviderId",
                table: "Coolers",
                column: "ProviderId",
                principalTable: "Providers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Cpus_Providers_ProviderId",
                table: "Cpus",
                column: "ProviderId",
                principalTable: "Providers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Gpus_Providers_ProviderId",
                table: "Gpus",
                column: "ProviderId",
                principalTable: "Providers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Motherboards_Providers_ProviderId",
                table: "Motherboards",
                column: "ProviderId",
                principalTable: "Providers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Psus_Providers_ProviderId",
                table: "Psus",
                column: "ProviderId",
                principalTable: "Providers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Rams_Providers_ProviderId",
                table: "Rams",
                column: "ProviderId",
                principalTable: "Providers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Storages_Providers_ProviderId",
                table: "Storages",
                column: "ProviderId",
                principalTable: "Providers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
