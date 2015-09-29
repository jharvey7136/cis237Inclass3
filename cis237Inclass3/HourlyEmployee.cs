using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237Inclass3
{
    class HourlyEmployee : Employee
    {

        private decimal hourlyRate;
        private double hoursWorked;



        public decimal HourlyRate
        {
            get { return hourlyRate; }
            set { hourlyRate = value; }
        }

        public double HoursWorked
        {
            get { return hoursWorked; }
            set { hoursWorked = value; }
        }


        public HourlyEmployee(string FirstName, string LastName, string Department, decimal HourlyRate) : base(FirstName, LastName, Department)
        {
            this.hourlyRate = HourlyRate;

        }

        public override string ToString()
        {
            return base.ToString() + " " + hourlyRate.ToString("C");
        }



        public decimal CalculateWeeklyGross()
        {
            return hourlyRate * (decimal)hoursWorked;


        }
    }
}
