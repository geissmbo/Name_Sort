using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;

namespace NameSort
{
    public class SortNameListAscending : ISortNameList
    {

        /// <summary>
        /// 
        /// </summary>
        /// <param name="persons"></param>
        public void SortListAlpha(List<Person> persons)
        {
            persons.Sort();
        }//end SortListAlpha

    }//end class SortNameList
}
