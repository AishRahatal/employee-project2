using System;
using System.Collections.Generic;
using System.Text;

namespace Employee_wage2
{
    class UC1_Empattendance
    {
        public  void get_attendance()
        {
            int is_fulltime = 1;

            Random random = new Random();
            int empcheck = random.Next(0, 2);

            if (empcheck == is_fulltime)
            {

                Console.WriteLine("Employee is present");
            }
            else
            {
                Console.WriteLine("Employee is absent");
                Console.ReadKey();
            }
        }
    }
}
