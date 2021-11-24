using System;
using System.Collections.Generic;
using System.Linq;
using Catalog.Entities;

namespace Catalog.Repository
{
    public class InMemoItemsRepository
    {
        private readonly List<Item> items = new List<Item>()
        {
            new Item 
            { 
                Id = Guid.NewGuid(),
                Name = "Mash",
                Price = 1890,
                CreatedDate = DateTimeOffset.UtcNow,
                Description = "Meroible story" 
            },
            new Item 
            { 
                Id = Guid.NewGuid(),
                Name = "Misha",
                Price = 1993,
                CreatedDate = DateTimeOffset.UtcNow,
                Description = "New age" 
            },
            new Item 
            { 
                Id = Guid.NewGuid(),
                Name = "Oleg",
                Price = 1990,
                CreatedDate = DateTimeOffset.UtcNow,
                Description = "Morning in America agen" 
            }
        };

        public IEnumerable<Item> GetItems() 
        {
            return items;
        }
        public Item GetItem(Guid id) 
        {
            return items.Where(item => item.Id == id).SingleOrDefault();
        }  
    }
}