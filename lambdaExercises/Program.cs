using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lambdaExercises
{
    class Program
    {
        
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee { fName = "Joe", lName = "Davis", Id = 21},
                new Employee { fName = "Mark", lName = "Simpson", Id = 22},
                new Employee { fName = "Timothy", lName = "Webber", Id = 23},
                new Employee { fName = "Joe", lName = "Junior", Id = 24},
                new Employee { fName = "Steven", lName = "Stevens", Id = 25},
                new Employee { fName = "Amy", lName = "Thorne", Id = 26},
                new Employee { fName = "Sara", lName = "Sandau", Id = 27 },
                new Employee { fName = "Michelle", lName = "Forester", Id = 28 },
                new Employee { fName = "Jane", lName = "Smith", Id = 29 },
                new Employee { fName = "Valerie", lName = "Cooper", Id = 30}


            };

            
            List<Employee> tempList = new List<Employee>();

            foreach (var emp in employees)
            {
                if (emp.fName == "Joe" )
                {
                    tempList.Add(emp);
                    Console.WriteLine(emp.fName + " " + emp.lName + " " + emp.Id);

                }
            }

            List<Employee> tempList2 = employees.Where(x => x.fName == "Joe").ToList();
            foreach (Employee emp in tempList2)
            {
                Console.WriteLine(emp.fName);

            }
            


            List<Employee> tempList3 = employees.Where(x => x.Id > 5).ToList();
            foreach (Employee emp in tempList3)
            {
                Console.WriteLine(emp.fName + " " + emp.lName + " " + emp.Id);

            }
            Console.ReadLine();
        
        }
       
    }
}
