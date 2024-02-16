using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessingGame
{
    public class SecretNumber
    {
        private int _maxValue = 0;

        /// <summary>
        /// Max Value will be setup in the constructor
        /// It represents the largest secret number
        /// and acts as the problem size (larger max value means longer to guess)
        /// </summary>
        public int MaxValue { get { return _maxValue; } }

        private int _secretNumber = 0;

        /// <summary>
        /// This field represents the number of guesses made
        /// The more guess, the larger the work
        /// Each guess is 1 unit of work
        /// </summary>
        private int _workCarriedOut = 0;

        public int WorkCarriedOut { get { return _workCarriedOut; } }

        private static Random _random = new Random();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="maxValue"></param>
        /// <remarks>This is useful for XML documentation</remarks>
        public SecretNumber(int maxValue = 100)
        {
            // remember to set the maximum value
            _maxValue = maxValue;

            // The secret number is a randomly chosen number between 1 and maxValue (both inclusive)
            // Each number is equally probable (the secret number is uniformly distributed within the
            // range of 1 to maxValue (both inclusive)
            _secretNumber = _random.Next(1, maxValue + 1);
        }

        /// <summary>
        /// Returns the result of a guess.
        /// Costs 1 work
        /// </summary>
        /// <param name="guess">Your guess</param>
        /// <returns>0 if the guess is equal to the secret number
        /// < 0 if the guess is too small
        /// > 0 if the guess is too large</returns>
        public int Guess(int guess)
        {
            _workCarriedOut++;
            return guess.CompareTo(_secretNumber);
        }

    }
}
