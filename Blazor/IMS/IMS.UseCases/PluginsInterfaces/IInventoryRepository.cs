using IMS.CoreBusiness;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace IMS.UseCases.PluginsInterfaces
{
    public interface IInventoryRepository
    {
        Task<IEnumerable<Inventory>> GetInventoryByNameAsync(string name);
    }
}
