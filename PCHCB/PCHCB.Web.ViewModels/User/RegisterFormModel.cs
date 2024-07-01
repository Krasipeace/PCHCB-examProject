namespace PCHCB.Web.ViewModels.User
{
    using System.ComponentModel.DataAnnotations;

    using static PCHCB.Common.EntityValidationConstants.User;
    using static PCHCB.Common.ErrorMessages.User;

    public class RegisterFormModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "E-mail")]
        public string Email { get; set; } = null!;

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        [StringLength(PasswordMaxLength, MinimumLength = PasswordMinLength, ErrorMessage = PasswordErrorMessage)]
        public string Password { get; set; } = null!;

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = PasswordsDoNotMatchErrorMessage)]
        public string ConfirmPassword { get; set; } = null!;

        [Required]
        [StringLength(FirstNameMaxLength, MinimumLength = FirstNameMinLength, ErrorMessage = FirstNameErrorMessage)]
        public string FirstName { get; set; } = null!;

        [Required]
        [StringLength(LastNameMaxLength, MinimumLength = LastNameMinLength, ErrorMessage = LastNameErrorMessage)]
        public string LastName { get; set; } = null!;

        //[Required]
        //[StringLength(DisplayNameMaxLength, MinimumLength = DisplayNameMinLength, ErrorMessage = DisplayNameErrorMessage)]
        //public string DisplayName { get; set; } = null!;
    }
}
