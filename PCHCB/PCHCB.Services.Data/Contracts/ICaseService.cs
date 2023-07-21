namespace PCHCB.Services.Data.Contracts
{
    using PCHCB.Web.ViewModels.Case;

    public interface ICaseService
    {
        Task<int> CreateCaseAsync(string providerId, CaseFormModel model);

        public Task<CaseFormModel> GetCaseForEditByIdAsync(int caseId);

        public Task EditCaseByIdAndFormModelAsync(int caseId, CaseFormModel formModel);

        Task DeleteCaseByIdAsync(int caseId);

        Task<bool> IsCaseExistByIdAsync(int caseId);

        Task<bool> IsProviderIdOwnerOfCaseIdAsync(string providerId, int caseId);

        //Task<CaseDeleteDetailsViewModel> GetCaseForDeleteByIdAsync(int caseId);

        //Task<CaseDetailsViewModel> GetCaseDetailsAsync(int caseId);

        //Task<IEnumerable<CaseAllViewModel>> AllByProviderIdAsync(string providerId);

        //Task<IEnumerable<CaseAllViewModel>> AllAvailableCases(string caseId);
    }
}
