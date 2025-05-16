using System;
using System.Collections.Generic;
using System.Deployment.Internal;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Recipint : Person

    {
        public int BloodWithdrawl { get; set; }
        public Recipint(string Name, string Address, string ID, BloodType bloodType, Gender gender,
            Case @Case, int bloodWithdrawl) : base(Name, Address, ID, bloodType, gender
            , @Case)
        {
            BloodWithdrawl = bloodWithdrawl;
        }
    }
}
        

       
    
    

