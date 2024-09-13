using IMS.CoreBusiness;
using Microsoft.AspNetCore.Components;

namespace IMS.WebApp.Components.Controls
{
    public class InventoryListItemComponentBase : ComponentBase
    {
        [Parameter]
        public Inventory? Inventory { get; set; }
    }
}
