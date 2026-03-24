using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceSegregation;

internal interface IJuiceMachine : ICleaner, ISqueezer
{
}
