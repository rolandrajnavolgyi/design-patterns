using System;
using System.Collections.Generic;
using System.Text;

namespace FluentBuilder;

internal abstract class GameBuilder
{
    protected Game game = new();
    public Game Build() => game;
}
