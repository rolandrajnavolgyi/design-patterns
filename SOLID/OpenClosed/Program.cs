using OpenClosed;

var expedition33 = new Game("Expedition 33", Genre.Adventure, Platform.PlayStation);
var bf6 = new Game("Battlefield 6", Genre.Action, Platform.PlayStation);
var indianaJones = new Game("Indiana Jones", Genre.Adventure, Platform.PC);
var wow = new Game("World of Warcraft", Genre.RolePlaying, Platform.PC);
var hearthstone = new Game("Hearthstone", Genre.Strategy, Platform.Mobile);

IList<Game> games = [ expedition33, wow, hearthstone ];

var adv_spec = new GenreSpecification(Genre.Adventure);
var ps_spec = new PlatformSpecification(Platform.PlayStation);

var gameFilter = new GameFilter();
Console.WriteLine($"My {Platform.PlayStation} {Genre.Adventure} games:");
foreach (var game in gameFilter.Filter(games, new AndSpecification<Game>(adv_spec, ps_spec)))
{
    Console.WriteLine(game.Name);
}