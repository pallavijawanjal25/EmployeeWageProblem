using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmploeeWageProblme
{
   static  class UC_First_EmployeeAttendance
    {
        public static void Emp_Attendance()
        {
            int IS_FULL_TIME = 1;
            Random random = new Random();
            int empCheck = random.Next(0, 2);
            if (empCheck == IS_FULL_TIME)
            {
                Console.WriteLine("Employee is present");
            }
            else
                Console.WriteLine("Employee is absent");
            Console.ReadKey();
        }

    }
}
    

