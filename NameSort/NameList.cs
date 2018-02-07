using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace NameSort
{
    public class NameList
    {
        static List<Person> persons = new List<Person>();

        /// <summary>
        /// Adds instance of Person to persons list
        /// </summary>
        /// <param name="person">Person being added</param>
        public static void AddPersonToList(Person person)
        {
            persons.Add(person);
        }//end AddPersonToList

        /// <summary>
        /// Converts list of people from a txt file into a List of People
        /// </summary>
        /// <param name="filePath">Path to file being converted</param>
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

        /// <summary>
        /// Converts a line of txt into a Person object.
        /// </summary>
        /// <param name="textLine">String being converted</param>
        /// <returns>Person obj</returns>
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

        /// <summary>
        /// Sorts list into alphabetical order by surname and then by given names.
        /// </summary>
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

        /// <summary>
        /// Prints persons list to console.
        /// </summary>
        public static void PrintListToConsole()
        {
            foreach (var person in persons)
            {
                person.PrintPerson();
            }
        }//end PrintListToConsole

    }//end class NameList
}
