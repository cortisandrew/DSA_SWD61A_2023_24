using GuessingGame;

int REPETITIONS = 1000;

for (int i = 0; i < REPETITIONS; i++)
{
    SecretNumber secret = new SecretNumber(100);
    AlgorithmA algorithmA = new AlgorithmA(secret);
    var algorithmResults = algorithmA.Guess();


    Console.WriteLine($"Algorithm A found the secret number {algorithmResults.Item1} and used {algorithmResults.Item2} guesses");
}

Console.ReadLine();
//secret.Guess(10);

