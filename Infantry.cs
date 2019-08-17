using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryUnit
{
    class Infantry : Personnel
    {


        public Infantry()
            : this(60.5)
        {

        }
        protected Infantry(double riskOfLife) //only allows derived class to change values
               : base("Infantry", 5, 60.5)
        {

        }

        public override double Fights() //for virtual or abstract method parent class
        {
            Console.WriteLine("Infantry fights for 7 hours");
            return 7.0;
        }

        
    }
}
