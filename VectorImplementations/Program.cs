// See https://aka.ms/new-console-template for more information
using System.Diagnostics;
using VectorImplementations;

/*
Console.WriteLine("Array Based Vector");


ArrayBasedVector<string> arrayBasedVector = new ArrayBasedVector<string>(4);
arrayBasedVector.Append("A");
arrayBasedVector.Append("B");
arrayBasedVector.Append("D");
arrayBasedVector.Append("E");

Console.WriteLine(arrayBasedVector);
arrayBasedVector.InsertAtRank(2, "C");
Console.WriteLine(arrayBasedVector);
arrayBasedVector.InsertAtRank(5, "F");
Console.WriteLine(arrayBasedVector);

arrayBasedVector.InsertAtRank(3, "C#");

Console.WriteLine(arrayBasedVector.RemoveAtRank(3));
Console.WriteLine();
*/

ArrayBasedVector<int> abv = new ArrayBasedVector<int>();

Stopwatch sw = new Stopwatch();

List<int> problemSizes = new List<int>() { 100, 100, 1000, 10000, 100000, 1000000, 10000000, 100000000 };
int repetitions = 100;

bool firstRun = true;

Console.WriteLine("Get at Rank");
foreach (int problemSize in problemSizes)
{
    // reset the stopwatch to 0 for the new problem size
    sw.Reset();

    abv = new ArrayBasedVector<int>(4); // new array based vector for this problem size, with array already large

    // fill up the array to obtain the required problemSize
    for (int i = 0; i < problemSize; i++)
    {
        abv.Append(i);
    }
    // now we have an array as large as the problem size!

    for (int i = 0; i < repetitions; i++)
    {
        
        sw.Start();
        abv.ElementAtRank(1);
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

firstRun = true;
Console.WriteLine("Append");
foreach (int problemSize in problemSizes)
{
    // reset the stopwatch to 0 for the new problem size
    sw.Reset();

    abv = new ArrayBasedVector<int>(problemSize + repetitions + 1); // new array based vector for this problem size, with array already large
    // length of array is a bit larger to avoid array growth

    // fill up the array to obtain the required problemSize
    for (int i = 0; i < problemSize; i++)
    {
        abv.Append(i);
    }
    // now we have an array as large as the problem size!

    for (int i = 0; i < repetitions; i++)
    {
        sw.Start();
        abv.Append(100);
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

firstRun = true;
Console.WriteLine("Insert at 0");
foreach (int problemSize in problemSizes)
{
    // reset the stopwatch to 0 for the new problem size
    sw.Reset();

    abv = new ArrayBasedVector<int>(problemSize + repetitions + 1); // new array based vector for this problem size, with array already large
    // length of array is a bit larger to avoid array growth

    // fill up the array to obtain the required problemSize
    for (int i = 0; i < problemSize; i++)
    {
        abv.Append(i);
    }
    // now we have an array as large as the problem size!

    for (int i = 0; i < repetitions; i++)
    {
        sw.Start();
        abv.InsertAtRank(0, 100);
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



