using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace NameSort
{
    public class NameList : INameList
    {
        List<Person> persons = new List<Person>();

        public void AddPersonToList(Person person)
        {
            persons.Add(person);
        }//end AddPersonToList


        public void ReadTxtFileToList(string filePath)
        {
            const Int32 bufferSize = 1024;
            string textLine;

            var fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            var file = new System.IO.StreamReader(fileStream, Encoding.UTF8, true, bufferSize);

            while ((textLine = file.ReadLine()) != null)
            {
                Person person = Person.ConvertLineToPerson(textLine);
                AddPersonToList(person);
                //person.PrintPerson();
            }

        }//end ReadTxtFileToList


        public void SortListAlpha()
        {
            persons.Sort();
        }//end SortListAlpha


        public void PrintListToTxt(string filePath)
        {
            using (TextWriter tw = new StreamWriter(filePath))
            {
                foreach (var p in persons)
                {
                    tw.WriteLine(p);
                }
            }

        }//end PrintListToTxt


        public void PrintListToConsole()
        {
            foreach (var person in persons)
            {
                person.PrintPerson();
            }
        }//end PrintListToConsole


        public Person GetPersonFromListByIndex(int index)
        {
            return persons[index];
        }

    }//end class NameList
}
