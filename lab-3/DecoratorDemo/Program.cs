using GameRPG;

Warrior warrior = new Warrior();
printInfo(warrior);
warrior.Attack();
Console.WriteLine("----------------------");

HasLeatherHelmet warriorWithHelmet = new HasLeatherHelmet(warrior);
printInfo(warriorWithHelmet);
Console.WriteLine("----------------------");

HasIronSword warriorWithSword = new HasIronSword(warriorWithHelmet);
printInfo(warriorWithSword);
warriorWithSword.Attack();

static void printInfo(Hero hero)
{
    Console.WriteLine($"Defense: {hero.Defense}\nMagic Resist: {hero.MagicResist}\nDamage: {hero.Damage}\nHP: {hero.Hp}");
}