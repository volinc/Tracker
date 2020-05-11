namespace Tracker.Web.Models
{
    using System;
    using System.Collections.Concurrent;
    using System.Collections.Generic;

    public class ItemRepository : IItemRepository
    {
        private static readonly ConcurrentDictionary<string, Item> Items = new ConcurrentDictionary<string, Item>();

        public ItemRepository()
        {
            Add(new Item { Id = Guid.NewGuid().ToString(), Text = "Item 1", Description = "This is an item description." });
            Add(new Item { Id = Guid.NewGuid().ToString(), Text = "Item 2", Description = "This is an item description." });
            Add(new Item { Id = Guid.NewGuid().ToString(), Text = "Item 3", Description = "This is an item description." });
        }

        public IEnumerable<Item> GetAll()
        {
            return Items.Values;
        }

        public void Add(Item item)
        {
            item.Id = Guid.NewGuid().ToString();
            Items[item.Id] = item;
        }

        public Item Get(string id)
        {
            Items.TryGetValue(id, out Item item);
            return item;
        }

        public Item Remove(string id)
        {
            Items.TryRemove(id, out Item item);
            return item;
        }

        public void Update(Item item)
        {
            Items[item.Id] = item;
        }
    }
}
