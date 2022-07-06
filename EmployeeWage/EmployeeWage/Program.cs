using System;

namespace EmployeeWage
{
    class Program
    {
        static void Main(string[] args)
        {
            //UC13_Storing Daily wages along with TotalWages
            Console.WriteLine("Welcome To Employee Wage Computation");
            EmpBuilderArray empWageBuilder = new EmpBuilderArray();
            empWageBuilder.addCompanyEmpWage("DMart", 20, 4, 20);
            empWageBuilder.addCompanyEmpWage("Relience", 10, 5, 20);
            empWageBuilder.computeEmpWage();

        }
    }
}