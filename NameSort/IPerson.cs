namespace NameSort
{
    public interface IPerson
    {
        string Surname { get; set; }

        int CompareTo(Person other);
        void PrintPerson();
        string ToString();
    }
}