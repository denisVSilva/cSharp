using System;

namespace miniGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            Console.WriteLine("Bem vindo ao mundo de arcadia.");
            Console.ReadKey();
            bool valido = false;
            while (valido == false)
            {
                Console.WriteLine("Qual é o seu nome:");
                player.name = Console.ReadLine();
                foreach (char word in player.name){
                if (word != ' ')
                {
                    valido = true;
                }
            }
            }
            Console.WriteLine("Otimo, bem vindo ao mundo de arcadia mr/mrs " + player.name);
            Console.ReadKey();
            Console.WriteLine("Nesse mundo a varias inumeras classes diferentes.");
            Console.ReadKey();
            System.Console.WriteLine("do mais poderoso cavaleiro, cuja espada perfura atraves do mal");
            Console.ReadKey();
            System.Console.WriteLine("quanto o mago mais habilidoso nas artes arcanas");
            Console.ReadKey();
            System.Console.WriteLine("e por ultimo Ladino de mãos e laminas tão ageis que são como o vento.");
            Console.ReadKey();
            System.Console.WriteLine("sua jornada começa com uma escolha, qual é sua classe");
            Console.ReadKey();
            valido = false;
            while (valido == false)
            {
                Console.WriteLine("escolha pelo numero");
                System.Console.WriteLine("1* Cavaleiro");
                System.Console.WriteLine("2* Mago");
                System.Console.WriteLine("3* Ladino");
                /* null Crash */
                player.classe = int.Parse(Console.ReadLine());
                if (player.classe <= 3 && player.classe >= 0)
                {
                    valido = true;
                }
            }
        }
    }
}
