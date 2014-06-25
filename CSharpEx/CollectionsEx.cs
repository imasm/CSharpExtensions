﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpEx
{
    /// <summary>
    /// Collection's extensions
    /// </summary>
    public static class CollectionsEx
    {
        /// <summary>
        /// Indicates whether the specified enumerable is null or empty.
        /// </summary>
        public static bool IsNullOrEmpty<T>(this IEnumerable<T> enumerable)
        {
            if (enumerable == null)
            {
                return true;
            }
            /* If this is a list, use the Count property for efficiency. 
             * The Count property is O(1) while IEnumerable.Count() is O(N). */
            var collection = enumerable as ICollection<T>;
            if (collection != null)
            {
                return collection.Count < 1;
            }
            return !enumerable.Any();
        }

        ///<summary>Finds the index of the first item matching an expression in an enumerable.</summary>
        ///<param name="items">The enumerable to search.</param>
        ///<param name="predicate">The expression to test the items against.</param>
        ///<returns>The index of the first matching item, or -1 if no items match.</returns>
        public static int FirstIndex<T>(this IEnumerable<T> items, Predicate<T> predicate)
        {
            if (items == null)
                return -1;

            int index = 0;
            foreach (var item in items)
            {
                if (predicate(item))
                    return index;

                index++;
            }
            return -1;
        }
    }
}