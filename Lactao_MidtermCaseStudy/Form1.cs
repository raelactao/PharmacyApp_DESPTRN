using Lactao_MidtermCaseStudy.Classes;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using System.ComponentModel;
using System.Xml.Linq;

namespace Lactao_MidtermCaseStudy
{
    public partial class Form1 : Form
    {
        private ShoppingCart shoppingCart = ShoppingCart.getInstance();

        private Product? prod;

        private int delIndex;

        public Form1()
        {
            InitializeComponent();
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //BindingList<Order> bs = new BindingList<Order>(shoppingCart.Orders);
            orderBindingSource.DataSource = shoppingCart.Orders;
            //orderBindingSource.DataSource = bs;
        }

        private void btnProductSelect_Click(object sender, EventArgs e)
        {

            SelectProdByName(boxProductSelect.Text);

            if (prod != null)
            {
                txt1Lbl.Text = prod.Name;
                txt2lbl.Text = prod.Type;
                txt3Lbl.Text = prod.Unit;
                txt4Lbl.Text = prod.Price.ToString();
                inputQty.Value = 0;
                txtTotal.Text = "0.00";
            }
         
        }

        private void inputQty_ValueChanged(object sender, EventArgs e)
        {
            if (prod != null)
            {
                decimal amount = inputQty.Value * prod.Price;
                txtTotal.Text = amount.ToString();
            }

            
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
           if (prod != null && inputQty.Value != 0)
            {
                shoppingCart.AddtoCart(prod, (int)inputQty.Value);

            }
            lblTotalNo.Text = shoppingCart.GetTotal().ToString();

            ResetTexts();
        }

        private void dgvShopCart_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexRow = e.RowIndex;
            DataGridViewRow row = dgvShopCart.Rows[indexRow];

            string name = (string)row.Cells[1].Value;
            lblRemoveItem.Text = name;
            
            Order? orderFromCart = shoppingCart.Orders.SingleOrDefault(p => p.Name == name);
            if (orderFromCart != null)
            {
                Product? prodFromOrder = GetProduct(name);
                txt1Lbl.Text = prodFromOrder.Name;
                txt2lbl.Text = prodFromOrder.Type;
                txt3Lbl.Text = prodFromOrder.Unit;
                txt4Lbl.Text = prodFromOrder.Price.ToString();
                inputQty.Value = (int)row.Cells[2].Value;
                txtTotal.Text = row.Cells[4].Value.ToString();

                delIndex = shoppingCart.Orders.IndexOf(orderFromCart);

                SelectProdByName(name);
            }


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            shoppingCart.DeleteItem(delIndex);
            lblTotalNo.Text = shoppingCart.GetTotal().ToString();
            ResetTexts();
        }

        private void SelectProdByName(string name)
        {

            foreach (string item in boxProductSelect.Items)
            {
                if (name.Equals(item))
                {
                    prod = GetProduct(item);
                }
            }

        }

        private Product? GetProduct(string name)
        {
            switch (name)
            {
                case "Sodium ascorbate (Vit. C)":
                    return Factory.Add("vitaminC");
                case "Vitamin E":
                    return Factory.Add("vitaminE");
                case "Multivitamins":
                    return Factory.Add("multivitamins");
                case "Iron Supplement":
                    return Factory.Add("iron");
                case "Calcium Supplement":
                    return Factory.Add("calcium");
                case "Magnesium Supplement":
                    return Factory.Add("magnesium");
                default:
                    return null;
            }
        }

        private void ResetTexts()
        {
            prod = null;
            lblRemoveItem.Text = " ";
            boxProductSelect.Text = " ";
            txt1Lbl.Text = "------------------------";
            txt2lbl.Text = "------------------------";
            txt3Lbl.Text = "------------------------";
            txt4Lbl.Text = "------------------------";
            inputQty.Value= 0;
            txtTotal.Text = "0.00";

        }


    }
}