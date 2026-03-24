using System;
using System.Collections.Generic;
using System.Text;

namespace FluentBuilder;

internal class Game
{
    public string? Name { get; set; }
    public Genre Genre { get; set; }
    public Platform Platform { get; set; }

    public class Builder : GamePlatformBuilder<Builder>
    {
    }

    public static Builder New => new();

    public override string ToString()
    {
        return $"Game: {Name}, Genre: {Genre}, Platform: {Platform}";
    }
}
