using oopadventure;

var language = new English();
Text.LoadLanguage(language);

Console.WriteLine(Text.Language.ChooseYourName);

var name = Console.ReadLine();
if (name == String.Empty) 
    name = Text.Language.DefaultName;

var player = new Player(name);

Console.WriteLine(Text.Language.Welcome, player.Name);

var house = new House(player);

