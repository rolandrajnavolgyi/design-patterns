using InterfaceSegregation;

internal class SqueezerPart : ISqueezer
{
    public void Squeeze(Fruit fruit)
    {
        Console.WriteLine($"{fruit} has been squeezed");
    }
}