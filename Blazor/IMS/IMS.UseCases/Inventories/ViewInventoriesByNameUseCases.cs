using IMS.CoreBusiness;
using IMS.UseCases.Inventories.Interfaces;
using IMS.UseCases.PluginsInterfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace IMS.UseCases.Inventories
{
    public class ViewInventoriesByNameUseCases : IViewInventoriesByNameUseCases
    {
        private readonly IInventoryRepository inventoryRepository;

        public ViewInventoriesByNameUseCases(IInventoryRepository inventoryRepository)
        {
            this.inventoryRepository = inventoryRepository;
        }
        public async Task<IEnumerable<Inventory>> ExecuteAsnc(string name = "")
        {
            return await inventoryRepository.GetInventoryByNameAsync(name);
        }

    }
}
