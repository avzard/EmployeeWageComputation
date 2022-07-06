using System;

namespace EmployeeWage
{
    class Program
    {
        static void Main(string[] args)
        {
            int IS_FULLTIME = 1;
            int EMP_RATE_PER_HOUR = 20;
            int empHrs = 0;
            int empWages = 0;
            Random rand = new Random();
            int empChek = rand.Next(1, 3);
            Console.WriteLine("Welcome To Employee Wage Computation");
            if (empChek == IS_FULLTIME)
            {
                empHrs = 8;
            }
            else
            {
                empHrs = 0;
            }
            empWages = empHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Total_Employee_Wages : " + empWages);
        }
    }
}