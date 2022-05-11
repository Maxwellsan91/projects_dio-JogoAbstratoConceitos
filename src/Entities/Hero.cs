namespace JogoAbst.src.Entities
{
    public abstract class Hero
    {

        public Hero(string Name,int Level,string HeroType)
        {
            this.name = Name;
            this.level = Level;
            this.heroType = HeroType;
        }
        public string name { get; set; }
        public int level { get; set; }
        public string heroType { get; set; }

        public Hero(){

        }

        public virtual string Attack() { 
            return this.name + " Atacou com sua espada"; 
            }        

        public override string ToString(){
            return this.name + " " + this.level + " " + this.heroType;
        }

    }
}