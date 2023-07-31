namespace PCHCB.Services.Data
{
    using Microsoft.EntityFrameworkCore;

    using PCHCB.Web.ViewModels.Home;
    using PCHCB.Web.ViewModels.Enums;
    using PCHCB.Data.Models;
    using PCHCB.Data;
    using PCHCB.Services.Data.Contracts;

    public class HomeService : IHomeService
    {
        private readonly PCHCBDbContext dbContext;

        public HomeService(PCHCBDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<AllComponentsSearchResult> AllAsync(AllQueryModel queryModel)
        {
            IQueryable<Case> caseQuery = this.dbContext
                .Cases
                .AsQueryable();

            IQueryable<Cooler> coolerQuery = this.dbContext
                .Coolers
                .AsQueryable();

            IQueryable<Cpu> cpuQuery = this.dbContext
                .Cpus
                .AsQueryable();

            IQueryable<Gpu> gpuQuery = this.dbContext
                .Gpus
                .AsQueryable();

            IQueryable<Motherboard> motherboardQuery = this.dbContext
                .Motherboards
                .AsQueryable();

            IQueryable<Psu> psuQuery = this.dbContext
                .Psus
                .AsQueryable();

            IQueryable<Ram> ramQuery = this.dbContext
                .Rams
                .AsQueryable();

            IQueryable<Storage> storageQuery = this.dbContext
                .Storages
                .AsQueryable();

            IQueryable<AllViewModel> allComponentsQuery = caseQuery
                .Select(c => new AllViewModel
                {
                    Id = c.Id,
                    Name = c.Name,
                    Description = c.Description,
                    Price = c.Price,
                    AddedOn = c.AddedOn,
                })
                .Concat(coolerQuery
                                   .Select(c => new AllViewModel
                                   {
                                       Id = c.Id,
                                       Name = c.Name,
                                       Description = c.Description,
                                       Price = c.Price,
                                       AddedOn = c.AddedOn,
                                   }))
                .Concat(cpuQuery
                                   .Select(c => new AllViewModel
                                   {
                                       Id = c.Id,
                                       Name = c.Name,
                                       Description = c.Description,
                                       Price = c.Price,
                                       AddedOn = c.AddedOn,
                                   }))
                .Concat(gpuQuery
                                   .Select(g => new AllViewModel
                                   {
                                       Id = g.Id,
                                       Name = g.Name,
                                       Description = g.Description,
                                       Price = g.Price,
                                       AddedOn = g.AddedOn,
                                   }))
                .Concat(motherboardQuery
                                   .Select(m => new AllViewModel
                                   {
                                       Id = m.Id,
                                       Name = m.Name,
                                       Description = m.Description,
                                       Price = m.Price,
                                       AddedOn = m.AddedOn,
                                   }))
                .Concat(psuQuery
                                   .Select(p => new AllViewModel
                                   {
                                       Id = p.Id,
                                       Name = p.Name,
                                       Description = p.Description,
                                       Price = p.Price,
                                       AddedOn = p.AddedOn,
                                   }))
                .Concat(ramQuery
                                   .Select(r => new AllViewModel
                                   {
                                       Id = r.Id,
                                       Name = r.Name,
                                       Description = r.Description,
                                       Price = r.Price,
                                       AddedOn = r.AddedOn,
                                   }))
                .Concat(storageQuery
                                   .Select(s => new AllViewModel
                                   {
                                       Id = s.Id,
                                       Name = s.Name,
                                       Description = s.Description,
                                       Price = s.Price,
                                       AddedOn = s.AddedOn,
                                   }));

            if (!string.IsNullOrWhiteSpace(queryModel.SearchTerm))
            {
                string wildCard = $"%{queryModel.SearchTerm.ToLower()}%";

                allComponentsQuery = allComponentsQuery
                    .Where(c => EF.Functions.Like(c.Name, wildCard) ||
                                EF.Functions.Like(c.Description, wildCard));
            }

            allComponentsQuery = queryModel.Sorting switch
            {
                GeneralSorting.Newest => allComponentsQuery
                    .OrderBy(c => c.AddedOn),
                GeneralSorting.Oldest => allComponentsQuery
                    .OrderByDescending(c => c.AddedOn),
                GeneralSorting.PriceAscending => allComponentsQuery
                    .OrderBy(c => c.Price),
                GeneralSorting.PriceDescending => allComponentsQuery
                    .OrderByDescending(c => c.Price),
                _ => allComponentsQuery
                    .OrderBy(c => c.Name != null)
                    .ThenByDescending(c => c.AddedOn)
            };

            var values = Enum.GetValues(typeof(GeneralSorting));

            IEnumerable<AllViewModel> allComponents = await allComponentsQuery
                   .Skip((queryModel.CurrentPage - 1) * queryModel.ComponentsPerPage)
                   .Take(queryModel.ComponentsPerPage)
                   .Select(c => new AllViewModel
                   {
                       Id = c.Id,
                       Name = c.Name,
                       Price = c.Price,
                       Description = c.Description,
                   })
                   .ToArrayAsync();

            return new AllComponentsSearchResult
            {
                Cases = allComponents,
                Coolers = allComponents,
                Cpus = allComponents,
                Gpus = allComponents,
                Motherboards = allComponents,
                Psus = allComponents,
                Rams = allComponents,
                Storages = allComponents,
                TotalComponents = await allComponentsQuery.CountAsync(),
            };
        }
    }
}
