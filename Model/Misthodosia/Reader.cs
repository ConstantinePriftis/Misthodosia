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
            employees = new Employee[5];
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
                //edo thelei allagei
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

    }
}
