using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace NameSort
{
    class GetNameListFromTxtFile : IGetNameList
    {

        private List<Person> persons = new List<Person>();

        public List<Person> GetNameList()
        {
            return persons;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="filePath"></param>
        public void PopulateNameList(string filePath)
        {
            const Int32 bufferSize = 1024;
            string textLine;

            var fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            var file = new System.IO.StreamReader(fileStream, Encoding.UTF8, true, bufferSize);

            while ((textLine = file.ReadLine()) != null)
            {
                Person person = Person.ConvertLineToPerson(textLine);
                AddPersonToList(person);
                //Console.WriteLine(person);
            }
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="person"></param>
        public void AddPersonToList(Person person)
        {
            persons.Add(person);
        }//end AddPersonToList


    }
}
