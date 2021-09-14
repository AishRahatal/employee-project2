using System;
using System.Collections.Generic;
using System.Text;

namespace Employee_wage2
{
    class UC4_switch
    {
        
            public const int is_parttime = 1;
        
        public const int is_fulltime = 2;
        public const int emp_rateperhour = 20;
        public  void get_switchwage()
        {
            //Constants

            //variables
            int emphrs = 0;
            int empwage = 0;
            Random random = new Random();
            int empcheck = random.Next(0, 3);
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
            Console.WriteLine("Emp Wage: " + empwage);
        }
    }
}
