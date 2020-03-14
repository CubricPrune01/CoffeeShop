using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CoffeeShopLib
{
    [Serializable]
    public class CustomerRepository : RepositoryBase
    {
        private List<Order> order = new List<Order>();
        private List<Customer> customers = new List<Customer>();
        private uint noOfCustomers;          
        public override List<Customer> Customers
        {
            get { return customers; }
            set { customers = value; }
        }
        public uint NoOfCustomers
        {
            get { return noOfCustomers; }
            set { noOfCustomers = value; }
        }
        public void Add(Customer newCustomer)
        {
            Customers.Add(newCustomer);
        }
        //query notation
        public List<Customer> BtwTwoDates(DateTime beginning, DateTime ending)
        {
            var time = (from cust in Customers
                        where cust.Orders.All(order => order.OrderTime > beginning && order.OrderTime < ending)
                        select cust).ToList();
            return time;
        }
        //dot notation
        public List<Customer> Undelivered()
        {
            List<Customer> customers1 = new List<Customer>();
            customers1 = customers.Where(cus => cus.Orders.Any(order => order.OrderStatus == false)).ToList();
            return customers1;
        }
    }
}
