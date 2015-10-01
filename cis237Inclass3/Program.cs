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
            SalaryEmployee salaryEmployee = new SalaryEmployee("Ringo", "DeathStarr", "IT", 15000);




            Console.WriteLine(salaryEmployee.ToString());

            Console.WriteLine(salaryEmployee.CalculateWeeklyGross());

            Console.WriteLine(salaryEmployee.GetDepartmentTwice());


            Console.WriteLine("*********************");

            HourlyEmployee hourlyEmployee = new HourlyEmployee("Funny", "Trips", "IT", 8.37m);
            hourlyEmployee.HoursWorked = 40;

            Console.WriteLine(hourlyEmployee.ToString());
            Console.WriteLine(hourlyEmployee.CalculateWeeklyGross());

            Console.WriteLine(hourlyEmployee.GetDepartmentTwice());

            Console.ReadKey();
        }
    }
}
