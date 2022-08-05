using System;

namespace SortArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] newNumbers = new int[] { 1, 7, 5, 2, 10, 4, 8, 3, 6, 9 };
            int num;

            for (int i = 0; i < newNumbers.Length; i++)
            {
                for (int sort = i + 1; sort < newNumbers.Length; sort++)
                {
                    if (newNumbers[i] < newNumbers[sort])
                    {
                        num = newNumbers[i];
                        newNumbers[i] = newNumbers[sort];
                        newNumbers[sort] = num;
                    }
                }
            }
            foreach (int values in newNumbers)
            {
                Console.WriteLine(values + " ");
            }

        }
    }
}




