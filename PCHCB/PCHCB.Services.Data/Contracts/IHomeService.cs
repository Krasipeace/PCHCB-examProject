namespace PCHCB.Services.Data.Contracts
{
    using PCHCB.Web.ViewModels.Home;

    public interface IHomeService
    {
        Task<AllComponentsSearchResult> AllAsync(AllQueryModel queryModel);
    }
}
