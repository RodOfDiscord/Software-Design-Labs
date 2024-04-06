namespace GameRPG
{
    public class HeroDecorator : Hero
    {
        Hero hero;

        public HeroDecorator(Hero hero)
        {
            this.hero = hero;
        }

        public override double Defense
        {
            get { return hero.Defense; }
        }

        public override double MagicResist
        {
            get { return hero.MagicResist; }
        }

        public override double Damage
        {
            get { return hero.Damage; }
        }

        public override double Hp
        {
            get { return hero.Hp; }
        }

    }
}
