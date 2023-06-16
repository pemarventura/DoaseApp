using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoaseApp.Shared.Classes;

namespace DoaseApp.Shared
{
    public class ItemRepository : IItemRepository
    {
        private readonly List<Item> _item = new List<Item>
        {
            new Item { NomeItem = "Dinheiro" },
            new Item { NomeItem = "Roupas" },
            new Item { NomeItem = "Brinquedos" },
            new Item { NomeItem = "Cestas basicas" },
            new Item { NomeItem = "Kit Higiene"}
        };

        public IEnumerable<Item> GetAll()
        {
            return _item.Select(item => item);
        }

        public Item GetItemByName(string name)
        {
            var item = _item.Where(item => item.NomeItem == item.NomeItem).FirstOrDefault();

            return item;
        }

        public void AddItem(Item item)
        {
            _item.Add(item);
        }
    }
}
