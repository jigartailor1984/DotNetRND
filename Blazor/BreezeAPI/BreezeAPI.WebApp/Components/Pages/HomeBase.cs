using Breeze;
using BreezeAPI.WebApp.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace BreezeAPI.WebApp.Components.Pages
{
    
    public class HomeBase : ComponentBase
    {
        [Inject]
        IConfiguration Configuration {  get; set; }

        AppModel? Model {  get; set; }

        protected override void OnInitialized()
        {
            Model = new AppModel();
            Model.Login.AppKey = Configuration["Breeze_AppKey"]!;
            Model.Login.SecretKey = Configuration["Breeze_SecretKey"]!;
            Model.Login.ApiSession = Configuration["Breeze_Session"]!;
            base.OnInitialized();
        }

    }
}
