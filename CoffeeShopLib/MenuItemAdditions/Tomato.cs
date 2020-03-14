using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopLib.MenuItemAdditions
{
    public class Tomato : MenuItemAdditions
    {
        public Tomato(IMenuItem item) : base(item)
        {
            if (item != null)
            {
                Description = item.Description + " Tomato";
                Cost = item.Cost + 0.35m;
            }
        }
        public Tomato()
        {
            Description = "Tomato";
            Cost = 0.35M;
        }
    }
}
