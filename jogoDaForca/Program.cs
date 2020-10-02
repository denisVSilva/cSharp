using System;
using jogoDaForca.Entities;
namespace jogoDaForca
{
    class Program
    {
        static void Main(string[] args)
        {
            Words word = new Words();
            string ans = word.getWord();
            char[] guess = new char[ans.Length];
            bool start = true;
            if (start == true)
            {
                for (int i = 0; i < ans.Length; i++){
                    char space = ' ';
                    if (ans[i].Equals(space)){
                        guess[i] = ' ';
                    } else {
                        guess[i] = '-';
                    }
                }
            }
            start = false;
            bool game = true;
            while (game)
            {  
                foreach (char words in guess){
                    System.Console.Write(words);
                }
                System.Console.WriteLine("\nguess a word");
                string wordy = Console.ReadLine();
                int count = 0;
                foreach (char w in wordy) {
                    count++;
                }
                if (count > 1)
                {
                    System.Console.WriteLine("1 letter at an time");
                } else{
                    count = 0;
                    foreach (char words in ans){
                        if(words == char.Parse(wordy)) {
                            guess[count] = char.Parse(wordy);
                            }
                        count++;
                        }
                    string guessing = new string(guess);
                    if (guessing == ans){
                        System.Console.WriteLine("congratulations");
                        game = false;
                        System.Console.WriteLine("you winned: " + word.save());
                        
                    }
                } 
            }
        }
    }
}
