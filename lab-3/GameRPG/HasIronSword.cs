namespace GameRPG
{
    public class HasIronSword : HeroDecorator
    {
        public HasIronSword(Hero hero) : base(hero) { }

        public override double Damage
        {
            get { return base.Damage + 10; }
        }
    }
}
