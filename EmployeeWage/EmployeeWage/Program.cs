using System;

namespace EmployeeWage
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome To Employee Wage Computation");

            //UC10_EmployeeWage For Multiple Company Using Interface Approch           
            EmpBuilderArray empWageBuilder = new EmpBuilderArray();
            empWageBuilder.addComapnyEmpWage("DMart", 20, 2, 10);
            empWageBuilder.addComapnyEmpWage("Relience", 10, 4, 20);
            empWageBuilder.computeEmpWage();

        }
    }
}