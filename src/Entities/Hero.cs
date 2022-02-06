namespace DIO.Game_POO.src.Entities
{
    public abstract class Hero
    {
        public Hero(string Name, int Level, string HeroType, int Hp, int Mp)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }

        public Hero()
        {

        }

        public string Name { get; set; }
        public int Level { get; set; }
        public string HeroType { get; set; }
        public int Hp { get; set; }
        public int Mp { get; set; }

        public override string ToString()
        {
            return $"Name: {this.Name}, Level:{this.Level}, Type: {this.HeroType}, Hp: {this.Hp}, Mp: {this.Mp}";
        }

        public virtual string Attack()
        {
            return "";
        }
    }
}