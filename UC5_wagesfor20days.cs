using System;
using System.Collections.Generic;
using System.Text;

namespace Employee_wage2
{
    class UC5_wagesfor20days
    {
        public const int is_parttime = 1;

        public const int is_fulltime = 2;
        public const int emp_rateperhour = 20;
        public const int num_workingdays = 20;
        public  void wage_20day()
        {
            int emphrs = 0;
            int empwage = 0;
            int total = 0;
            Random random = new Random();
            int empcheck = random.Next(0, 3);
            for (int day = 0; day < num_workingdays; day++)
            {
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
            total = total +empwage;
                Console.WriteLine("Day#: " + day + " Employee Hours : " + emphrs);
                Console.WriteLine(".........................................................");


            }
            Console.WriteLine("Total Employee Wage: " + total);
        }
    }
}
