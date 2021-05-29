using OrdersStore.Entities;
using OrdersStore.InterfaceAdapters.Gateways;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OrdersStore.Frameworks.DataStoreSrc
{
    class OrdersDataStoreInMemory : OrdersDataStore
    {
        public Task<bool> AddItemAsync(Order item)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> DeleteItemAsync(string id)
        {
            throw new System.NotImplementedException();
        }

        public Task<Order> GetItemAsync(string id)
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<Order>> GetItemsAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> UpdateItemAsync(Order item)
        {
            throw new System.NotImplementedException();
        }
    }
}
