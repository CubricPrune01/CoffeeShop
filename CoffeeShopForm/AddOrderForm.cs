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
using CoffeeShopLib.MenuItemAdditions;
using CoffeeShopLib.MenuItems;

namespace CoffeeShopForm
{
    
    public partial class AddOrderForm : Form
    {
        public bool submitted = false;
        public CoffeeShopLib.MenuItem menuItem { get; set; }
        public CoffeeShopLib.MenuItem menuItemAddition { get; set; }
        public Customer Customer { get; set; }
        public Order Order { get; set; }
        DataTable table = new DataTable();
        private List<IMenuItem> items= new List<IMenuItem>();
        private int numberOfRows = 0;

        public List<IMenuItem> Items
        {
            get { return items; }
            set { items = value; }
        }
        public AddOrderForm(Customer customer)
        {
            InitializeComponent();
            Customer = customer;
            
           
            cheeseValue.Text = "0";
            lettuceValue.Text = "0";
            mayoValue.Text = "0";
            milkValue.Text = "0";
            sugarValue.Text = "0";
            sweetenerValue.Text = "0";
            tomatoValue.Text = "0";
            
            Order = new Order();          
            menuGridView.Rows.Add(new Coffee().Description).ToString();
            menuGridView.Rows.Add(new CoffeeDarkRoast().Description).ToString();
            menuGridView.Rows.Add(new Tea().Description).ToString();
            menuGridView.Rows.Add(new SandwichWithBacon().Description).ToString();
            menuGridView.Rows.Add(new SandwichWithEggSalad().Description).ToString();
            menuGridView.Rows.Add(new SandwichWithRoastedBeef().Description).ToString();

            menuGridView.Rows[0].Cells[1].Value = (new Coffee().Cost).ToString();
            menuGridView.Rows[1].Cells[1].Value = (new CoffeeDarkRoast().Cost).ToString();
            menuGridView.Rows[2].Cells[1].Value = (new Tea().Cost).ToString();
            menuGridView.Rows[3].Cells[1].Value = (new SandwichWithBacon().Cost).ToString();
            menuGridView.Rows[4].Cells[1].Value = (new SandwichWithEggSalad().Cost).ToString();
            menuGridView.Rows[5].Cells[1].Value = (new SandwichWithRoastedBeef().Cost).ToString();

            additionGridView.Rows.Add(new Cheese().Description).ToString();
            additionGridView.Rows.Add(new Lettuce().Description).ToString();
            additionGridView.Rows.Add(new Mayo().Description).ToString();
            additionGridView.Rows.Add(new Milk().Description).ToString();
            additionGridView.Rows.Add(new Suggar().Description).ToString();
            additionGridView.Rows.Add(new Sweetener().Description).ToString();
            additionGridView.Rows.Add(new Tomato().Description).ToString();

            additionGridView.Rows[0].Cells[1].Value = (new Cheese().Cost).ToString();
            additionGridView.Rows[1].Cells[1].Value = (new Lettuce().Cost).ToString();
            additionGridView.Rows[2].Cells[1].Value = (new Mayo().Cost).ToString();
            additionGridView.Rows[3].Cells[1].Value = (new Milk().Cost).ToString();
            additionGridView.Rows[4].Cells[1].Value = (new Suggar().Cost).ToString();
            additionGridView.Rows[5].Cells[1].Value = (new Sweetener().Cost).ToString();
            additionGridView.Rows[6].Cells[1].Value = (new Tomato().Cost).ToString();
        }
        private void NUD_Cheese_ValueChanged(object sender, EventArgs e)
        {
            decimal cheese = NUD_Cheese.Value;
            cheeseValue.Text = cheese.ToString();            
        }
        private void NUD_Lettuce_ValueChanged(object sender, EventArgs e)
        {
            decimal lettuce = NUD_Lettuce.Value;
            lettuceValue.Text = lettuce.ToString();
        }

        private void NUD_Mayo_ValueChanged(object sender, EventArgs e)
        {
            decimal mayo = NUD_Mayo.Value;
            mayoValue.Text = mayo.ToString();            
        }

        private void NUD_Milk_ValueChanged(object sender, EventArgs e)
        {
            decimal milk = NUD_Milk.Value;
            milkValue.Text = milk.ToString();
        }

        private void NUD_Sugar_ValueChanged(object sender, EventArgs e)
        {
            decimal sugar = NUD_Sugar.Value;
            sugarValue.Text = sugar.ToString();
        }

        private void NUD_Sweetener_ValueChanged(object sender, EventArgs e)
        {
            decimal sweetener = NUD_Sweetener.Value;
            sweetenerValue.Text = sweetener.ToString();
        }

        private void NUD_Tomato_ValueChanged(object sender, EventArgs e)
        {
            decimal tomato = NUD_Tomato.Value;
            tomatoValue.Text = tomato.ToString();
        }
        private void MenuGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;            
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (menuGridView.CurrentRow == null)
                return;
            IMenuItem item = new Coffee();            
            if (menuGridView.CurrentRow.Index == 1)
                item = new CoffeeDarkRoast();
            else if (menuGridView.CurrentRow.Index == 2)
                item = new Tea();
            else if (menuGridView.CurrentRow.Index == 3)
                item = new SandwichWithBacon();
            else if (menuGridView.CurrentRow.Index == 4)
                item = new SandwichWithEggSalad();
            else if (menuGridView.CurrentRow.Index == 5)
                item = new SandwichWithRoastedBeef();
            for (int i = 0; i < NUD_Cheese.Value; i++)
            {
                item = new Cheese(item);
            }
            for (int i = 0; i < NUD_Lettuce.Value; i++)
            {
                item = new Lettuce(item);
            }
            for (int i = 0; i < NUD_Mayo.Value; i++)
            {
                item = new Mayo(item);
            }
            for (int i = 0; i < NUD_Milk.Value; i++)
            {
                item = new Milk(item);
            }
            for (int i = 0; i < NUD_Sugar.Value; i++)
            {
                item = new Suggar(item);
            }
            for (int i = 0; i < NUD_Sweetener.Value; i++)
            {
                item = new Sweetener(item);
            }
            for (int i = 0; i < NUD_Tomato.Value; i++)
            {
                item = new Tomato(item);
            }           
            orderListGridView.Rows.Add();
            orderListGridView.Rows[numberOfRows].Cells[0].Value = item.Description;
            orderListGridView.Rows[numberOfRows++].Cells[1].Value = item.Cost;
            items.Add(item);
        }
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            Order order1 = Customer.CreatePhoneOrder(Customer.Address);
            foreach (IMenuItem item in items)
            {
                order1.AddOrderItem(item);
            }            
            submitted = true;

            Close();
        }
    }    

}
