using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3
{
    public class Worker : Human
    {
        private decimal weekSalary;
        private decimal workHoursPerDay;

        public decimal WeekSalary
        {
            get { return weekSalary; }
            set
            {
                if (value <= 10)
                {
                    throw new ArgumentException("Expected value mismatch! Argument: weekSalary");
                }

                weekSalary = value;
            }
        }

        public decimal WorkHoursPerDay
        {
            get { return workHoursPerDay; }
            set
            {
                if (value < 1 || value > 12)
                {
                    throw new ArgumentException("Expected value mismatch! Argument: workHoursPerDay");
                }

                workHoursPerDay = value;
            }
        }

        public Worker(string firstName, string lastName, decimal weekSalary, decimal workHoursPerDay)
            : base(firstName, lastName)
        {
            WeekSalary = weekSalary;
            WorkHoursPerDay = workHoursPerDay;
        }

        public decimal CalculateSalaryPerHour()
        {
            decimal salaryPerHour = WeekSalary / (WorkHoursPerDay * 5); // Assuming a 5-day workweek
            return salaryPerHour;
        }
        public override string ToString()
        {
            decimal salaryPerHour = CalculateSalaryPerHour();

            return $"First Name: {FirstName}\nLast Name: {LastName}\nWeek Salary: {WeekSalary:f2}\nHours per day: {WorkHoursPerDay:f2}\nSalary per hour: {salaryPerHour:f2}";
        }
    }
}
