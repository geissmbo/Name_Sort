using System;
using System.Collections.Generic;
using System.Text;

namespace NameSort
{
    public class Person : IComparable<Person>
    {
        
        private string surname;
        private List<string> given;

        public string Surname { get; set; }

        /// <summary>
        /// Person object containing surname and list of given names
        /// </summary>
        /// <param name="lastName">surname as string</param>
        /// <param name="givenNames">given names as list of string</param>
        public Person(string lastName, List<string> givenNames)
        {
            surname = lastName;
            given = givenNames;
        }

        /// <summary>
        /// Prints full name to console
        /// </summary>
        public void PrintPerson()
        {
            foreach (var name in given)
            {
               Console.Write("{0} ", name);
            }
            Console.WriteLine(surname);
        }//end PrintPerson

        /// <summary>
        /// ToString override
        /// </summary>
        /// <returns>Full name as space seperated string</returns>
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
        /// CompareTo implementation for sort.
        /// Sorts by surname first, then by given names.
        /// </summary>
        /// <param name="other">Person being compared to</param>
        /// <returns>int
        /// -1 for less than other
        /// 0 for equal to other
        /// 1 for greater than other
        /// </returns>
        public int CompareTo(Person other)
        {
            //TODO rework to add given name ordering if surnames equal
            int result = this.surname.CompareTo(other.surname);

            if (result == 0)
            {
                for (int i = 0; i < this.given.Count; i++)
                {
                    result = this.given[i].CompareTo(other.given[i]);
                    if (result != 0)
                    {
                        return result;
                    }
                }
            }
            return result;
        }
    }//end class Person
}
