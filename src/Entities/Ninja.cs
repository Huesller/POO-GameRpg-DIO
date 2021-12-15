namespace ProjetoGameDIO.src.Entities
{
    public class Ninja : Hero
    {
       public Ninja(string Name, int Level, string HeroType, int HP) : base(Name, Level, HeroType, HP)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }

        public override string Attack()
        {
            return this.Name + " Usou um Ninjutso";
        }
        public string Attack(int Bonus){

            if (Bonus > 13){
                return this.Name + " Usou um Ninjutso super efetivo com bonus de " + Bonus;
            }else{
                return this.Name + " Usou um Ninjutso com força fraca com bonus de " + Bonus;
            }
            
    }
}}