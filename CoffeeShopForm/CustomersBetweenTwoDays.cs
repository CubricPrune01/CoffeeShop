using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CoffeeShopLib;

namespace CoffeeShopForm
{
    public partial class CustomersBetweenTwoDays : Form
    {
        public CustomerRepository CustomerRepository { get; set; }
        public List<Customer> Customers { get; set; }
        public Customer CurrentCustomer { get; set; }
        public CustomersBetweenTwoDays(CustomerRepository customerRepository,DateTime start, DateTime end)
        {
            InitializeComponent();
            CustomerRepository = customerRepository;

            Customers = CustomerRepository.BtwTwoDates(start,end);


            foreach (Customer customer in Customers)
            {
                customer_ListBox.Items.Add(customer);
            }

        }

        private void Customer_ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            CurrentCustomer = customer_ListBox.SelectedItem as Customer;
            order_ListBox.Items.Clear();

            foreach (Order order in CurrentCustomer.Orders)
            {
                order_ListBox.Items.Add(order);
            }

      
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
