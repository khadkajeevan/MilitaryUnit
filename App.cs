using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryUnit
{
    class App
    {
        public void Run()
        {
            var infantry = new Infantry();
            var medical = new Medical();
            var artillery = new Artillery();

          
            var personnels = new List<Personnel>() { infantry, medical, artillery };

            foreach (var personnel in personnels)
            {
                DoPersonnelStuff(personnel);
            }
        }

        private void DoPersonnelStuff(Personnel personnel)
        {
            if (personnel is Medical asMedical)
            {
                asMedical.MedicalCamp();
            }
            else
            {
                personnel.Fire();
            }

                       
            var totalfight = personnel.Fights();

            personnel.Rest();
            personnel.Reload();

            totalfight += personnel.Fights();

            Console.WriteLine($"Total hours of fight {totalfight}\n");

        }

                       
    }
}
