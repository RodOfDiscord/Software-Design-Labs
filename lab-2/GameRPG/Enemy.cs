namespace GameRPG
{
    public class Enemy : Character
    {
        public void Attack(Character target)
        {
            Console.WriteLine($"Attacking a {target.Name}");
        }
    }
}
