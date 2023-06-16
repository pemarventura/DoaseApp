using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoaseApp.Shared.Classes;

namespace DoaseApp.Shared
{
    public interface IItemRepository
    {
        IEnumerable<Item> GetAll();
        Item GetItemByName(string item);
        void AddItem(Item item);
    }
}
