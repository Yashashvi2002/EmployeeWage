using System;

namespace EmployeeWage
{
    class Program
    {
        // Constants
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;
        public const int EMP_WAGE_PER_HOUR = 20;
        public const int NUM_OF_WORKING_DAYS = 2; //Change as per requirement i.e 20
        public const int MAX_HRS_IN_MONTH = 10; //Change as per requirement i.e 100
        public static int ComputeEmpWage()
        {
            // Variables
            int empHours = 0, totalEmphrs = 0, totalWorkingDays = 0;


            //computation
            while (totalEmphrs < MAX_HRS_IN_MONTH && totalWorkingDays < NUM_OF_WORKING_DAYS)
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
            int totalEmpWage = totalEmphrs * EMP_WAGE_PER_HOUR;
            Console.WriteLine("Total Emp Wage: " + totalEmpWage);
            return totalEmpWage;
        }
        static void Main(string[] args)
        {
            ComputeEmpWage();
        }
    }
}
