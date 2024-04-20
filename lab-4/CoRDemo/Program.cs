using SupportService;

int flag;
do
{
    Console.WriteLine(@"1. Software glitches or freezes
    2. No internet connection to my computer
    3. My PC won`t turn on
    4. Graphics card is not functioning properly
    5. My phone`s screen is damaged");

}while (!int.TryParse(Console.ReadLine(), out flag));

Level1Support support = new Level1Support();
support.Link(new Level2Support())
       .Link(new Level3Support())
       .Link(new Level4Support());

int difficulty;
switch (flag)
{
    case 1:
        difficulty = 3;
        break;
    case 2:
        difficulty = 9;
        break;
    case 3:
        difficulty = 15;
        break;
    case 4:
        difficulty = 24;
        break;
    case 5:
        difficulty = 26;
        break;
    default:
        Console.WriteLine("bad input flag");
        return;
}

Request request = new Request(difficulty);
support.Handle(request);
