using System.Collections.Generic;

namespace NameSort
{
    /// <summary>
    /// 
    /// </summary>
    public interface ISortNameList
    {

        /// <summary>
        /// Sorts list into alphabetical order by surname and then by given names.
        /// </summary>
        void SortListAlpha(List<Person> persons);
    }
}