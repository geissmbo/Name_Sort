using System;


namespace NameSort
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath;
            NameList nameList = new NameList();
            if (args.Length < 1)
            {
                filePath = "./unsorted-names-list.txt";
                Console.WriteLine("No file path specified!\nUsing default path {0}", filePath);
            } else
            {
                filePath = args[0];
            }
            try
            {
                nameList.ReadTxtFileToList(filePath);
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
            nameList.SortListAlpha();
            Console.WriteLine("Sorted list \n");
            nameList.PrintListToConsole();
            nameList.PrintListToTxt("./sorted-names-list.txt");
            Console.WriteLine("\n-Press any key to continue.");
            Console.ReadKey();
        }
    }
}
