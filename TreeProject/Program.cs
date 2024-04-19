using System.Runtime.InteropServices;
using TreeProject;

namespace TreeProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BST<string> treeOne = new BST<string>();

            treeOne.AddNewChildNode(20, "Twenty");
            treeOne.AddNewChildNode(5, "Five");
            treeOne.AddNewChildNode(4, "Four");
            treeOne.AddNewChildNode(10, "Ten");
            treeOne.AddNewChildNode(22, "Twenty-Two");

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

            treeTwo.AddNewChildNode(1, 1);
            treeTwo.AddNewChildNode(2, 2);
            treeTwo.AddNewChildNode(3, 3);
            treeTwo.AddNewChildNode(4, 4);
            treeTwo.AddNewChildNode(5, 5);
            treeTwo.AddNewChildNode(6, 6);


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
                treeThree.AddNewChildNode(i, i);
            }

            Console.WriteLine(
            treeThree.ToString());
        }
    }
}