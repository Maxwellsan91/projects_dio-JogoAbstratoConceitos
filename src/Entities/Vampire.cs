namespace JogoAbst.src.Entities
{
    public class Vampire : Hero
    {
        public Vampire(string Name,int Level,string HeroType)
        {
            this.name = Name;
            this.level = Level;
            this.heroType = HeroType;
        }

        public override string Attack() { 
            return this.name + " Realizou um ataque sangrento"; 
            }

        public virtual string Attack(int Bonus) { 
            return this.name + " Realizou um ataque especial com dano " + Bonus + "x maior"; 
            }
    }
}