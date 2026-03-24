using FluentBuilder;

var game = Game.New
    .OfPlatform(Platform.NintendoSwitch)
    .OfName("The Legend of Zelda: Breath of the Wild")
    .OfGenre(Genre.Adventure)
    .Build();

Console.WriteLine(game);