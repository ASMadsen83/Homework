using System;

namespace HomeworkFirst
{
    public class Program
    {
        static void Main(string[] args)
        {
            // TODO: write code to ask for input array of numbers, then which number we want to find
            // and then output first and last occurrences into console


            Console.WriteLine("How many numbers do you want to show?");
            var amountofnumbers = Convert.ToInt32(Console.ReadLine());

            int[][] array = new int[amountofnumbers][];

            for (int line = 0; line < array.Length; line++)
            {
                int arrayLength = line + 1;
                array[line] = new int[arrayLength];

                int[] linenum = array[line];

                linenum[0] = 1;
                linenum[linenum.Length - 1] = 1;


                if (line > 1)
                    for (int y = 1; y < linenum.Length - 1; y++)
                    {
                        var previousLine = array[line - 1];
                        linenum[y] = previousLine[y - 1] + previousLine[y];
                    }


                Console.WriteLine("what numbers do you want to find?");
                var find1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("and second number?");
                var find2 = Convert.ToInt32(Console.ReadLine());

                String searcharray = "find1";
                int index = Array.IndexOf(array, searcharray);
                Console.WriteLine("The first occurrence of \"{0}\" is at index {1}.",   // how to show the actual number?
                                  searcharray, index);

                String searcharray1 = "find2";
                int index1 = Array.IndexOf(array, searcharray);
                Console.WriteLine("The first occurrence of \"{0}\" is at index1 {1}.",  // how to show the actual number?
                                  searcharray1, index1);
            }


            // TODO : Find index of first occurrence in integer array. Solve using loop of your choice.
            public static int LastIntegerIndex(int[] items, int numberToFind)
            {
                // TODO: Delete following line before implementing.
                throw new NotImplementedException();
            }

            // TODO : Find index of last occurrence in given array. Solve using loop of your choice.
            public static int FirstIntegerIndex(int[] items, int numberToFind)
            {
                // TODO: Delete following line before implementing.
                throw new NotImplementedException();
            }
        



    }
    }    
}
