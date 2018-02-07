using System;


namespace NameSort
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = "./unsorted-names-list.txt";
            NameList.ReadTxtFileToList(filePath);
            NameList.PrintListToConsole();
            Console.WriteLine("sorting.....");
            NameList.SortListAlpha();
            NameList.PrintListToConsole();
            NameList.PrintListToTxt("./sorted-names-list.txt");
            Console.ReadKey();
        }
    }
}
