using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopLib.MenuItemAdditions
{
    public class Mayo : MenuItemAdditions
    {
        public Mayo(IMenuItem item) : base(item)
        {
            if (item != null)
            {
                Description = item.Description + " Mayo";
                Cost = item.Cost + 0.00M;
            }
        }
        public Mayo()
        {
            Description = "Mayo";
            Cost = 0.00M;
        }
    }
}
