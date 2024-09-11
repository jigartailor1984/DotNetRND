using IMS.CoreBusiness;
using IMS.UseCases.PluginsInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IMS.Plugins.InMemory
{
    public class InventoryRepository : IInventoryRepository
    {
        private List<Inventory> inventories;
        public InventoryRepository()
        {
            inventories = new List<Inventory> {
                new Inventory{InventoryId=1, InventoryName="Bike Seat", Quantity=10, Price=2},
                new Inventory{InventoryId=1, InventoryName="Bike Body", Quantity=10, Price=15},
                new Inventory{InventoryId=1, InventoryName="Bike Wheels", Quantity=20, Price=8},
                new Inventory{InventoryId=1, InventoryName="Bike Padels", Quantity=20, Price=1},
                };
        }
        public async Task<IEnumerable<Inventory>> GetInventoryByNameAsync(string name)
        {
            if (string.IsNullOrWhiteSpace(name)) { return await Task.FromResult(inventories); }
            return inventories.Where(x => x.InventoryName.Contains(name,StringComparison.OrdinalIgnoreCase));
        }
    }
}
