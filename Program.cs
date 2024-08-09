using System;

namespace Employee
{

    class Program
    {
        static void Main(string[] args)
        {
            //Constants
            int INT_FULL_TIME = 1;
            int EMP_RATE_PER_HOUR = 20;

            //Variables
            int empHours = 0;
            int empWage = 0;
            Random random = new Random();

            int empCheck = random.Next(0, 2);

            if (empCheck == INT_FULL_TIME)
            {
                Console.WriteLine("Employee is Present");
                empHours = 8;
            }
            else
            {
                Console.WriteLine("Employee is Absent");
                empHours = 0;
            }
            empWage = empHours * EMP_RATE_PER_HOUR;
            Console.WriteLine(empWage);
        }
    }
}
