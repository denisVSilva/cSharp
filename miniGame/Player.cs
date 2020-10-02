namespace miniGame
{
    public class Player
    {
        public string name {get; set;}
        public int classe {get; set;}
        public int level {get; set;} = 0;
        public float Xp {get;set;} = 0;
        public int Hp {get;set;} = 100;

        public void Damage(int dam){
            Hp = Hp - dam;
        }
        public void Heal(int H){
            if (Hp < 100)
            {
                Hp = Hp + H;
            } 
            if (Hp > 100){
                Hp = 100;
            }
            
        }
        public void xpUp(int up){
            Xp = Xp + up;
        }
        public void levelUp(int up){
            level = level + up;
        }

        public int attack(string f){
            if (classe == 1)
            {
                if (f == "corte")
                {
                    return 5;
                }
            }
            if (classe == 2)
            {
                if (f == "ataque magico")
                {
                    return 5;
                }
            }
            if (classe == 3)
            {
                if (f == "esfaquear")
                {
                    return 2;
                }
            }
        }

    }
}