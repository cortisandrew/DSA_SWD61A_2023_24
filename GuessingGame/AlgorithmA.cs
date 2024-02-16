using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessingGame
{
    public class AlgorithmA
    {
        private SecretNumber secret;

        public AlgorithmA(SecretNumber secret)
        {
            this.secret = secret;
        }

        public (int, int) Guess()
        {
            for (int i = 1; i < secret.MaxValue; i++)
            {
                if (secret.Guess(i) == 0)
                {
                    // i is the secret number
                    return (i, secret.WorkCarriedOut); // i and the work carried out
                }
            }

            // secret.MaxValue is the secret number
            secret.Guess(secret.MaxValue);
            return (secret.MaxValue, secret.WorkCarriedOut);
        }
    }
}
