using System;
using System.Collections.Generic;
using System.Text;


namespace EmployeeWage
{
    class EmpWageBuilder
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;

        private string company;
        private int empRatePerHour;
        private int numOfWorkingDays;
        private int maxHourPerMonth;
        private int totalEmpWages;

        public EmpWageBuilder(string v1, int v2, int v3, int v4)
        {
        }

        public EmpWageBuilder(string company, int empRatePerHour, int numOfWorkingDays, int maxHourPerMonth, int totalEmpWages)
        {
            this.company = company;
            this.empRatePerHour = empRatePerHour;
            this.numOfWorkingDays = numOfWorkingDays;
            this.maxHourPerMonth = maxHourPerMonth;
            this.totalEmpWages = totalEmpWages;
        }
        public void computeEmpWage()
        {
            int empHrs = 0, totalEmpHours = 0, totalWorkingDays = 0;
            while (totalEmpHours <= this.maxHourPerMonth && totalWorkingDays <= this.numOfWorkingDays)
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
            int totalEmpWages = totalEmpHours * this.empRatePerHour;
            Console.WriteLine("Total Emplyee Monthly Wages : " + totalEmpWages);
        }
        public string toString()
        {
            return "Total Emplyee wages for compny :" + this.company + "is : " + this.totalEmpWages;
        }
    }
}