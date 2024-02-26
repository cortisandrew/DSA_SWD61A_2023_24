// See https://aka.ms/new-console-template for more information
using VectorImplementations;

Console.WriteLine("Array Based Vector");


ArrayBasedVector<string> arrayBasedVector = new ArrayBasedVector<string>();
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

