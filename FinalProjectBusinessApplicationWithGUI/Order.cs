
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectBusinessApplicationWithGUI
{
    class Order
    {
        private string product_name;
        private string product_price;
        private string quantity;
        private string username;

        public string Product_name { get => product_name; set => product_name = value; }
        public string Product_price { get => product_price; set => product_price = value; }
        public string Quantity { get => quantity; set => quantity = value; }
        public string Username { get => username; set => username = value; }

        public Order(string product_name, string quantity, string product_price, string username)
        {
            this.product_name = product_name;
            this.product_price = product_price;
            this.username = username;
            this.Set_quantity(quantity);
        }

        public void Set_productnametoOrder(string product_name)
        {
            this.product_name = product_name;
        }
        public string Get_productnametoOrder()
        {
            return product_name;
        }
        public void Set_productPricetoOrder(string product_price)
        {
            this.product_price = product_price;
        }
        public string Get_productPricetoOrder()
        {
            return product_price;
        }
        public void Set_quantity(string Quantity)
        {
            this.quantity = Quantity;
        }
        public string Get_Quantity()
        {
            return quantity;
        }
        public string GetUsername()
        {
            return username;
        }


        public void SetUsername(string username)
        {
            this.username = username;
        }
    }
}
