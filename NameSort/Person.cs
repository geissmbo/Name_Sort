using System;
using System.Collections.Generic;
using System.Text;

namespace NameSort
{
    public class Person : IComparable<Person>, IPerson
    {
        
        private string surname;
        private List<string> given;

        public string Surname { get; set; }

        /// <summary>
        /// Constructor for Person object containing surname and list of given names
        /// </summary>
        /// <param name="lastName">surname as string</param>
        /// <param name="givenNames">given names as list of string</param>
        public Person(string lastName, List<string> givenNames)
        {
            surname = lastName;
            given = givenNames;
        }


        public void PrintPerson()
        {
            foreach (var name in given)
            {
               Console.Write("{0} ", name);
            }
            Console.WriteLine(surname);
        }//end PrintPerson


        public override string ToString()
        {
            string fullName = "";

            foreach (var name in given)
            {
                fullName += name + " ";
            }
            fullName += surname;
            return fullName;
        }//end Override ToString

        /// <summary>
        /// Converts a line of txt into a Person object.
        /// </summary>
        /// <param name="textLine">String being converted</param>
        /// <returns>Person obj</returns>
        public static Person ConvertLineToPerson(string textLine)
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


        public int CompareTo(Person other)
        {
            int result = this.surname.CompareTo(other.surname);
            
            if (result == 0)
            {
                int highestIndexComparable = Math.Min(this.given.Count, other.given.Count);

                for (int i = 0; i < highestIndexComparable; i++)
                {
                    result = this.given[i].CompareTo(other.given[i]);
                    if (result != 0)
                    {
                        return result;
                    }
                    //Last given name reached for one person but still no differences - sort shorter name to lower index in list
                    if (i == highestIndexComparable - 1) 
                    {
                        result = (this.given.Count > other.given.Count) ? 1 : -1;
                    }
                }
            }
            return result;
        }
    }//end class Person
}
