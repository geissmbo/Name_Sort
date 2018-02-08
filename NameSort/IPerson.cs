namespace NameSort
{
    public interface IPerson
    {
        string Surname { get; set; }

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
        int CompareTo(Person other);

        /// <summary>
        /// Prints full name to console
        /// </summary>
        void PrintPerson();

        /// <summary>
        /// ToString override
        /// </summary>
        /// <returns>Full name as space seperated string</returns>
        string ToString();

    }
}