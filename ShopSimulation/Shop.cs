using ShopLibrary;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace ShopSimulation
{
    public partial class Shop : Form
    {
        Store store = new Store();
        private List<item> shoppingCartData = new List<item>();
        BindingSource bindingSourceStore = new BindingSource();
        BindingSource cartBinding = new BindingSource();
        BindingSource vendorBinding = new BindingSource();
        private decimal storeprofit = 0;

        public Shop()
        {
            InitializeComponent();
            SetupVendors();
            SetupItems();

            bindingSourceStore.DataSource = store.Items.
                Where(itemToBeSold => itemToBeSold.Sold == false).ToList();

            StoreList.DataSource = bindingSourceStore;

            StoreList.DisplayMember = "Display";
            StoreList.ValueMember = "Display";

            cartBinding.DataSource = shoppingCartData;
            CartList.DataSource = cartBinding;

            CartList.DisplayMember = "Display";
            CartList.ValueMember = "Display";

            vendorBinding.DataSource = store.Vendors;
            VendorList.DataSource = vendorBinding;

            VendorList.DisplayMember = "Display";
            VendorList.ValueMember = "Display";

        }

        private void SetupVendors()
        {  
            store.Vendors.Add(new Vendor("Bill", "Smith", .2));
            store.Vendors.Add(new Vendor("Sue", "Johnson", .3));
            store.Vendors.Add(new Vendor("Bob", "Peterson", .5));
            store.Vendors.Add(new Vendor("Jack", "Jackson", .5));
   
        }

        private void SetupItems()
        {

            store.Items.Add(new item
            {
                Title = "Harry Potter",
                Description = "A book about magic and harry's adventures",
                Price = 8,
                Sold = false,
                Owner = store.Vendors[0]
            });

            store.Items.Add(new item
            {
                Title = "Harry Potter 2",
                Description = "Deathly hallows",
                Price = 9,
                Sold = false,
                Owner = store.Vendors[1]
            });

            store.Items.Add(new item
            {
                Title = "Harry Potter 3",
                Description = "Rise of the phoenix",
                Price = 10,
                Sold = false,
                Owner = store.Vendors[1]
            });

            store.Name = "Cheaper than your ex";
        }

        private void Add_to_cart_click_event(object sender, EventArgs e)
        {
            item selectedItem = (item)StoreList.SelectedItem;
            shoppingCartData.Add(selectedItem);
            cartBinding.ResetBindings(false);

        }

        private void MakePurchase_click(object sender, EventArgs e)
        {
            foreach (var item in shoppingCartData)
            {
                item.Sold = true;
                //commission - rabat!
                item.Owner.PaymentDue += (decimal)item.Owner.Commission * item.Price;
                //increase stor profit, other half of commission amount
                storeprofit += (1 - (decimal)item.Owner.Commission) * item.Price;
            }

            shoppingCartData.Clear();

            bindingSourceStore.DataSource = store.Items.
               Where(itemToBeSold => itemToBeSold.Sold == false).ToList();

            Profit_text.Text = string.Format("${0}", storeprofit);

            cartBinding.ResetBindings(false);
            bindingSourceStore.ResetBindings(false);
            vendorBinding.ResetBindings(false);
        }
    }
}
