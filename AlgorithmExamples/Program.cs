namespace AlgorithmExamples
{
    internal class Program
    {
        static Random random = new Random();

        static void Main(string[] args)
        {
            int n = 1024;

            for (int i = 0; i < 20; i++)
            {
                int countOperations = BinarySearchExample(n);

                Console.WriteLine(countOperations);
            }
        }

        private static int BinarySearchExample(int n)
        {
            #region setup (don't count the operations)
            // fill up an array of size n
            int[] numbers = new int[n];
            for (int i = 0; i < n; i++)
                numbers[i] = random.Next();

            // select a number "at random" to search
            int numberToSearch = numbers[0];

            // Binary search can only work on a sorted array
            Array.Sort(numbers);
            #endregion

            int count = 0; // represents the work carried out (and we will return this value)

            // low and high represent the range where we need to search. Since the array is of length n,
            // notice that high - low + 1 = n (therefore the size of the range to search is n)
            int low = 0;        // 1 work
            int high = n - 1;   // 1 work
            int midpoint;       // 1 work
            count += 3;

            while (high > low) // we still have places to search, every loop, is 1 work
            {
                midpoint = (low + high) / 2; // 1 work
                count++;

                // assume that only 1 comparison happens,
                // and the assignment or break is 1 work as well
                // 2 work per iteration
                count += 2;

                // compare the value at the midpoint against the number to search
                if (numbers[midpoint] == numberToSearch)
                {
                    // usually you would return either the value or the position
                    break;
                } 
                else if (numbers[midpoint] < numberToSearch)
                {
                    // the number to search is LARGER than the midpoint
                    low = midpoint + 1;
                }
                else // numbers[midpoin] > numberToSearch
                {
                    // the nmber to search is SMALLER than the midpoint
                    high = midpoint - 1;
                }
            }


            return count;

        }
    }
}