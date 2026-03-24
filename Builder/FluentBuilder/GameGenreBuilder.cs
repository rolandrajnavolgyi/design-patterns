using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Text;

namespace FluentBuilder;

internal class GameGenreBuilder<TBuilder> : GameNameBuilder<GameGenreBuilder<TBuilder>> 
    where TBuilder : GameGenreBuilder<TBuilder>
{
    public TBuilder OfGenre(Genre genre)
    {
        game.Genre = genre;
        return (TBuilder)this;
    }
}
