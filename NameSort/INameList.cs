namespace NameSort
{
    public interface INameList
    {
        /// <summary>
        /// Adds instance of Person to persons list
        /// </summary>
        /// <param name="person">Person being added</param>
        void AddPersonToList(Person person);

        /// <summary>
        /// Returns Person at specified index from Persons List, currently only used in unit tests.
        /// </summary>
        /// <param name="index">List index to return</param>
        /// <returns>Person at specified index</returns>
        Person GetPersonFromListByIndex(int index);

        /// <summary>
        /// Prints persons list to console.
        /// </summary>
        void PrintListToConsole();

        /// <summary>
        /// Generates a .txt file from a persons List
        /// </summary>
        /// <param name="filePath">Name of the file being generated</param>
        void PrintListToTxt(string filePath);

        /// <summary>
        /// Converts list of people from a txt file into a List of People
        /// </summary>
        /// <param name="filePath">Path to file being converted</param>
        void ReadTxtFileToList(string filePath);

        /// <summary>
        /// Sorts list into alphabetical order by surname and then by given names.
        /// </summary>
        void SortListAlpha();
    }
}