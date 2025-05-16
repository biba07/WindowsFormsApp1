using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1;

namespace WindowsFormsApp1
{
    public class Person
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string ID { get; set; }
        
        public BloodType BloodType { get; set; }
        public Case _Case { get; set; }
        public Gender Gender { get; set; }
        

   

     

        public Person(string name, string address,string iD, BloodType bloodType, Gender gender, Case @case)
        {
            Name = name;
            Address = address;
            
            ID = iD;
            BloodType = bloodType;
            Gender = gender;
            _Case = @case;
        }

        public virtual void ProcessBlood()
        {

        }
    }
}
