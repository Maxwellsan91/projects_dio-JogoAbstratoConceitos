namespace JogoAbst.src.Entities
{
    public class Hunter : Hero
    {
        public Hunter(string Name,int Level,string HeroType)
        {
            this.name = Name;
            this.level = Level;
            this.heroType = HeroType;
        }

        public override string Attack() { 
            return this.name + " Realizou um ataque certeiro"; 
            }

        public virtual string Attack(int Bonus) { 

            if (Bonus > 4)
            {
                return this.name + " Realizou um ataque especial com dano " + Bonus + "x maior";                 
            }else{
                return this.name + " Ataque especial falhou "; 
            }
            }
    }
}