namespace DIO.Game_POO.src.Entities
{
    public class Ninja : Hero
    {
        public Ninja(string Name, int Level, string HeroType, int Hp, int Mp)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.Hp = Hp;
            this.Mp = Mp;
        }

        public override string Attack()
        {

            return $"{this.Name} atacou com sua katana.";
        }

        public string Attack(int Bonus)
        {
            if (Bonus > 6)
            {
                return $"{this.Name} lançou sua estrela ninja com bônus de {Bonus}.";
            }
            else
            {
                return $"{this.Name} atacou com sua katana com bônus de {Bonus}.";
            }
        }
    }
}
