namespace ProjetoGameDIO.src.Entities
{
    public abstract class Hero
    {
        public Hero(string Name, int Level, string HeroType, int HP){
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
            return "Personagem" + " " + this.Name + " Possui o level" + " "+  this.Level + " é da classe" + " " + this.HeroType + " com HP de" + " " + this.HP;    
        }

        public virtual string Attack(){
            return this.Name + " Atacou com sua espada";
        }

    }

}