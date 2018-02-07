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

        public int CompareTo(Person other)
        {
            return this.surname.CompareTo(other.surname);
        }
    }
}
