namespace GameRPG
{
    public class HasRubyRing : HeroDecorator
    {
        public HasRubyRing(Hero hero) : base(hero) { }

        public override double Hp
        {
            get { return base.Hp + 10; }
        }

        public override double Defense
        {
            get { return base.Defense + 1; }
        }
    }
}
