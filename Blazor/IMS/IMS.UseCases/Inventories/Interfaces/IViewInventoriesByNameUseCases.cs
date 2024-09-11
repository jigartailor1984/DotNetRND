using IMS.CoreBusiness;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace IMS.UseCases.Inventories.Interfaces
{
    public interface IViewInventoriesByNameUseCases
    {
        Task<IEnumerable<Inventory>> ExecuteAsnc(string name = "");
    }
}