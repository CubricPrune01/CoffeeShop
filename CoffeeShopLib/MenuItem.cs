using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopLib
{
    abstract public class MenuItem : IMenuItem
    {
        protected string description;
        protected decimal cost;
        
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        
        public decimal Cost
        {
            get { return cost; }
            set { cost = value; }
        }
        public MenuItem(string description, decimal cost)
        {

            Description = description;
            Cost = cost;
        }
        public MenuItem()
        {

        }        
        public override string ToString()
        {
            return "Menu Item:" + "\tDescription: " + Description + " - " + "\n\tBase Cost: " + Cost + "\n";
        }
        public string GetInfo()
        {
            return $"{Description} - {Cost}";
        }
    }
}