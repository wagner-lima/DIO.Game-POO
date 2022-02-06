namespace DIO.Game_POO.src.Entities
{
    public class Wizard : Hero
    {
        public Wizard(string Name, int Level, string HeroType, int Hp, int Mp)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.Hp = Mp;
            this.Mp = Mp;
        }
        public override string Attack()
        {

            return $"{this.Name} lançou uma magia.";
        }

        public string Attack(int Bonus)
        {
            if (Bonus > 6)
            {
                return $"{this.Name} lançou uma magia super efetiva com bônus de {Bonus}.";
            }
            else
            {
                return $"{this.Name} lançou uma magia com bônus de {Bonus}.";
            }
        }
    }
}