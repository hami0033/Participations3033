using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFToys_Classes
{
    public class Toy
    {
        public string Manufacturer { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Image { get; set; }
        private string Aisle { get; set; }

        public Toy()
        {
            Manufacturer = string.Empty;
            Name = string.Empty;
            Price = 0;
            Image = string.Empty;
            Aisle = string.Empty;
        }
        public Toy(string manufacturer, string name, double price, string image)
        {
            manufacturer = Manufacturer;
            name = Name;
            price = Price;
            image = Image;
        }

        public string GetAisle()
        {
            string manufacturer = Manufacturer.ToUpper();

            char[] manWord = manufacturer.ToCharArray();

            char firstLetter = manWord[0];

            Aisle = firstLetter.ToString();

            return Aisle + Price;
        }

        public override string ToString()
        {
            string output = Manufacturer + " - " + Name;
            return output;
        }
    }
}
