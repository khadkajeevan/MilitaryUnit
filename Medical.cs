using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryUnit
{
    class Medical : Personnel
    {
        public Medical()
            : base("Medical", 20.5)
        {

        }

        public new void Reload()
        {
            Console.WriteLine($"{personnelType} unit provides support and takes care of wounded infantry personnel");
        }

        public override void Rest()
        {
            base.Rest();
            Console.WriteLine($"{personnelType} takes care of  wounded warriors");
        }

        public override double Fights()
        {
            Console.WriteLine($"{personnelType} fights  1.5 hour");
            return 1.5;
        }

        public void MedicalCamp()
        {
            Console.WriteLine("Medical team sets up first aid camp for wounded warriors!");
        }
    }
}
