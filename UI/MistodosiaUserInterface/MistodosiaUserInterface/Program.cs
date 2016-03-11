using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Misthodosia;


namespace MistodosiaUserInterface
{
    class Program
    {

       
        static void Main(string[] args)
        {
            startGui();
        }

        public static void startGui()
        {
            Console.WriteLine("Mistodosia");
            Console.WriteLine("Press 1 to show all the employees or Press 2 to search by type...");
            string s = Console.ReadLine();

            switch (s)
            {
                case "1":
                    printAllEmployees();
                    break;

                case "2":
                    searchEmployee();
                    break;

                default:
                    Console.WriteLine("Goodbye!");
                    break;
            }
            Console.ReadLine();
        }

        public static void printAllEmployees()
        {
            Reader rd = new Reader();
            Console.WriteLine(rd.GetAllEmployees());
            foreach (var item in rd.GetAllEmployees())
            {
                Console.WriteLine(item.ID + " " + item.Name + " " + item.SurName + " " + item.Wage);
            }
        }

        public static void searchEmployee()
        {
            Reader rd = new Reader();
            Console.WriteLine("Search by 'id' or 'name' or 'surname' or 'greater/less salary'");
            string s = Console.ReadLine();
            switch (s)
            {
                    //test com
                case "id":
                    Console.WriteLine("Type the ID");
                    string tmpID = Console.ReadLine();
                    int id = Convert.ToInt32(tmpID);
                    Employee tmp = rd.SearchById(id);
                    Console.WriteLine(tmp.ToString());
                    
                    break;

                case "name":
                    Console.WriteLine("Type the Name");
                    string tmpName = Console.ReadLine();
                    Employee tmp4 = rd.SearchByName(tmpName);
                    Console.WriteLine(tmp4.ToString());

                    break;

                case "surname":
                    Console.WriteLine("Type the Surname");
                    string tmpSurname = Console.ReadLine();
                    //Console.WriteLine(rd.SearchById(tmpSurname));
                    Employee tmp5 = rd.SearchBySurname(tmpSurname);
                    Console.WriteLine(tmp5.ToString());

                    break;

                case "greater salary":
                    Console.WriteLine("Type the amound");
                    string tmp2 = Console.ReadLine();
                    decimal tmpDec = Convert.ToDecimal(tmp2);
                   // rd.MoreWage(tmpDec);
                    List<Employee> listTmp = rd.MoreWage(tmpDec);

                    foreach (var item in listTmp)
                    {
                        Console.WriteLine(item.ToString());
                    }

                    break;

                case "less salary":
                    Console.WriteLine("Type the amound");
                    string tmp3 = Console.ReadLine();
                    decimal tmpDec2 = Convert.ToDecimal(tmp3);
                    Console.WriteLine(tmpDec2);
                    
                    break;

                default:
                    Console.WriteLine("Invalid word...");
                    break;
            }
        }
    }
}
