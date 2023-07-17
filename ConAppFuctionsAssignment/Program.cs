using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppFuctionsAssignment
{
    public class SalaryCalc
    {
        //Calculate salary for any employee
        public int CalculateSal(int wHour, int wDays, int projectHandles = 1, int extras = 0)
        {
            return wHour * wDays * 100 + projectHandles * 3000 + extras * 2000;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please choose employee type whose salary is to be calculated from the following: ");
            Console.WriteLine("HR -> 1");
            Console.WriteLine("Admin -> 2");
            Console.WriteLine("Software Developer -> 1");
            Console.WriteLine("Enter your choice");
            int choice = int.Parse(Console.ReadLine());
            //initialisation of variables to be passed to function for salary calculation
            int wHour, wDays, projectHandles, extras;
            SalaryCalc salaryCalc = new SalaryCalc();
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter Working Hours");
                    wHour = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter number of Working Days");
                    wDays = int.Parse(Console.ReadLine());
                    int hrSalary = salaryCalc.CalculateSal(wHour, wDays);
                    Console.WriteLine("HR Monthly Salary is: \t" + hrSalary);
                    break;
                case 2:
                    Console.WriteLine("Enter Working Hours");
                    wHour = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter number of Working Days");
                    wDays = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter number of Project Handles");
                    projectHandles = int.Parse(Console.ReadLine());
                    int adminSalary = salaryCalc.CalculateSal(wHour, wDays, projectHandles);
                    Console.WriteLine("Admin Monthly Salary is: \t" + adminSalary);
                    break;
                case 3:
                    Console.WriteLine("Enter Working Hours");
                    wHour = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter number of Working Days");
                    wDays = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter number of Project Handles");
                    projectHandles = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter number of Extras");
                    extras = int.Parse(Console.ReadLine());
                    int devSalary = salaryCalc.CalculateSal(wHour, wDays, projectHandles, extras);
                    Console.WriteLine("Software Devloper Monthly Salary is: \t" + devSalary);
                    break;
                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }
            Console.ReadKey();
        }
    }
}
