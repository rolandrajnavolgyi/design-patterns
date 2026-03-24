using System;
using System.Collections.Generic;
using System.Text;

namespace FluentBuilder;

internal class GamePlatformBuilder<TBuilder> : GameGenreBuilder<GamePlatformBuilder<TBuilder>>
    where TBuilder : GamePlatformBuilder<TBuilder>
{
    public TBuilder OfPlatform(Platform platform)
    {
        game.Platform = platform;
        return (TBuilder)this;
    }
}
