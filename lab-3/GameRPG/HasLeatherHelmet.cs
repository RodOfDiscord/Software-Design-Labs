namespace GameRPG
{
    public class HasLeatherHelmet : HeroDecorator
    {
        public HasLeatherHelmet(Hero hero) : base(hero) { }

        public override double Defense
        {
            get { return base.Defense + 10; }
        }

    }
}
