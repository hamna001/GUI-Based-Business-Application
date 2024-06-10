using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectBusinessApplicationWithGUI
{
    class Cars
    {
        private string car_name;
        private string car_model;
        private string car_color;
        private string car_Quanity;
        private string car_price;

        public string Car_name { get => car_name; set => car_name = value; }
        public string Car_model { get => car_model; set => car_model = value; }
        public string Car_color { get => car_color; set => car_color = value; }
        public string Car_Quanity { get => car_Quanity; set => car_Quanity = value; }
        public string Car_price { get => car_price; set => car_price = value; }

        public Cars(string car_name, string car_model, string car_color, string Car_Quanity, string car_price)
        {
            this.car_name = car_name;
            this.car_model = car_model;
            this.car_color = car_color;
            this.car_Quanity = Car_Quanity;
            this.car_price = car_price;
        }
        public Cars()
        {

        }
        public string GetCarName()
        {
            return car_name;
        }
        public String GetcarModel()
        {
            return car_model;
        }
        public string GetcarColor()
        {
            return car_color;
        }
        public string GetcarPrice()
        {
            return car_price;
        }
        public string GetcarQuantity()
        {
            return car_Quanity;
        }

        public void setname(string name)
        {

        }
        public void setprice(string price)
        {
            this.car_price = price;
        }

       
    }
}
