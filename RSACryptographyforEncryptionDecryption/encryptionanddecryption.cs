using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSACryptographyforEncryptionDecryption
{
    public class encryptionanddecryption
    {
        public double gcd(double a, double h)
        {
            double temp;
            while (true)
            {
                temp = a % h;

                if (temp == 0)
                {
                    return h;
                }
                a = h;
                h = temp;
            }
        }



        public double[] encrypter(string message, double messageToBeEncrypted, double e, double encryptedMessage, double n)
        {
            string alphabet = " abcdefghijklmnopqrstuvwxyz.,'";
            double[] alphabet1 = new double[message.Length];

            for (int i = 0; i < message.Length; i++)
            {
                char oldChar = message.ToLower()[i];
                int oldCharIdx = alphabet.IndexOf(oldChar);
                messageToBeEncrypted = Math.Pow(oldCharIdx, e);
                encryptedMessage = messageToBeEncrypted % n;
                alphabet1[i] = encryptedMessage;
            }

            return alphabet1;


        }

        public string[] decrypter(double[] messageEncryptes, double d, double messageToBeDecryted, double decryptedMessage, double n)
        {
            string alphabet = " abcdefghijklmnopqrstuvwxyz.,'";
            string[] alphabet1 = new string[messageEncryptes.Length];
            int j = 0;

            for (int i = 0; i < messageEncryptes.Length; i++)
            {
                double oldChar = (messageEncryptes[i]);
                // int oldCharIdx = alphabet[oldChar];
                messageToBeDecryted = Math.Pow(oldChar, d);
                decryptedMessage = messageToBeDecryted % n;
                j = Convert.ToInt32(decryptedMessage);
                alphabet1[i] = Convert.ToString(alphabet[j]);
                //j++;
            }

            return alphabet1;


        }
    }
}
