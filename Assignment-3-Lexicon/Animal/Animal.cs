using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3_Lexicon
{
    abstract class Animal
    {
        private string? aniname;
        private int age;
        private double weight;
        private int nroflegs;

        public Animal(string aniname, int age, double weight, int nroflegs)
        { 
            AniName = aniname;
            Age = age;
            Weight = weight;
            NrOfLegs = nroflegs;
        }

        public int Age
        {
            get { return age; }
            set
            {
                if (value == 0)
                {
                    throw new ArgumentException("Age must be greater than zero.");
                }
                else
                {
                    age = value;
                }
            }
        }

        public string? AniName
        {
            get { return aniname; }
            set { aniname = value;}
        }

        
        public double Weight
        {
            get { return weight; }
            set { weight = value; }
        }
        public int NrOfLegs
        {
            get { return nroflegs; }
            set { nroflegs = value; }
        }
        public abstract string DoSound();
        
    }
}
