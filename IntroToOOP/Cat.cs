using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToOOP
{
    class Cat
    {
        //I need STATES
        //Fields
        private string name;
        private int age;
        private string furColor;
        private bool isHungry = true;
        private string hairLength;

        //Properties 
        public string Name
        {
            get {return this.name;} //Seeing the value of name
            set {this.name = value;} //Allows you to change the value of name
        }

        public string HairLength
        {
            get { return this.hairLength; }
            set { this.hairLength = value; }
        }

        


        
        



        //I need BEHAVIORS


        //Constructors
        public Cat()
        {
            //Default Constructor
            //Takes No Parameters (nothing in the parantheses)
        }


        //Example of an overload constructor
        public Cat(string name, int age, string furColor)
        {
            this.name = name;
            this.age = age;
            this.furColor = furColor;
        }

        //Methods
        public void Eat()
        {
            if(isHungry)
            {
                isHungry = false;
            }
            Console.WriteLine("Is the cat hungry? " + isHungry);
        }

        public void Meow()
        {
            Console.WriteLine("\a");
        }

        public string Hairball()
        {
            if (hairLength == "too long")
            {
                return (this.name + " has a hairball.");
            }
            else
            {
                return (this.name + " is nicely groomed.");
            }
        }
    }
}