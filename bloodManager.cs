using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class bloodManager

    {


        public List<Person> People;
        private Dictionary<BloodType, int> totalbloodByType;
        public bloodManager()
        {
            People = new List<Person>();
            totalbloodByType = new Dictionary<BloodType, int>();

            foreach (BloodType type in Enum.GetValues(typeof(BloodType)))
            {
                totalbloodByType[type] = 0;

            }
        }
        public void AddPerson(Person person)
        {

            People.Add(person);
            if (person is Donor donor)
            {
                totalbloodByType[donor.BloodType] += donor.Blooddonation;

            }
            else if (person is Recipint recipint)
            {
                totalbloodByType[recipint.BloodType] -= recipint.BloodWithdrawl;
            }
        }
        public Dictionary<BloodType, int> GettotalBlood()
        {
            return totalbloodByType;

        }

    }
}



       /* public List<Person> People;
        public bloodManager(){
            People = new List<Person>();
        }
        public void AddPerson(Person person)
        {
            People.Add(person);
        }public Dictionary<BloodType, int> GettotalBloodType()
        {
            Dictionary<BloodType, int> totalBytype = new Dictionary<BloodType, int>();



            foreach (BloodType type in Enum.GetValues(typeof(BloodType)))
            {
                totalBytype[type] = 0;
            }
            foreach (Person person in People)
            {
                if (person is Donor donor)
                {
                    totalBytype[donor.BloodType] += donor.Blooddonation;
                }
                else if (person is Recipint recipint)
                {
                    totalBytype[recipint.BloodType] -= recipint.BloodWithdrawl;
                }
            }
            return totalBytype;
        }
            public Dictionary<BloodType, int> GeTotalBloodTypeLinq()
        {
            return People.GroupBy(p => p.BloodType).ToDictionary(

                group => group.Key,
                group => group.Sum(p =>
                {
                    int bloodValue = 0;
                    if (p is Donor d)
                    {
                        bloodValue = d.Blooddonation;
                    }
                    else if (p is Recipint pa)
                    {
                        bloodValue = -pa.BloodWithdrawl;

                    }
                    return bloodValue;*/
               
            
           
                 
        
        

    
