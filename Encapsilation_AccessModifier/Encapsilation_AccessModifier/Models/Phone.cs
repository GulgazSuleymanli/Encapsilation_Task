using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsilation_AccessModifier.Models
{
    internal class Phone
    {
        private int _id;
        private string _name;
        private string _brandName;
        private double _price;
        private int _count;

        public Phone(string name)
        {
            _name = name;
        }

        public Phone(int id, string name, string brandName, double price, int count):this(name)
        {
            Id = id;
            BrandName = brandName;
            Price = price;
            Count = count;
        }

        public int Id
        {
            get 
            { 
                return _id; 
            }
            set 
            {
                if(value>0)
                {
                    _id = value;
                }
            }
        }

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if(value.Length>=2)
                {
                    _name = value;
                }
            }
        }

        public string BrandName
        {
            get
            {
                return _brandName;
            }
            set
            {
                if (value.Length >= 3)
                {
                    _brandName = value;
                }
            }
        }

        public double Price
        {
            get
            {
                return _price;
            }
            set
            {
                if (value > 0)
                {
                    _price = value;
                }
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
                if(value > 0)
                {
                    _count = value;
                }
            }
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Id: {Id}, Name: {Name}, Brand name: {BrandName}, Price: {Price}, Count: {Count}");
        }

    }
}
