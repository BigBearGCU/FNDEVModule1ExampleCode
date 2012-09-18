using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IEquatableDemo
{
    class Product : IEquatable<Product>
    {
        private int _id;
        private string _name;
        private double _price;

        public Product(int id, string name, double price)
        {
            _id = Id;
            _name = name;
            _price = price;
        }

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public double Price
        {
            get { return _price; }
            set { _price = value; }
        }

        public bool Equals(Product other)
        {
            return(this._id == other._id) &&
                (this._name == other._name) &&
                (this._price == other._price);
        }
    }
}
