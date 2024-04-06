namespace GameRPG
{
    public abstract class Hero
    {
        public virtual double Defense { get; protected set; }
        public virtual double MagicResist { get; protected set; }
        public virtual double Damage { get; protected set; }
        public virtual double Hp { get; protected set; } = 100;

        public void Attack()
        {
            Console.WriteLine($"Dealt {Damage} damage");
        }
    }
}
