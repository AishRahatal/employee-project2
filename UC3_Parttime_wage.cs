using System;
using System.Collections.Generic;
using System.Text;

namespace Employee_wage2
{
    class UC3_Parttime_wage
    {
        public  void get_parttimewage()
        {
            int is_parttime = 1;
            int is_fulltime = 2;
            int emp_rateperhour = 20;
            int emphrs = 0;
            int empwage = 0;

            Random random = new Random();
            int empcheck = random.Next(0, 3);
            if(empcheck == is_parttime)
            {
                emphrs = 4;
                Console.WriteLine("Employee is part time and total hours=" + emphrs);
            }
            else if(empcheck == is_fulltime)
            {
                emphrs = 8;
                Console.WriteLine("Employee is full time and total hours="+ emphrs);
            }
            else
            {
                emphrs = 0;
                Console.WriteLine("Employee has not fullfilled hours=" + emphrs);

            }
            empwage = emphrs * emp_rateperhour;

            Console.WriteLine("Employee Wage: " + empwage);
            Console.ReadKey();
        }   

    }
}
