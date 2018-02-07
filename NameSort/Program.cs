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
            try
            {
                NameList.ReadTxtFileToList(filePath);
            }
            catch (Exception e)
            {
                Console.WriteLine("Invalid filepath\nPress any key to exit");
                Console.ReadKey();
                Environment.Exit(-1);
            }
            Console.WriteLine("Retrieving List from {0}", filePath );
            //NameList.PrintListToConsole();
            Console.WriteLine("\nSorting.....\n");
            NameList.SortListAlpha();
            Console.WriteLine("\nSorted list \n");
            NameList.PrintListToConsole();
            NameList.PrintListToTxt("./sorted-names-list.txt");
            Console.WriteLine("\n-Press any key to continue.");
            Console.ReadKey();
        }
    }
}
