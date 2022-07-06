using System;

namespace EmployeeWage
{
    class Program
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;
        public const int EMP_RATE_PER_HOUR = 20;
        public const int NUM_OF_WORKING_DAYS = 20;
        public const int MAX_HOUR_IN_MONTH = 100;

        static void Main(string[] args)
        {

            Console.WriteLine("Welcome To Employee Wage Computation");
            Console.WriteLine("Total Emplyee Monthly Wages : " + TotalWages());

        }
        public static int TotalWages()
        {
            int empHrs = 0, totalEmpHours = 0, totalWorkingDays = 0;
            while (totalEmpHours <= MAX_HOUR_IN_MONTH && totalWorkingDays <= NUM_OF_WORKING_DAYS)
            {
                totalWorkingDays++;
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
                totalEmpHours += empHrs;
                Console.WriteLine("Days : " + totalWorkingDays + "Emp Hrs : " + empHrs);
            }
            return totalEmpHours * EMP_RATE_PER_HOUR;
        }
    }
}