namespace PCHCB.Web.ViewModels.Provider
{
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// Pre-Delete Details View Model
    /// </summary>
    public class DeleteDetailsViewModel
    {
        public string Name { get; set; } = null!;

        [Display(Name = "Image Link")]
        public string ImageUrl { get; set; } = null!;

        public string Description { get; set; } = null!;
    }
}
