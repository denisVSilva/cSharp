namespace miniGame
{
    public class enemy
    {
        public string name {get; set;}
        public int Hp {get; set;}
        public int damage {get; set;}

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
       
    }
}