using System.Runtime.InteropServices;
using TreeProject;

namespace TreeProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BinaryMaxHeap<string> heap = new BinaryMaxHeap<string>();
            heap.Add(40, "Fourty");
            heap.Add(24, "24");
            heap.Add(18, "18");
            heap.Add(22, "22");
            heap.Add(11, "11");
            heap.Add(9, "9");

            Console.WriteLine(heap.ToString());

            heap.Add(42, "42");

            Console.WriteLine(heap.ToString());




            /*
            BST<string> treeOne = new BST<string>();

            treeOne.Add(20, "Twenty");
            treeOne.Add(5, "Five");
            treeOne.Add(4, "Four");
            treeOne.Add(10, "Ten");
            treeOne.Add(22, "Twenty-Two");

            Console.WriteLine("Searching for 10");
            Console.WriteLine(treeOne.Search(10));

            Console.WriteLine("Searching for 25");
            try
            {
                treeOne.Search(25);
            }
            catch (KeyNotFoundException)
            {
                Console.WriteLine("Key was not found!");
            }

            BST<int> treeTwo = new BST<int>();

            treeTwo.Add(1, 1);
            treeTwo.Add(2, 2);
            treeTwo.Add(3, 3);
            treeTwo.Add(4, 4);
            treeTwo.Add(5, 5);
            treeTwo.Add(6, 6);
            treeTwo.Add(7, 7);
            treeTwo.Add(8, 8);

            Console.WriteLine(treeTwo.ToString());

            Random r = new Random();
            List<int> randomNumbers = new List<int>();

            for (int i = 0; i < 60; i++)
            {
                randomNumbers.Add(r.Next(1, 1001));
            }

            // remove duplicates
            randomNumbers = randomNumbers.Distinct().ToList<int>();

            BST<int> treeThree = new BST<int>();
            foreach (int i in randomNumbers)
            {
                treeThree.Add(i, i);
            }

            Console.WriteLine(
            treeThree.ToString());
            */
        }
    }
}