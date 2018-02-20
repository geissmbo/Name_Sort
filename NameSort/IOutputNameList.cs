using System;
using System.Collections.Generic;
using System.Text;

namespace NameSort
{
    interface IOutputNameList
    {
        /// <summary>
        /// Prints persons list to console.
        /// </summary>
        void PrintListToConsole(List<Person> persons);

        void PrintList(string location, List<Person> persons);
    }
}
