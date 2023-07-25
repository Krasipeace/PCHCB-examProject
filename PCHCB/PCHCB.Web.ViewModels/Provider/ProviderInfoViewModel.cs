namespace PCHCB.Web.ViewModels.Provider
{
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// Short Info about provider
    /// </summary>
    public class ProviderInfoViewModel
    {
        [Display(Name = "Provided by ")]
        public string WebPage { get; set; } = null!;
    }
}
