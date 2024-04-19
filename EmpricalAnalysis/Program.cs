using System.Diagnostics;

namespace EmpricalAnalysis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // You need something to time your algorithms
            // The stopwatch offers an accurate reading of the time required 
            Stopwatch sw = new Stopwatch();

            // The algorithms slow down, depending on the problem size
            // Often, larger problem sizes are very interesting
            // Notice, that the small problem size is repeated twice (because I want to discard the first result)
            List<int> problemSizes = new List<int>() { 100, 100, 1000, 10000, 100000, 1000000, 10000000 };

            // The more repetitions, the more accurate the time in practice, but the slower the program will be
            int repetitions = 20;

            // Setup
            // PRNGs should only be instantiated ONCE
            Random random = new Random();

            // Sort an array
            Console.WriteLine("Empirical Analysis for Sorting an array of different problem sizes");

            // Set the firstRun to true (this will be used to discard the first result)
            bool firstRun = true;
            foreach (int problemSize in problemSizes)
            {
                // reset the stopwatch to 0 for the new problem size
                sw.Reset();

                // you might have some setup here
                int[] arrayToSort = new int[problemSize];

                

                for (int i = 0; i < repetitions; i++)
                {
                    // or setup here...
                    for (int j = 0; j < arrayToSort.Length; j++)
                    {
                        arrayToSort[i] = random.Next(1, int.MaxValue);
                    }

                    sw.Start();
                    // carry out the algorithm here for given problem size
                    Array.Sort(arrayToSort);
                    sw.Stop();
                }

                if (firstRun)
                {
                    firstRun = false;
                }
                else
                {
                    Console.WriteLine($"{problemSize}, {(double)sw.ElapsedTicks / repetitions}");
                }
            }

            // Find Maximum
            Console.WriteLine("Empirical Analysis for Finding the maximum in an array of different problem sizes");

            // Set the firstRun to true (this will be used to discard the first result)
            firstRun = true;
            foreach (int problemSize in problemSizes)
            {
                // reset the stopwatch to 0 for the new problem size
                sw.Reset();

                // you might have some setup here
                int[] arrayToSort = new int[problemSize];

                for (int i = 0; i < repetitions; i++)
                {
                    // or setup here...
                    for (int j = 0; j < arrayToSort.Length; j++)
                    {
                        arrayToSort[i] = random.Next(1, int.MaxValue);
                    }

                    sw.Start();
                    // carry out the algorithm here for given problem size
                    FindMax(arrayToSort);
                    sw.Stop();
                }

                if (firstRun)
                {
                    firstRun = false;
                }
                else
                {
                    Console.WriteLine($"{problemSize}, {(double)sw.ElapsedTicks / repetitions}");
                }
            }

            // Find Maximum
            Console.WriteLine("Empirical Analysis for Nested Loop of different problem sizes");

            // Set the firstRun to true (this will be used to discard the first result)
            firstRun = true;
            foreach (int problemSize in problemSizes)
            {
                // reset the stopwatch to 0 for the new problem size
                sw.Reset();

                // you might have some setup here
                
                for (int i = 0; i < repetitions; i++)
                {
                    // or setup here...
                    

                    sw.Start();
                    // carry out the algorithm here for given problem size
                    NestedLoop(problemSize);
                    sw.Stop();
                }

                if (firstRun)
                {
                    firstRun = false;
                }
                else
                {
                    Console.WriteLine($"{problemSize}, {(double)sw.ElapsedTicks / repetitions}");
                }
            }
        }

        static int FindMax(int[] array)
        {
            // find the maximum item in the array and return the position
            int max = array[0];
            int maxPosition = 0;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                    maxPosition = i;
                }
            }

            return maxPosition;
        }

        static void NestedLoop(int problemSize)
        {
            int count = 0;

            for (int i = 0; i < problemSize; i++)
            {
                for (int j = 0; j < problemSize; j++)
                {
                    count++;
                }
            }
        }
    }
}