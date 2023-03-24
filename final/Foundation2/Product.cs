using System;
using System.Collections.Generic;
using System.Text;

namespace Foundation2
{
    class Product
    {
        private string _name;
        private string _id;
        private double _indPrice;
        private int _quantity;
        private double _price;


        public Product
        (
            string name,
            string id,
            double indPrice,
            int quantity
        )
        {
            _name = name;
            _id = id;
            _indPrice = indPrice;
            _quantity = quantity;
            _price = indPrice * quantity;
        }

        public double getPrice()
        {
            return _price;
        }
        public string getProductInfo()
        {
            return $"ID {"["+_id+"]:",-9} {_name,-25}${_indPrice,-10} x {_quantity,-20}${Math.Round(_price,2)}";
        }

    }
}
