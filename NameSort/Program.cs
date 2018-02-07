using System;


namespace NameSort
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath;
            if (args.Length < 1)
            {
                filePath = "./unsorted-names-list.txt";
            } else
            {
                filePath = args[0];
            }
            NameList.ReadTxtFileToList(filePath);
            Console.WriteLine("Original List");
            NameList.PrintListToConsole();
            Console.WriteLine("\nSorting.....\n");
            NameList.SortListAlpha();
            NameList.PrintListToConsole();
            NameList.PrintListToTxt("./sorted-names-list.txt");
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
        }
    }
}
