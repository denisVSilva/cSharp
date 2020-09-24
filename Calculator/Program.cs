using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            bool calc = false;
            System.Console.WriteLine("Give me a type of calculation from 1 to 3");
            System.Console.WriteLine("1. sum");
            System.Console.WriteLine("2. sub");
            System.Console.WriteLine("3. mult");
            int result = int.Parse(System.Console.ReadLine());
            System.Console.WriteLine("Give me the first number");
            int Fnum = int.Parse(System.Console.ReadLine());
            System.Console.WriteLine("Give me the Second number");
            int Snum = int.Parse(System.Console.ReadLine());
             
            switch (result)
            {
                case 1:
                result = Calculation.Sum(Fnum,Snum);
                calc = true;
                break;
                case 2:
                result = Calculation.Sub(Fnum,Snum);
                calc = true;
                break;
                case 3:
                result = Calculation.Mult(Fnum,Snum);
                calc = true;
                break;
                default:
                System.Console.WriteLine("calculation do not exist");
                break;
            }
            if (calc){
                System.Console.WriteLine(result);
            }
        }
    }
}
