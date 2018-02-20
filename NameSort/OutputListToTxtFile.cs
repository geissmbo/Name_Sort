using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace NameSort
{
    class OutputListToTxtFile : IOutputNameList
    {

        public void PrintList(string filePath, List<Person> persons)
        {
            using (TextWriter tw = new StreamWriter(filePath))
            {
                foreach (var p in persons)
                {

                    tw.WriteLine(p);
                }
            }
        }

        public void PrintListToConsole(List<Person> persons)
        {
            foreach (var person in persons)
            {
                person.PrintPerson();
            }
        }
    }
}

