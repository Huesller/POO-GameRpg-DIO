namespace ProjetoGameDIO.src.Entities
{
    public class BlackWizard : Hero
    {
        public BlackWizard(string Name, int Level, string HeroType, int HP) : base(Name, Level, HeroType, HP)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.HP = HP;
        }

        public override string Attack(){
            return this.Name + " Lançou Magia das sombras";
        }
        public string Attack(int Bonus){

            if (Bonus > 30){
                return this.Name + " Lançou Magia das sombras extrema com bonus de " + Bonus;
            }else{
                return this.Name + " Lançou uma magia das sombras de força fraca com bonus de " + Bonus;
            }
            
    }
}}