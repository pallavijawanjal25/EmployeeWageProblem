using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmploeeWageProblme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UC_First_EmployeeAttendance.Emp_Attendance();
            UC_Second_DailyEmpWage.EmployeeWage();
            UC3_PartTimeWage.PartTimeEmpWage();
            UC4_EmpWageUsingSwitch.EmpWageUsingSwitch();
            UC5_EmpWageForMonth.CalculateWagesFor20DaysInMonth();
            UC6_EmpWageTillHrOrReached.CalculateWageTil_HrsOr_IsReached();
        }
    }
}
