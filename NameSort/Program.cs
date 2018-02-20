using System;


namespace NameSort
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath;
            //NameList nameList = new NameList();
            GetNameListFromTxtFile nameList = new GetNameListFromTxtFile();
            OutputListToTxtFile outputList = new OutputListToTxtFile();
            SortNameListAscending sorter = new SortNameListAscending();

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
                nameList.PopulateNameList(filePath);
            }
            catch (Exception e)
            {
                Console.WriteLine("Invalid filepath\nPress any key to exit");
                Console.ReadKey();
                Environment.Exit(-1);
            }
            Console.WriteLine("Retrieving List from {0}", filePath );
            //Console.WriteLine("\nSorting.....\n");
            Console.WriteLine("Sorted list \n");
            sorter.SortListAlpha(nameList.GetNameList());
            outputList.PrintListToConsole(nameList.GetNameList());
            outputList.PrintList("./sorted-names-list.txt", nameList.GetNameList());
            Console.WriteLine("\n-Press any key to continue.");
            Console.ReadKey();
        }
    }
}
