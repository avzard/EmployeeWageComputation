using System;

namespace EmployeeWage
{
    class Program
    {
        static void Main(string[] args)
        {
            //UC12_Managing EmpWages Using LinkedList 
            Console.WriteLine("Welcome To Employee Wage Computation");
            EmpBuilderArray empWageBuilder = new EmpBuilderArray();
            empWageBuilder.addCompanyEmpWage("DMart", 20, 4, 20);
            empWageBuilder.addCompanyEmpWage("Relience", 10, 5, 20);
            empWageBuilder.computeEmpWage();
            Console.WriteLine("Total Wage for DMart Comapny " + empWageBuilder.getTotalWage("DMart"));
            Console.WriteLine("Total Wage for Relience Comapny " + empWageBuilder.getTotalWage("Relience"));

        }
    }
}