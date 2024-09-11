using IMS.CoreBusiness;
using IMS.UseCases.Inventories.Interfaces;
using Microsoft.AspNetCore.Components;

namespace IMS.WebApp.Components.Pages
{
    public class HomeBase : ComponentBase
    {
        [Inject]
        public IViewInventoriesByNameUseCases ViewInventoriesByNameUseCases { get; set; }

        public List<Inventory>? Inventories { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Inventories = (await ViewInventoriesByNameUseCases.ExecuteAsnc()).ToList();
        }
    }
}
