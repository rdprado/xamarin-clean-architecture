using OrdersStore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrdersStore.Gateways
{
    public class MockDataStore : IDataStore<Order>
    {
        readonly List<Order> items;

        public MockDataStore()
        {
            items = new List<Order>()
            {
                new Order { Id = Guid.NewGuid().ToString(), Text = "First item", Description="This is an item description." },
                new Order { Id = Guid.NewGuid().ToString(), Text = "Second item", Description="This is an item description." },
                new Order { Id = Guid.NewGuid().ToString(), Text = "Third item", Description="This is an item description." },
                new Order { Id = Guid.NewGuid().ToString(), Text = "Fourth item", Description="This is an item description." },
                new Order { Id = Guid.NewGuid().ToString(), Text = "Fifth item", Description="This is an item description." },
                new Order { Id = Guid.NewGuid().ToString(), Text = "Sixth item", Description="This is an item description." }
            };
        }

        public async Task<bool> AddItemAsync(Order item)
        {
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateItemAsync(Order item)
        {
            var oldItem = items.Where((Order arg) => arg.Id == item.Id).FirstOrDefault();
            items.Remove(oldItem);
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteItemAsync(string id)
        {
            var oldItem = items.Where((Order arg) => arg.Id == id).FirstOrDefault();
            items.Remove(oldItem);

            return await Task.FromResult(true);
        }

        public async Task<Order> GetItemAsync(string id)
        {
            return await Task.FromResult(items.FirstOrDefault(s => s.Id == id));
        }

        public async Task<IEnumerable<Order>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(items);
        }
    }
}