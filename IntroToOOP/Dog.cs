using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToOOP
{
    class Dog
    {

        //Fields
        private string hairLength;
        private double height;
        private string runningSpeed;
        private double weight;
        private bool useBathroom;

        
        //Properties
        public double Height
        {
            get { return this.height; }
            set { this.height = value; }
        }

        public string RunningSpeed
        {
            get {return this.runningSpeed;}
            set {this.runningSpeed = value;}
        }






        public Dog()
        {

        }

        public Dog(string hairLength, double height, string runningSpeed, double weight)
        {
            this.hairLength = hairLength;
            this.height = height;
            this.runningSpeed = runningSpeed;
            this.weight = weight;
        }

      



        public void Run()
        {

        }

        public void Bark()
        {
            if (useBathroom)
            {
                
            }
            Console.WriteLine("\a");
        }

        public void Potty()
        {

        }

        public void Cuddle()
        {

        }
    }

    
}
