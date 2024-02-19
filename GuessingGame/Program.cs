using GuessingGame;
using System.Diagnostics;

List<int> problemSizes = new List<int>() { 100, 1000, 10000, 100000, 1000000, 10000000, 100000000 };
int REPETITIONS = 1000;

Console.WriteLine("Algorithm B:");
foreach (int problemSize in problemSizes)
{
    List<int> workCarriedOut = new List<int>(REPETITIONS);

    for (int i = 0; i < REPETITIONS; i++)
    {

        SecretNumber secret = new SecretNumber(problemSize);
        AlgorithmB algorithmB = new AlgorithmB(secret);
        var algorithmResults = algorithmB.Guess();

        workCarriedOut.Add(algorithmResults.Item2);
        //Console.WriteLine($"Algorithm A found the secret number {algorithmResults.Item1} and used {algorithmResults.Item2} guesses");
    }

    //Console.WriteLine($"The fastest game took {workCarriedOut.Min()} guesses");
    Console.WriteLine($"For a problem size {problemSize}, the mean number of guesses is {workCarriedOut.Average()} guesses");
    // Console.WriteLine($"The slowest game took {workCarriedOut.Max()} guesses");

}


Console.WriteLine("Algorithm A:");
foreach (int problemSize in problemSizes)
{
    List<int> workCarriedOut = new List<int>(REPETITIONS);

    for (int i = 0; i < REPETITIONS; i++)
    {
        
        SecretNumber secret = new SecretNumber(problemSize);
        AlgorithmA algorithmA = new AlgorithmA(secret);
        var algorithmResults = algorithmA.Guess();
        
        workCarriedOut.Add(algorithmResults.Item2);
        //Console.WriteLine($"Algorithm A found the secret number {algorithmResults.Item1} and used {algorithmResults.Item2} guesses");
    }

    //Console.WriteLine($"The fastest game took {workCarriedOut.Min()} guesses");
    Console.WriteLine($"For a problem size {problemSize}, the mean number of guesses is {workCarriedOut.Average()} guesses");
    // Console.WriteLine($"The slowest game took {workCarriedOut.Max()} guesses");

}

Console.ReadLine();
//secret.Guess(10);

