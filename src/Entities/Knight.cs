namespace ProjetoGameDIO.src.Entities
{
    public class Knight : Hero
    {
        public Knight(string Name, int Level, string HeroType, int HP) : base(Name, Level, HeroType, HP)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.HP = HP;
        }
        
         public string Attack(int Bonus){

            if (Bonus > 10){
                return this.Name + " Acertou um golpe critico massivo " + Bonus;
            }else{
                return this.Name + " Acertou um golpe critico fraco " + Bonus;
            }
 
    }
}}