using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToOOP
{
    class Superhero
    {
        //Fields
        private bool canFly;
        private double health;
        private string superName;
        private int StrengthLevel;

        //Properties 

      public bool CanFly
        {
            get { return this.canFly; }
            set {this.canFly = value; }

        }

    }
}
