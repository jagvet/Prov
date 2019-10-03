using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prov_modellering
{
    class book
    {
        public int price;
        string name;
        int rarity;
        string category;
        int actualValue;
        bool cursed;
        static Random generator = new Random();
        List<string> names = new List<string> { "Boken om böcker", "The Book About Books", "Prince Ali", "Call of Duty - Complete Saga", "Lord of the Ring"};
        List<string> categories = new List<string> { "Drama", "Action", "Comedy", "Romantic", "Thriller", "Sci-fi" };

        public void Book()
        {
            price = generator.Next(11); //Slumpar priset på boken

            rarity = generator.Next(11); //Slumpar hur sälsynt

            int cursegenerator = generator.Next(1); //ger antingen 1 eller 0

            if(cursegenerator == 1)//om det är 1 är den cursed
            {
                cursed = true;
            }
            else//annars inte cursed
            {
                cursed = false;
            }

            name = names[generator.Next(names.Count)];//slumpar ett namn

            category = categories[generator.Next(categories.Count)];//slumpar en kategori
        }

        public void PrintInfo()//skriver ut allting man vet om boken och vad den säljs för
        {
            Book();//hämtar info om boken och lägger in det nedan
            Console.WriteLine("The name of the book is '" + name + "' and belongs to the genre " + category);
            Console.WriteLine("The price is " + price + " USD");
        }

        public int Evaluate()//det pris man tror boken har
        {
            int rightprice = actualValue * rarity;

            return generator.Next(rightprice / 2, rightprice * 15 / 10);
        }
    }
}
