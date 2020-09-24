namespace miniGame
{
    public class Player
    {
        public string name {get; set;}
        public int classe {get; set;}
        public int level {get; set;} = 0;
        public float Xp {get;set;} = 0;
        public int Hp {get;set;} = 100;

        public int Damage(int dam){
            return Hp = Hp - dam;
        }
        public int Heal(int H){
            if (Hp == 100)
            {
                return 0;
            }
            return Hp = Hp + H;
        }
        public float xpUp(int up){
            return Xp = Xp + up;
        }
        public int levelUp(int up){
            return level = level + up;
        }
    }
}