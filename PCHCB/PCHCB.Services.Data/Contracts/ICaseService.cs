namespace PCHCB.Services.Data.Contracts
{
    using PCHCB.Web.ViewModels.Case;
    using PCHCB.Web.ViewModels.Home;
    using PCHCB.Web.ViewModels.Provider;

    public interface ICaseService
    {
        Task<int> CreateCaseAsync(string providerId, CaseFormModel model);

        public Task<CaseFormModel> GetCaseForEditByIdAsync(int caseId);

        public Task EditCaseByIdAndFormModelAsync(int caseId, CaseFormModel formModel);

        Task<bool> IsCaseExistByIdAsync(int caseId);

        Task<bool> IsProviderIdOwnerOfCaseIdAsync(string providerId, int caseId);

        Task<DeleteDetailsViewModel> GetCaseForDeleteByIdAsync(int caseId);

        Task DeleteCaseByIdAsync(int caseId);

        Task<IEnumerable<AllViewModel>> GetAllCasesAsync();

        Task<SearchResult> SearchCasesAsync(AllQueryModel queryModel);

        Task<CaseDetailsViewModel> GetCaseDetailsAsync(int caseId);
    }
}
