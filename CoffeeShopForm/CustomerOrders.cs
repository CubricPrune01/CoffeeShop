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
    public partial class Customer_Orders : Form
    {
        public CustomerRepository CustomerRepository { get; set; }
        public List<Customer> Customers { get; set; }
        public Customer CurrentCustomer { get; set; }

        public Customer_Orders(CustomerRepository customerRepository)
        {
            InitializeComponent();
            CustomerRepository = customerRepository;
            Customers = CustomerRepository.Undelivered();


            foreach (Customer customer in Customers)
            {
                customerInfo_ListBox.Items.Add(customer);
            }
        }

        private void CustomerInfo_ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            CurrentCustomer = customerInfo_ListBox.SelectedItem as Customer;
            order_ListBox.Items.Clear();

            foreach (Order items in CurrentCustomer.Orders)
            {
                if (items != null)
                {
                    MessageBox.Show(items.GetInfo());
                    order_ListBox.Items.Add(items.GetInfo());
                }
            }

        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
