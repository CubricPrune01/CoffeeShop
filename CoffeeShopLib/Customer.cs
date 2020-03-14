using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopLib
{
    [Serializable]

    public class Customer
    {
        
        private static uint idNumber;
        private string name;
        public Address Address;
        private uint phone;        
        private List<Order> orders = new List<Order>();
        private uint noOfOrders;
        private OrderItem orderItem;
        private MenuItem menuItem;
        private string nameOfItem;
        //private Order order;       
        public Customer()
        {
            IdNumber = idNumber++;
        }
        static Customer()
        {
            idNumber = 1; 
        }
        public uint IdNumber
        {
            get { return idNumber; }
            set { idNumber = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        
        public uint Phone
        {
            get { return phone; }
            set { phone = value; }
        }
        [JsonProperty]
        public List<Order> Orders
        {
            get { return orders; }
            set { orders = value; }
        }
        public uint NoOfOrders
        {
            get { return noOfOrders; }
            set { noOfOrders = value; }
        }
        public OrderItem OrderItem
        {
            get { return orderItem; }
            set { orderItem = value; }
        }
        public string NameOfItem
        {
            get { return nameOfItem; }
            set { nameOfItem = value; }
        }
        //public Order Order
        //{
        //    get { return order; }
        //    set { order = value; }
        //}
        public MenuItem MenuItem
        {
            get { return menuItem; }
            set { menuItem = value; }
        }
        public Customer(string name, uint phone, Address address)
        {
            IdNumber = idNumber++;
            Name = name;
            Address = address;
            Phone = phone;
            Orders = orders;
            OrderItem = orderItem;
            //Order = order;
        }
       
        public Order CreatePhoneOrder(Address Address)
        {
            Order nOrder = new Order(Name, Address);
            Orders.Add(nOrder);
            return nOrder;
        }
        public Customer(MenuItem menuItem)
        {
            IdNumber = idNumber++;
            this.menuItem = menuItem;
            NameOfItem = nameOfItem;
        }
       
        public override string ToString()
        {
            string result = "\nCustomer: Id: " + $"{IdNumber++}" + ", Customer Name: " + Name + "\n\tAddress: Address: " + Address.ToString() + " Phone: " + Phone + "\n\tOrders: ";
            foreach (Order items in Orders)

                if (items != null)
                {
                    result += $"\n{items.GetInfo()}";
                }
            return result;
        }
        public Order AddOrder(Order orderItem)
        {
            Orders.Add(orderItem);
            return orderItem;
        }        
    }
}