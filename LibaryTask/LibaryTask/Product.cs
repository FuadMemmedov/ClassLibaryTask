using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibaryTask
{
    internal class Product
    {
        private double _price;
        private int _count;
        public int No;
        public string Name;

        public double Price
        {
            get
            {
                return _price;
            }
            set
            {
                _price = value;
            }
        }
        public int Count
        {
            get
            {
                return _count;
            }
            set
            {
                _count = value;
            }
        }

        public Product(string name,double price,int no)
        {
            Name = name;
            Price = price;
            No = no;
        }
    }
}
