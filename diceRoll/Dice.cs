using System;

namespace diceRoll
{
    public class Dice
    {
        public int roll {get; set;}
        public int num {get; set;}
        public int plus(){
            Random rand = new Random();
            int dice = rand.Next(1, roll + 1);
            return dice + num;

        }
        public int min(){
            Random rand = new Random();
            int dice = rand.Next(1, roll);
            return dice - num;
        }
        public int none(){
            Random rand = new Random();
            int dice = rand.Next(1, roll);
            return dice;
        }
    }
}