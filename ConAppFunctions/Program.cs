using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppFunctions
{
    //public class OurClass
    //{
    //    //instance method return type void and no parameters
    //    public void Display()
    //    {
    //        Console.WriteLine("Welcome to Methods!!");
    //    }

    //    //static method
    //    public static void Welcome()
    //    {
    //        Console.WriteLine("Static method welcomes you!!");
    //    }
    //    //method to return double and take two parameters
    //    public double Add(double n1, double n2)
    //    {
    //        double result;
    //        result = n1 + n2;
    //        return result;
    //    }
    //}

    //call by value
    //public class Calc
    //{
    //    public void Increment(int num)
    //    {
    //        Console.WriteLine("Value of num inside method before increment: \t" + num);
    //        num += 5;
    //        Console.WriteLine("Value of num inside method after increment: \t" + num);
    //    }
    //}

    //call by reference
    //public class Calc
    //{
    //    public void Increment(ref int num)
    //    {
    //        Console.WriteLine("Value of num inside method before increment: \t" + num);
    //        num += 5;
    //        Console.WriteLine("Value of num inside method after increment: \t" + num);
    //    }
    //}
    public class Calc
    {
        //public void BonusCalc(double salary, ref double bonus)
        //{
        //    bonus = salary * 0.2;
        //}
        public double Add(params double[] numbers)
        {
            double total = 0;
            foreach (double number in numbers) { 
            total += number;}
            return total;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //OurClass obj = new OurClass();
            //obj.Display();
            //OurClass.Welcome();
            //OurClass ourClass = new OurClass();
            //double num1, num2;
            //Console.WriteLine("Enter first number");
            //num1 = double.Parse(Console.ReadLine());
            //Console.WriteLine("Enter second number");
            //num2 = double.Parse(Console.ReadLine());
            //Console.WriteLine("Result after addtion is \t" + ourClass.Add(num1, num2));

            //int myNum;
            //Console.WriteLine("Enter a number");
            //myNum = int.Parse(Console.ReadLine());
            //Console.WriteLine("Value of myNum in main before method is called: \t" + myNum);
            //Calc calc = new Calc();
            //calc.Increment(myNum);
            //Console.WriteLine("Value of myNum in main after method is called: \t" + myNum);
            //int myNum;
            //Console.WriteLine("Enter a number");
            //myNum = int.Parse(Console.ReadLine());
            //Console.WriteLine("Value of myNum in main before method is called: \t" + myNum);
            //Calc calc = new Calc();
            //calc.Increment(ref myNum);
            //Console.WriteLine("Value of myNum in main after method is called: \t" + myNum);

            //double salary = 50000;
            //double bonus = 500;
            //Calc calc = new Calc();
            //calc.BonusCalc(salary, ref bonus);
            //Console.WriteLine($"Salary is \t {salary} \nBonus is \t {bonus}");

            Calc calc = new Calc();
            Console.WriteLine("Result after adding 1,12,23.5 is: \t" + calc.Add(1, 12, 23.5));
            Console.WriteLine("Result after adding 69,64,20.48,1.6 is: \t" + calc.Add(69, 64, 20.48, 1.6));
            Console.ReadKey();
        }
    }
}
