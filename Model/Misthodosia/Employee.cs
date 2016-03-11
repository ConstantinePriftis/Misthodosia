using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Misthodosia
{
   public  class Employee
    {
        public int ID { get; set; }        
        public string Name { get; set; }
        public string SurName { get; set; }
        public decimal Wage { get; set; }
        public Employee(int id ,string name , string surName , decimal wage)
        {
            this.ID = id;
            this.Name = name;
            this.SurName = surName;
            this.Wage = wage;
        }

        public override string ToString()
        {
            return "ID: " + ID + "Name: " + Name + "Surname: " + SurName + "Wage: " + Wage;
        }
    }
}
