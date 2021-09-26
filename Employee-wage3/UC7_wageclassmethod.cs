using System;
using System.Collections.Generic;
using System.Text;

namespace Employee_wage2
{
    class UC7_wageclassmethod
    {
        public const int is_parttime = 1;

        public const int is_fulltime = 2;
        public const int emp_rateperhour = 20;
        public const int num_workingdays = 20;
        public const int max_hours = 100;
        public  int wage_classmethod()
        {
            int emphrs = 0;
            int empwage = 0;
            int totalemphrs = 0;
            int totaldays = 0;

            while (totalemphrs <= max_hours && totaldays < num_workingdays)
            {
                Random random = new Random();
                int empcheck = random.Next(0, 3);
                totaldays++;
                switch (empcheck)
                {
                    case is_parttime:
                        emphrs = 4;
                        Console.WriteLine("Employee is part time and total hours=" + emphrs);
                        break;
                    case is_fulltime:
                        emphrs = 8;
                        Console.WriteLine("Employee is full time and total hours=" + emphrs);

                        break;
                    default:
                        emphrs = 0;
                        Console.WriteLine("Employee has not fullfilled hours=" + emphrs);
                        break;
                }
                empwage = emphrs * emp_rateperhour;
                Console.WriteLine("Employee Wage: " + empwage);
                totalemphrs += emphrs;
                Console.WriteLine("Day#: " + totaldays + " Employee Hours : " + emphrs);
                Console.WriteLine(".........................................................");

            }
            int totalwage = totalemphrs * emp_rateperhour;
            Console.WriteLine("Total Employee Wage: " + totalwage);
            return totalwage;
        }
    }
}
