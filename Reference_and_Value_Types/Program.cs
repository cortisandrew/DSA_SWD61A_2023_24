// See https://aka.ms/new-console-template for more information
using Reference_and_Value_Types;

// Value Types!
int a = 5;
int b = a; // 5

a = 6;

Console.WriteLine($"The value of a is {a}");    // 6
Console.WriteLine($"The value of b is {b}");    // 5

Console.WriteLine();
Console.WriteLine();

// Reference Types

Placeholder pa = new Placeholder(5);    // 5
Placeholder pb = pa;                    // 5

pa.Value = 6;

Console.WriteLine($"The value of pa is {pa.Value}");    // 6
Console.WriteLine($"The value of pb is {pb.Value}");    // 6 



