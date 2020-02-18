using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Text;

namespace MvcControlsToolkit.Core.Types
{
    public static class TimeRestrictionParser
    {
        private static ConcurrentDictionary<Type, Func<string, ITimeRestriction>> register 
            = new ConcurrentDictionary<Type, Func<string, ITimeRestriction>>();
        public static void Register<T>(Func<string, ITimeRestriction> parser)
        {
            register.AddOrUpdate(typeof(T), parser, (x, y) => parser);
        }
        public static ITimeRestriction Parse(Type type, string value)
        {
            var f = register.GetValueOrDefault(type);
            return f == null ? null : f(value);
        }
    }
}
