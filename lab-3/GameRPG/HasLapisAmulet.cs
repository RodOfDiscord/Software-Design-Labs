namespace GameRPG
{
    public class HasLapisAmulet : HeroDecorator
    {
        public HasLapisAmulet(Hero hero) : base(hero) { }

        public override double MagicResist
        {
            get { return base.MagicResist + 10; }
        }
    }
}
