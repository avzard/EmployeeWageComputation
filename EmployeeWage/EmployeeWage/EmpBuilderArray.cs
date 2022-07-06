using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWage
{
    public class EmpBuilderArray : IComputeEmpWage
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;

        private int numOfComapy = 0;
        private CompanyEmpWage[] companyEmpWageArray;
        private Dictionary<string, CompanyEmpWage> companyToEmpWageMap;

        public EmpBuilderArray()
        {
            this.companyEmpWageArray = new CompanyEmpWage[5];
            this.companyToEmpWageMap = new Dictionary<string, CompanyEmpWage>();


        }

        public void addCompanyEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
        {
            companyEmpWageArray[numOfComapy] = new CompanyEmpWage(company, empRatePerHour, numOfWorkingDays, maxHoursPerMonth);
            CompanyEmpWage companyEmpWage = new CompanyEmpWage(company, empRatePerHour, numOfWorkingDays, maxHoursPerMonth);
            companyToEmpWageMap.Add(company, companyEmpWage);
            numOfComapy++;
        }

        public void computeEmpWage()
        {
            for (int i = 0; i < numOfComapy; i++)
            {
                companyEmpWageArray[i].setTotalEmpWage(this.computeEmpWage(this.companyEmpWageArray[i]));
                Console.WriteLine(this.companyEmpWageArray[i].toString());
            }
        }

        private int computeEmpWage(CompanyEmpWage companyEmpWage)

        {
            int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;
            while (totalEmpHrs <= companyEmpWage.maxHoursPerMonth && totalWorkingDays < companyEmpWage.numOfWorkingDays)
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
                totalEmpHrs += empHrs;
                Console.WriteLine("Day : " + totalWorkingDays + "Emp Hrs : " + empHrs);
            }
            return totalEmpHrs * companyEmpWage.empRatePerHour;

        }


        public int getTotalWage(string company)
        {
            Console.WriteLine("Inside GetTotalWage Method");
            int result = this.companyToEmpWageMap[company].totalEmpWage;
            Console.WriteLine("TotalWage {0}", result);
            return result;
        }
    }
}