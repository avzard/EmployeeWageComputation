using System;

namespace EmployeeWage
{
    class Program
    {
        static void Main(string[] args)
        {

            //UC11_Using Api Aproch
            Console.WriteLine("Welcome To Employee Wage Computation");
            EmpBuilderArray empWageBuilder = new EmpBuilderArray();
            empWageBuilder.addCompanyEmpWage("DMart", 20, 2, 10);
            empWageBuilder.addCompanyEmpWage("Relience", 10, 4, 20);
            empWageBuilder.computeEmpWage();
            Console.WriteLine("Total Wage for DMart Comapny " + empWageBuilder.getTotalWage("DMart"));

        }
    }
}