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
    public partial class CoffeeShopForm : Form
    {
        public List<Customer> Customers { get; set; }
        public Customer CurrentCustomer { get; set; }
        CustomerRepository repository = new CustomerRepository();
        public int CurrentIndex { get; set; }
        private int numberOfRows = 0;

        public CoffeeShopForm()
        {
            InitializeComponent();
            Customers = new List<Customer>();            
        } 
        public DataGridView DataGridView2
        {
            get { return dataGridView2; }
        }
        
        private void BtnAddCustomer_Click(object sender, EventArgs e)
        {   
            
            AddCustomerForm addCustomerForm = new AddCustomerForm();
            addCustomerForm.ShowDialog(this);            
            dataGridView2.Rows.Add(addCustomerForm.Customer.IdNumber++, addCustomerForm.Customer.Name, addCustomerForm.Customer.Address.Street, addCustomerForm.Customer.Address.City, addCustomerForm.Customer.Address.Province, addCustomerForm.Customer.Address.PostalCode, addCustomerForm.Customer.Phone);
            Customers.Add(addCustomerForm.Customer);
        }        

        private void AddCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCustomerForm addCustomerForm = new AddCustomerForm();
            addCustomerForm.ShowDialog(this);
        }

        private void CloseToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnAddOrder_Click(object sender, EventArgs e)
        {

            CurrentCustomer = Customers[CurrentIndex];
            AddOrderForm addOrderForm = new AddOrderForm(CurrentCustomer);
            
            addOrderForm.ShowDialog(this);

            Customers.Insert(CurrentIndex, addOrderForm.Customer);
            Customers.Remove(CurrentCustomer);
           
            dataOrderList.Rows.Clear();
            foreach (CoffeeShopLib.MenuItem item in addOrderForm.Items)
            {

                dataOrderList.Rows.Add(item.Description,item.Cost);
            }
        }
        private void AddOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CurrentCustomer = Customers[CurrentIndex];
            AddOrderForm addOrderForm = new AddOrderForm(CurrentCustomer);
            addOrderForm.ShowDialog(this);
            if (addOrderForm.submitted == true)
            {
                // display and add order
                //addOrderForm.Items.

            }

            foreach (CoffeeShopLib.MenuItem item in addOrderForm.Items)
            {

                dataOrderList.Rows.Add(item.Description, item.Cost);
            }
        }

        private void BtnEditCustomer_Click(object sender, EventArgs e)
        {            
            Customer customer = new Customer();
            customer.Name = DataGridView2.Rows[DataGridView2.CurrentRow.Index].Cells["Column_Name"].Value.ToString();
            customer.Address.Street = DataGridView2.Rows[DataGridView2.CurrentRow.Index].Cells["Column_Street"].Value.ToString();
            customer.Address.City = DataGridView2.Rows[DataGridView2.CurrentRow.Index].Cells["Column_City"].Value.ToString();
            customer.Address.Province = DataGridView2.Rows[DataGridView2.CurrentRow.Index].Cells["Column_Province"].Value.ToString();
            customer.Address.PostalCode = DataGridView2.Rows[DataGridView2.CurrentRow.Index].Cells["Column_PostalCode"].Value.ToString();
            customer.Phone = Convert.ToUInt32(DataGridView2.Rows[DataGridView2.CurrentRow.Index].Cells["Column_PhoneNumber"].Value.ToString());
            CustomerEditForm customerEditForm = new CustomerEditForm(customer);         
            customerEditForm.ShowDialog(this);
            
            int currentIndex = DataGridView2.CurrentCell.RowIndex;
            dataGridView2.Rows[currentIndex].Cells[1].Value = customerEditForm.Customer.Name;
            dataGridView2.Rows[currentIndex].Cells[2].Value = customerEditForm.Customer.Address.Street;
            dataGridView2.Rows[currentIndex].Cells[3].Value = customerEditForm.Customer.Address.City;
            dataGridView2.Rows[currentIndex].Cells[4].Value = customerEditForm.Customer.Address.Province;
            dataGridView2.Rows[currentIndex].Cells[5].Value = customerEditForm.Customer.Address.PostalCode;
            dataGridView2.Rows[currentIndex].Cells[6].Value = customerEditForm.Customer.Phone;
        }

        private void EditCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            customer.Name = DataGridView2.Rows[DataGridView2.CurrentRow.Index].Cells["Column_Name"].Value.ToString();
            customer.Address.Street = DataGridView2.Rows[DataGridView2.CurrentRow.Index].Cells["Column_Street"].Value.ToString();
            customer.Address.City = DataGridView2.Rows[DataGridView2.CurrentRow.Index].Cells["Column_City"].Value.ToString();
            customer.Address.Province = DataGridView2.Rows[DataGridView2.CurrentRow.Index].Cells["Column_Province"].Value.ToString();
            customer.Address.PostalCode = DataGridView2.Rows[DataGridView2.CurrentRow.Index].Cells["Column_PostalCode"].Value.ToString();
            customer.Phone = Convert.ToUInt32(DataGridView2.Rows[DataGridView2.CurrentRow.Index].Cells["Column_PhoneNumber"].Value.ToString());
            CustomerEditForm customerEditForm = new CustomerEditForm(customer);
            customerEditForm.ShowDialog(this);

            int currentIndex = DataGridView2.CurrentCell.RowIndex;
            dataGridView2.Rows[currentIndex].Cells[1].Value = customerEditForm.Customer.Name;
            dataGridView2.Rows[currentIndex].Cells[2].Value = customerEditForm.Customer.Address.Street;
            dataGridView2.Rows[currentIndex].Cells[3].Value = customerEditForm.Customer.Address.City;
            dataGridView2.Rows[currentIndex].Cells[4].Value = customerEditForm.Customer.Address.Province;
            dataGridView2.Rows[currentIndex].Cells[5].Value = customerEditForm.Customer.Address.PostalCode;
            dataGridView2.Rows[currentIndex].Cells[6].Value = customerEditForm.Customer.Phone;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            CustomerRepository customerRepository = new CustomerRepository();
            foreach (Customer customer in Customers)
            {
                customerRepository.Add(customer);
            }
            customerRepository.Save("customers.json");
            MessageBox.Show("Success");
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            CustomerRepository customerRepository = new CustomerRepository();
            foreach (Customer customer in Customers)
            {
                customerRepository.Add(customer);
            }       
            Customer_Orders customerOrdersForm = new Customer_Orders(customerRepository);
            customerOrdersForm.ShowDialog(this);
        }

        private void Button2_Click(object sender, EventArgs e)
        {

            CustomerRepository customerRepository = new CustomerRepository();
            foreach (Customer customer in Customers)
            {
                customerRepository.Add(customer);
            }
            MessageBox.Show(dateTimePicker1.Value.ToString());
            MessageBox.Show(dateTimePicker2.Value.ToString());
            CustomersBetweenTwoDays customersBetweenTwoDays = new CustomersBetweenTwoDays(customerRepository, dateTimePicker1.Value, dateTimePicker2.Value);
            customersBetweenTwoDays.ShowDialog(this);
        }
        
        private void DataGridView2_SelectionChanged(object sender, EventArgs e)
        {
            CurrentIndex = dataGridView2.CurrentRow.Index;

        }
    }
}
