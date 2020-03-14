using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopLib.MenuItemAdditions
{
   
    public class Milk : MenuItemAdditions
    {
        public Milk(IMenuItem item) : base(item)
        {
            if(item != null)
            {
                Description = item.Description + " Milk";
                Cost = item.Cost + 0.10m;
            }            
        }
        public Milk()
        {
            Description = "Milk";
            Cost = 0.10M;
        }
    }
}
