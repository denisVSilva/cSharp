using System;

namespace diceRoll
{
    class Program
    {
        static void Main(string[] args)
        {
            Dice diceR = new Dice();
            System.Console.WriteLine("the max number that your dice can roll");
            diceR.roll = int.Parse(Console.ReadLine());
            System.Console.WriteLine("you want to add or subtract numbers from the result? (y/n)");
            string ans = Console.ReadLine();
            if (ans == "y")
            {
                System.Console.WriteLine("(plus or sub)");
                ans = Console.ReadLine();
                if (ans == "plus")
                {
                    System.Console.WriteLine("how much?");
                    diceR.num = int.Parse(Console.ReadLine());
                    System.Console.WriteLine(diceR.plus());
                } else if (ans == "sub"){
                    System.Console.WriteLine("how much?");
                    diceR.num = int.Parse(Console.ReadLine());
                    System.Console.WriteLine(diceR.min());
                }
            }else
            {
                System.Console.WriteLine(diceR.none());
            }

        }
    }
}
