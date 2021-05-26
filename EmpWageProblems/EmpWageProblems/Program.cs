using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWageProblems
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Employee Wage Program"); //main
            EmployeWageProblem EmployeeWage = new EmployeWageProblem();
            EmployeeWage.Attendance();
            Console.ReadKey();
        }

    }
}