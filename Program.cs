using System;

namespace EmployeeWage
{
    class Program
    {
        // Constants
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;
        public static int computeEmpWage(string company, int empWagePerHour, int numOfWorkingHours, int maxHrsInMonth)
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
            Console.WriteLine("Total Emp Wage for company: "+ company+" is: " + totalEmpWage + "\n");
            return totalEmpWage;
        }
        static void Main(string[] args)
        {
            computeEmpWage("Dmart",20,2,10);
            computeEmpWage("Reliance", 10, 4, 20);
        }
    }
}
