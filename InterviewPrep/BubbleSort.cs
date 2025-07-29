using System;
using System.Collections.Generic;

namespace InterviewPrep
{
    /// <summary>
    /// Given a list of strings, sort them.
    /// This solution uses a simple bubble sort.
    /// </summary>
    public class BubbleSort : IQuestion
    {
        public string Command => "bubble-sort";
        public string Description => "Run the BubbleSort question";

        public void Run()
        {
            var listToSort = new List<string> { "asdf", "zxy", "kdcn", "bdns" };

            Console.WriteLine("Unsorted List");
            PrintStrings(listToSort);
            Console.WriteLine();

            for (int i = 0; i < listToSort.Count - 1; i++)
            {
                for (var j = i + 1; j < listToSort.Count; j++)
                {
                    if (String.Compare(listToSort[i], listToSort[j]) > 0)
                    {
                        var temp = listToSort[i];
                        listToSort[i] = listToSort[j];
                        listToSort[j] = temp;
                    }
                }
            }

            Console.WriteLine("Sorted List");
            PrintStrings(listToSort);
        }

        private static void PrintStrings(List<string> stringList)
        {
            foreach (var x in stringList)
            {
                Console.WriteLine(x);
            }
        }
    }
}
