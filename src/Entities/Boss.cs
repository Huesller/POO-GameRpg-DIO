namespace ProjetoGameDIO.src.Entities
{
    public class Boss
    {
        
         public Boss(string Name, int Level, string HeroType, int HP){
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.HP = HP;
                   
        }
        public string Name;
        public int Level;
        public string HeroType;
        public int HP; 

         public override string ToString(){
            return "O BOSS" + " " + this.Name + " Possui o level" + " "+  this.Level + " é da classe" + " " + this.HeroType + " com HP de" + " " + this.HP;    
        }

        public string Attack(){
            return this.Name + " Atacou com seu machado gigante";
        }
        public string Attack(int Bonus){

            if (Bonus > 150){
                return this.Name + " Acertou um golpe de machado critico " + Bonus;
            }else{
                return this.Name + " Acertou um golpe de machado fraco " + Bonus;
            }
 
    }

    }

}