﻿// See https://aka.ms/new-console-template for more information
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

/*

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
*/

// NodeTest();

// SinglyLinkedListTest();

SinglyLinkedList<string> singlyLinkedList = new SinglyLinkedList<string>();
singlyLinkedList.Append("A");
singlyLinkedList.Append("B");
singlyLinkedList.Append("D");
singlyLinkedList.Append("E");

Node<string> cursor = singlyLinkedList.GetFirstNode();
cursor = cursor.Next; // B

Console.WriteLine(singlyLinkedList);

singlyLinkedList.InsertAfter(cursor, "C");
Console.WriteLine(singlyLinkedList);

QueueUsingSinglyLinkedLists<string> myQueue = new QueueUsingSinglyLinkedLists<string>();

myQueue.Enqueue("A");
myQueue.Enqueue("B");
myQueue.Enqueue("C");
myQueue.Enqueue("D");
myQueue.Enqueue("E");

Console.WriteLine(myQueue);

while (myQueue.Size > 0)
{
    Console.WriteLine(myQueue.Dequeue());
}

myQueue = new QueueUsingSinglyLinkedLists<string>();
Queue_implemented_using_ABV<string> myABVQueue = new Queue_implemented_using_ABV<string>();

Stopwatch myStopWatch = new Stopwatch();

for (int i = 0; i < 1000000; i++)
{
    myStopWatch.Start();
    myQueue.Enqueue("A");
    myStopWatch.Stop();
}

for (int i = 0; i < 1000000; i++)
{
    myStopWatch.Start();
    myQueue.Dequeue();
    myStopWatch.Stop();
}

Console.WriteLine("Enqueueing and Dequeueing 1000000 elements using SLL takes:");
Console.WriteLine(myStopWatch.ElapsedMilliseconds);

myStopWatch.Reset();

for (int i = 0; i < 1000000; i++)
{
    myStopWatch.Start();
    myABVQueue.Enqueue("A");
    myStopWatch.Stop();
}

for (int i = 0; i < 1000000; i++)
{
    myStopWatch.Start();
    myABVQueue.Dequeue();
    myStopWatch.Stop();
}

Console.WriteLine("Enqueueing and Dequeueing 1000000 elements using ABV takes:");
Console.WriteLine(myStopWatch.ElapsedMilliseconds);



static void NodeTest()
{
    // Create an instance of nodeA.. right now, it does not have a next.
    Node<string> nodeA = new Node<string>("A", null);

    // Create a node C, this will be at the end of the linked list
    Node<string> nodeC = new Node<string>("C", null);
    // Create a node B, with node C behind it
    Node<string> nodeB = new Node<string>("B", nodeC);

    // Update node A to point to Node B
    nodeA.Next = nodeB;

    Node<string>? cursor = nodeA;
    while (cursor != null)
    {
        Console.Write(cursor);
        Console.Write(" -> ");
        cursor = cursor.Next;
    }
    Console.WriteLine();

    Node<string> nodeE = new Node<string>("E", null);
    nodeC.Next = nodeE;

    cursor = nodeA;
    while (cursor != null)
    {
        Console.Write(cursor);
        Console.Write(" -> ");
        cursor = cursor.Next;
    }
    Console.Write(" [F] -> [G] -> [H] -> ... [Z] -> ");
    Console.WriteLine();

    Node<string> nodeD = new Node<string>("D", nodeE);
    nodeC.Next = nodeD;


    cursor = nodeA;
    while (cursor != null)
    {
        Console.Write(cursor);
        Console.Write(" -> ");
        cursor = cursor.Next;
    }
    Console.Write(" [F] -> [G] -> [H] -> ... [Z] -> ");
    Console.WriteLine();
}

static void SinglyLinkedListTest()
{
    SinglyLinkedList<string> linkedList = new SinglyLinkedList<string>();
    linkedList.InsertFirst("B"); // Case 1: list is empty
    Console.WriteLine(linkedList);
    linkedList.InsertFirst("A"); // Case 2: list is NOT empty
    Console.WriteLine(linkedList);

    linkedList.Append("C");
    linkedList.Append("D");
    Console.WriteLine(linkedList);


    Console.WriteLine(linkedList.RemoveHead());
    Console.WriteLine(linkedList.RemoveHead());
    Console.WriteLine(linkedList.RemoveHead());
    Console.WriteLine(linkedList.RemoveHead());


    Console.ReadKey();
}