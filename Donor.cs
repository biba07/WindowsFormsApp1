using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WindowsFormsApp1
{


    public class Donor : Person

    {
        public int Blooddonation { get; set; }
        public Donor(string Name, string Address, string ID, BloodType bloodType, Gender gender, Case @case, int blooddonation) :
            base(Name, Address, ID, bloodType, gender, @case)
        {
            Blooddonation = blooddonation;

        }



    }
}
    
    

