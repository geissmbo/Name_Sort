using System;
using System.Collections.Generic;
using System.Text;

namespace NameSort
{
    interface IGetNameList
    {

        void PopulateNameList(string source);

        void AddPersonToList(Person person);

        List<Person> GetNameList();

    }
}
