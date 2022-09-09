using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3_Lexicon
{
    abstract class Animal
    {
        private string? AniName;
        private int age;
        private double weight;
        private int NrOfLegs; 

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
            get { return AniName; }
            set { AniName = value;}
        }

        
        public double Weight
        {
            get { return weight; }
            set { weight = value; }
        }
        public int NrOfLegs
        {
            get { return NrOfLegs; }
            set { NrOfLegs = value; }
        }
    }
}
