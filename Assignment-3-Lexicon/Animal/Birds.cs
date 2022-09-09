using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3_Lexicon.Animal
{
	class Birds : Animal
	{
		private string? aniname;
		private int age;
		private double weight;
		private int nroflegs;

        public Birds(string aniname, double weight, int age, int nroflegs, double wingSpan)
        {
            WingSpan = wingSpan;
        }

        public double WingSpan		
		{
			get;
			 
		}

		
		public override string DoSound()
		{
			return "choon choon";
		}

		public override string Stats()
		{
			return base.Stats() + $"\tWing span: {WingSpan} m";
		}
	}
}
