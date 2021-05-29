using OrdersStore.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OrdersStore.InterfaceAdapters.Gateways
{
    public interface OrdersDataStore
    {
        Task<bool> AddItemAsync(Order item);
        Task<bool> UpdateItemAsync(Order item);
        Task<bool> DeleteItemAsync(string id);
        Task<Order> GetItemAsync(string id);
        Task<IEnumerable<Order>> GetItemsAsync();
    }
}
