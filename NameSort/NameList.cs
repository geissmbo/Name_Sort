using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.IO;

namespace NameSort
{
    public class NameList
    {
        static List<Person> persons = new List<Person>();

        public static void AddPersonToList(Person person)
        {
            persons.Add(person);
        }//end AddPersonToList

        public static void ReadTxtFileToList(string filePath)
        {
            const Int32 bufferSize = 1024;
            string textLine;

            var fileStream = new System.IO.FileStream(filePath,
                                                System.IO.FileMode.Open,
                                                System.IO.FileAccess.Read,
                                                System.IO.FileShare.ReadWrite);

            var file = new System.IO.StreamReader(fileStream, Encoding.UTF8, true, bufferSize);

            while ((textLine = file.ReadLine()) != null)
            {
                Person person = ConvertLineToPerson(textLine);
                AddPersonToList(person);
                //person.PrintPerson();
            }

        }//end ReadTxtFileToList

        private static Person ConvertLineToPerson(string textLine)
        {
            string[] splitName = textLine.Split();

            int surnameIndex = splitName.Length - 1;

            List<string> givenNames = new List<string>();
            string surname = splitName[surnameIndex];

            for (int i = 0; i < surnameIndex; i++)
            {
                givenNames.Add(splitName[i]);
            }

            Person person = new Person(surname, givenNames);//change to pass
            return person;
        }//end ConvertLineToPerson

        public static void SortListAlpha()
        {

            persons.Sort();

        }//end SortListAlpha

        public static void PrintListToTxt(string filePath)
        {
            //System.IO.File.WriteAllLines(@"./sorted-names-list.txt", lines);
            //filePath = "./sorted-names-list.txt";
            using (TextWriter tw = new StreamWriter(filePath))
            {
                foreach (var p in persons)
                {
                    tw.WriteLine(p);
                }
            }

        }//end PrintListToTxt

        public static void PrintListToConsole()
        {
            foreach (var person in persons)
            {
                person.PrintPerson();
            }
        }//end PrintListToConsole



    }//end class NameList
}
