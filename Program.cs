using System;

namespace EmployeeWage
{
    public class EmpWageBuilderObject
    {
        // Constants
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;

        private string company;
        private int empWagePerHour;
        private int numOfWorkingHours;
        private int maxHrsInMonth;
        private int totalEmpWage;

        public EmpWageBuilderObject(string company, int empWagePerHour, int numOfWorkingHours, int maxHrsInMonth)
        {
            this.company = company;
            this.empWagePerHour = empWagePerHour;
            this.numOfWorkingHours = numOfWorkingHours;
            this.maxHrsInMonth = maxHrsInMonth;
        }
        public void computeEmpWage()
        {
            // Variables
            int empHours = 0, totalEmphrs = 0, totalWorkingDays = 0;


            //computation
            while (totalEmphrs < maxHrsInMonth && totalWorkingDays < numOfWorkingHours)
            {
                totalWorkingDays++;
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case IS_PART_TIME:
                        empHours = 4;
                        break;
                    case IS_FULL_TIME:
                        empHours = 8;
                        break;
                    default:
                        empHours = 0;
                        break;

                }
                totalEmphrs += empHours;
                Console.WriteLine("Days#:" + totalWorkingDays + " Emp Hrs: " + empHours);
            }
            int totalEmpWage = totalEmphrs * empWagePerHour;
            Console.WriteLine("Total Emp Wage for company: " + company + " is: " + totalEmpWage + "\n");
            
        }
        public string toString()
        {
            return "Total Emp Wage for company: " + this.company + " is: " + this.totalEmpWage;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            EmpWageBuilderObject dMart = new EmpWageBuilderObject("DMart", 20, 2, 10);  
            EmpWageBuilderObject reliance = new EmpWageBuilderObject("Reliance", 10, 4, 20);
            dMart.computeEmpWage();
            Console.WriteLine(dMart.toString());
            reliance.computeEmpWage();
            Console.WriteLine(reliance.toString());
        }
    }
}
