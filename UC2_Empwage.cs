using System;
using System.Collections.Generic;
using System.Text;

namespace Employee_wage2
{
    class UC2_Empwage
    {
        public  void get_wage()
        {
            int is_fulltime = 1;
            int emp_rateperhour = 20;
            //variables
            int emphrs = 0;
            int empwage = 0;
            Random random = new Random();
            int empcheck = random.Next(0, 2);
            if (empcheck == is_fulltime)
            {
                emphrs = 8;
                Console.WriteLine("Employee is full time and total hours=" + emphrs);
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
