using CoffeeShopLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CoffeeShopLib.MenuItemAdditions
{
    public abstract class MenuItemAdditions : MenuItem
    {
        [JsonProperty]
        private IMenuItem menu;
        [JsonIgnore]
        public IMenuItem Menu { get; set; }
        public MenuItemAdditions(IMenuItem item)
        {
            Menu = item;
        }
        public MenuItemAdditions()
        {
            Description = description;
            Cost = cost;
        }
       
    }
}
