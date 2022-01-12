using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Bosca_Dana_Laab12.Models;

namespace Bosca_Dana_Laab12.Data
{
    public interface IRestService
    {
        Task<List<ShopList>> RefreshDataAsync();
        Task SaveShopListAsync(ShopList item, bool isNewItem);
        Task DeleteShopListAsync(int id);
    }
}
