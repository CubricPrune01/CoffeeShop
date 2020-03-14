using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopLib.MenuItemAdditions
{
    public class Lettuce : MenuItemAdditions
    {
        public Lettuce(IMenuItem item) : base(item)
        {
            if (item != null)
            {
                Description = item.Description + " Lettuce";
                Cost = item.Cost + 0.30M;
            }
        }
        public Lettuce()
        {
            Description = "Lettuce";
            Cost = 0.30M;
        }
    }
}
