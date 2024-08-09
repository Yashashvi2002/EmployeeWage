using System;

namespace Employee
{

    class Program
    {
        static void Main(string[] args)
        {
            //Constants
            int IS_PART_TIME = 1;
            int INT_FULL_TIME = 2;
            int EMP_RATE_PER_HOUR = 20;

            //Variables
            int empHours = 0;
            int empWage = 0;
            Random random = new Random();

            int empCheck = random.Next(0, 3);

            if (empCheck == INT_FULL_TIME)
            {
                empHours = 8;
            }
            else if (empCheck == IS_PART_TIME)
            {
                empHours = 4;

            }
            else
            {
                empHours = 0;
            }
            empWage = empHours * EMP_RATE_PER_HOUR;
            Console.WriteLine(empWage);
        }
    }
}