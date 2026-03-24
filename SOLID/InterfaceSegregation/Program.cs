using InterfaceSegregation;

var orange = new Fruit("orange");
var cleaner = new CleanerPart();
var squeezer = new SqueezerPart();

var fruitJuiceMachine = new FruitJuiceMachine(cleaner, squeezer);
fruitJuiceMachine.Clean(orange);
fruitJuiceMachine.Squeeze(orange); 

