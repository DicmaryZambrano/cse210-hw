using System;
using System.Collections.Generic;
using System.Text;

namespace Foundation2
{
    class Order
    {
        private Customer _customer;
        private List<Product> _products = new List<Product>();

        public Order(Customer customer, List<Product> products)
        {
            _customer = customer;
            _products.AddRange(products);
        }

        private double getSubTotal()
        {
            double total = 0;

            foreach (Product product in _products)
            {
                total += product.getPrice();
            }

            return total;
        }

        private double getTotal()
        {
            return getSubTotal() + getShippingCost();
        }

        private double getShippingCost()
        {
            double shipping;

            if(_customer.LivesInUSA())
            {
                shipping = 5;
            }
            else
            {
                shipping = 35;
            }

            return shipping;
        }

        private string getInfoString()
        {
            List<string> infoStrings = new List<string>();

            foreach (Product product in _products)
            {
                infoStrings.Add(product.getProductInfo() + "\n");
            }

            return string.Join("",infoStrings);
        }

        private string makePackingLabel()
        {
            string allProductInfo = getInfoString();

            string packingLabel = $"PackingLabel:\n\n{allProductInfo}";

            return packingLabel;
        }

        public string getPackingLabel()
        {
            return makePackingLabel();
        }

        private string makeShippingLabel()
        {
            string adress = _customer.getAddress();
            string name = _customer.getName();

            string shippingLabel = $"ShippingLabel:\n\n{name}\n{adress}";
            return shippingLabel;
        }
        
        public string getShippingLablel()
        {
            return makeShippingLabel();
        }

        private string makePriceString()
        {
            double shipping = getShippingCost();
            double subTotal = Math.Round(getSubTotal(),2);
            double total = Math.Round(getTotal(),2);
            string priceString = $"{"Shipping:",-72}${shipping}\n{"Subtotal:",-72}${subTotal}\n{"Total:",-72}${total}";

            return priceString;
        }

        public string getPriceString()
        {
            return makePriceString();
        }
    }
}
