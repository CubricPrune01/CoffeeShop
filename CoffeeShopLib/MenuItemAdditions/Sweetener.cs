using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopLib.MenuItemAdditions
{
    
    public class Sweetener : MenuItemAdditions
    {
        public Sweetener(IMenuItem item) : base(item)
        {
            if(item != null)
            {
                Description = item.Description + " Sweetener";
                Cost = item.Cost + 0.06m;
            }           
        }
        public Sweetener()
        {
            Description = "Sweetner";
            Cost = 0.06M;
        }
    }
}
