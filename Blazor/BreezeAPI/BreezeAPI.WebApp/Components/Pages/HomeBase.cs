using BreezeAPI.WebApp.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace BreezeAPI.WebApp.Components.Pages
{
    [AllowAnonymous]
    public class HomeBase : ComponentBase
    {
        [SupplyParameterFromQuery]
        public string? ApiSession{ get; set; }

        [SupplyParameterFromForm]
        public BreezeLoginModel? LoginModel { get; set; }

        [Inject]
        public NavigationManager Navigation {  get; set; }

        protected override Task OnInitializedAsync()
        {
            return base.OnInitializedAsync();
        }

        protected override void OnParametersSet()
        {

            LoginModel ??= new BreezeLoginModel();

        }

        public void Submit()
        {
            if (ApiSession == null)
            { 
                if (LoginModel is null)
                {
                    throw new ArgumentNullException(nameof(LoginModel));
                }

                string encodedKey = UrlEncoder.Default.Encode(LoginModel.AppKey);
                string url = $"https://api.icicidirect.com/apiuser/login?api_key={encodedKey}";

                Navigation.NavigateTo(url, true);
            }
            else
            {
                //Todo: BreezeAPI object creation.
            }
        }
    }
}
