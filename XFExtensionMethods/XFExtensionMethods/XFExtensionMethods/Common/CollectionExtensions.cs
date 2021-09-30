using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace XFExtensionMethods.Common
{
    public static class CollectionExtensions
    {
        public static bool HasItems<T>(this IEnumerable<T> collection)
        {
            return collection != null && collection.Any();
        }

        public static ObservableCollection<T> ToObservableCollection<T>(this IEnumerable<T> collection)
        {
            if (collection == null)
                return new ObservableCollection<T>();

            return new ObservableCollection<T>(collection);
        }

        public static void AddRange<T>(this ObservableCollection<T> targetCollection, IEnumerable<T> sourceCollection)
        {
            if (targetCollection == null)
                throw new ArgumentNullException(nameof(targetCollection));

            if (sourceCollection == null)
                throw new ArgumentNullException(nameof(sourceCollection));

            foreach (var item in sourceCollection)
                targetCollection.Add(item);
        }

        public static int GetIndex<T>(this IEnumerable<T> collection, T value)
        {
            if (collection is IList<T> list)
                return list.IndexOf(value);

            var index = 0;
            foreach (var item in collection)
            {
                if (item.Equals(value))
                    return index;

                ++index;
            }

            return -1;
        }
    }
}
