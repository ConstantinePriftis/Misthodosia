using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Misthodosia
{
    public class Reader
    {
        Employee[] employees;
        public Reader()
        {
           
            employees = new Employee[10];
            PopulateEmployees();
        }

        public void PopulateEmployees()
        {
            int counter = 0;
            foreach (string line in File.ReadLines(@"EmployeesDatabase.txt"))
            {
                string[] tmp = line.Split(',');
                int tmpid = Convert.ToInt32(tmp[0]);
                string tmpname = tmp[1];
                string tmpSurname = tmp[2];
                decimal tmpWage = Convert.ToDecimal(tmp[3]);
                employees[counter] = new Employee(tmpid, tmpname, tmpSurname, tmpWage);
                counter++;
            }
        }
        public Employee[] GetAllEmployees()
        {
            return employees; 
        }
        public bool IdExists(int id)
        { 
            foreach (var item in employees)
            {
                
                if (id == item.ID)
                    return true;
            }
            return false;
        }
        // comment
        //Den katalaveno ti ennoeis edo
        public Employee SearchById(int id)
        {
            foreach (var item in employees)
            {
                if (IdExists(id))
                    return item;
            }
            return null;
        }
        public bool NameExists(string name)
        {
            foreach (var item in employees)
            {
                if (name == item.Name)
                    return true;
            }
            return false;
        }
        public Employee SearchByName(string name)
        {
            foreach (var item in employees)
            {
                if (NameExists(name))
                    return item
                        ;
            }
            return null;
        }

        public bool SurNameExists(string surname)
        {
            foreach (var item in employees)
            {
                if (surname == item.SurName)
                    return true;
            }
            return false;
        }
        public Employee SearchBySurname(string surname)
        {
            foreach (var item in employees)
            {
                if (SurNameExists(surname))
                    return item;
            }
            return null;
        }

        public Employee LessWage(decimal wage)
        {
            foreach (var item in employees)
            {
                if (item.Wage <= wage)
                    return item;
            }
            return null;
        }
        public Employee MoreWage(decimal wage)
        {
            foreach (var item in employees)
            {
                if (item.Wage >= wage)
                    return item;
            }
            return null;
        }
        

    }
}
