using System;
using popQuiz.Entities;
namespace popQuiz
{
    class Program
    {
        static void Main(string[] args)
        {
            quiz q = new quiz();
            System.Console.WriteLine("Start the game, create new questions or edit . \nStart/New/Edit");
            string res = Console.ReadLine().ToUpper();
            if (res == "START")
            {
                string[] quiz = q.getQuiz();
                System.Console.WriteLine("The question is: " + quiz[1] + "\nWho is he: ");
                string guess = Console.ReadLine();
                if(guess.ToUpper() == quiz[0].ToUpper()){
                    System.Console.WriteLine("you are right it is " +quiz[0]);
                }
            } else if (res == "NEW"){
                q.createQuiz();
            } else if (res == "EDIT")
            {
                q.changeQuestion();
            }
        }
    }
}