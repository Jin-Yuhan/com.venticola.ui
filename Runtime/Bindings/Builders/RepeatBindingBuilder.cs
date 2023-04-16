using System;
using UnityEngine;

namespace VentiCola.UI.Bindings
{
    public static class RepeatBindingBuilder
    {
        public static GameObject RepeatForEachOf<T>(this GameObject self, Func<IReactiveCollection> collection, Action<int, T> renderItemAction = null)
        {
            BaseBinding
                .Allocate<ForEachBinding<T>>()
                .Initalize(self, collection, renderItemAction);
            return self;
        }

        public static GameObject Count(this GameObject self, Func<int> count, Action<int> renderItemAction)
        {
            //BaseBinding
            //    .Allocate<ForEachBinding<int>>()
            //    .InitalizeObject(go, m_CollectionFunc, renderItemAction);
            return self;
        }
    }
}
