using System;

namespace Memoria
{
    class Program
    {
        static void Main(string[] args)
        {
            bool errar = false;
            Console.WriteLine("Bem vindo ao jogo da memoria");
            while (errar == false)
            {
                int count = leitor.Count();
                if (count == 0)
                {
                    Console.WriteLine("Adicione a primeira palavra a sua lista");
                    leitor.write(Console.ReadLine()); 
                } else {
                    string[] lines = leitor.itens();
                    Random rand = new Random();
                    int guess = rand.Next(0, count);
                    string ans = lines[guess];
                    guess += 1;
                    System.Console.WriteLine("Qual foi a palavra que escreveu na posição: " + guess);
                    string res = Console.ReadLine();
                    if (res == ans)
                    {
                        Console.WriteLine("acertou");
                        Console.WriteLine("Adicione outra palavra a sua lista");
                        leitor.write(Console.ReadLine());
                    } else
                    {
                        Console.WriteLine("Errou");
                        errar = true;
                    }
                }
            }   
        }
    }
}
 