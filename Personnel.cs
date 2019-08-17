using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryUnit
{
    abstract class Personnel
    
    {
        protected readonly int fireArms = 15;
        protected readonly double riskOfLife;

        protected readonly string personnelType;

        protected Personnel(string personnelType, double riskOfLife)
        {
            this.personnelType = personnelType;
            this.riskOfLife = riskOfLife;
        }

        protected Personnel (string personnelType, int fireArms, double riskOfLife)
        {
            this.personnelType = personnelType;
            this.fireArms = fireArms;
            this.riskOfLife = riskOfLife;
        }

        public virtual void Rest() // designed to be overridden by derived class
        {
            Console.WriteLine($"{personnelType} rests");
        }
        public void Reload()
        {
            Console.WriteLine($"{personnelType} reloads");
        }
        public virtual void Fire()
        {
            Console.WriteLine($"{personnelType} fires  from {fireArms} different firearms");
        }
        public abstract double Fights(); //has no good implementation so abstract

    }
}

