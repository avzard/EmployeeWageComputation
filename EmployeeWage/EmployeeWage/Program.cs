using System;

namespace EmployeeWage
{
    class Program
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;
        public const int EMP_RATE_PER_HOUR = 20;
        public const int NUM_OF_WORKING_DAYS = 20;

        static void Main(string[] args)
        {
            int empHrs = 0, empWage = 0, totalEmpWages = 0;
            Console.WriteLine("Welcome To Employee Wage Computation");
            for (int day = 0; day <= NUM_OF_WORKING_DAYS; day++)
            {
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case IS_PART_TIME:
                        empHrs = 4;
                        break;
                    case IS_FULL_TIME:
                        empHrs = 8;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                empWage = empHrs * EMP_RATE_PER_HOUR;
                totalEmpWages += empWage;
                Console.WriteLine("Emp Wages : " + empWage);
            }
            Console.WriteLine("Total_Monthly_Wages : " + totalEmpWages);
        }
    }
}