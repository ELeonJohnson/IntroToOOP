using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat firstCat = new Cat();
            firstCat.Name = "Mr. Fuzzy";

            Cat secondCat = new Cat("Midnight", 14, "Black");

            Console.WriteLine(firstCat.Name);
            Console.WriteLine(secondCat.Name);

            //calling the method Eat() on the firstCat
            firstCat.Eat();

            secondCat.Meow();

            Dog firstDog = new Dog();
            firstDog.Height = 12.5;

            Dog secondDog = new Dog("Long", 8.4, "Slow", 185);

            secondDog.Bark();

            Console.WriteLine(firstDog.Height);
            Console.WriteLine(secondDog.RunningSpeed);

            firstCat.HairLength = "nice and short";
            secondCat.HairLength = "too long";

            Console.WriteLine(firstCat.Hairball());
            Console.WriteLine(secondCat.Hairball());
        }
    }
}
