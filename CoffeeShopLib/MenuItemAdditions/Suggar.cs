using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopLib.MenuItemAdditions
{
    
    public class Suggar : MenuItemAdditions
    {
        public Suggar(IMenuItem item) : base(item)
        {
            if(item != null)
            {
                Description = item.Description + " Sugar";
                Cost = item.Cost + 0.05m;
            }           
        }
        public Suggar()
        {
            Description = "Sugar";
            Cost = 0.05M;
        }
    }
}
