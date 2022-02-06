namespace DIO.Game_POO.src.Entities
{
    public class Knight : Hero
    {
        public Knight(string Name, int Level, string HeroType, int Hp, int Mp)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.Hp = Hp;
            this.Mp = Mp;
        }
        public override string Attack()
        {

            return $"{this.Name} atacou com sua espada.";
        }
        public string Attack(int Bonus)
        {
            if (Bonus > 6)
            {
                return $"{this.Name} usou ataque especial com sua espada e bônus de {Bonus}.";
            }
            else
            {
                return $"{this.Name} atacou com sua espada com bônus de {Bonus}.";
            }
        }
    }
}