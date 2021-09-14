using System;

namespace Employee_wage2
{
    class Program
    {  //program uses object to call methods
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to employee wage problem!");
            Console.WriteLine("****************************************************************");
            Console.WriteLine("Output of UC1");
            Console.WriteLine("Check employee's attendance:");
            UC1_Empattendance obj1 = new UC1_Empattendance(); // creating object
                obj1.get_attendance();
          
            Console.WriteLine("****************************************************************");
            
            Console.WriteLine("Output of UC2");
            Console.WriteLine("Get wage of employee fulltime :");
            UC2_Empwage obj2 = new UC2_Empwage();
            obj2.get_wage();
         
            Console.WriteLine("***************************************************************");

            Console.WriteLine("Output of UC3");
            Console.WriteLine("Get wage of employee fulltime and part time :");
            UC3_Parttime_wage obj3 = new UC3_Parttime_wage();
                obj3.get_parttimewage();
           
            Console.WriteLine("****************************************************************");

            Console.WriteLine("Output of UC4");
            Console.WriteLine("Get wage of employee fulltime and part time using switch case :");
            UC4_switch obj4 = new UC4_switch();
            obj4.get_switchwage();
            Console.WriteLine("*****************************************************************");

            Console.WriteLine("Output of UC5");
            Console.WriteLine("Get wage of employee wage for 20 days in month :");
            UC5_wagesfor20days obj5 = new UC5_wagesfor20days();
            obj5.wage_20day();
            Console.WriteLine("*****************************************************************");

            Console.WriteLine("Output of UC6");
            Console.WriteLine("Get wage of employee wage for max 100 hours and till 20 days in month :");
            UC6_Wagetill100Hrsor20days obj6 = new UC6_Wagetill100Hrsor20days();
            obj6.wage_20day();
            Console.WriteLine("****************************************************************");

            Console.WriteLine("Output of UC7");
            Console.WriteLine("Get wage of employee using return mehod:");
            UC7_wageclassmethod obj7 = new UC7_wageclassmethod();
            obj7.wage_classmethod();
          

            
            Console.WriteLine("***************************************************************");
            Console.WriteLine("Output of UC8");
            Console.WriteLine("Get wage of employee using parameters:");
            UC8_withparameters obj8 = new UC8_withparameters();
            obj8.wage_withparams("xyz", 10, 2, 8);
            Console.ReadKey();
        }
    }
}
