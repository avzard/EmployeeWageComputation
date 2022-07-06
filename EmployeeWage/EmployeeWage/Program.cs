using System;

namespace EmployeeWage
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Employee Wage Computation");
            int isFullTime = 1;
            Random rand = new Random();
            int rn = rand.Next(1, 3);
            if (isFullTime == 1)
                Console.WriteLine("Employee Is Presnet");
            else
                Console.WriteLine("Employee Absent");
        }
    }
}