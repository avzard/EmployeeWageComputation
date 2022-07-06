using System;

namespace EmployeeWage
{
    class Program
    {
        static void Main(string[] args)
        {
            //UC14_Geting TotalWages by company Name
            Console.WriteLine("Welcome To Employee Wage Computation");
            EmpBuilderArray empWageBuilder = new EmpBuilderArray();
            empWageBuilder.addCompanyEmpWage("DMart", 20, 2, 10);
            empWageBuilder.addCompanyEmpWage("Relience", 20, 5, 20);
            empWageBuilder.computeEmpWage();
            Console.WriteLine("Total Wage for DMart Comapny " + empWageBuilder.getTotalWage("DMart"));
            Console.WriteLine("Total Wage for Relience Comapny " + empWageBuilder.getTotalWage("Relience"));
        }
    }
}