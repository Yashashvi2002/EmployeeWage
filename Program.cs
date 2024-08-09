using System;

namespace EmployeeWage
{
    class Program
    {
        // Constants
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;
        public const int EMP_WAGE_PER_HOUR = 20;
        public const int NUM_OF_WORKING_DAYS = 20;//Change working days as per requirement

        static void Main(string[] args)
        {
            // Variables
            int empHours = 0;
            int empWage = 0;
            int totalEmpWage = 0;

            for (int day = 0; day < NUM_OF_WORKING_DAYS; day++)
            {
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case IS_FULL_TIME:
                        empHours = 8;
                        break;
                    case IS_PART_TIME:
                        empHours = 4;
                        break;
                    default:
                        empHours = 0;
                        break;
                }
                empWage = empHours * EMP_WAGE_PER_HOUR;
                totalEmpWage += empWage;
                Console.WriteLine("Employee Wage: " + empWage);
            }
            Console.WriteLine("Total Emp Wage: " + totalEmpWage);
        }
    }
}
