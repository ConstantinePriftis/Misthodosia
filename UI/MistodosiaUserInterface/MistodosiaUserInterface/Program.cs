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
            rd.PopulateEmployees();
            foreach (var item in rd.GetAllEmployees())
            {
                Console.WriteLine(item.ID + " " + item.Name + " " + item.SurName + " " + item.Wage);
            }
        }

        public static void searchEmployee()
        {
            Reader rd = new Reader();
            Console.WriteLine("Type 'id' or 'name' or 'surname' or 'salary'");
            string s = Console.ReadLine();
            switch (s)
            {
                case "id":
                    Console.WriteLine("Type the ID");
                    //if id exists print the employee
                    //else print not valid id
                    string tmpID = Console.ReadLine();
                    int id = Convert.ToInt32(tmpID);
                    //rd.SearchById(id);
                    Console.WriteLine(rd.SearchById(id));
                    
                    break;

                case "name":
                    //if name exists print the employee
                    //else print not valid id
                    Console.WriteLine("searching");
                    break;

                case "surname":
                    //if surname exists print the employee
                    //else print not valid id
                    Console.WriteLine("searching");
                    break;

                case "salary":
                    //if salary exists print the employee
                    //else print not valid id
                    Console.WriteLine("searching");
                    break;

                default:
                    Console.WriteLine("Invalid word...");
                    break;
            }
        }
    }
}
