using GameRPG;


EnemyBuilder enemyBuilder = new EnemyBuilder();
HeroBuilder heroBuilder = new HeroBuilder();
CharacterDirector director = new(heroBuilder);

director.MakeBasicHero();
Hero hero = heroBuilder.Build();
PrintInfo(hero);

Console.WriteLine("------------------------");

director.ChangeBuilder(enemyBuilder);
director.MakeBasicEnemy();
Enemy enemy = enemyBuilder.Build();
PrintInfo(enemy);

static void PrintInfo(Character character)
{
    string info = $"Name: {character.Name}\n";
    info += $"Body Type: {character.BodyType}\n";
    info += $"Eyes Color: {character.EyesColor.Name}\n";
    info += $"Hair Color: {character.HairColor.Name}\n";
    info += $"Hair Style: {character.HairStyle}\n";
    info += $"Hat Type: {character.HatType}\n";
    info += $"Hat Color: {character.HatColor.Name}\n";
    info += $"Height: {character.Height}\n";
    info += $"Pants Color: {character.PantsColor.Name}\n";
    info += $"Shirt Color: {character.ShirtColor.Name}\n";
    info += $"Shoes Color: {character.ShoesColor.Name}\n";

    Console.WriteLine(info);
}