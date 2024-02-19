using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessingGame
{
    public class AlgorithmB
    {
        private SecretNumber secret;

        public AlgorithmB(SecretNumber secret)
        {
            this.secret = secret;
        }

        public (int, int) Guess()
        {
            int minValue = 1;
            int maxValue = secret.MaxValue;

            while (minValue <= maxValue)
            {
                int guess = (minValue + maxValue) / 2;

                int result = secret.Guess(guess);

                if (result == 0)
                {
                    // The guess is successfull!
                    return (guess, secret.WorkCarriedOut);
                }
                else if (result < 0)
                {
                    // The guess is too small
                    // The secret number is larger than our guess!
                    minValue = guess + 1;
                } else // if (result > 0)
                {
                    // The guess is too large
                    // The secret number is smaller than our guess!
                    maxValue = guess - 1;
                }
            }

            throw new InvalidOperationException("The secret number is not within the range, or the secret class has an implementation issue!");
        }
    }
}
