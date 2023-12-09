using System;
using System.Collections.Generic;

namespace PrototypePattern_4
{
    public class PrototypeManager
    {
        private readonly Dictionary<string, IWidget> widgetPrototypes = new Dictionary<string, IWidget>();

        public IWidget this[string key]
        {
            get
            {
                if (widgetPrototypes.TryGetValue(key, out var widget))
                {
                    return widget?.clone() as IWidget;
                }
                return null;
            }
            set { widgetPrototypes[key] = value; }
        }

        public bool ContainsKey(string key)
        {
            return widgetPrototypes.ContainsKey(key);
        }
    }
}
