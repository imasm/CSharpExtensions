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
    }
}
