namespace JogoAbst.src.Entities
{
    public class Wizard : Hero
    {
        public Wizard(string Name,int Level,string HeroType)
        {
            this.name = Name;
            this.level = Level;
            this.heroType = HeroType;
        }
        public override string Attack() { 
            return this.name + " Atacou com sua Magia"; 
            }

        public virtual string Attack(int Bonus) { 

            if (Bonus > 6)
            {
                return this.name + " Lançou uma magia com dano crítico de " + Bonus;                 
            }else{
                return this.name + " Lançou magia fraca com bonus de ataque de " + Bonus; 
            }
            }


    }
}