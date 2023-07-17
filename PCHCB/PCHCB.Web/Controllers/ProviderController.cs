namespace PCHCB.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Authorization;

    using PCHCB.Services.Data.Contracts;
    using PCHCB.Web.ViewModels.Provider;
    using PCHCB.Web.Infrastructure.Extensions;

    using static PCHCB.Common.NotificationMessages;

    [Authorize]
    public class ProviderController : Controller
    {
        private readonly IProviderService providerService;

        public ProviderController(IProviderService providerService)
        {
            this.providerService = providerService;
        }

        [HttpGet]
        public async Task<IActionResult> BecomeProvider()
        {
            string? userId = this.User.GetId();
            bool isProviderExists = await this.providerService
                .ProviderExistsByUserIdAsync(userId!);

            if (isProviderExists)
            {
                this.TempData[ErrorMessage] = "You are already a provider!";

                return this.RedirectToAction("Index", "Home");
            }

            return this.View();
        }

        [HttpPost]
        public async Task<IActionResult> BecomeProvider(BecomeProviderFormModel model)
        {
            string? userId = this.User.GetId();
            bool isProviderExists = await this.providerService
                .ProviderExistsByUserIdAsync(userId!);

            if (isProviderExists)
            {
                this.TempData[ErrorMessage] = "You are already a provider!";

                return this.RedirectToAction("Index", "Home");
            }

            bool isPhoneNumberExists = await this.providerService
                .ProviderExistsByPhoneNumber(model.PhoneNumber);
            if (isPhoneNumberExists)
            {
                this.ModelState.AddModelError(nameof(model.PhoneNumber), "Provider with such phone number already exists!");

                return this.View(model);
            }

            bool isWebPageExists = await this.providerService
                .ProviderExistsByWebSite(model.WebPage);
            if (isWebPageExists)
            {
                this.ModelState.AddModelError(nameof(model.WebPage), "Provider with such web page already exists!");

                return this.View(model);
            }

            bool isLogoUrlExists = await this.providerService
                .ProviderExistsByLogoUrl(model.LogoUrl);
            if (isLogoUrlExists)
            {
                this.ModelState.AddModelError(nameof(model.LogoUrl), "Provider with such logo url already exists!");

                return this.View(model);
            }

            if (!this.ModelState.IsValid)
            {
                return this.View(model);
            }

            try
            {
                await this.providerService.CreateProvider(userId!, model);
            }
            catch (Exception)
            {
                this.TempData[ErrorMessage] = "Oops, something went wrong! Try again later!";

                return this.RedirectToAction("Index", "Home");
            }

            return this.RedirectToAction("Index", "Home");
        }
    }
}
