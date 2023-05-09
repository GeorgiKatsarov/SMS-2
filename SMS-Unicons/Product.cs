using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    internal class Product
    {
        private int id;
        private string name;
        private int quantity;
        private decimal price;
        private decimal deliveryPrice;
        
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }
        public decimal Price
        {
            get { return price; }
            set { price = value; }
        }
        public decimal DeliveryPrice
        {
            get { return deliveryPrice; }
            set { deliveryPrice = value; }
        }


    }
