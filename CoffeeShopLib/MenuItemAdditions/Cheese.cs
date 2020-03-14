using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopLib.MenuItemAdditions
{
    public class Cheese : MenuItemAdditions
    {
        public Cheese(IMenuItem item) : base(item)
        {
            if (item != null)
            {
                Description = item.Description + " Cheese";
                Cost = item.Cost + 0.40M;
            }
        } 
        public Cheese()
        {
            Description = "Cheese";
            Cost = 0.40M;
        }
    }
}
