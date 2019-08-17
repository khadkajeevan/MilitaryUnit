using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryUnit
{
    class Artillery : Personnel
    {
        public Artillery()
            : base("Artillery", 15, 20.5)
        {
        }
        public override void Fire()
        {
            Console.WriteLine($"{personnelType} provides fire support from time to time");
        }

        public override double Fights()
        {
            Console.WriteLine($"{personnelType} fights 3.0 hours");
            return 4.0;
        }
    }
}
