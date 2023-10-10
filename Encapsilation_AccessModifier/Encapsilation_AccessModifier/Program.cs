using Encapsilation_AccessModifier.Models;
using System.Threading.Channels;

namespace Encapsilation_AccessModifier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Store store = new Store("A24");
            Phone phone = new Phone(1, "Iphone 13", "Apple", 1850, 5);
            Phone phone2 = new Phone(2, "A24", "Samsung", 783, 3);
            //phone.ShowInfo();
            store.AddPhone(phone);
            store.AddPhone(phone2);
            store.ShowAllPhones();
            int input;

            #region Optional
            do
            {
                Console.WriteLine("Aparmaq istediyiniz emeliyyata uygun reqemi daxil edin:");
                Console.WriteLine("1- Magazadaki butun telefonlari goster\r\n2- Magazaya yeni telefon elave et. \r\n3- Qiymet araligina uygun telefonlari axtar\r\n4- Telefonu siyahidan sil\r\n5-Proqrami dayandir");
                input = int.Parse(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        store.ShowAllPhones();
                        break;
                    case 2:
                        Console.WriteLine("Elave etmek istediyiniz telefonun deyerlerini daxil edin:");
                        string phonename = Console.ReadLine();
                        Phone phone3 = new Phone(phonename);
                        store.AddPhone(phone3);
                        break;
                    case 3:
                        Console.WriteLine("Min ve Max price deyerlerini daxil edin:");
                        double min = double.Parse(Console.ReadLine());
                        double max = double.Parse(Console.ReadLine());
                        store.ShowPhoneForPrice(min, max);
                        break;
                    case 4:
                        Console.WriteLine("Silmek istediyiniz Phonun adini daxil edin:");
                        string word = Console.ReadLine();
                        Phone phone1 = new Phone(word);
                        store.RemovePhone(ref phone1);
                        break;
                    default:
                        Console.WriteLine("Daxil edilen reqem hec bir emeliyyata uygun deyil.");
                        break;
                }
            }
            while (input != 5); 
            #endregion


        }
    }
}