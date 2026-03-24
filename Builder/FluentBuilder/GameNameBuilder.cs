using System;
using System.Collections.Generic;
using System.Text;

namespace FluentBuilder;

internal class GameNameBuilder<TBuilder> : GameBuilder 
    where TBuilder : GameNameBuilder<TBuilder>
{
    public TBuilder OfName(string name)
    { 
        game.Name = name;
        return (TBuilder)this;
    }
}
