using CoffeeShopLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeShopForm
{
    public partial class CustomerEditForm : Form
    {
        public Customer Customer { get; set; }
       
        public  CustomerEditForm(Customer customer): this()
        {
            Customer = customer;
            txtName.Text = customer.Name;
            txtStreet.Text = customer.Address.Street;
            txtCity.Text = customer.Address.City;
            txtProvince.Text = customer.Address.Province;
            txtPostalCode.Text = customer.Address.Province;
            txtPhoneNumber.Text = Convert.ToString(customer.Phone);

        }
        public CustomerEditForm()
        {
            InitializeComponent();            
        }

        private void CustomerEditForm_Load(object sender, EventArgs e)
        {            

        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            Customer.Name = txtName.Text;
            Customer.Address.Street = txtStreet.Text;
            Customer.Address.City = txtCity.Text;
            Customer.Address.Province = txtProvince.Text;
            Customer.Address.PostalCode = txtPostalCode.Text;
            Customer.Phone = Convert.ToUInt32(txtPhoneNumber.Text);            
            Close();
        }
    }
}
