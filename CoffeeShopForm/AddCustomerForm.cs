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
    public partial class AddCustomerForm : Form
    {        
        public Customer Customer { get; set; }    
        public AddCustomerForm()
        {
            InitializeComponent();
            Customer = new Customer();
        }
        private void BtnAdd_Click(object sender, EventArgs e)
        {            
            Customer.Name = txtName.Text;
            Customer.Address.Street = txtStreet.Text;
            Customer.Address.City = txtCity.Text;
            Customer.Address.Province = txtProvince.Text;
            Customer.Address.PostalCode = txtPostalCode.Text;
            Customer.Phone = Convert.ToUInt32(txtPhoneNumber.Text);
            Close();
        }

       

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {     
            
            Close();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtStreet.Clear();
            txtCity.Clear();
            txtProvince.Clear();
            txtPostalCode.Clear();
            txtPhoneNumber.Clear();
        }
    }
}
