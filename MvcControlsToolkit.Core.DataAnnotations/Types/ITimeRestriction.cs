using System;
using System.Collections.Generic;
using System.Text;

namespace MvcControlsToolkit.Core.Types
{
    public interface ITimeRestriction: IComparable
    {
        DateTime ToDateTime();
        ITimeRestriction Add(TimeSpan ts);
    }
}
