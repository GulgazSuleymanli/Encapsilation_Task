using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsilation_AccessModifier.Models
{
    internal class Store
    {
        private string _name;
        Phone[] Phones=new Phone[0];

        public Store(string name)
        {
            Name = name;
        }

        public string Name 
        { 
            get
            {
                return _name;
            }
            set
            {
                if(value.Length > 3)
                {
                    _name = value;
                }
            }
        }

        public void AddPhone(Phone phone)
        {
            Array.Resize(ref Phones, Phones.Length+1);
            Phones[Phones.Length - 1] = phone;
        }

        public void ShowAllPhones()
        {
            foreach(Phone phone in Phones)
            {
                phone.ShowInfo();
            }
        }

        public void ShowPhoneForPrice(double minPrice,  double maxPrice)
        {
            foreach (Phone phone in Phones)
            {
                if(phone.Price >= minPrice && phone.Price <= maxPrice)
                {
                    phone.ShowInfo();
                }
            }
        }

        public void RemovePhone(ref Phone phone)
        {
            Phone[] NewPhones = new Phone[0];
            for (int i = 0; i < Phones.Length; i++)
            {
                if (Phones[i] != phone)
                {
                    Array.Resize(ref NewPhones, NewPhones.Length+1);
                    NewPhones[NewPhones.Length-1] = phone;
                }

            }
            Phones = NewPhones;
        }
    }
}
