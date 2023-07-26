namespace PCHCB.Services.Data
{
    using Microsoft.EntityFrameworkCore;

    using PCHCB.Data.Models;
    using PCHCB.Data.Models.Enums;
    using PCHCB.Services.Data.Contracts;
    using PCHCB.Web.Data;
    using PCHCB.Web.ViewModels.Home;
    using PCHCB.Web.ViewModels.Motherboard;
    using PCHCB.Web.ViewModels.Provider;

    using static PCHCB.Common.GeneralAppConstants;

    public class MotherboardService : IMotherboardService
    {
        private readonly PCHCBDbContext dbContext;

        public MotherboardService(PCHCBDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<int> CreateMotherboardAsync(string providerId, MotherboardFormModel model)
        {
            Motherboard motherboard = new Motherboard()
            {
                Name = model.Name,
                Price = model.Price,
                FormFactor = (MbFormFactor)model.FormFactor,
                Socket = model.Socket,
                Chipset = model.Chipset,
                RamType = (RamType)model.RamType,
                RamSlots = model.RamSlots,
                RamCapacity = model.RamCapacity,
                SataSlots = model.SataSlots,
                PcieType = (InterfaceType)model.PcieType,
                M2Slots = model.M2Slots,
                ImageUrl = model.ImageUrl,
                Description = model.Description,
                AddedOn = DateTime.UtcNow,
                ProviderId = Guid.Parse(providerId),
            };

            await this.dbContext.Motherboards.AddAsync(motherboard);
            await this.dbContext.SaveChangesAsync();

            return motherboard.Id;
        }

        public async Task<MotherboardFormModel> GetMotherboardForEditByIdAsync(int motherboardId)
        {
            Motherboard motherboard = await this.dbContext.Motherboards
                .FirstAsync(m => m.Id == motherboardId);

            return new MotherboardFormModel()
            {
                Name = motherboard.Name,
                Price = motherboard.Price,
                FormFactor = (int)motherboard.FormFactor,
                Socket = motherboard.Socket,
                Chipset = motherboard.Chipset,
                RamType = (int)motherboard.RamType,
                RamSlots = motherboard.RamSlots,
                RamCapacity = motherboard.RamCapacity,
                SataSlots = motherboard.SataSlots,
                PcieType = (int)motherboard.PcieType,
                M2Slots = motherboard.M2Slots,
                ImageUrl = motherboard.ImageUrl,
                Description = motherboard.Description,
            };
        }

        public async Task EditMotherboardByIdAndFormModelAsync(int motherboardId, MotherboardFormModel model)
        {
            Motherboard motherboard = await this.dbContext.Motherboards
                .FirstAsync(m => m.Id == motherboardId);

            motherboard.Name = model.Name;
            motherboard.Price = model.Price;
            motherboard.FormFactor = (MbFormFactor)model.FormFactor;
            motherboard.Socket = model.Socket;
            motherboard.Chipset = model.Chipset;
            motherboard.RamType = (RamType)model.RamType;
            motherboard.RamSlots = model.RamSlots;
            motherboard.RamCapacity = model.RamCapacity;
            motherboard.SataSlots = model.SataSlots;
            motherboard.PcieType = (InterfaceType)model.PcieType;
            motherboard.M2Slots = model.M2Slots;
            motherboard.ImageUrl = model.ImageUrl;
            motherboard.Description = model.Description;

            await this.dbContext.SaveChangesAsync();
        }

        public async Task<bool> IsMotherboardExistByIdAsync(int motherboardId)
        {
            bool result = await this.dbContext.Motherboards
                .AnyAsync(m => m.Id == motherboardId);

            return result;
        }

        public async Task<bool> IsProviderIdOwnerOfMotherboardIdAsync(string providerId, int motherboardId)
        {
            Provider? provider = await this.dbContext.Providers
                .Include(p => p.ProviderMotherboards)
                .FirstOrDefaultAsync(p => p.Id.ToString().ToLower() == providerId.ToLower());

            if (provider == null)
            {
                return false;
            }

            return provider.ProviderMotherboards.Any(pc => pc.Id == motherboardId);
        }

        public async Task<DeleteDetailsViewModel> GetMotherboardForDeleteByIdAsync(int motherboardId)
        {
            Motherboard motherboard = await dbContext.Motherboards
                .FirstAsync(m => m.Id == motherboardId);

            return new DeleteDetailsViewModel
            {
                Name = motherboard.Name,
                Description = motherboard.Description,
                ImageUrl = motherboard.ImageUrl
            };
        }

        public async Task DeleteMotherboardByIdAsync(int motherboardId)
        {
            Motherboard motherboard = await this.dbContext.Motherboards
                .FirstAsync(m => m.Id == motherboardId);

            motherboard.Name = ComponentUnavailable;
            this.dbContext.Motherboards.Remove(motherboard);

            await this.dbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<AllViewModel>> GetAllMotherboardsAsync()
        {
            return await this.dbContext.Motherboards
                .Where(m => m.Name != ComponentUnavailable)
                .Select(m => new AllViewModel
                {
                    Id = m.Id,
                    Name = m.Name,
                    Price = m.Price,
                    ImageUrl = m.ImageUrl,
                })
                .ToListAsync();
        }

        public async Task<MotherboardDetailsViewModel> GetMotherboardDetailsAsync(int motherboardId)
        {
            Motherboard motherboard = await dbContext.Motherboards
                .Include(m => m.Provider)
                .ThenInclude(u => u.User)
                .Where(m => m.Name != ComponentUnavailable)
                .FirstAsync(m => m.Id == motherboardId);

            return new MotherboardDetailsViewModel
            {
                Id = motherboard.Id,
                Name = motherboard.Name,
                Price = motherboard.Price,
                Socket = motherboard.Socket,
                Chipset = motherboard.Chipset,
                RamType = (int)motherboard.RamType,
                RamSlots = motherboard.RamSlots,
                RamCapacity = motherboard.RamCapacity,
                SataSlots = motherboard.SataSlots,
                PcieType = (int)motherboard.PcieType,
                M2Slots = motherboard.M2Slots,
                ImageUrl = motherboard.ImageUrl,
                Description = motherboard.Description,
                Provider = new ProviderInfoViewModel()
                {
                    WebPage = motherboard.Provider.WebPage,
                }
            };
        }
    }
}
