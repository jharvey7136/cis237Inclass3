using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237Inclass3
{
    class Program
    {
        static void Main(string[] args)
        {
            SalaryEmployee salaryEmployee = new SalaryEmployee("Ringo", "DeathStarr", "IT", 15000m);




            Console.WriteLine(salaryEmployee.ToString());

            Console.WriteLine(salaryEmployee.CalculateWeeklyGross());

            Console.WriteLine(salaryEmployee.GetDepartmentTwice());


            Console.WriteLine("*********************");

            HourlyEmployee hourlyEmployee = new HourlyEmployee("Funny", "Trips", "IT", 8.37m);
            hourlyEmployee.HoursWorked = 40;

            Console.WriteLine(hourlyEmployee.ToString());
            Console.WriteLine(hourlyEmployee.CalculateWeeklyGross());

            Console.WriteLine(hourlyEmployee.GetDepartmentTwice());

            Console.WriteLine("*************NEW SHIT***************");

            HourlyEmployee joe = new HourlyEmployee("Joe", "Dirtbag", "HR", 9.37m);
            joe.HoursWorked = 87;
            SalaryEmployee dick = new SalaryEmployee("Dick", "Head", "PR", 15000m);
            Employee ronald = new SalaryEmployee("Mrs.", "Ronfonbob", "IT", 42369m);

            IEmployee newPerson = new HourlyEmployee("Some", "OneElse", "WK", 12.43m);

            
            //downcast from type iemployee to type hourly employee
            HourlyEmployee myStack;
            myStack = (HourlyEmployee)newPerson;

            dick.CompareTo(joe);


            IEmployee[] employeeList = {
                                           joe,
                                           dick,
                                           new SalaryEmployee("Ben", "Dover", "ST", 99075m),
                                           ronald
                                       };
            foreach(IEmployee employee in employeeList)
            {
                Console.WriteLine(employee.ToString());
                Console.WriteLine(employee.CalculateWeeklyGross());
                Console.WriteLine();

            }


            Console.ReadKey();
        }
    }
}
